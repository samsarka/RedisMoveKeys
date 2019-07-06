using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
using System.Configuration;
using System.Net;
using System.Windows.Forms;

namespace RedisMoveKeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        static String frmconStr = "";
        static String toconStr = "";


        private void Move_Click(object sender, EventArgs e)
        {
            if ((txtkey1.TextLength > 0) && (txtkey2.TextLength > 0))
            {
                frmconStr = txtkey1.Text;
                toconStr = txtkey2.Text;

               
                ConfigurationOptions options = ConfigurationOptions.Parse(frmconStr);
                ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(options);
                IDatabase db = connection.GetDatabase();
                EndPoint endPoint = connection.GetEndPoints().First();
                RedisKey[] keys = connection.GetServer(endPoint).Keys(pattern: "*").ToArray();



                foreach (RedisKey key in keys)
                {

                    txtkeyval.Text = txtkeyval.Text + Environment.NewLine + key.ToString();
                    setDestination(key);
                }

                MessageBox.Show("Move Completed.");
            }

            else
            {
                MessageBox.Show("Keys are missing !");
            }
        }
        private static Lazy<ConnectionMultiplexer> LazyfrmConn = new Lazy<ConnectionMultiplexer>(() =>
        {
           

            return ConnectionMultiplexer.Connect(frmconStr);
        });

        private static Lazy<ConnectionMultiplexer> LazytoConn = new Lazy<ConnectionMultiplexer>(() =>
        {
            return ConnectionMultiplexer.Connect(toconStr);
        });


        void setDestination(RedisKey key)
        {
            IDatabase frmcache = LazyfrmConn.Value.GetDatabase();
            IDatabase tocache = LazytoConn.Value.GetDatabase();

            tocache.StringSet(key.ToString(), frmcache.StringGet(key));

        }

        private void btnListkey2_Click(object sender, EventArgs e)
        {
            if (txtkey2.TextLength > 0)
            {
                
                ConfigurationOptions options = ConfigurationOptions.Parse(toconStr);
                ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(options);
                IDatabase db = connection.GetDatabase();
                EndPoint endPoint = connection.GetEndPoints().First();
                RedisKey[] keys = connection.GetServer(endPoint).Keys(pattern: "*").ToArray();

                txtkeyval.Text = "*****Listing " + keys.Count().ToString() + " " + endPoint.ToString() + "  Keys*****";
                foreach (RedisKey key in keys)
                {

                    txtkeyval.Text = txtkeyval.Text + Environment.NewLine + key.ToString();
                    setDestination(key);
                }

                MessageBox.Show("List Completed.");
            }

            else
            {
                MessageBox.Show("Key 2 Missing !");
            }

        }
    }
}

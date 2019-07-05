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
            string src = txtkey1.Text;
            string dest = txtkey2.Text;

            
        }

        static string frmconStr = "";
        static string toconStr = "";


        private void Move_Click(object sender, EventArgs e)
        {
           

            string connectionString = frmconStr;
            ConfigurationOptions options = ConfigurationOptions.Parse(connectionString);
            ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(options);
            IDatabase db = connection.GetDatabase();
            EndPoint endPoint = connection.GetEndPoints().First();
            RedisKey[] keys = connection.GetServer(endPoint).Keys(pattern: "*").ToArray();

            foreach (RedisKey key in  keys)
                {

                txtkeyval.Text = txtkeyval.Text + Environment.NewLine + key.ToString();
                setDestination(key);
            }

            MessageBox.Show("Move Completed.");
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
            string connectionString = toconStr;
            ConfigurationOptions options = ConfigurationOptions.Parse(connectionString);
            ConnectionMultiplexer connection = ConnectionMultiplexer.Connect(options);
            IDatabase db = connection.GetDatabase();
            EndPoint endPoint = connection.GetEndPoints().First();
            RedisKey[] keys = connection.GetServer(endPoint).Keys(pattern: "*").ToArray();

            txtkeyval.Text = "*****Listing Destination Keys*****";
            foreach (RedisKey key in keys)
            {

                txtkeyval.Text = txtkeyval.Text + Environment.NewLine + key.ToString();
                setDestination(key);
            }

            MessageBox.Show("List Completed.");
        }

      
    }
}

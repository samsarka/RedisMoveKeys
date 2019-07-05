namespace RedisMoveKeys
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Move = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkey2 = new System.Windows.Forms.TextBox();
            this.txtkey1 = new System.Windows.Forms.TextBox();
            this.txtkeyval = new System.Windows.Forms.RichTextBox();
            this.btnListkey2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Move
            // 
            this.Move.Location = new System.Drawing.Point(31, 148);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(75, 23);
            this.Move.TabIndex = 0;
            this.Move.Text = "Move";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key 2 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key 1:";
            // 
            // txtkey2
            // 
            this.txtkey2.Location = new System.Drawing.Point(108, 92);
            this.txtkey2.Name = "txtkey2";
            this.txtkey2.Size = new System.Drawing.Size(658, 20);
            this.txtkey2.TabIndex = 2;
            // 
            // txtkey1
            // 
            this.txtkey1.Location = new System.Drawing.Point(108, 43);
            this.txtkey1.Name = "txtkey1";
            this.txtkey1.Size = new System.Drawing.Size(658, 20);
            this.txtkey1.TabIndex = 1;
            // 
            // txtkeyval
            // 
            this.txtkeyval.Location = new System.Drawing.Point(31, 196);
            this.txtkeyval.Name = "txtkeyval";
            this.txtkeyval.Size = new System.Drawing.Size(735, 229);
            this.txtkeyval.TabIndex = 3;
            this.txtkeyval.Text = "";
            // 
            // btnListkey2
            // 
            this.btnListkey2.Location = new System.Drawing.Point(691, 148);
            this.btnListkey2.Name = "btnListkey2";
            this.btnListkey2.Size = new System.Drawing.Size(75, 23);
            this.btnListkey2.TabIndex = 4;
            this.btnListkey2.Text = "List Key 2 ";
            this.btnListkey2.UseVisualStyleBackColor = true;
            this.btnListkey2.Click += new System.EventHandler(this.btnListkey2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.btnListkey2);
            this.Controls.Add(this.txtkeyval);
            this.Controls.Add(this.txtkey1);
            this.Controls.Add(this.txtkey2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Move);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedisMoveKeys";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkey2;
        private System.Windows.Forms.TextBox txtkey1;
        private System.Windows.Forms.RichTextBox txtkeyval;
        private System.Windows.Forms.Button btnListkey2;
    }
}


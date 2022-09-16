using System.Windows.Forms;

namespace Captchalogue
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainDigit1 = new System.Windows.Forms.TextBox();
            this.mainDigit2 = new System.Windows.Forms.TextBox();
            this.mainDigit3 = new System.Windows.Forms.TextBox();
            this.mainDigit4 = new System.Windows.Forms.TextBox();
            this.mainDigit5 = new System.Windows.Forms.TextBox();
            this.mainDigit6 = new System.Windows.Forms.TextBox();
            this.mainDigit7 = new System.Windows.Forms.TextBox();
            this.mainDigit8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 502);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // mainDigit1
            // 
            this.mainDigit1.BackColor = System.Drawing.Color.White;
            this.mainDigit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDigit1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDigit1.Location = new System.Drawing.Point(67, 543);
            this.mainDigit1.MaxLength = 1;
            this.mainDigit1.Name = "mainDigit1";
            this.mainDigit1.Size = new System.Drawing.Size(31, 31);
            this.mainDigit1.TabIndex = 12;
            this.mainDigit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainDigit1.Click += new System.EventHandler(this.MainDigit_Clicked);
            this.mainDigit1.TextChanged += new System.EventHandler(this.MainDigit_Entered);
            // 
            // mainDigit2
            // 
            this.mainDigit2.BackColor = System.Drawing.Color.White;
            this.mainDigit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDigit2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDigit2.Location = new System.Drawing.Point(104, 543);
            this.mainDigit2.MaxLength = 1;
            this.mainDigit2.Name = "mainDigit2";
            this.mainDigit2.Size = new System.Drawing.Size(31, 31);
            this.mainDigit2.TabIndex = 13;
            this.mainDigit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainDigit2.Click += new System.EventHandler(this.MainDigit_Clicked);
            this.mainDigit2.TextChanged += new System.EventHandler(this.MainDigit_Entered);
            // 
            // mainDigit3
            // 
            this.mainDigit3.BackColor = System.Drawing.Color.White;
            this.mainDigit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDigit3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDigit3.Location = new System.Drawing.Point(141, 543);
            this.mainDigit3.MaxLength = 1;
            this.mainDigit3.Name = "mainDigit3";
            this.mainDigit3.Size = new System.Drawing.Size(31, 31);
            this.mainDigit3.TabIndex = 14;
            this.mainDigit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainDigit3.Click += new System.EventHandler(this.MainDigit_Clicked);
            this.mainDigit3.TextChanged += new System.EventHandler(this.MainDigit_Entered);
            // 
            // mainDigit4
            // 
            this.mainDigit4.BackColor = System.Drawing.Color.White;
            this.mainDigit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDigit4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDigit4.Location = new System.Drawing.Point(178, 543);
            this.mainDigit4.MaxLength = 1;
            this.mainDigit4.Name = "mainDigit4";
            this.mainDigit4.Size = new System.Drawing.Size(31, 31);
            this.mainDigit4.TabIndex = 15;
            this.mainDigit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainDigit4.Click += new System.EventHandler(this.MainDigit_Clicked);
            this.mainDigit4.TextChanged += new System.EventHandler(this.MainDigit_Entered);
            // 
            // mainDigit5
            // 
            this.mainDigit5.BackColor = System.Drawing.Color.White;
            this.mainDigit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDigit5.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDigit5.Location = new System.Drawing.Point(215, 543);
            this.mainDigit5.MaxLength = 1;
            this.mainDigit5.Name = "mainDigit5";
            this.mainDigit5.Size = new System.Drawing.Size(31, 31);
            this.mainDigit5.TabIndex = 16;
            this.mainDigit5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainDigit5.Click += new System.EventHandler(this.MainDigit_Clicked);
            this.mainDigit5.TextChanged += new System.EventHandler(this.MainDigit_Entered);
            // 
            // mainDigit6
            // 
            this.mainDigit6.BackColor = System.Drawing.Color.White;
            this.mainDigit6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDigit6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDigit6.Location = new System.Drawing.Point(252, 543);
            this.mainDigit6.MaxLength = 1;
            this.mainDigit6.Name = "mainDigit6";
            this.mainDigit6.Size = new System.Drawing.Size(31, 31);
            this.mainDigit6.TabIndex = 17;
            this.mainDigit6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainDigit6.Click += new System.EventHandler(this.MainDigit_Clicked);
            this.mainDigit6.TextChanged += new System.EventHandler(this.MainDigit_Entered);
            // 
            // mainDigit7
            // 
            this.mainDigit7.BackColor = System.Drawing.Color.White;
            this.mainDigit7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDigit7.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDigit7.Location = new System.Drawing.Point(289, 543);
            this.mainDigit7.MaxLength = 1;
            this.mainDigit7.Name = "mainDigit7";
            this.mainDigit7.Size = new System.Drawing.Size(31, 31);
            this.mainDigit7.TabIndex = 18;
            this.mainDigit7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainDigit7.Click += new System.EventHandler(this.MainDigit_Clicked);
            this.mainDigit7.TextChanged += new System.EventHandler(this.MainDigit_Entered);
            // 
            // mainDigit8
            // 
            this.mainDigit8.BackColor = System.Drawing.Color.White;
            this.mainDigit8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainDigit8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDigit8.Location = new System.Drawing.Point(326, 543);
            this.mainDigit8.MaxLength = 1;
            this.mainDigit8.Name = "mainDigit8";
            this.mainDigit8.Size = new System.Drawing.Size(31, 31);
            this.mainDigit8.TabIndex = 19;
            this.mainDigit8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainDigit8.Click += new System.EventHandler(this.MainDigit_Clicked);
            this.mainDigit8.TextChanged += new System.EventHandler(this.MainDigit_Entered);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(425, 594);
            this.Controls.Add(this.mainDigit8);
            this.Controls.Add(this.mainDigit7);
            this.Controls.Add(this.mainDigit6);
            this.Controls.Add(this.mainDigit5);
            this.Controls.Add(this.mainDigit4);
            this.Controls.Add(this.mainDigit3);
            this.Controls.Add(this.mainDigit2);
            this.Controls.Add(this.mainDigit1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "App";
            this.Text = "Captchalogue";
            this.Load += new System.EventHandler(this.App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox mainDigit1, mainDigit2, mainDigit3, mainDigit4, 
                        mainDigit5, mainDigit6, mainDigit7, mainDigit8;
    }
}


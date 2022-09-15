
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
            this.alcCode1 = new System.Windows.Forms.TextBox();
            this.alcCode2 = new System.Windows.Forms.TextBox();
            this.alcLabel1 = new System.Windows.Forms.Label();
            this.alcLabel2 = new System.Windows.Forms.Label();
            this.operAND = new System.Windows.Forms.Button();
            this.operOR = new System.Windows.Forms.Button();
            this.operXOR = new System.Windows.Forms.Button();
            this.operNAND = new System.Windows.Forms.Button();
            this.operXNOR = new System.Windows.Forms.Button();
            this.operNOR = new System.Windows.Forms.Button();
            this.resultCode = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alcCode1
            // 
            this.alcCode1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alcCode1.Location = new System.Drawing.Point(34, 62);
            this.alcCode1.MaxLength = 8;
            this.alcCode1.Name = "alcCode1";
            this.alcCode1.Size = new System.Drawing.Size(183, 38);
            this.alcCode1.TabIndex = 0;
            this.alcCode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alcCode2
            // 
            this.alcCode2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alcCode2.Location = new System.Drawing.Point(283, 62);
            this.alcCode2.MaxLength = 8;
            this.alcCode2.Name = "alcCode2";
            this.alcCode2.Size = new System.Drawing.Size(183, 38);
            this.alcCode2.TabIndex = 1;
            this.alcCode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alcLabel1
            // 
            this.alcLabel1.AutoSize = true;
            this.alcLabel1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alcLabel1.Location = new System.Drawing.Point(30, 37);
            this.alcLabel1.Name = "alcLabel1";
            this.alcLabel1.Size = new System.Drawing.Size(82, 22);
            this.alcLabel1.TabIndex = 2;
            this.alcLabel1.Text = "Code 1";
            // 
            // alcLabel2
            // 
            this.alcLabel2.AutoSize = true;
            this.alcLabel2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alcLabel2.Location = new System.Drawing.Point(279, 37);
            this.alcLabel2.Name = "alcLabel2";
            this.alcLabel2.Size = new System.Drawing.Size(82, 22);
            this.alcLabel2.TabIndex = 3;
            this.alcLabel2.Text = "Code 2";
            // 
            // operAND
            // 
            this.operAND.BackColor = System.Drawing.Color.Aqua;
            this.operAND.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operAND.Location = new System.Drawing.Point(34, 124);
            this.operAND.Name = "operAND";
            this.operAND.Size = new System.Drawing.Size(67, 43);
            this.operAND.TabIndex = 4;
            this.operAND.Text = "&&&&";
            this.operAND.UseVisualStyleBackColor = false;
            this.operAND.Click += new System.EventHandler(this.OperAND_Click);
            // 
            // operOR
            // 
            this.operOR.BackColor = System.Drawing.Color.Aqua;
            this.operOR.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operOR.Location = new System.Drawing.Point(107, 124);
            this.operOR.Name = "operOR";
            this.operOR.Size = new System.Drawing.Size(67, 43);
            this.operOR.TabIndex = 5;
            this.operOR.Text = "||";
            this.operOR.UseVisualStyleBackColor = false;
            this.operOR.Click += new System.EventHandler(this.OperOR_Click);
            // 
            // operXOR
            // 
            this.operXOR.BackColor = System.Drawing.Color.Aqua;
            this.operXOR.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operXOR.Location = new System.Drawing.Point(180, 124);
            this.operXOR.Name = "operXOR";
            this.operXOR.Size = new System.Drawing.Size(67, 43);
            this.operXOR.TabIndex = 6;
            this.operXOR.Text = "^^";
            this.operXOR.UseVisualStyleBackColor = false;
            this.operXOR.Click += new System.EventHandler(this.OperXOR_Click);
            // 
            // operNAND
            // 
            this.operNAND.BackColor = System.Drawing.Color.Aqua;
            this.operNAND.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operNAND.Location = new System.Drawing.Point(253, 124);
            this.operNAND.Name = "operNAND";
            this.operNAND.Size = new System.Drawing.Size(67, 43);
            this.operNAND.TabIndex = 7;
            this.operNAND.Text = "~&&";
            this.operNAND.UseVisualStyleBackColor = false;
            this.operNAND.Click += new System.EventHandler(this.OperNAND_Click);
            // 
            // operXNOR
            // 
            this.operXNOR.BackColor = System.Drawing.Color.Aqua;
            this.operXNOR.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operXNOR.Location = new System.Drawing.Point(399, 124);
            this.operXNOR.Name = "operXNOR";
            this.operXNOR.Size = new System.Drawing.Size(67, 43);
            this.operXNOR.TabIndex = 9;
            this.operXNOR.Text = "~^";
            this.operXNOR.UseVisualStyleBackColor = false;
            this.operXNOR.Click += new System.EventHandler(this.OperXNOR_Click);
            // 
            // operNOR
            // 
            this.operNOR.BackColor = System.Drawing.Color.Aqua;
            this.operNOR.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operNOR.Location = new System.Drawing.Point(326, 124);
            this.operNOR.Name = "operNOR";
            this.operNOR.Size = new System.Drawing.Size(67, 43);
            this.operNOR.TabIndex = 8;
            this.operNOR.Text = "~|";
            this.operNOR.UseVisualStyleBackColor = false;
            this.operNOR.Click += new System.EventHandler(this.OperNOR_Click);
            // 
            // resultCode
            // 
            this.resultCode.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultCode.Location = new System.Drawing.Point(210, 195);
            this.resultCode.MaxLength = 8;
            this.resultCode.Name = "resultCode";
            this.resultCode.ReadOnly = true;
            this.resultCode.Size = new System.Drawing.Size(183, 38);
            this.resultCode.TabIndex = 10;
            this.resultCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(122, 204);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(82, 22);
            this.resultLabel.TabIndex = 11;
            this.resultLabel.Text = "Result";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 270);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultCode);
            this.Controls.Add(this.operXNOR);
            this.Controls.Add(this.operNOR);
            this.Controls.Add(this.operNAND);
            this.Controls.Add(this.operXOR);
            this.Controls.Add(this.operOR);
            this.Controls.Add(this.operAND);
            this.Controls.Add(this.alcLabel2);
            this.Controls.Add(this.alcLabel1);
            this.Controls.Add(this.alcCode2);
            this.Controls.Add(this.alcCode1);
            this.Name = "App";
            this.Text = "Captchalogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alcCode1;
        private System.Windows.Forms.TextBox alcCode2;
        private System.Windows.Forms.Label alcLabel1;
        private System.Windows.Forms.Label alcLabel2;
        private System.Windows.Forms.Button operAND;
        private System.Windows.Forms.Button operOR;
        private System.Windows.Forms.Button operXOR;
        private System.Windows.Forms.Button operNAND;
        private System.Windows.Forms.Button operXNOR;
        private System.Windows.Forms.Button operNOR;
        private System.Windows.Forms.TextBox resultCode;
        private System.Windows.Forms.Label resultLabel;
    }
}


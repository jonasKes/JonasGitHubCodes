namespace Chat.WinForm
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
            this.boxUser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1userN = new System.Windows.Forms.TextBox();
            this.textBox2PassW = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // boxUser
            // 
            this.boxUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boxUser.Location = new System.Drawing.Point(399, 36);
            this.boxUser.Name = "boxUser";
            this.boxUser.Size = new System.Drawing.Size(143, 127);
            this.boxUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // textBox1userN
            // 
            this.textBox1userN.Location = new System.Drawing.Point(53, 125);
            this.textBox1userN.Name = "textBox1userN";
            this.textBox1userN.Size = new System.Drawing.Size(100, 20);
            this.textBox1userN.TabIndex = 3;
            // 
            // textBox2PassW
            // 
            this.textBox2PassW.Location = new System.Drawing.Point(53, 184);
            this.textBox2PassW.Name = "textBox2PassW";
            this.textBox2PassW.Size = new System.Drawing.Size(100, 20);
            this.textBox2PassW.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2PassW);
            this.Controls.Add(this.textBox1userN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxUser);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.boxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView boxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1userN;
        private System.Windows.Forms.TextBox textBox2PassW;
        private System.Windows.Forms.Button button1;
    }
}


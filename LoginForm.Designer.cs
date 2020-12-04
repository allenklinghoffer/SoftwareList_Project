namespace login
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.useridTextBox = new System.Windows.Forms.TextBox();
            this.showpdcheckBox = new System.Windows.Forms.CheckBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.openregisterfromlinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.userpdtextBox = new System.Windows.Forms.TextBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號:";
            // 
            // useridTextBox
            // 
            this.useridTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridTextBox.Location = new System.Drawing.Point(179, 113);
            this.useridTextBox.Name = "useridTextBox";
            this.useridTextBox.Size = new System.Drawing.Size(247, 29);
            this.useridTextBox.TabIndex = 1;
            // 
            // showpdcheckBox
            // 
            this.showpdcheckBox.AutoSize = true;
            this.showpdcheckBox.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpdcheckBox.Location = new System.Drawing.Point(334, 197);
            this.showpdcheckBox.Name = "showpdcheckBox";
            this.showpdcheckBox.Size = new System.Drawing.Size(92, 24);
            this.showpdcheckBox.TabIndex = 2;
            this.showpdcheckBox.Text = "顯示密碼";
            this.showpdcheckBox.UseVisualStyleBackColor = true;
            this.showpdcheckBox.CheckedChanged += new System.EventHandler(this.showpdcheckBox_CheckedChanged);
            // 
            // Loginbutton
            // 
            this.Loginbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.Location = new System.Drawing.Point(179, 230);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(111, 35);
            this.Loginbutton.TabIndex = 3;
            this.Loginbutton.Text = "登入";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // openregisterfromlinkLabel
            // 
            this.openregisterfromlinkLabel.AutoSize = true;
            this.openregisterfromlinkLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openregisterfromlinkLabel.Location = new System.Drawing.Point(214, 279);
            this.openregisterfromlinkLabel.Name = "openregisterfromlinkLabel";
            this.openregisterfromlinkLabel.Size = new System.Drawing.Size(177, 20);
            this.openregisterfromlinkLabel.TabIndex = 4;
            this.openregisterfromlinkLabel.TabStop = true;
            this.openregisterfromlinkLabel.Text = "若尚未註冊 請點擊這裡!";
            this.openregisterfromlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openregisterfromlinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "密碼:";
            // 
            // userpdtextBox
            // 
            this.userpdtextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userpdtextBox.Location = new System.Drawing.Point(179, 162);
            this.userpdtextBox.Name = "userpdtextBox";
            this.userpdtextBox.Size = new System.Drawing.Size(247, 29);
            this.userpdtextBox.TabIndex = 6;
            this.userpdtextBox.UseSystemPasswordChar = true;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(315, 230);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(111, 35);
            this.cancelbutton.TabIndex = 7;
            this.cancelbutton.Text = "取消";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "系統清冊查詢系統";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Loginbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(600, 314);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.userpdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openregisterfromlinkLabel);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.showpdcheckBox);
            this.Controls.Add(this.useridTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox useridTextBox;
        private System.Windows.Forms.CheckBox showpdcheckBox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.LinkLabel openregisterfromlinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userpdtextBox;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
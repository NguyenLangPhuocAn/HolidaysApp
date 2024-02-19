namespace HolidaysApp
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Username = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_Quit = new System.Windows.Forms.Button();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // Txt_Username
            // 
            this.Txt_Username.Location = new System.Drawing.Point(156, 50);
            this.Txt_Username.MaxLength = 30;
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Size = new System.Drawing.Size(251, 20);
            this.Txt_Username.TabIndex = 3;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(156, 97);
            this.Txt_Password.MaxLength = 36;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(251, 20);
            this.Txt_Password.TabIndex = 4;
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.BackColor = System.Drawing.Color.Teal;
            this.Btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Quit.ForeColor = System.Drawing.Color.LightSalmon;
            this.Btn_Quit.Location = new System.Drawing.Point(156, 124);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(68, 27);
            this.Btn_Quit.TabIndex = 5;
            this.Btn_Quit.Text = "Quit";
            this.Btn_Quit.UseVisualStyleBackColor = false;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.Teal;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.ForeColor = System.Drawing.Color.LightSalmon;
            this.Btn_Login.Location = new System.Drawing.Point(295, 123);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(112, 27);
            this.Btn_Login.TabIndex = 6;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(419, 163);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Username;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_Quit;
        private System.Windows.Forms.Button Btn_Login;
    }
}
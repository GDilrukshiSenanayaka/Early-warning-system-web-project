namespace DisasterManagementSystem
{
    partial class UserLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reset1 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.showpass1 = new System.Windows.Forms.CheckBox();
            this.txtc_passward = new System.Windows.Forms.TextBox();
            this.cus_passward = new System.Windows.Forms.Label();
            this.txtc_username = new System.Windows.Forms.TextBox();
            this.cus_Username = new System.Windows.Forms.Label();
            this.custlogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(113, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "Create Account";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(84, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Don\'t have an Account?";
            // 
            // reset1
            // 
            this.reset1.BackColor = System.Drawing.Color.CadetBlue;
            this.reset1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset1.FlatAppearance.BorderSize = 4;
            this.reset1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset1.ForeColor = System.Drawing.Color.White;
            this.reset1.Location = new System.Drawing.Point(56, 360);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(237, 44);
            this.reset1.TabIndex = 51;
            this.reset1.Text = "Reset";
            this.reset1.UseVisualStyleBackColor = false;
            this.reset1.Click += new System.EventHandler(this.reset1_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Blue;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.FlatAppearance.BorderSize = 4;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(56, 310);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(237, 44);
            this.login.TabIndex = 50;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // showpass1
            // 
            this.showpass1.AutoSize = true;
            this.showpass1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showpass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpass1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.showpass1.Location = new System.Drawing.Point(158, 275);
            this.showpass1.Name = "showpass1";
            this.showpass1.Size = new System.Drawing.Size(135, 24);
            this.showpass1.TabIndex = 49;
            this.showpass1.Text = "Show Passward";
            this.showpass1.UseVisualStyleBackColor = true;
            this.showpass1.CheckedChanged += new System.EventHandler(this.showpass1_CheckedChanged);
            // 
            // txtc_passward
            // 
            this.txtc_passward.BackColor = System.Drawing.Color.White;
            this.txtc_passward.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_passward.ForeColor = System.Drawing.Color.Black;
            this.txtc_passward.Location = new System.Drawing.Point(56, 226);
            this.txtc_passward.Name = "txtc_passward";
            this.txtc_passward.PasswordChar = '*';
            this.txtc_passward.Size = new System.Drawing.Size(237, 30);
            this.txtc_passward.TabIndex = 48;
            // 
            // cus_passward
            // 
            this.cus_passward.AutoSize = true;
            this.cus_passward.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_passward.ForeColor = System.Drawing.Color.Black;
            this.cus_passward.Location = new System.Drawing.Point(52, 200);
            this.cus_passward.Name = "cus_passward";
            this.cus_passward.Size = new System.Drawing.Size(83, 23);
            this.cus_passward.TabIndex = 47;
            this.cus_passward.Text = "Passward";
            // 
            // txtc_username
            // 
            this.txtc_username.BackColor = System.Drawing.SystemColors.Window;
            this.txtc_username.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc_username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtc_username.Location = new System.Drawing.Point(56, 145);
            this.txtc_username.Name = "txtc_username";
            this.txtc_username.Size = new System.Drawing.Size(237, 30);
            this.txtc_username.TabIndex = 46;
            // 
            // cus_Username
            // 
            this.cus_Username.AutoSize = true;
            this.cus_Username.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_Username.ForeColor = System.Drawing.Color.Black;
            this.cus_Username.Location = new System.Drawing.Point(52, 119);
            this.cus_Username.Name = "cus_Username";
            this.cus_Username.Size = new System.Drawing.Size(89, 23);
            this.cus_Username.TabIndex = 45;
            this.cus_Username.Text = "Username";
            // 
            // custlogin
            // 
            this.custlogin.AutoSize = true;
            this.custlogin.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custlogin.ForeColor = System.Drawing.Color.Navy;
            this.custlogin.Location = new System.Drawing.Point(50, 53);
            this.custlogin.Name = "custlogin";
            this.custlogin.Size = new System.Drawing.Size(259, 33);
            this.custlogin.TabIndex = 44;
            this.custlogin.Text = "Customer Login ";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.showpass1);
            this.Controls.Add(this.txtc_passward);
            this.Controls.Add(this.cus_passward);
            this.Controls.Add(this.txtc_username);
            this.Controls.Add(this.cus_Username);
            this.Controls.Add(this.custlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.CheckBox showpass1;
        private System.Windows.Forms.TextBox txtc_passward;
        private System.Windows.Forms.Label cus_passward;
        private System.Windows.Forms.TextBox txtc_username;
        private System.Windows.Forms.Label cus_Username;
        private System.Windows.Forms.Label custlogin;
    }
}
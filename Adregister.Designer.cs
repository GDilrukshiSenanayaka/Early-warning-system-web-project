namespace DisasterManagementSystem
{
    partial class Adregister
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
            this.reset2 = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.txtcmpass = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Label();
            this.txtpassward = new System.Windows.Forms.TextBox();
            this.passward = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.custlogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(120, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 59;
            this.label2.Text = "Back to Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(91, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Already have an Account?";
            // 
            // reset2
            // 
            this.reset2.BackColor = System.Drawing.Color.CadetBlue;
            this.reset2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset2.FlatAppearance.BorderSize = 4;
            this.reset2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset2.ForeColor = System.Drawing.Color.White;
            this.reset2.Location = new System.Drawing.Point(69, 433);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(237, 44);
            this.reset2.TabIndex = 57;
            this.reset2.Text = "Reset";
            this.reset2.UseVisualStyleBackColor = false;
            this.reset2.Click += new System.EventHandler(this.reset2_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Blue;
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.FlatAppearance.BorderSize = 4;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(69, 383);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(237, 44);
            this.btn_register.TabIndex = 56;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpass.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.showpass.Location = new System.Drawing.Point(171, 344);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(135, 24);
            this.showpass.TabIndex = 55;
            this.showpass.Text = "Show Passward";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // txtcmpass
            // 
            this.txtcmpass.BackColor = System.Drawing.Color.White;
            this.txtcmpass.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcmpass.ForeColor = System.Drawing.Color.Black;
            this.txtcmpass.Location = new System.Drawing.Point(69, 295);
            this.txtcmpass.Name = "txtcmpass";
            this.txtcmpass.PasswordChar = '*';
            this.txtcmpass.Size = new System.Drawing.Size(237, 30);
            this.txtcmpass.TabIndex = 54;
            // 
            // Confirm
            // 
            this.Confirm.AutoSize = true;
            this.Confirm.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(65, 269);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(154, 23);
            this.Confirm.TabIndex = 53;
            this.Confirm.Text = "Confirm Passward";
            // 
            // txtpassward
            // 
            this.txtpassward.BackColor = System.Drawing.Color.White;
            this.txtpassward.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassward.ForeColor = System.Drawing.Color.Black;
            this.txtpassward.Location = new System.Drawing.Point(69, 215);
            this.txtpassward.Name = "txtpassward";
            this.txtpassward.PasswordChar = '*';
            this.txtpassward.Size = new System.Drawing.Size(237, 30);
            this.txtpassward.TabIndex = 52;
            // 
            // passward
            // 
            this.passward.AutoSize = true;
            this.passward.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passward.Location = new System.Drawing.Point(65, 189);
            this.passward.Name = "passward";
            this.passward.Size = new System.Drawing.Size(83, 23);
            this.passward.TabIndex = 51;
            this.passward.Text = "Passward";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(69, 134);
            this.txtusername.Name = "txtusername";
            this.txtusername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtusername.Size = new System.Drawing.Size(237, 30);
            this.txtusername.TabIndex = 50;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(65, 108);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(89, 23);
            this.Username.TabIndex = 49;
            this.Username.Text = "Username";
            // 
            // custlogin
            // 
            this.custlogin.AutoSize = true;
            this.custlogin.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custlogin.ForeColor = System.Drawing.Color.Navy;
            this.custlogin.Location = new System.Drawing.Point(67, 38);
            this.custlogin.Name = "custlogin";
            this.custlogin.Size = new System.Drawing.Size(239, 33);
            this.custlogin.TabIndex = 48;
            this.custlogin.Text = "Admin Register";
            // 
            // Adregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset2);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.txtcmpass);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.txtpassward);
            this.Controls.Add(this.passward);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.custlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adregister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adregister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset2;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.TextBox txtcmpass;
        private System.Windows.Forms.Label Confirm;
        private System.Windows.Forms.TextBox txtpassward;
        private System.Windows.Forms.Label passward;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label custlogin;
    }
}
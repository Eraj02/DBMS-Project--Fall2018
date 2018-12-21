namespace Gym_MS
{
    partial class Admin_credentials
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
            this.admin_pw = new System.Windows.Forms.TextBox();
            this.admin_Id = new System.Windows.Forms.TextBox();
            this.admin_Login = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.admin_login_back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_pw
            // 
            this.admin_pw.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admin_pw.Location = new System.Drawing.Point(260, 221);
            this.admin_pw.Name = "admin_pw";
            this.admin_pw.PasswordChar = '*';
            this.admin_pw.Size = new System.Drawing.Size(336, 32);
            this.admin_pw.TabIndex = 1;
            // 
            // admin_Id
            // 
            this.admin_Id.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.admin_Id.Location = new System.Drawing.Point(260, 140);
            this.admin_Id.Name = "admin_Id";
            this.admin_Id.Size = new System.Drawing.Size(336, 32);
            this.admin_Id.TabIndex = 0;
            // 
            // admin_Login
            // 
            this.admin_Login.AutoSize = true;
            this.admin_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.admin_Login.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_Login.Location = new System.Drawing.Point(524, 316);
            this.admin_Login.Name = "admin_Login";
            this.admin_Login.Size = new System.Drawing.Size(72, 24);
            this.admin_Login.TabIndex = 11;
            this.admin_Login.Text = "Log_in";
            this.admin_Login.Click += new System.EventHandler(this.admin_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(197, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 49);
            this.label3.TabIndex = 10;
            this.label3.Text = "Admin Log-in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(95, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Email ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(95, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Password";
            // 
            // admin_login_back
            // 
            this.admin_login_back.AutoSize = true;
            this.admin_login_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.admin_login_back.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_login_back.Location = new System.Drawing.Point(94, 313);
            this.admin_login_back.Name = "admin_login_back";
            this.admin_login_back.Size = new System.Drawing.Size(56, 27);
            this.admin_login_back.TabIndex = 14;
            this.admin_login_back.Text = "Back";
            this.admin_login_back.Click += new System.EventHandler(this.admin_login_back_Click);
            // 
            // Admin_credentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Gym_MS.Properties.Resources.blurred_gym_machines_1203_101;
            this.ClientSize = new System.Drawing.Size(637, 448);
            this.Controls.Add(this.admin_login_back);
            this.Controls.Add(this.admin_pw);
            this.Controls.Add(this.admin_Id);
            this.Controls.Add(this.admin_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Admin_credentials";
            this.Text = "Admin_credentials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox admin_pw;
        private System.Windows.Forms.TextBox admin_Id;
        private System.Windows.Forms.Label admin_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label admin_login_back;
    }
}
namespace Gym_MS
{
    partial class Member_credentials
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
            this.mem_Login = new System.Windows.Forms.Label();
            this.member_Id = new System.Windows.Forms.TextBox();
            this.member_pw = new System.Windows.Forms.TextBox();
            this.sign_up = new System.Windows.Forms.Label();
            this.mem_login_back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Email ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Member Log-in";
            // 
            // mem_Login
            // 
            this.mem_Login.AutoSize = true;
            this.mem_Login.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mem_Login.Location = new System.Drawing.Point(479, 362);
            this.mem_Login.Name = "mem_Login";
            this.mem_Login.Size = new System.Drawing.Size(79, 27);
            this.mem_Login.TabIndex = 5;
            this.mem_Login.Text = "Log_in";
            this.mem_Login.Click += new System.EventHandler(this.mem_Login_Click);
            // 
            // member_Id
            // 
            this.member_Id.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_Id.Location = new System.Drawing.Point(213, 155);
            this.member_Id.Name = "member_Id";
            this.member_Id.Size = new System.Drawing.Size(336, 32);
            this.member_Id.TabIndex = 0;
            // 
            // member_pw
            // 
            this.member_pw.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_pw.Location = new System.Drawing.Point(213, 261);
            this.member_pw.Name = "member_pw";
            this.member_pw.PasswordChar = '*';
            this.member_pw.Size = new System.Drawing.Size(336, 32);
            this.member_pw.TabIndex = 1;
            // 
            // sign_up
            // 
            this.sign_up.AutoSize = true;
            this.sign_up.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up.Location = new System.Drawing.Point(409, 408);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(149, 27);
            this.sign_up.TabIndex = 8;
            this.sign_up.Text = "New? Sign up!";
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // mem_login_back
            // 
            this.mem_login_back.AutoSize = true;
            this.mem_login_back.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mem_login_back.Location = new System.Drawing.Point(51, 362);
            this.mem_login_back.Name = "mem_login_back";
            this.mem_login_back.Size = new System.Drawing.Size(56, 27);
            this.mem_login_back.TabIndex = 9;
            this.mem_login_back.Text = "Back";
            this.mem_login_back.Click += new System.EventHandler(this.mem_login_back_Click);
            // 
            // Member_credentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gym_MS.Properties.Resources.abstract_blur_fitness_gym_and_equipment_1339_4861;
            this.ClientSize = new System.Drawing.Size(587, 479);
            this.Controls.Add(this.mem_login_back);
            this.Controls.Add(this.sign_up);
            this.Controls.Add(this.member_pw);
            this.Controls.Add(this.member_Id);
            this.Controls.Add(this.mem_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Member_credentials";
            this.Text = "Member_credentials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mem_Login;
        private System.Windows.Forms.TextBox member_Id;
        private System.Windows.Forms.TextBox member_pw;
        private System.Windows.Forms.Label sign_up;
        private System.Windows.Forms.Label mem_login_back;
    }
}
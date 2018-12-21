namespace Gym_MS
{
    partial class Admin_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_login));
            this.label1 = new System.Windows.Forms.Label();
            this.view_TD = new System.Windows.Forms.Button();
            this.view_MD = new System.Windows.Forms.Button();
            this.admin_logout = new System.Windows.Forms.Button();
            this.view_packages = new System.Windows.Forms.Button();
            this.subs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back!";
            // 
            // view_TD
            // 
            this.view_TD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.view_TD.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_TD.Location = new System.Drawing.Point(126, 263);
            this.view_TD.Name = "view_TD";
            this.view_TD.Size = new System.Drawing.Size(232, 59);
            this.view_TD.TabIndex = 7;
            this.view_TD.Text = "View Trainers\' Details";
            this.view_TD.UseVisualStyleBackColor = false;
            this.view_TD.Click += new System.EventHandler(this.view_TD_Click);
            // 
            // view_MD
            // 
            this.view_MD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.view_MD.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_MD.Location = new System.Drawing.Point(126, 341);
            this.view_MD.Name = "view_MD";
            this.view_MD.Size = new System.Drawing.Size(228, 59);
            this.view_MD.TabIndex = 8;
            this.view_MD.Text = "View Members\' Details";
            this.view_MD.UseVisualStyleBackColor = false;
            this.view_MD.Click += new System.EventHandler(this.view_MD_Click);
            // 
            // admin_logout
            // 
            this.admin_logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.admin_logout.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_logout.Location = new System.Drawing.Point(407, 433);
            this.admin_logout.Name = "admin_logout";
            this.admin_logout.Size = new System.Drawing.Size(95, 42);
            this.admin_logout.TabIndex = 9;
            this.admin_logout.Text = "Log out";
            this.admin_logout.UseVisualStyleBackColor = false;
            this.admin_logout.Click += new System.EventHandler(this.admin_logout_Click);
            // 
            // view_packages
            // 
            this.view_packages.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.view_packages.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_packages.Location = new System.Drawing.Point(126, 99);
            this.view_packages.Name = "view_packages";
            this.view_packages.Size = new System.Drawing.Size(232, 59);
            this.view_packages.TabIndex = 10;
            this.view_packages.Text = "View Packages";
            this.view_packages.UseVisualStyleBackColor = false;
            this.view_packages.Click += new System.EventHandler(this.view_packages_Click);
            // 
            // subs
            // 
            this.subs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.subs.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subs.Location = new System.Drawing.Point(126, 183);
            this.subs.Name = "subs";
            this.subs.Size = new System.Drawing.Size(228, 59);
            this.subs.TabIndex = 11;
            this.subs.Text = "View Subscriptions";
            this.subs.UseVisualStyleBackColor = false;
            this.subs.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(514, 475);
            this.Controls.Add(this.subs);
            this.Controls.Add(this.view_packages);
            this.Controls.Add(this.admin_logout);
            this.Controls.Add(this.view_MD);
            this.Controls.Add(this.view_TD);
            this.Controls.Add(this.label1);
            this.Name = "Admin_login";
            this.Text = "admin_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view_TD;
        private System.Windows.Forms.Button view_MD;
        private System.Windows.Forms.Button admin_logout;
        private System.Windows.Forms.Button view_packages;
        private System.Windows.Forms.Button subs;
    }
}
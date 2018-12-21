namespace Gym_MS
{
    partial class Member_login
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
            this.view_packages = new System.Windows.Forms.Button();
            this.rate = new System.Windows.Forms.Button();
            this.view_schedule = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // view_packages
            // 
            this.view_packages.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_packages.Location = new System.Drawing.Point(37, 129);
            this.view_packages.Name = "view_packages";
            this.view_packages.Size = new System.Drawing.Size(388, 36);
            this.view_packages.TabIndex = 2;
            this.view_packages.Text = "View Packages- To view all packages offered by your branch.\r\n";
            this.view_packages.UseVisualStyleBackColor = true;
            this.view_packages.Click += new System.EventHandler(this.view_packages_Click);
            // 
            // rate
            // 
            this.rate.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.Location = new System.Drawing.Point(37, 343);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(388, 36);
            this.rate.TabIndex = 4;
            this.rate.Text = "Rate Your Trainer";
            this.rate.UseVisualStyleBackColor = true;
            this.rate.Click += new System.EventHandler(this.rate_Click);
            // 
            // view_schedule
            // 
            this.view_schedule.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_schedule.Location = new System.Drawing.Point(37, 230);
            this.view_schedule.Name = "view_schedule";
            this.view_schedule.Size = new System.Drawing.Size(388, 36);
            this.view_schedule.TabIndex = 5;
            this.view_schedule.Text = "View Schedule- To view the Class Schedule of your Gym branch.\r\n";
            this.view_schedule.UseVisualStyleBackColor = true;
            this.view_schedule.Click += new System.EventHandler(this.view_schedule_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(354, 440);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(109, 39);
            this.logout.TabIndex = 6;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Member_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gym_MS.Properties.Resources.abstract_blur_fitness_gym_and_equipment_1339_4861;
            this.ClientSize = new System.Drawing.Size(495, 491);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.view_schedule);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.view_packages);
            this.Controls.Add(this.label1);
            this.Name = "Member_login";
            this.Text = "Member_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view_packages;
        private System.Windows.Forms.Button rate;
        private System.Windows.Forms.Button view_schedule;
        private System.Windows.Forms.Button logout;
    }
}
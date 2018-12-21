namespace Gym_MS
{
    partial class Home
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
            this.member = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.RadioButton();
            this.Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Who are you?";
            // 
            // member
            // 
            this.member.AutoSize = true;
            this.member.BackColor = System.Drawing.Color.Transparent;
            this.member.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.member.Location = new System.Drawing.Point(148, 164);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(123, 35);
            this.member.TabIndex = 4;
            this.member.TabStop = true;
            this.member.Text = "Member";
            this.member.UseVisualStyleBackColor = false;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.admin.Location = new System.Drawing.Point(390, 164);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(109, 35);
            this.admin.TabIndex = 5;
            this.admin.TabStop = true;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.Transparent;
            this.Go.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Go.Location = new System.Drawing.Point(296, 338);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 34);
            this.Go.TabIndex = 6;
            this.Go.Text = "Go!";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gym_MS.Properties.Resources.blurred_gym_machines_1203_101;
            this.ClientSize = new System.Drawing.Size(704, 435);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.member);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton member;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.Button Go;
    }
}


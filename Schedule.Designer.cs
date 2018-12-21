namespace Gym_MS
{
    partial class Schedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Back = new System.Windows.Forms.Button();
            this.view_packages = new System.Windows.Forms.Button();
            this.schdeule_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.schdeule_view)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(529, 424);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(140, 36);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // view_packages
            // 
            this.view_packages.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_packages.Location = new System.Drawing.Point(272, 12);
            this.view_packages.Name = "view_packages";
            this.view_packages.Size = new System.Drawing.Size(206, 37);
            this.view_packages.TabIndex = 12;
            this.view_packages.Text = "Your Schedule";
            this.view_packages.UseVisualStyleBackColor = true;
            // 
            // schdeule_view
            // 
            this.schdeule_view.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schdeule_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.schdeule_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schdeule_view.Location = new System.Drawing.Point(35, 67);
            this.schdeule_view.Name = "schdeule_view";
            this.schdeule_view.Size = new System.Drawing.Size(653, 339);
            this.schdeule_view.TabIndex = 11;
            this.schdeule_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schdeule_view_CellContentClick);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 473);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.view_packages);
            this.Controls.Add(this.schdeule_view);
            this.Name = "Schedule";
            this.Text = "Subscribe";
            ((System.ComponentModel.ISupportInitialize)(this.schdeule_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button view_packages;
        private System.Windows.Forms.DataGridView schdeule_view;
    }
}
namespace Gym_MS
{
    partial class Packages
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
            this.package_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.package_view)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(394, 414);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(140, 36);
            this.Back.TabIndex = 8;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // view_packages
            // 
            this.view_packages.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_packages.Location = new System.Drawing.Point(60, 6);
            this.view_packages.Name = "view_packages";
            this.view_packages.Size = new System.Drawing.Size(379, 37);
            this.view_packages.TabIndex = 6;
            this.view_packages.Text = "You can Subscribe to these Packages";
            this.view_packages.UseVisualStyleBackColor = true;
            // 
            // package_view
            // 
            this.package_view.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.package_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.package_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.package_view.Location = new System.Drawing.Point(12, 49);
            this.package_view.Name = "package_view";
            this.package_view.Size = new System.Drawing.Size(522, 359);
            this.package_view.TabIndex = 9;
            this.package_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.package_view_CellContentClick);
            // 
            // Packages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 456);
            this.Controls.Add(this.package_view);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.view_packages);
            this.Name = "Packages";
            this.Text = "Packages";
            ((System.ComponentModel.ISupportInitialize)(this.package_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button view_packages;
        private System.Windows.Forms.DataGridView package_view;
    }
}
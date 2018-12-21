namespace Gym_MS
{
    partial class Trainer_details
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
            this.trainer_view = new System.Windows.Forms.DataGridView();
            this.view_packages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trainer_view)).BeginInit();
            this.SuspendLayout();
            // 
            // trainer_view
            // 
            this.trainer_view.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.trainer_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.trainer_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainer_view.Location = new System.Drawing.Point(12, 55);
            this.trainer_view.Name = "trainer_view";
            this.trainer_view.Size = new System.Drawing.Size(776, 363);
            this.trainer_view.TabIndex = 0;
            this.trainer_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trainer_view_CellContentClick);
            // 
            // view_packages
            // 
            this.view_packages.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_packages.Location = new System.Drawing.Point(297, 12);
            this.view_packages.Name = "view_packages";
            this.view_packages.Size = new System.Drawing.Size(206, 37);
            this.view_packages.TabIndex = 9;
            this.view_packages.Text = "All  Trainers";
            this.view_packages.UseVisualStyleBackColor = true;
            this.view_packages.Click += new System.EventHandler(this.view_packages_Click);
            // 
            // Trainer_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 468);
            this.Controls.Add(this.view_packages);
            this.Controls.Add(this.trainer_view);
            this.Name = "Trainer_details";
            this.Text = "Trainer_details";
            ((System.ComponentModel.ISupportInitialize)(this.trainer_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView trainer_view;
        private System.Windows.Forms.Button view_packages;
    }
}
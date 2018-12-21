namespace Gym_MS
{
    partial class Member_details
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
            this.member_view = new System.Windows.Forms.DataGridView();
            this.view_packages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.member_view)).BeginInit();
            this.SuspendLayout();
            // 
            // member_view
            // 
            this.member_view.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.member_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.member_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.member_view.Location = new System.Drawing.Point(12, 52);
            this.member_view.Name = "member_view";
            this.member_view.Size = new System.Drawing.Size(776, 347);
            this.member_view.TabIndex = 12;
            this.member_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.member_view_CellContentClick);
            // 
            // view_packages
            // 
            this.view_packages.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_packages.Location = new System.Drawing.Point(296, 9);
            this.view_packages.Name = "view_packages";
            this.view_packages.Size = new System.Drawing.Size(206, 37);
            this.view_packages.TabIndex = 10;
            this.view_packages.Text = "All  Members";
            this.view_packages.UseVisualStyleBackColor = true;
            // 
            // Member_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.member_view);
            this.Controls.Add(this.view_packages);
            this.Name = "Member_details";
            this.Text = "Members_details";
            ((System.ComponentModel.ISupportInitialize)(this.member_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView member_view;
        private System.Windows.Forms.Button view_packages;
    }
}
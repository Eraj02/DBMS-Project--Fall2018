namespace Gym_MS
{
    partial class Subs
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
            this.view = new System.Windows.Forms.Button();
            this.sub_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sub_view)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(124, 12);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(206, 37);
            this.view.TabIndex = 11;
            this.view.Text = "Subscriptions";
            this.view.UseVisualStyleBackColor = true;
            // 
            // sub_view
            // 
            this.sub_view.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sub_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sub_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sub_view.Location = new System.Drawing.Point(12, 65);
            this.sub_view.Name = "sub_view";
            this.sub_view.Size = new System.Drawing.Size(469, 363);
            this.sub_view.TabIndex = 10;
            this.sub_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trainer_view_CellContentClick);
            // 
            // Subs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 459);
            this.Controls.Add(this.view);
            this.Controls.Add(this.sub_view);
            this.Name = "Subs";
            this.Text = "Subs";
            ((System.ComponentModel.ISupportInitialize)(this.sub_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view;
        private System.Windows.Forms.DataGridView sub_view;
    }
}
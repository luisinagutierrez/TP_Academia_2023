namespace UIDesktop
{
    partial class frmSpecialitiesList
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
            dgwSpecialitiesList = new DataGridView();
            lbSpecialities = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwSpecialitiesList).BeginInit();
            SuspendLayout();
            // 
            // dgwSpecialitiesList
            // 
            dgwSpecialitiesList.AllowUserToOrderColumns = true;
            dgwSpecialitiesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSpecialitiesList.Location = new Point(12, 69);
            dgwSpecialitiesList.Name = "dgwSpecialitiesList";
            dgwSpecialitiesList.RowHeadersWidth = 51;
            dgwSpecialitiesList.RowTemplate.Height = 29;
            dgwSpecialitiesList.Size = new Size(776, 188);
            dgwSpecialitiesList.TabIndex = 0;
            // 
            // lbSpecialities
            // 
            lbSpecialities.AutoSize = true;
            lbSpecialities.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSpecialities.Location = new Point(12, 27);
            lbSpecialities.Name = "lbSpecialities";
            lbSpecialities.Size = new Size(445, 25);
            lbSpecialities.TabIndex = 1;
            lbSpecialities.Text = "Lista de especialidades de la academia";
            // 
            // frmSpecialitiesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbSpecialities);
            Controls.Add(dgwSpecialitiesList);
            Name = "frmSpecialitiesList";
            Text = "frmSpecialitiesList";
            Load += frmSpecialitiesList_Load;
            ((System.ComponentModel.ISupportInitialize)dgwSpecialitiesList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwSpecialitiesList;
        private Label lbSpecialities;
    }
}
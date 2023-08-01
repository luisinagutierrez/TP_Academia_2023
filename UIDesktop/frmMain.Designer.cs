namespace UIDesktop
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pictureBox1 = new PictureBox();
            msMain = new MenuStrip();
            tstMain = new ToolStripTextBox();
            registrarseToolStripMenuItem = new ToolStripMenuItem();
            iniciarSesiónToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            administradorToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            docentesToolStripMenuItem = new ToolStripMenuItem();
            especialidadesToolStripMenuItem = new ToolStripMenuItem();
            contactoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            msMain.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 415);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // msMain
            // 
            msMain.ImageScalingSize = new Size(20, 20);
            msMain.Items.AddRange(new ToolStripItem[] { tstMain, registrarseToolStripMenuItem, iniciarSesiónToolStripMenuItem, materiasToolStripMenuItem, docentesToolStripMenuItem, especialidadesToolStripMenuItem, contactoToolStripMenuItem });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(800, 31);
            msMain.TabIndex = 1;
            msMain.Text = "menuStrip1";
            msMain.ItemClicked += msMain_ItemClicked;
            // 
            // tstMain
            // 
            tstMain.Name = "tstMain";
            tstMain.Size = new Size(100, 27);
            tstMain.Tag = "";
            tstMain.Text = "Academia";
            tstMain.Click += toolStripTextBox1_Click;
            // 
            // registrarseToolStripMenuItem
            // 
            registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            registrarseToolStripMenuItem.Size = new Size(96, 27);
            registrarseToolStripMenuItem.Text = "Registrarse";
            registrarseToolStripMenuItem.Click += registrarseToolStripMenuItem_Click;
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            iniciarSesiónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, administradorToolStripMenuItem });
            iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            iniciarSesiónToolStripMenuItem.Size = new Size(110, 27);
            iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(187, 26);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // administradorToolStripMenuItem
            // 
            administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            administradorToolStripMenuItem.Size = new Size(187, 26);
            administradorToolStripMenuItem.Text = "Administrador";
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(80, 27);
            materiasToolStripMenuItem.Text = "Materias";
            // 
            // docentesToolStripMenuItem
            // 
            docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            docentesToolStripMenuItem.Size = new Size(85, 27);
            docentesToolStripMenuItem.Text = "Docentes";
            // 
            // especialidadesToolStripMenuItem
            // 
            especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            especialidadesToolStripMenuItem.Size = new Size(121, 27);
            especialidadesToolStripMenuItem.Text = "Especialidades";
            especialidadesToolStripMenuItem.Click += especialidadesToolStripMenuItem_Click;
            // 
            // contactoToolStripMenuItem
            // 
            contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            contactoToolStripMenuItem.Size = new Size(83, 27);
            contactoToolStripMenuItem.Text = "Contacto";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(msMain);
            MainMenuStrip = msMain;
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip msMain;
        private ToolStripTextBox tstMain;
        private ToolStripMenuItem registrarseToolStripMenuItem;
        private ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem docentesToolStripMenuItem;
        private ToolStripMenuItem especialidadesToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem administradorToolStripMenuItem;
        private ToolStripMenuItem contactoToolStripMenuItem;
    }
}
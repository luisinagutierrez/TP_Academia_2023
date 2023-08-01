namespace UIDesktop
{
    partial class frmUserSignUp
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lbUserName = new Label();
            lbUserPassword = new Label();
            lbUserIdPerson = new Label();
            btnUserSignUpAccept = new Button();
            btnUserSignUpCancel = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 99);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(240, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(173, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 2;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(12, 35);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(143, 20);
            lbUserName.TabIndex = 4;
            lbUserName.Text = "Nombre de usuario*";
            // 
            // lbUserPassword
            // 
            lbUserPassword.AutoSize = true;
            lbUserPassword.Location = new Point(12, 99);
            lbUserPassword.Name = "lbUserPassword";
            lbUserPassword.Size = new Size(89, 20);
            lbUserPassword.TabIndex = 5;
            lbUserPassword.Text = "Contraseña*";
            // 
            // lbUserIdPerson
            // 
            lbUserIdPerson.AutoSize = true;
            lbUserIdPerson.Location = new Point(12, 163);
            lbUserIdPerson.Name = "lbUserIdPerson";
            lbUserIdPerson.Size = new Size(83, 20);
            lbUserIdPerson.TabIndex = 6;
            lbUserIdPerson.Text = "Id Persona*";
            // 
            // btnUserSignUpAccept
            // 
            btnUserSignUpAccept.Location = new Point(319, 260);
            btnUserSignUpAccept.Name = "btnUserSignUpAccept";
            btnUserSignUpAccept.Size = new Size(94, 29);
            btnUserSignUpAccept.TabIndex = 7;
            btnUserSignUpAccept.Text = "Aceptar";
            btnUserSignUpAccept.UseVisualStyleBackColor = true;
            // 
            // btnUserSignUpCancel
            // 
            btnUserSignUpCancel.Location = new Point(137, 260);
            btnUserSignUpCancel.Name = "btnUserSignUpCancel";
            btnUserSignUpCancel.Size = new Size(94, 29);
            btnUserSignUpCancel.TabIndex = 8;
            btnUserSignUpCancel.Text = "Cancelar";
            btnUserSignUpCancel.UseVisualStyleBackColor = true;
            btnUserSignUpCancel.Click += btnUserSignUpCancel_Click;
            // 
            // frmUserSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 332);
            Controls.Add(btnUserSignUpCancel);
            Controls.Add(btnUserSignUpAccept);
            Controls.Add(lbUserIdPerson);
            Controls.Add(lbUserPassword);
            Controls.Add(lbUserName);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "frmUserSignUp";
            Text = "frmUserSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lbUserName;
        private Label lbUserPassword;
        private Label lbUserIdPerson;
        private Button btnUserSignUpAccept;
        private Button btnUserSignUpCancel;
    }
}
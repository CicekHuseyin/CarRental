namespace CarRental.WinFormsUI
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            LblLogin = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            LblClear = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            LblExit = new Label();
            BtnLogin = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Bauhaus 93", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogin.ForeColor = Color.FromArgb(0, 117, 214);
            LblLogin.Location = new Point(83, 148);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(130, 45);
            LblLogin.TabIndex = 2;
            LblLogin.Text = "LOGIN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Location = new Point(36, 271);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 215);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // LblClear
            // 
            LblClear.AutoSize = true;
            LblClear.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LblClear.ForeColor = Color.FromArgb(0, 117, 214);
            LblClear.Location = new Point(161, 390);
            LblClear.Name = "LblClear";
            LblClear.Size = new Size(111, 20);
            LblClear.TabIndex = 4;
            LblClear.Text = "Clear Fields";
            LblClear.Click += LblClear_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Location = new Point(36, 350);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(36, 293);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // LblExit
            // 
            LblExit.AutoSize = true;
            LblExit.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LblExit.ForeColor = Color.FromArgb(0, 117, 214);
            LblExit.Location = new Point(118, 506);
            LblExit.Name = "LblExit";
            LblExit.Size = new Size(41, 20);
            LblExit.TabIndex = 5;
            LblExit.Text = "Exit";
            LblExit.Click += LblExit_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(0, 117, 214);
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(36, 433);
            BtnLogin.Margin = new Padding(3, 4, 3, 4);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(236, 49);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "LOG IN";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(67, 215);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(205, 31);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(67, 293);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(205, 31);
            txtPassword.TabIndex = 2;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(308, 547);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(LblExit);
            Controls.Add(BtnLogin);
            Controls.Add(LblClear);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(LblLogin);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LblLogin;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label LblClear;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label LblExit;
        private Button BtnLogin;
        private TextBox txtUserName;
        private TextBox txtPassword;
    }
}

namespace CarRental.WinFormsUI
{
    partial class FrmCustomer
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
            panelTop = new Panel();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            lblTc = new Label();
            lblTelefon = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            dgvCustomers = new DataGridView();
            mskTc = new MaskedTextBox();
            mskPhone = new MaskedTextBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(mskPhone);
            panelTop.Controls.Add(mskTc);
            panelTop.Controls.Add(btnGuncelle);
            panelTop.Controls.Add(btnSil);
            panelTop.Controls.Add(btnEkle);
            panelTop.Controls.Add(lblTc);
            panelTop.Controls.Add(lblTelefon);
            panelTop.Controls.Add(txtFullName);
            panelTop.Controls.Add(lblFullName);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(882, 120);
            panelTop.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DodgerBlue;
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(728, 73);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(103, 44);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DodgerBlue;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(619, 73);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(103, 44);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DodgerBlue;
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(510, 73);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(103, 44);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // lblTc
            // 
            lblTc.AutoSize = true;
            lblTc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTc.ForeColor = Color.FromArgb(30, 136, 229);
            lblTc.Location = new Point(87, 73);
            lblTc.Name = "lblTc";
            lblTc.Size = new Size(87, 23);
            lblTc.TabIndex = 0;
            lblTc.Text = "TC Kimlik";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefon.ForeColor = Color.FromArgb(30, 136, 229);
            lblTelefon.Location = new Point(412, 38);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(68, 23);
            lblTelefon.TabIndex = 0;
            lblTelefon.Text = "Telefon";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(198, 33);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(156, 30);
            txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblFullName.ForeColor = Color.FromArgb(30, 136, 229);
            lblFullName.Location = new Point(87, 34);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(87, 23);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Ad Soyad";
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(0, 120);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.RowTemplate.Height = 29;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(882, 383);
            dgvCustomers.TabIndex = 1;
            // 
            // mskTc
            // 
            mskTc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mskTc.Location = new Point(198, 73);
            mskTc.Mask = "00000000000";
            mskTc.Name = "mskTc";
            mskTc.Size = new Size(156, 30);
            mskTc.TabIndex = 3;
            mskTc.ValidatingType = typeof(int);
            // 
            // mskPhone
            // 
            mskPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            mskPhone.Location = new Point(498, 33);
            mskPhone.Mask = "(999) 000-0000";
            mskPhone.Name = "mskPhone";
            mskPhone.Size = new Size(156, 30);
            mskPhone.TabIndex = 4;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 503);
            Controls.Add(dgvCustomers);
            Controls.Add(panelTop);
            Name = "FrmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri İşlemleri";
            Load += FrmCustomer_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private TextBox txtFullName;
        private Label lblFullName;
        private Label lblTc;
        private Label lblTelefon;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvCustomers;
        private MaskedTextBox mskPhone;
        private MaskedTextBox mskTc;
    }
}
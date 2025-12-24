namespace CarRental.WinFormsUI
{
    partial class FrmCar
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
            lblColor = new Label();
            txtColor = new TextBox();
            txtModel = new TextBox();
            txtBrand = new TextBox();
            lblModel = new Label();
            txtPlate = new TextBox();
            lblPlate = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            lblBrand = new Label();
            lblYear = new Label();
            txtYear = new TextBox();
            lblKm = new Label();
            txtKm = new TextBox();
            lblDailyPrice = new Label();
            textBox1 = new TextBox();
            chkIsAvailable = new CheckBox();
            lblDurum = new Label();
            dgvVehicles = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(chkIsAvailable);
            panelTop.Controls.Add(btnSil);
            panelTop.Controls.Add(lblColor);
            panelTop.Controls.Add(btnGuncelle);
            panelTop.Controls.Add(btnEkle);
            panelTop.Controls.Add(txtColor);
            panelTop.Controls.Add(txtKm);
            panelTop.Controls.Add(textBox1);
            panelTop.Controls.Add(txtYear);
            panelTop.Controls.Add(lblDurum);
            panelTop.Controls.Add(lblKm);
            panelTop.Controls.Add(lblDailyPrice);
            panelTop.Controls.Add(txtModel);
            panelTop.Controls.Add(lblYear);
            panelTop.Controls.Add(txtBrand);
            panelTop.Controls.Add(lblModel);
            panelTop.Controls.Add(txtPlate);
            panelTop.Controls.Add(lblBrand);
            panelTop.Controls.Add(lblPlate);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(831, 289);
            panelTop.TabIndex = 1;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblColor.ForeColor = Color.FromArgb(30, 136, 229);
            lblColor.Location = new Point(426, 92);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(50, 23);
            lblColor.TabIndex = 0;
            lblColor.Text = "Renk";
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtColor.Location = new Point(512, 85);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(156, 30);
            txtColor.TabIndex = 4;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtModel.Location = new Point(225, 85);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(156, 30);
            txtModel.TabIndex = 3;
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBrand.Location = new Point(512, 33);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(156, 30);
            txtBrand.TabIndex = 2;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblModel.ForeColor = Color.FromArgb(30, 136, 229);
            lblModel.Location = new Point(106, 92);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(61, 23);
            lblModel.TabIndex = 0;
            lblModel.Text = "Model";
            // 
            // txtPlate
            // 
            txtPlate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlate.Location = new Point(225, 33);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(156, 30);
            txtPlate.TabIndex = 1;
            // 
            // lblPlate
            // 
            lblPlate.AutoSize = true;
            lblPlate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlate.ForeColor = Color.FromArgb(30, 136, 229);
            lblPlate.Location = new Point(106, 40);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(53, 23);
            lblPlate.TabIndex = 0;
            lblPlate.Text = "Plaka";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DodgerBlue;
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(474, 228);
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
            btnSil.Location = new Point(365, 228);
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
            btnEkle.Location = new Point(256, 228);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(103, 44);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrand.ForeColor = Color.FromArgb(30, 136, 229);
            lblBrand.Location = new Point(426, 40);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(61, 23);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Marka";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblYear.ForeColor = Color.FromArgb(30, 136, 229);
            lblYear.Location = new Point(106, 139);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(30, 23);
            lblYear.TabIndex = 0;
            lblYear.Text = "Yıl";
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtYear.Location = new Point(225, 132);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(156, 30);
            txtYear.TabIndex = 3;
            // 
            // lblKm
            // 
            lblKm.AutoSize = true;
            lblKm.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblKm.ForeColor = Color.FromArgb(30, 136, 229);
            lblKm.Location = new Point(426, 139);
            lblKm.Name = "lblKm";
            lblKm.Size = new Size(37, 23);
            lblKm.TabIndex = 0;
            lblKm.Text = "Km";
            // 
            // txtKm
            // 
            txtKm.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtKm.Location = new Point(512, 132);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(156, 30);
            txtKm.TabIndex = 3;
            // 
            // lblDailyPrice
            // 
            lblDailyPrice.AutoSize = true;
            lblDailyPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDailyPrice.ForeColor = Color.FromArgb(30, 136, 229);
            lblDailyPrice.Location = new Point(106, 188);
            lblDailyPrice.Name = "lblDailyPrice";
            lblDailyPrice.Size = new Size(106, 23);
            lblDailyPrice.TabIndex = 0;
            lblDailyPrice.Text = "Günlik Fiyat";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(225, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 30);
            textBox1.TabIndex = 3;
            // 
            // chkIsAvailable
            // 
            chkIsAvailable.AutoSize = true;
            chkIsAvailable.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chkIsAvailable.ForeColor = Color.FromArgb(30, 136, 229);
            chkIsAvailable.Location = new Point(512, 188);
            chkIsAvailable.Name = "chkIsAvailable";
            chkIsAvailable.Size = new Size(18, 17);
            chkIsAvailable.TabIndex = 5;
            chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDurum.ForeColor = Color.FromArgb(30, 136, 229);
            lblDurum.Location = new Point(426, 188);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(66, 23);
            lblDurum.TabIndex = 0;
            lblDurum.Text = "Durum";
            // 
            // dgvVehicles
            // 
            dgvVehicles.AllowUserToAddRows = false;
            dgvVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehicles.BackgroundColor = Color.White;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Dock = DockStyle.Fill;
            dgvVehicles.Location = new Point(0, 289);
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.ReadOnly = true;
            dgvVehicles.RowHeadersVisible = false;
            dgvVehicles.RowHeadersWidth = 51;
            dgvVehicles.RowTemplate.Height = 29;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.Size = new Size(831, 302);
            dgvVehicles.TabIndex = 2;
            // 
            // FrmCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 591);
            Controls.Add(dgvVehicles);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmCar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç İşlemleri";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private MaskedTextBox mskPhone;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Label lblTelefon;
        private TextBox txtPlate;
        private Label lblPlate;
        private TextBox txtBrand;
        private Label lblColor;
        private TextBox txtColor;
        private TextBox txtModel;
        private Label lblModel;
        private NumericUpDown numericUpDown1;
        private TextBox txtKm;
        private TextBox textBox1;
        private TextBox txtYear;
        private Label lblKm;
        private Label lblDailyPrice;
        private Label lblYear;
        private Label lblBrand;
        private CheckBox chkIsAvailable;
        private Label lblDurum;
        private DataGridView dgvVehicles;
    }
}
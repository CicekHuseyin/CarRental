namespace CarRental.WinFormsUI
{
    partial class FrmRental
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
            txtTotalPrice = new TextBox();
            btnGuncelle = new Button();
            btnEkle = new Button();
            dtpReturnDate = new DateTimePicker();
            btnSil = new Button();
            dtpRentDate = new DateTimePicker();
            cmbCustomer = new ComboBox();
            cmbVehicle = new ComboBox();
            lblReturnDate = new Label();
            lblCustomer = new Label();
            lblTotalPrice = new Label();
            lblRentDate = new Label();
            lblVehicle = new Label();
            dgvRentals = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentals).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(txtTotalPrice);
            panelTop.Controls.Add(btnGuncelle);
            panelTop.Controls.Add(btnEkle);
            panelTop.Controls.Add(dtpReturnDate);
            panelTop.Controls.Add(btnSil);
            panelTop.Controls.Add(dtpRentDate);
            panelTop.Controls.Add(cmbCustomer);
            panelTop.Controls.Add(cmbVehicle);
            panelTop.Controls.Add(lblReturnDate);
            panelTop.Controls.Add(lblCustomer);
            panelTop.Controls.Add(lblTotalPrice);
            panelTop.Controls.Add(lblRentDate);
            panelTop.Controls.Add(lblVehicle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(839, 222);
            panelTop.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BackColor = Color.White;
            txtTotalPrice.Location = new Point(238, 157);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(190, 27);
            txtTotalPrice.TabIndex = 7;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DodgerBlue;
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(689, 148);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(103, 44);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.DodgerBlue;
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(471, 148);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(103, 44);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Checked = false;
            dtpReturnDate.Format = DateTimePickerFormat.Short;
            dtpReturnDate.Location = new Point(607, 90);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.ShowCheckBox = true;
            dtpReturnDate.Size = new Size(185, 27);
            dtpReturnDate.TabIndex = 6;
            dtpReturnDate.Value = new DateTime(2025, 12, 24, 0, 0, 0, 0);
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.DodgerBlue;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(580, 148);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(103, 44);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // dtpRentDate
            // 
            dtpRentDate.Format = DateTimePickerFormat.Short;
            dtpRentDate.Location = new Point(238, 90);
            dtpRentDate.Name = "dtpRentDate";
            dtpRentDate.Size = new Size(190, 27);
            dtpRentDate.TabIndex = 6;
            dtpRentDate.Value = new DateTime(2025, 12, 24, 0, 0, 0, 0);
            // 
            // cmbCustomer
            // 
            cmbCustomer.BackColor = Color.White;
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(607, 34);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(185, 28);
            cmbCustomer.TabIndex = 5;
            // 
            // cmbVehicle
            // 
            cmbVehicle.BackColor = Color.White;
            cmbVehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicle.FormattingEnabled = true;
            cmbVehicle.Location = new Point(238, 34);
            cmbVehicle.Name = "cmbVehicle";
            cmbVehicle.Size = new Size(190, 28);
            cmbVehicle.TabIndex = 5;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblReturnDate.ForeColor = Color.FromArgb(30, 136, 229);
            lblReturnDate.Location = new Point(486, 94);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(110, 23);
            lblReturnDate.TabIndex = 0;
            lblReturnDate.Text = "Teslim Tarihi";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomer.ForeColor = Color.FromArgb(30, 136, 229);
            lblCustomer.Location = new Point(486, 39);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(71, 23);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Müşteri";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.FromArgb(30, 136, 229);
            lblTotalPrice.Location = new Point(88, 161);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(113, 23);
            lblTotalPrice.TabIndex = 0;
            lblTotalPrice.Text = "Toplam Fiyat";
            // 
            // lblRentDate
            // 
            lblRentDate.AutoSize = true;
            lblRentDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRentDate.ForeColor = Color.FromArgb(30, 136, 229);
            lblRentDate.Location = new Point(88, 94);
            lblRentDate.Name = "lblRentDate";
            lblRentDate.Size = new Size(131, 23);
            lblRentDate.TabIndex = 0;
            lblRentDate.Text = "Kiralama Tarihi";
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblVehicle.ForeColor = Color.FromArgb(30, 136, 229);
            lblVehicle.Location = new Point(88, 39);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(46, 23);
            lblVehicle.TabIndex = 0;
            lblVehicle.Text = "Araç";
            // 
            // dgvRentals
            // 
            dgvRentals.AllowUserToAddRows = false;
            dgvRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRentals.BackgroundColor = Color.White;
            dgvRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentals.Dock = DockStyle.Fill;
            dgvRentals.Location = new Point(0, 222);
            dgvRentals.Name = "dgvRentals";
            dgvRentals.ReadOnly = true;
            dgvRentals.RowHeadersVisible = false;
            dgvRentals.RowHeadersWidth = 51;
            dgvRentals.RowTemplate.Height = 29;
            dgvRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentals.Size = new Size(839, 273);
            dgvRentals.TabIndex = 2;
            dgvRentals.CellClick += dgvRentals_CellClick;
            // 
            // FrmRental
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 495);
            Controls.Add(dgvRentals);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "FrmRental";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Kiralama İşlemleri";
            Load += FrmRental_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Label lblVehicle;
        private ComboBox cmbCustomer;
        private ComboBox cmbVehicle;
        private Label lblCustomer;
        private DateTimePicker dtpReturnDate;
        private DateTimePicker dtpRentDate;
        private Label lblReturnDate;
        private Label lblRentDate;
        private TextBox txtTotalPrice;
        private Label lblTotalPrice;
        private DataGridView dgvRentals;
    }
}
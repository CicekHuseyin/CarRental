using CarRental.Business.Concrete;
using CarRental.Entities.Concrete;
using System.Data;

namespace CarRental.WinFormsUI
{
    public partial class FrmRental : Form
    {
        private VehicleManager _vehicleManager;
        private CustomerManager _customerManager;
        private RentalManager _rentalManager;
        private int _selectedRentalId = 0;

        public FrmRental()
        {
            InitializeComponent();
            _vehicleManager = new VehicleManager();
            _customerManager = new CustomerManager();
            _rentalManager = new RentalManager();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var rental = new Rental
                {
                    VehicleId = Convert.ToInt32(cmbVehicle.SelectedValue),
                    CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue),
                    RentDate = dtpRentDate.Value,
                    ReturnDate = dtpReturnDate.Value
                    // TotalPrice burada YOK
                };

                _rentalManager.Add(rental);

                MessageBox.Show(
                    "Araç kiralama işlemi başarıyla eklendi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadRentalsToGrid();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmRental_Load(object sender, EventArgs e)
        {
            LoadVehiclesToCombo();
            LoadCustomersToCombo();
            LoadRentalsToGrid();
        }

        /// <summary>
        /// Sistemde müsait olan araçları veritabanından getirir
        /// ve araç seçim ComboBox'ına plaka bilgisiyle bağlar.
        /// </summary>
        private void LoadVehiclesToCombo(int? selectedVehicleId = null)
        {
            try
            {
                var vehicles = _vehicleManager.GetAll();

                // Yeni kayıt → sadece müsait araçlar
                if (selectedVehicleId == null)
                    vehicles = vehicles.Where(x => x.IsAvailable).ToList();
                else
                {
                    // Güncelleme → seçili araç + müsait olanlar
                    vehicles = vehicles
                        .Where(x => x.IsAvailable || x.Id == selectedVehicleId)
                        .ToList();
                }

                cmbVehicle.DataSource = null;
                cmbVehicle.DisplayMember = "Plate";
                cmbVehicle.ValueMember = "Id";
                cmbVehicle.DataSource = vehicles;
                cmbVehicle.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sistemde kayıtlı tüm müşterileri getirir
        /// ve müşteri seçim ComboBox'ına ad-soyad bilgisiyle bağlar.
        /// </summary>
        private void LoadCustomersToCombo()
        {
            try
            {
                var customers = _customerManager.GetAll();

                cmbCustomer.DataSource = null;
                cmbCustomer.DisplayMember = "FullName";
                cmbCustomer.ValueMember = "Id";
                cmbCustomer.DataSource = customers;
                cmbCustomer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sistemde kayıtlı tüm araç kiralama işlemlerini
        /// veritabanından getirerek DataGridView kontrolüne bağlar.
        /// </summary>
        private void LoadRentalsToGrid()
        {
            try
            {
                var rentals = _rentalManager.GetAll();
                dgvRentals.DataSource = null;
                dgvRentals.DataSource = rentals;

                dgvRentals.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Araç kiralama işlemlerinden sonra form üzerindeki
        /// tüm giriş alanlarını temizler ve varsayılan değerlere döner.
        /// </summary>
        private void ClearInputs()
        {
            cmbVehicle.SelectedIndex = -1;
            cmbCustomer.SelectedIndex = -1;

            dtpRentDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today;

            txtTotalPrice.Clear();

            cmbVehicle.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedRentalId == 0)
                    return;

                _rentalManager.Delete(_selectedRentalId);

                MessageBox.Show("Kiralama işlemi başarıyla silindi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadRentalsToGrid();
                ClearInputs();
                _selectedRentalId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var rental = _rentalManager.GetById(_selectedRentalId);

                if (rental == null)
                    return;

                rental.VehicleId = Convert.ToInt32(cmbVehicle.SelectedValue);
                rental.CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                rental.RentDate = dtpRentDate.Value;
                rental.ReturnDate = dtpReturnDate.Value;
                rental.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);

                _rentalManager.Update(rental);

                MessageBox.Show("Kiralama işlemi başarıyla güncellendi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadRentalsToGrid();
                ClearInputs();
                _selectedRentalId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// DataGridView üzerinde seçilen kiralama kaydının
        /// bilgilerini form alanlarına doldurur.
        /// </summary>
        private void dgvRentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row = dgvRentals.Rows[e.RowIndex];

                _selectedRentalId = Convert.ToInt32(row.Cells["Id"].Value);

                // Gerçek kiralama kaydı alınır
                var rental = _rentalManager.GetById(_selectedRentalId);
                if (rental == null)
                    return;

                //KRİTİK: önce ComboBox'ları yükle
                LoadVehiclesToCombo(rental.VehicleId);
                LoadCustomersToCombo();

                //KRİTİK: DataSource yüklendikten sonra SelectedValue ver
                cmbVehicle.SelectedValue = rental.VehicleId;
                cmbCustomer.SelectedValue = rental.CustomerId;

                dtpRentDate.Value = rental.RentDate;
                dtpReturnDate.Value = rental.ReturnDate ?? DateTime.Today;
                txtTotalPrice.Text = rental.TotalPrice.ToString("0.00");
            }
            catch (Exception ex)
            {
                _selectedRentalId = 0;

                MessageBox.Show(
                    "Kayıt seçilirken bir hata oluştu.\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

    }
}

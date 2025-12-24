using CarRental.Business.Concrete;
using CarRental.Entities.Concrete;

namespace CarRental.WinFormsUI
{
    public partial class FrmCar : Form
    {
        private int _selectedVehicleId = 0;
        private VehicleManager _vehicleManager;

        public FrmCar()
        {
            InitializeComponent();
            _vehicleManager = new VehicleManager();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var vehicle = new Vehicle
                {
                    Plate = txtPlate.Text.Trim(),
                    Brand = txtBrand.Text.Trim(),
                    Model = txtModel.Text.Trim(),
                    Color = txtColor.Text.Trim(),
                    ProductionYear = int.Parse(txtYear.Text.Trim()),
                    Kilometer = int.Parse(txtKm.Text.Trim()),
                    DailyPrice = int.Parse(txtDailyPrice.Text.Trim()),
                    IsAvailable = chkIsAvailable.Checked
                };

                _vehicleManager.Add(vehicle);

                MessageBox.Show("Araç başarıyla eklendi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadVehiclesToGrid();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedVehicleId == 0)
                    return;

                var vehicle = _vehicleManager.GetById(_selectedVehicleId);

                if (vehicle == null)
                    return;

                _vehicleManager.Delete(vehicle.Id);

                MessageBox.Show("Araç başarıyla silindi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadVehiclesToGrid();
                ClearInputs();
                _selectedVehicleId = 0;
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
                var vehicle = _vehicleManager.GetById(_selectedVehicleId);

                if (vehicle == null)
                    return;

                vehicle.Plate = txtPlate.Text.Trim();
                vehicle.Brand = txtBrand.Text.Trim();
                vehicle.Model = txtModel.Text.Trim();
                vehicle.Color = txtColor.Text.Trim();
                vehicle.ProductionYear = int.Parse(txtYear.Text.Trim());
                vehicle.Kilometer = int.Parse(txtKm.Text.Trim());
                vehicle.DailyPrice = int.Parse(txtDailyPrice.Text.Trim());
                vehicle.IsAvailable = chkIsAvailable.Checked;

                _vehicleManager.Update(vehicle);

                MessageBox.Show("Araç başarıyla güncellendi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadVehiclesToGrid();
                ClearInputs();
                _selectedVehicleId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Araç işlemleri formu yüklendiğinde tetiklenir.
        /// Sistemde kayıtlı araçları veritabanından getirerek
        /// DataGridView kontrolünde listeler.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen Form</param>
        /// <param name="e">Olay parametreleri</param>
        private void FrmCar_Load(object sender, EventArgs e)
        {
            LoadVehiclesToGrid();
        }

        /// <summary>
        /// DataGridView üzerinde seçilen satırın araç bilgilerini
        /// ilgili input alanlarına doldurur.
        /// Ayrıca seçilen aracın Id bilgisini güncelleme ve silme
        /// işlemlerinde kullanılmak üzere saklar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen DataGridView</param>
        /// <param name="e">
        /// Tıklanan hücrenin satır ve sütun indeks bilgilerini içerir.
        /// </param>
        private void dgvVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEkle.Enabled = false;
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row = dgvVehicles.Rows[e.RowIndex];

                _selectedVehicleId = Convert.ToInt32(row.Cells["Id"].Value);

                txtPlate.Text = row.Cells["Plate"].Value?.ToString();
                txtBrand.Text = row.Cells["Brand"].Value?.ToString();
                txtModel.Text = row.Cells["Model"].Value?.ToString();
                txtColor.Text = row.Cells["Color"].Value?.ToString();

                txtYear.Text = row.Cells["ProductionYear"].Value?.ToString();
                txtKm.Text = row.Cells["Kilometer"].Value?.ToString();
                txtDailyPrice.Text = row.Cells["DailyPrice"].Value?.ToString();
                chkIsAvailable.Checked = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
            }
            catch (Exception ex)
            {
                _selectedVehicleId = 0;

                MessageBox.Show(
                    "Kayıt seçilirken bir hata oluştu.\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Sistemde kayıtlı tüm araçları veritabanından getirerek
        /// DataGridView kontrolüne bağlar.
        /// Listeleme sırasında oluşabilecek hatalar
        /// try-catch bloğu içerisinde yakalanır.
        /// </summary>
        private void LoadVehiclesToGrid()
        {
            try
            {
                var vehicles = _vehicleManager.GetAll();
                dgvVehicles.DataSource = null;
                dgvVehicles.DataSource = vehicles;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Araç ekleme, silme veya güncelleme işlemlerinden sonra
        /// form üzerindeki tüm giriş alanlarını temizler,
        /// aracın müsaitlik durumunu varsayılan olarak aktif yapar
        /// ve imleci plaka alanına odaklar.
        /// </summary>
        private void ClearInputs()
        {
            txtPlate.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtColor.Clear();
            txtYear.Clear();
            txtKm.Clear();
            txtDailyPrice.Clear();
            chkIsAvailable.Checked = true;
            txtPlate.Focus();
        }


    }
}

using CarRental.Business.Concrete;
using CarRental.Entities.Concrete;

namespace CarRental.WinFormsUI
{
    public partial class FrmCustomer : Form
    {
        private int _selectedCustomerId = 0;
        private CustomerManager _customerManager;

        public FrmCustomer()
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ConfigurationManager.ConnectionStrings["CarRentalDb"]?.ConnectionString);
            LoadCustomersToGrid();
        }

        /// <summary>
        /// Sistemde kayıtlı tüm müşterileri veritabanından getirerek
        /// DataGridView kontrolüne bağlar.
        /// Listeleme sırasında oluşabilecek hatalar try-catch bloğu
        /// içerisinde yakalanarak kullanıcıya gösterilir.
        /// </summary>
        private void LoadCustomersToGrid()
        {
            try
            {
                var customers = _customerManager.GetAll();
                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Müşteri ekleme, silme veya güncelleme işlemlerinden sonra
        /// form üzerindeki tüm giriş alanlarını temizler
        /// ve imleci ad-soyad alanına odaklar.
        /// </summary>
        private void ClearInputs()
        {
            txtFullName.Clear();
            mskPhone.Clear();
            mskTc.Clear();
            txtFullName.Focus();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = new Customer
                {
                    FullName = txtFullName.Text.Trim(),
                    TC = mskTc.Text.Trim(),
                    Phone = mskPhone.Text.Trim()
                };

                _customerManager.Add(customer);

                MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCustomersToGrid();

                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// DataGridView üzerinde seçilen satırın müşteri bilgilerini
        /// ilgili input alanlarına doldurur.
        /// Ayrıca seçilen kaydın Id bilgisini güncelleme ve silme
        /// işlemlerinde kullanılmak üzere saklar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen DataGridView</param>
        /// <param name="e">
        /// Tıklanan hücrenin satır ve sütun indeks bilgilerini içerir.
        /// </param>
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];

                _selectedCustomerId = Convert.ToInt32(row.Cells["Id"].Value);

                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                mskTc.Text = row.Cells["TC"].Value?.ToString();
                mskPhone.Text = row.Cells["Phone"].Value?.ToString();
            }
            catch (Exception ex)
            {
                _selectedCustomerId = 0;

                MessageBox.Show(
                    "Kayıt seçilirken bir hata oluştu.\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedCustomerId == 0)
                    return;

                var customer = _customerManager.GetById(_selectedCustomerId);

                if (customer == null)
                    return;

                _customerManager.Delete(customer.Id);

                MessageBox.Show("Müşteri başarıyla silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                LoadCustomersToGrid();
                ClearInputs();
                _selectedCustomerId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = _customerManager.GetById(_selectedCustomerId);

                if (customer == null)
                    return;

                customer.FullName = txtFullName.Text.Trim();
                customer.TC = mskTc.Text.Trim();
                customer.Phone = mskPhone.Text.Trim();

                _customerManager.Update(customer);

                MessageBox.Show("Müşteri başarıyla güncellendi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCustomersToGrid();
                ClearInputs();
                _selectedCustomerId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

using CarRental.Business.Concrete;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace CarRental.WinFormsUI
{
    public partial class FrmCustomer : Form
    {
        private CustomerManager _customerManager;

        public FrmCustomer()
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ConfigurationManager.ConnectionStrings["CarRentalDb"]?.ConnectionString);
            //LoadCustomersToGrid();
        }

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
    }
}

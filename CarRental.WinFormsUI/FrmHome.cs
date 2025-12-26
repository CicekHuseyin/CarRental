namespace CarRental.WinFormsUI
{
    public partial class FrmHome : Form
    {

        public FrmHome()
        {
            InitializeComponent();
        }

        private void pbCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer customer = new FrmCustomer();
            customer.Show();
        }

        private void pbCar_Click(object sender, EventArgs e)
        {
            FrmCar car = new FrmCar();
            car.Show();
        }

        private void pbRent_Click(object sender, EventArgs e)
        {
            FrmRental frmRental = new FrmRental();
            frmRental.Show();
        }

        private void pbReport_Click(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.Show();
        }
    }
}

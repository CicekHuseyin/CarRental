using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

using CarRental.Business.Abstract;
using CarRental.Business.Concrete;
using CarRental.Entities.Dtos;

namespace CarRental.WinFormsUI
{
    public partial class FrmLogin : Form
    {
        private IAuthService _authService;

        public FrmLogin()
        {
            InitializeComponent();
            _authService = new AuthManager();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = new LoginDto
                {
                    Username = txtUserName.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                };

                _authService.Login(dto);

                MessageBox.Show("Giriþ baþarýlý","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                FrmHome frmHome = new FrmHome();
                frmHome.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void LblClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

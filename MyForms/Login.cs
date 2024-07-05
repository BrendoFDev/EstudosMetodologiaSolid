using MyForms.Factory;

namespace MyForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

            EventHandler eventhandler = new EventHandler(bttLogin_Click);
            if (e.KeyCode == Keys.Enter)
                eventhandler(null, e);
        }

        private void bttLogin_Click(object? sender, EventArgs e)
        {

        }

        private void bttLogon_Click(object sender, EventArgs e)
        {
            CadUsuario cadUsuario = new CadUsuario();
        }
    }
}

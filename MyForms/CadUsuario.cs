using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyForms.Services;
using MyForms.Entity;
using MyForms.Factory;


namespace MyForms
{
    public partial class CadUsuario : Form
    {

        public CadUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLogin.Focus();
            }
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttCadastrar.Focus();
            }
        }

        private void bttCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                INhibernateHelper nhibernateHelper = new NhibernateHelper();
                IUserService userService = new UserService(nhibernateHelper);
                User user = new User();

                if (!string.IsNullOrEmpty(txtNome.Text) || !string.IsNullOrEmpty(txtEmail.Text) || !string.IsNullOrEmpty(txtSenha.Text) || !string.IsNullOrEmpty(txtLogin.Text))
                {
                    user.Name = txtNome.Text;
                    user.Email = txtEmail.Text;
                    user.Login = txtLogin.Text;
                    user.Password = txtSenha.Text;

                    userService.Save(user);

                    MessageBox.Show("Usuario Cadastrado com sucesso");

                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}

using DemoLib.Models;
using System;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class AuthorizeForm : Form
    {
        private UsersModel model_ = new UsersModel();
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void AuthorizeForm_Load(object sender, EventArgs e)
        {
            LoginComboBox.DataSource = model_.GetAllLogins();
        }

        private void LoginComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            string login = LoginComboBox.SelectedItem.ToString();
            string password = PasswordTextBox.Text;

            if (model_.Authorization(login, password))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
               /// уточнить
                Hide();
            }
            else
            {
                MessageBox.Show("Вы не молодец, неверный пароль");
            }
        }
    }
}

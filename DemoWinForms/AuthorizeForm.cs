using DemoLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}

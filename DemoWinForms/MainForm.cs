using ClientCard;
using DemoLib;
using DemoLib.Models;
using DemoLib.Presenters;
using DemoLib.Views;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class MainForm : Form
    {
        private User currentUser_ = null;
        private ClientPresenter presenter_;
        public MainForm(User user)
        {
            currentUser_ = user;
            InitializeComponent();

            MemoryClientsModel model = new MemoryClientsModel();

            /// Д.З Сделать нормальный вид карточек
            List<IClientView> cards = new List<IClientView>();
            for (int i = 0; i < model.GetClientsCount(); i++)
            {
                ClientView card = new ClientView(); /// наклепали пустую карточку
                card.SelectedClient += Card_SelectedClient;
                ClientsLayout.Controls.Add(card); /// добавляем карточку на главную форму в layout
                cards.Add(card); 
            }

            presenter_ = new ClientPresenter(new MemoryClientsModel(), cards);
        }

        private void Card_SelectedClient(Client obj)
        {
            if(obj == null)
            {
                return;
            }

            ClientOrdersForm ordersForm = new ClientOrdersForm();
            ordersForm.Text = "Заказы клиента " + obj.Name;
            ordersForm.SetOrder(obj.order);
            ordersForm.ShowDialog();
        }

        private void SearchByClientNameTextBox_TextChanged(object sender, System.EventArgs e)
        {
            string searchingText = SearchByClientNameTextBox.Text;
            
            presenter_.SearchClientsByPartialName(searchingText);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            /// currentUser_ == null - это гость
            if(currentUser_.Role == UserRole.Client || currentUser_ == null)
            {
                this.SearchByClientNameTextBox.Enabled = false;
                this.SearchByNameLabel.Text = "Поиск по клиенту Вам недоступен";
                this.SearchByNameLabel.ForeColor = System.Drawing.Color.Red;
            }

            Text = this.Text + " - " + currentUser_.Login;
        }
    }
}

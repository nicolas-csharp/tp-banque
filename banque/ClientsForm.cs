using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banque
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void decoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnexionForm connexionForm = new ConnexionForm();
            connexionForm.Show();
        }

        private void verscompteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComptesForm comptesForm = new ComptesForm();
            comptesForm.Show();
        }

        // Fonction pour charger les clients qui appel la fonction GetAllClients du backend
        // private void ChargerClients()
        // {
        //    clientsLabel = DBInterface.GetAllClients();
        //    clientsGrid.DataSource = clientsLabel;
        // }
    }
}

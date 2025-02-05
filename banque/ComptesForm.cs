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
    public partial class ComptesForm : Form
    {
        public ComptesForm()
        {
            InitializeComponent();
        }

        private void retourButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            // Modification des informations du clients, le changement devrait modifier directement la base
            // de données.
        }

        private void compteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompteForm compteForm = new CompteForm();
            compteForm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnexionForm connexionForm = new ConnexionForm();
            connexionForm.Show();
        }
    }
}

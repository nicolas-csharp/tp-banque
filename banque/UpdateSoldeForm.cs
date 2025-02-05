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
    public partial class UpdateSoldeForm : Form
    {
        public UpdateSoldeForm()
        {
            InitializeComponent();
        }

        private void retourButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompteForm compteForm = new CompteForm();
            compteForm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solde mis à jour.");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnexionForm connexionForm = new ConnexionForm();
            connexionForm.Show();
        }
    }
}

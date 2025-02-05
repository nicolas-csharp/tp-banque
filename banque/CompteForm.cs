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
    public partial class CompteForm : Form
    {
        public CompteForm()
        {
            InitializeComponent();
        }

        private void retourButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComptesForm comptesForm = new ComptesForm();
            comptesForm.Show();
        }

        private void soldeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateSoldeForm updateSoldeForm = new UpdateSoldeForm();
            updateSoldeForm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnexionForm connexionForm = new ConnexionForm();
            connexionForm.Show();
        }
    }
}

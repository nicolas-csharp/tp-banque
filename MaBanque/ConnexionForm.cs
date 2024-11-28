using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaBanque
{
    public partial class ConnexionForm : Form
    {
        public ConnexionForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "test" && txtPassword.Text == "test")
            {
                this.Hide();
                ClientsForm clientsForm = new ClientsForm();
                clientsForm.Show();
            }
            else
            {
                MessageBox.Show("Identifiants incorrects.");
            }
        }
    }
}

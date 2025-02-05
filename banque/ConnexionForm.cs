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
    public partial class ConnexionForm : Form
    {
        public ConnexionForm()
        {
            InitializeComponent();
            passwordTextbox.KeyDown += passwordTextbox_KeyDown;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            // Le code suivant serait ce qu'on aurait fait si la base de donnée
            // était relier au projet.

            // DBInterface dbInterface = new DBInterface();
            // bool isValid = dbInterface.CheckLogin(usernamen, password);
            // if (isValid) {
            // ComptesForm comptesForm = new ComptesForm();
            // comptesForm.Show();
            // this.Hide(); }

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Connexion réussie");
                ClientsForm clientsForm = new ClientsForm();
                clientsForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Identifidant ou mot de passe invalide.");
            }
        }

        private void passwordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}

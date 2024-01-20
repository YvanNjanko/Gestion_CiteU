using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FrontEnd_Gestion_CiteU
{
    public partial class CreateAccount : Form
    {
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ConnectPage MenuForm = new ConnectPage();
            MenuForm.Show();
            this.Hide();
        }

        private void SeConnecter_Click(object sender, EventArgs e)
        {
            // Récupérer les informations saisies
            string nomAdmin = textBox1.Text.Trim();
            string motDePasse = textBox2.Text;

            // Vérifier si les champs sont vides
            if (string.IsNullOrEmpty(nomAdmin) || string.IsNullOrEmpty(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            // Utiliser une connexion à la base de données pour insérer les informations dans la table admin
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Utiliser une commande SQL pour insérer les informations dans la table admin
                    string query = "INSERT INTO admin (nom, password) VALUES (@nomAdmin, @motDePasse)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nomAdmin", nomAdmin);
                    command.Parameters.AddWithValue("@motDePasse", motDePasse);

                    // Exécuter la commande SQL
                    command.ExecuteNonQuery();

                    MessageBox.Show("Le compte administrateur a été créé avec succès.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la création du compte administrateur : " + ex.Message);
                }
                finally
                {
                    // Fermer la connexion à la base de données
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Ajouter du code si nécessaire
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            // Ajouter du code si nécessaire
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Ajouter du code si nécessaire
        }
    }
}

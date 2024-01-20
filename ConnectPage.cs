using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FrontEnd_Gestion_CiteU
{
    public partial class ConnectPage : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public ConnectPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialise la connexion à la base de données
           /* connection = new MySqlConnection(connectionString);

            try
            {
                // Ouvre la connexion à la base de données
                connection.Open();
                MessageBox.Show("Connexion à la base de données réussie.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message);
            }
            finally
            {
                // Ferme la connexion, assurez-vous de la fermer lorsque vous n'en avez plus besoin
                connection.Close();
            }
           */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeConnecter_Click(object sender, EventArgs e)
        {
            // Récupère les données entrées par l'utilisateur
            string nomUtilisateur = textBox1.Text;
            string motDePasse = textBox2.Text;

            // Initialise la connexion à la base de données
            connection = new MySqlConnection(connectionString);

            try
            {
                // Ouvre la connexion à la base de données
                connection.Open();

                // Vérifie les informations dans la base de données
                string query = "SELECT COUNT(*) FROM admin WHERE nom = @nom AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nom", nomUtilisateur);
                cmd.Parameters.AddWithValue("@password", motDePasse);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    // Les informations sont correctes, redirigez vers la page Menu1.cs
                    MessageBox.Show("Connexion réussie !");
                    Menu1 menu = new Menu1();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                // Ferme la connexion, assurez-vous de la fermer lorsque vous n'en avez plus besoin
                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CreateAccount MenuForm = new CreateAccount();
            MenuForm.Show();
            this.Hide();

        }
    }

}

using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FrontEnd_Gestion_CiteU
{
    public partial class Info : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public Info()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void Info_Load(object sender, EventArgs e)
        {
            LoadAdminData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CiteStatus menuForm = new CiteStatus();
            menuForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Demander les informations de l'admin à créer
                string userName = Interaction.InputBox("Entrez le nom d'utilisateur du nouvel admin:", "Ajouter un nouvel admin", "");
                string password = Interaction.InputBox("Entrez le mot de passe du nouvel admin:", "Ajouter un nouvel admin", "");

                // Ajouter le nouvel admin à la table admin
                string addAdminQuery = "INSERT INTO admin (nom, password) VALUES (@userName, @password)";
                MySqlCommand addAdminCmd = new MySqlCommand(addAdminQuery, connection);
                addAdminCmd.Parameters.AddWithValue("@userName", userName);
                addAdminCmd.Parameters.AddWithValue("@password", password);

                addAdminCmd.ExecuteNonQuery();

                MessageBox.Show("Nouvel admin ajouté avec succès.");

                // Recharger les données après l'ajout d'un nouvel admin
                LoadAdminData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du nouvel admin : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion à la base de données dans le bloc finally
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Demander l'ID de l'admin à supprimer
            string adminIdToDelete = Interaction.InputBox("Entrez l'ID de l'admin à supprimer:", "Supprimer un admin", "");

            // Vérifier si l'ID existe dans la table admin
            string checkAdminIdQuery = "SELECT COUNT(*) FROM admin WHERE id = @adminId";
            MySqlCommand checkAdminIdCmd = new MySqlCommand(checkAdminIdQuery, connection);
            checkAdminIdCmd.Parameters.AddWithValue("@adminId", adminIdToDelete);

            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                int countAdminId = Convert.ToInt32(checkAdminIdCmd.ExecuteScalar());

                if (countAdminId > 0)
                {
                    // Admin trouvé, procéder à la suppression
                    string deleteAdminQuery = "DELETE FROM admin WHERE id = @adminId";
                    MySqlCommand deleteAdminCmd = new MySqlCommand(deleteAdminQuery, connection);
                    deleteAdminCmd.Parameters.AddWithValue("@adminId", adminIdToDelete);

                    deleteAdminCmd.ExecuteNonQuery();

                    MessageBox.Show("Admin supprimé avec succès de la base de données.");

                    // Recharger les données après la suppression
                    LoadAdminData();
                }
                else
                {
                    MessageBox.Show("Aucun admin trouvé avec l'ID spécifié.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression de l'admin : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion à la base de données dans le bloc finally
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void LoadAdminData()
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Sélectionner les données des admins depuis la table admin
                string query = "SELECT * FROM admin";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Utiliser un adaptateur de données pour remplir un DataSet
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Admin");

                // Afficher les données dans le DataGridView
                dataGridViewBuildings.DataSource = dataSet.Tables["Admin"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données des admins : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion à la base de données
                connection.Close();
            }
        }
    }
}

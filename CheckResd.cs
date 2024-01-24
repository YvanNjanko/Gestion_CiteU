using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FrontEnd_Gestion_CiteU
{
    public partial class CheckResd : Form
    {
        // Connexion à la base de données
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public CheckResd()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu1 MenuForm = new Menu1();
            MenuForm.Show();
            this.Hide();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            LoadResidentsData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Demander le matricule du résident à supprimer
            string matriculeToDelete = Interaction.InputBox("Veuillez entrer le matricule du résident à supprimer:", "Supprimer un résident", "");

            if (!string.IsNullOrEmpty(matriculeToDelete))
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Récupérer le code de la chambre associée au résident
                    string getChambreCodeQuery = "SELECT CodeChambre FROM Resident WHERE MatriculeEtudiant = @matricule";
                    MySqlCommand getChambreCodeCmd = new MySqlCommand(getChambreCodeQuery, connection);
                    getChambreCodeCmd.Parameters.AddWithValue("@matricule", matriculeToDelete);
                    string chambreCode = Convert.ToString(getChambreCodeCmd.ExecuteScalar());

                    // Supprimer le résident de la table Resident
                    string deleteResidentQuery = "DELETE FROM Resident WHERE MatriculeEtudiant = @matricule";
                    MySqlCommand deleteResidentCmd = new MySqlCommand(deleteResidentQuery, connection);
                    deleteResidentCmd.Parameters.AddWithValue("@matricule", matriculeToDelete);
                    deleteResidentCmd.ExecuteNonQuery();

                    MessageBox.Show("Résident supprimé avec succès.");

                    // Mettre à jour le nombre de lits de la chambre dans la table Chambre
                    string updateNombreLitsQuery = "UPDATE Chambre SET NombreLits = NombreLits + 1 WHERE Code = @chambreCode";
                    MySqlCommand updateNombreLitsCmd = new MySqlCommand(updateNombreLitsQuery, connection);
                    updateNombreLitsCmd.Parameters.AddWithValue("@chambreCode", chambreCode);
                    updateNombreLitsCmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression du résident : " + ex.Message);
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

        private void LoadResidentsData()
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Sélectionner les données des résidents depuis la table Resident
                string query = "SELECT MatriculeEtudiant, CodeChambre, NbreMoisLocation FROM Resident";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Utiliser un adaptateur de données pour remplir un DataSet
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Resident");

                // Afficher les données dans le DataGridView
                dataGridViewBuildings.DataSource = dataSet.Tables["Resident"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données des résidents : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion à la base de données
                connection.Close();
            }
        }

        private void CheckResd_Load(object sender, EventArgs e)
        {
            LoadResidentsData();
        }
    }
}

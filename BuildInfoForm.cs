using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace FrontEnd_Gestion_CiteU
{
    public partial class BuildInfoForm : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public BuildInfoForm()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void BuildInfoForm_Load(object sender, EventArgs e)
        {
            // Charger les données des bâtiments depuis la base de données et les afficher dans le DataGridView
            LoadBuildingData();
        }

        private void LoadBuildingData()
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Sélectionner les données des bâtiments depuis la table Batiment
                string query = "SELECT Code, NombreEtages, ChambresParEtage, PrixChambre, NombreMaxLitsParChambre FROM Batiment";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Utiliser un adaptateur de données pour remplir un DataSet
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Batiment");

                // Afficher les données dans le DataGridView
                dataGridViewBuildings.DataSource = dataSet.Tables["Batiment"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données des bâtiments : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion à la base de données
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu1 menu = new Menu1();
            menu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Redirection vers la page CreateBuilding.cs
            NewBuild createBuildingForm = new NewBuild();
            createBuildingForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Demander le code du bâtiment à supprimer
            string codeBatimentToDelete = Interaction.InputBox("Veuillez entrer le code du bâtiment à supprimer:", "Supprimer un bâtiment", "");

            if (!string.IsNullOrEmpty(codeBatimentToDelete))
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Supprimer les résidents associés aux chambres du bâtiment
                    string deleteResidentsQuery = "DELETE FROM Resident WHERE CodeChambre IN (SELECT Code FROM Chambre WHERE BatimentCode = @batimentCode)";
                    MySqlCommand deleteResidentsCmd = new MySqlCommand(deleteResidentsQuery, connection);
                    deleteResidentsCmd.Parameters.AddWithValue("@batimentCode", codeBatimentToDelete);
                    deleteResidentsCmd.ExecuteNonQuery();

                    // Supprimer les chambres associées au bâtiment
                    string deleteChambresQuery = "DELETE FROM Chambre WHERE BatimentCode = @batimentCode";
                    MySqlCommand deleteChambresCmd = new MySqlCommand(deleteChambresQuery, connection);
                    deleteChambresCmd.Parameters.AddWithValue("@batimentCode", codeBatimentToDelete);
                    deleteChambresCmd.ExecuteNonQuery();

                    // Supprimer le bâtiment lui-même
                    string deleteBatimentQuery = "DELETE FROM Batiment WHERE Code = @code";
                    MySqlCommand deleteBatimentCmd = new MySqlCommand(deleteBatimentQuery, connection);
                    deleteBatimentCmd.Parameters.AddWithValue("@code", codeBatimentToDelete);
                    deleteBatimentCmd.ExecuteNonQuery();

                    MessageBox.Show("Bâtiment, chambres et résidents associés supprimés avec succès.");

                    // Rafraîchir les données affichées dans le DataGridView
                    LoadBuildingData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression du bâtiment : " + ex.Message);
                }
                finally
                {
                    // Fermer la connexion à la base de données
                    connection.Close();
                }
            }
        }


    }
}

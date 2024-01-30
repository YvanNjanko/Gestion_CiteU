using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace FrontEnd_Gestion_CiteU
{
    public partial class CheckRoom : Form
    {
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public CheckRoom()
        {
            InitializeComponent();
        }

        private void CheckRoom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Récupérer le code du bâtiment à partir du TextBox
            string batimentCode = Interaction.InputBox("Entrez le code du bâtiment:", "Rechercher les chambres", "").Trim();

            // Vérifier si le code du bâtiment est renseigné
            if (!string.IsNullOrEmpty(batimentCode))
            {
                // Utiliser la chaîne de connexion pour établir une connexion à la base de données
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Utiliser une commande SQL pour récupérer les informations des chambres avec les résidents
                        string query = "SELECT C.*, R.MatriculeEtudiant, E.Nom, E.Sexe " +
                                       "FROM Chambre C " +
                                       "LEFT JOIN Resident R ON C.Code = R.CodeChambre " +
                                       "LEFT JOIN Etudiant E ON R.MatriculeEtudiant = E.Matricule " +
                                       "WHERE C.BatimentCode = @batimentCode";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@batimentCode", batimentCode);

                        // Utiliser un adaptateur pour remplir un DataSet avec les résultats de la requête
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Chambres");

                        // Liaison du DataGridView avec le DataSet
                        dataGridViewBuildings.DataSource = dataSet.Tables["Chambres"];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message);
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
            else
            {
                MessageBox.Show("Veuillez entrer le code du bâtiment.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu2 MenuForm = new Menu2();
            MenuForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Récupérer le code de la chambre à partir du TextBox
            string chambreCode = textBox1.Text.Trim();

            // Vérifier si le code de la chambre est renseigné
            if (!string.IsNullOrEmpty(chambreCode))
            {
                // Utiliser la chaîne de connexion pour établir une connexion à la base de données
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Utiliser une commande SQL pour récupérer les informations de la chambre et du résident associé
                        string query = "SELECT C.*, R.MatriculeEtudiant, E.Nom, E.Sexe " +
                                       "FROM Chambre C " +
                                       "LEFT JOIN Resident R ON C.Code = R.CodeChambre " +
                                       "LEFT JOIN Etudiant E ON R.MatriculeEtudiant = E.Matricule " +
                                       "WHERE C.Code = @chambreCode";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@chambreCode", chambreCode);

                        // Utiliser un adaptateur pour remplir un DataSet avec les résultats de la requête
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Chambres");

                        // Liaison du DataGridView avec le DataSet
                        dataGridViewBuildings.DataSource = dataSet.Tables["Chambres"];

                        // Vérifier si des données ont été trouvées
                        if (dataSet.Tables["Chambres"].Rows.Count == 0)
                        {
                            MessageBox.Show("Aucune chambre trouvée avec le code spécifié.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message);
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
            else
            {
                MessageBox.Show("Veuillez entrer le code de la chambre.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

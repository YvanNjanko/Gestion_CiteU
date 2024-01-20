using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd_Gestion_CiteU
{
    public partial class DisplayStud : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public DisplayStud()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);

        }

        private void DisplayStud_Load(object sender, EventArgs e)
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
                string query = "SELECT * FROM etudiant";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Utiliser un adaptateur de données pour remplir un DataSet
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Etudiant");

                // Afficher les données dans le DataGridView
                dataGridViewBuildings.DataSource = dataSet.Tables["Etudiant"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données des Etudiant : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion à la base de données
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu1 MenuForm = new Menu1();
            MenuForm.Show();
            this.Hide();
        }
    }
}

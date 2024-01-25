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
    public partial class ViewPay : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public ViewPay()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu2 MenuForm = new Menu2();
            MenuForm.Show();
            this.Hide();
        }

        private void ViewPay_Load(object sender, EventArgs e)
        {
            LoadPaymentData();
            ShowCiteInformation();
        }

        private void LoadPaymentData()
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Sélectionner les données de la table paiment où statu est égale à true
                string query = "SELECT * FROM paiment WHERE statu = true";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Utiliser un adaptateur de données pour remplir un DataSet
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Paiment");

                // Afficher les données dans le DataGridView
                dataGridViewBuildings.DataSource = dataSet.Tables["Paiment"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données de paiement : " + ex.Message);
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

        private void labelTotalGains2_Click(object sender, EventArgs e)
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Compter le nombre de lignes de la table paiment où statu est égale à true
                string countQuery = "SELECT COUNT(*) FROM paiment WHERE statu = true";
                MySqlCommand countCmd = new MySqlCommand(countQuery, connection);

                // Obtenir le nombre de lignes
                int rowCount = Convert.ToInt32(countCmd.ExecuteScalar());

                // Afficher le nombre de lignes dans le label
                labelTotalGains2.Text = "Nombre de paiements validés : " + rowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du calcul du nombre de paiements validés : " + ex.Message);
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ShowCiteInformation()
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // 1. Le nombre total de paiement valides
                string countQuery = "SELECT COUNT(*) FROM paiment WHERE statu = true";
                MySqlCommand countBuildingsCmd = new MySqlCommand(countQuery, connection);
                int totalBuildings = Convert.ToInt32(countBuildingsCmd.ExecuteScalar());
                labelTotalGains2.Text = "Nombre de paiements validés : " + totalBuildings;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des informations de paiement : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion à la base de données
                connection.Close();
            }
        }
    }
}

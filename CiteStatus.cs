﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FrontEnd_Gestion_CiteU
{
    public partial class CiteStatus : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public CiteStatus()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void CiteStatus_Load(object sender, EventArgs e)
        {
            // Afficher les informations demandées
            ShowCiteInformation();
        }

        private void ShowCiteInformation()
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // 1. Le nombre total de bâtiments créés
                string countBuildingsQuery = "SELECT COUNT(*) FROM Batiment";
                MySqlCommand countBuildingsCmd = new MySqlCommand(countBuildingsQuery, connection);
                int totalBuildings = Convert.ToInt32(countBuildingsCmd.ExecuteScalar());
                labelTotalBuildings.Text = "Nombre total de bâtiments créés : " + totalBuildings;

                // 2. Le nombre total de chambres dans la base de données
                string countTotalRoomsQuery = "SELECT COUNT(*) FROM Chambre";
                MySqlCommand countTotalRoomsCmd = new MySqlCommand(countTotalRoomsQuery, connection);
                int totalRooms = Convert.ToInt32(countTotalRoomsCmd.ExecuteScalar());
                labelTotalRooms.Text = "Nombre total de chambres : " + totalRooms;

                // 3. Le nombre de chambres occupées
                string countOccupiedRoomsQuery = "SELECT COUNT(DISTINCT CodeChambre) FROM Resident";
                MySqlCommand countOccupiedRoomsCmd = new MySqlCommand(countOccupiedRoomsQuery, connection);
                int occupiedRooms = Convert.ToInt32(countOccupiedRoomsCmd.ExecuteScalar());
                labelOccupiedRooms.Text = "Nombre de chambres occupées : " + occupiedRooms;

                // 4. Le chiffre d'affaires de la cité
                string totalRevenueQuery = "SELECT SUM(PrixChambre * ChambresParEtage * (NombreEtages+1) ) FROM Batiment";
                MySqlCommand totalRevenueCmd = new MySqlCommand(totalRevenueQuery, connection);
                decimal totalRevenue = Convert.ToDecimal(totalRevenueCmd.ExecuteScalar());
                labelTotalRevenue.Text = "Chiffre d'affaires de la cité : " + totalRevenue + " FCFA";


                // 5. Les gains (somme des prix des chambres occupées multiplié par le nombre de mois)
                // Calculer la somme des produits NbreMoisLocation * PrixChambre pour les enregistrements où statu = true
                string getTotalGainsQuery = "SELECT SUM(NbreMoisLocation * PrixChambre) FROM paiment WHERE statu = true";
                MySqlCommand getTotalGainsCmd = new MySqlCommand(getTotalGainsQuery, connection);

                // Exécuter la commande et récupérer le résultat
                object totalGainsObject = getTotalGainsCmd.ExecuteScalar();

                if (totalGainsObject != null && totalGainsObject != DBNull.Value)
                {
                    // Afficher le résultat dans le label
                    labelTotalGains2.Text = "Gains cumulés : " + totalGainsObject.ToString() + " FCFA";
                }
                else
                {
                    // Si la somme est nulle, afficher un message approprié
                    labelTotalGains2.Text = "Aucun gain cumulé pour le moment.";
                }

                // 6. Le nombre total de Residents dans la base de données
                string countTotalRQuery = "SELECT COUNT(*) FROM resident";
                MySqlCommand countTotalRCmd = new MySqlCommand(countTotalRQuery, connection);
                int totalR = Convert.ToInt32(countTotalRCmd.ExecuteScalar());
                labelTotalR.Text = "Nombre total de Resident : " + totalR;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des informations de la cité : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion à la base de données
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu2 menuForm = new Menu2();
            menuForm.Show();
            this.Hide();
        }

        private void labelTotalGains2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Info menuForm = new Info();
            menuForm.Show();
            this.Hide();
        }

        private void labelTotalBuildings_Click(object sender, EventArgs e)
        {

        }
    }
}

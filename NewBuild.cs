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
    public partial class NewBuild : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public NewBuild()
        {
            InitializeComponent();

            // Initialisez la connexion dans le constructeur
            connection = new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu1 MenuForm = new Menu1();
            MenuForm.Show();
            this.Hide();
        }

        private void enterCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterEtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterPrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterBed_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateBuildingBtn_Click(object sender, EventArgs e)
        {
            // Récupérer les données du formulaire
            char code;
            if (!char.TryParse(enterCode.Text, out code))
            {
                MessageBox.Show("Veuillez entrer un code valide.");
                return;
            }

            string etageStr = enterEtage.Text;
            string roomStr = enterRoom.Text;
            string prixStr = enterPrix.Text;
            string bedStr = enterBed.Text;

            // Vérifier si tous les champs sont remplis
            if (string.IsNullOrEmpty(etageStr) || string.IsNullOrEmpty(roomStr) || string.IsNullOrEmpty(prixStr) || string.IsNullOrEmpty(bedStr))
            {
                MessageBox.Show("Veuillez remplir tous les champs du formulaire.");
                return; // Arrêter le traitement si un champ n'est pas rempli
            }

            try
            {
                // Convertir les valeurs numériques
                if (!int.TryParse(etageStr, out int nombreEtages) ||
                    !int.TryParse(roomStr, out int chambresParEtage) ||
                    !decimal.TryParse(prixStr, out decimal prixChambre) ||
                    !int.TryParse(bedStr, out int nombreMaxLitsParChambre))
                {
                    MessageBox.Show("Veuillez entrer des valeurs numériques valides.");
                    return; // Arrêter le traitement si une valeur n'est pas valide
                }

                // Ouvrir la connexion à la base de données
                connection.Open();

                // Insérer un nouveau bâtiment dans la table Batiment
                string batimentQuery = "INSERT INTO Batiment (Code, NombreEtages, ChambresParEtage, PrixChambre, NombreMaxLitsParChambre) VALUES (@code, @nombreEtages, @chambresParEtage, @prixChambre, @nombreMaxLitsParChambre)";
                MySqlCommand batimentCmd = new MySqlCommand(batimentQuery, connection);
                batimentCmd.Parameters.AddWithValue("@code", code);
                batimentCmd.Parameters.AddWithValue("@nombreEtages", nombreEtages);
                batimentCmd.Parameters.AddWithValue("@chambresParEtage", chambresParEtage);
                batimentCmd.Parameters.AddWithValue("@prixChambre", prixChambre);
                batimentCmd.Parameters.AddWithValue("@nombreMaxLitsParChambre", nombreMaxLitsParChambre);

                batimentCmd.ExecuteNonQuery();

                MessageBox.Show("Bâtiment ajouté avec succès dans la base de données.");

                // Créer les chambres pour chaque niveau du bâtiment
                for (int etage = 0; etage <= nombreEtages; etage++)
                {
                    for (int chambreNumero = 1; chambreNumero <= chambresParEtage; chambreNumero++)
                    {
                        string chambreCode = etage.ToString() + code + chambreNumero.ToString();
                        int nombreLits = nombreMaxLitsParChambre;
                        int nombreLitsOccupes = 0;

                        // Insérer la chambre dans la table Chambre
                        string chambreQuery = "INSERT INTO Chambre (Code, NombreLits, NombreLitsOccupes, BatimentCode, NumeroEtage) VALUES (@code, @nombreLits, @nombreLitsOccupes, @batimentCode, @numeroEtage)";
                        MySqlCommand chambreCmd = new MySqlCommand(chambreQuery, connection);
                        chambreCmd.Parameters.AddWithValue("@code", chambreCode);
                        chambreCmd.Parameters.AddWithValue("@nombreLits", nombreLits);
                        chambreCmd.Parameters.AddWithValue("@nombreLitsOccupes", nombreLitsOccupes);
                        chambreCmd.Parameters.AddWithValue("@batimentCode", code.ToString());
                        chambreCmd.Parameters.AddWithValue("@numeroEtage", etage);

                        chambreCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Chambres ajoutées avec succès dans la base de données.");

                // Réinitialiser les valeurs des champs du formulaire
                enterCode.Text = string.Empty;
                enterEtage.Text = string.Empty;
                enterRoom.Text = string.Empty;
                enterPrix.Text = string.Empty;
                enterBed.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du bâtiment : " + ex.Message);
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

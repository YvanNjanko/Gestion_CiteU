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
        // Assurez-vous d'avoir une connexion à la base de données définie à l'échelle de la classe
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
            char code = Convert.ToChar(enterCode.Text);
            int nombreEtages = Convert.ToInt32(enterEtage.Text);
            int chambresParEtage = Convert.ToInt32(enterRoom.Text);
            decimal prixChambre = Convert.ToDecimal(enterPrix.Text);
            int nombreMaxLitsParChambre = Convert.ToInt32(enterBed.Text);

            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Insérer un nouveau bâtiment dans la table Batiment
                string query = "INSERT INTO Batiment (Code, NombreEtages, ChambresParEtage, PrixChambre, NombreMaxLitsParChambre) VALUES (@code, @nombreEtages, @chambresParEtage, @prixChambre, @nombreMaxLitsParChambre)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@nombreEtages", nombreEtages);
                cmd.Parameters.AddWithValue("@chambresParEtage", chambresParEtage);
                cmd.Parameters.AddWithValue("@prixChambre", prixChambre);
                cmd.Parameters.AddWithValue("@nombreMaxLitsParChambre", nombreMaxLitsParChambre);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Bâtiment ajouté avec succès dans la base de données.");

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
                connection.Close();
            }
        }

    }
}

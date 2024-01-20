using Microsoft.VisualBasic;
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
    public partial class AddBed : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public AddBed()
        {
            InitializeComponent();
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

        private void createRoomBtn_Click(object sender, EventArgs e)
        {
            // Récupérer le code de la chambre entré
            string codeChambre = enterCode.Text;

            if (!string.IsNullOrEmpty(codeChambre))
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Vérifier si la chambre existe dans la base de données
                    string checkChambreQuery = "SELECT COUNT(*) FROM Chambre WHERE Code = @codeChambre";
                    MySqlCommand checkChambreCmd = new MySqlCommand(checkChambreQuery, connection);
                    checkChambreCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

                    int countChambre = Convert.ToInt32(checkChambreCmd.ExecuteScalar());

                    if (countChambre > 0)
                    {
                        // La chambre existe, obtenir le nombre de lits occupés et le nombre maximum de lits par chambre du bâtiment associé
                        string getChambreInfoQuery = "SELECT NombreLits, BatimentCode FROM Chambre WHERE Code = @codeChambre";
                        MySqlCommand getChambreInfoCmd = new MySqlCommand(getChambreInfoQuery, connection);
                        getChambreInfoCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

                        string getBatChambreInfoQuery = "SELECT BatimentCode FROM Chambre WHERE Code = @codeChambre";
                        MySqlCommand getBatChambreInfoCmd = new MySqlCommand(getBatChambreInfoQuery, connection);
                        getBatChambreInfoCmd.Parameters.AddWithValue("@codeChambre", codeChambre);


                        int nombreLits = Convert.ToInt32(getChambreInfoCmd.ExecuteScalar());
                        string batimentCode = Convert.ToString(getBatChambreInfoCmd.ExecuteScalar());

                        // Récupérer le nombre maximum de lits par chambre du bâtiment
                        string getMaxLitsQuery = "SELECT NombreMaxLitsParChambre FROM Batiment WHERE Code = @batimentCode";
                        MySqlCommand getMaxLitsCmd = new MySqlCommand(getMaxLitsQuery, connection);
                        getMaxLitsCmd.Parameters.AddWithValue("@batimentCode", batimentCode);

                        int nombreMaxLits = Convert.ToInt32(getMaxLitsCmd.ExecuteScalar());

                        // Vérifier si le nombre de lits est inférieur au nombre maximum de lits
                        if (nombreLits < nombreMaxLits)
                        {
                            // Ajouter un lit à la chambre
                            string addBedQuery = "UPDATE Chambre SET NombreLits = NombreLits + 1 WHERE Code = @codeChambre";
                            MySqlCommand addBedCmd = new MySqlCommand(addBedQuery, connection);
                            addBedCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

                            addBedCmd.ExecuteNonQuery();

                            MessageBox.Show("Lit ajouté à la chambre avec succès.");
                        }
                        else
                        {
                            MessageBox.Show("La chambre a atteint le nombre maximum de lits.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucune chambre trouvée avec le code spécifié.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout de lit à la chambre : " + ex.Message);
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Récupérer le code de la chambre
            string codeChambre = Interaction.InputBox("Veuillez entrer le code de la chambre:", "Supprimer un lit", "");

            if (!string.IsNullOrEmpty(codeChambre))
            {
                try
                {
                    // Ouvrir la connexion à la base de données
                    connection.Open();

                    // Vérifier si la chambre existe dans la base de données
                    string checkChambreQuery = "SELECT COUNT(*) FROM Chambre WHERE Code = @codeChambre";
                    MySqlCommand checkChambreCmd = new MySqlCommand(checkChambreQuery, connection);
                    checkChambreCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

                    int countChambre = Convert.ToInt32(checkChambreCmd.ExecuteScalar());

                    if (countChambre > 0)
                    {
                        // La chambre existe, vérifier si elle a au moins un lit
                        string getNombreLitsQuery = "SELECT NombreLits FROM Chambre WHERE Code = @codeChambre";
                        MySqlCommand getNombreLitsCmd = new MySqlCommand(getNombreLitsQuery, connection);
                        getNombreLitsCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

                        int nombreLits = Convert.ToInt32(getNombreLitsCmd.ExecuteScalar());

                        if (nombreLits > 0)
                        {
                            // Supprimer un lit de la chambre
                            string removeBedQuery = "UPDATE Chambre SET NombreLits = NombreLits - 1 WHERE Code = @codeChambre";
                            MySqlCommand removeBedCmd = new MySqlCommand(removeBedQuery, connection);
                            removeBedCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

                            removeBedCmd.ExecuteNonQuery();

                            MessageBox.Show("Lit supprimé de la chambre avec succès.");
                        }
                        else
                        {
                            MessageBox.Show("La chambre n'a aucun lit à supprimer.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucune chambre trouvée avec le code spécifié.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression du lit de la chambre : " + ex.Message);
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

    }
}

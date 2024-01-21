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
    public partial class CreateRoom : Form
    {
        private MySqlConnection connection; // Déclarez la variable de connexion

        public CreateRoom()
        {
            InitializeComponent();
            InitializeConnection(); // Initialisez la connexion dans le constructeur
        }

        // Méthode pour initialiser la connexion
        private void InitializeConnection()
        {
            try
            {
                string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";
                connection = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'initialisation de la connexion : " + ex.Message);
            }
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

        private void createRoomBtn_Click(object sender, EventArgs e)
        {
            // Récupérer les informations du formulaire
            string codeBatiment = enterCode.Text;
            string etageStr = enterEtage.Text;

            // Vérifier si tous les champs sont remplis
            if (string.IsNullOrEmpty(codeBatiment) || string.IsNullOrEmpty(etageStr))
            {
                MessageBox.Show("Veuillez remplir tous les champs du formulaire.");
                return; // Arrêter le traitement si un champ n'est pas rempli
            }

            try
            {
                // Convertir la valeur numérique de l'étage
                if (!int.TryParse(etageStr, out int numeroEtage))
                {
                    MessageBox.Show("Veuillez entrer une valeur numérique valide pour l'étage.");
                    return; // Arrêter le traitement si la valeur n'est pas valide
                }

                // Ouvrir la connexion à la base de données
                connection.Open();

                // Vérifier si le bâtiment existe
                string checkBatimentQuery = "SELECT COUNT(*) FROM Batiment WHERE Code = @codeBatiment";
                MySqlCommand checkBatimentCmd = new MySqlCommand(checkBatimentQuery, connection);
                checkBatimentCmd.Parameters.AddWithValue("@codeBatiment", codeBatiment);

                int countBatiment = Convert.ToInt32(checkBatimentCmd.ExecuteScalar());

                if (countBatiment > 0)
                {
                    // Récupérer le nombre d'étages du bâtiment
                    string getNombreEtagesQuery = "SELECT NombreEtages FROM Batiment WHERE Code = @codeBatiment";
                    MySqlCommand getNombreEtagesCmd = new MySqlCommand(getNombreEtagesQuery, connection);
                    getNombreEtagesCmd.Parameters.AddWithValue("@codeBatiment", codeBatiment);

                    int nombreEtagesBatiment = Convert.ToInt32(getNombreEtagesCmd.ExecuteScalar());

                    if (numeroEtage <= nombreEtagesBatiment)
                    {
                        // Compter le nombre de chambres pour cet étage
                        string countChambresQuery = "SELECT COUNT(*) FROM Chambre WHERE NumeroEtage = @numeroEtage AND BatimentCode = @batimentCode";
                        MySqlCommand countChambresCmd = new MySqlCommand(countChambresQuery, connection);
                        countChambresCmd.Parameters.AddWithValue("@numeroEtage", numeroEtage);
                        countChambresCmd.Parameters.AddWithValue("@batimentCode", codeBatiment);

                        int nombreChambres = Convert.ToInt32(countChambresCmd.ExecuteScalar());

                        // Récupérer le nombre de chambres par étage du bâtiment
                        string getChambresParEtageQuery = "SELECT ChambresParEtage FROM Batiment WHERE Code = @codeBatiment";
                        MySqlCommand getChambresParEtageCmd = new MySqlCommand(getChambresParEtageQuery, connection);
                        getChambresParEtageCmd.Parameters.AddWithValue("@codeBatiment", codeBatiment);

                        // Récupérer le nombre de lits par chambre
                        string getLitQuery = "SELECT NombreMaxLitsParChambre FROM Batiment WHERE Code = @codeBatiment";
                        MySqlCommand getLitCmd = new MySqlCommand(getLitQuery, connection);
                        getLitCmd.Parameters.AddWithValue("@codeBatiment", codeBatiment);

                        int chambresParEtage = Convert.ToInt32(getChambresParEtageCmd.ExecuteScalar());
                        int nbreLits = Convert.ToInt32(getLitCmd.ExecuteScalar());
                        int NombreLitsOccupes = 0;

                        if (nombreChambres < chambresParEtage)
                        {
                            int tentative = 1;
                            string codeChambre = $"{numeroEtage}{codeBatiment}{tentative}";

                            // Vérifier si le code de la chambre existe déjà
                            while (ChambreExists(codeChambre))
                            {
                                tentative++;
                                codeChambre = $"{numeroEtage}{codeBatiment}{nombreChambres + tentative}";
                            }

                            // Ajouter une nouvelle chambre
                            string insertChambreQuery = "INSERT INTO Chambre (Code, NumeroEtage, BatimentCode, NombreLitsOccupes, NombreLits) VALUES (@codeChambre, @numeroEtage, @batimentCode, @NombreLitsOccupes,@NombreLits)";
                            MySqlCommand insertChambreCmd = new MySqlCommand(insertChambreQuery, connection);
                            insertChambreCmd.Parameters.AddWithValue("@codeChambre", codeChambre);
                            insertChambreCmd.Parameters.AddWithValue("@numeroEtage", numeroEtage);
                            insertChambreCmd.Parameters.AddWithValue("@batimentCode", codeBatiment);
                            insertChambreCmd.Parameters.AddWithValue("@NombreLitsOccupes", NombreLitsOccupes);
                            insertChambreCmd.Parameters.AddWithValue("@NombreLits", nbreLits);

                            insertChambreCmd.ExecuteNonQuery();

                            MessageBox.Show("Chambre ajoutée avec succès.");
                        }
                        else
                        {
                            MessageBox.Show("Le nombre maximum de chambres à cet étage a été atteint.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("L'étage dépasse le nombre d'étages du bâtiment.");
                    }
                }
                else
                {
                    MessageBox.Show("Le bâtiment n'existe pas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la chambre : " + ex.Message);
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


        private bool ChambreExists(string codeChambre)
        {
            // Vérifier si le code de la chambre existe déjà dans la base de données
            string checkChambreQuery = "SELECT COUNT(*) FROM Chambre WHERE Code = @codeChambre";
            MySqlCommand checkChambreCmd = new MySqlCommand(checkChambreQuery, connection);
            checkChambreCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

            int countChambre = Convert.ToInt32(checkChambreCmd.ExecuteScalar());

            return countChambre > 0;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Demander le code de la chambre à supprimer
                string codeChambreToDelete = Interaction.InputBox("Veuillez entrer le code de la chambre à supprimer:", "Supprimer une chambre", "");

                if (!string.IsNullOrEmpty(codeChambreToDelete))
                {
                    // Vérifier si la chambre avec le code spécifié existe
                    string checkChambreQuery = "SELECT COUNT(*) FROM Chambre WHERE Code = @codeChambre";
                    MySqlCommand checkChambreCmd = new MySqlCommand(checkChambreQuery, connection);
                    checkChambreCmd.Parameters.AddWithValue("@codeChambre", codeChambreToDelete);

                    int countChambre = Convert.ToInt32(checkChambreCmd.ExecuteScalar());

                    if (countChambre > 0)
                    {

                        // Supprimer la chambre
                        string deleteChambreQuery = "DELETE FROM Chambre WHERE Code = @codeChambre";
                        MySqlCommand deleteChambreCmd = new MySqlCommand(deleteChambreQuery, connection);
                        deleteChambreCmd.Parameters.AddWithValue("@codeChambre", codeChambreToDelete);
                        deleteChambreCmd.ExecuteNonQuery();

                        // Supprimer les residents
                        string deleteResidentQuery = "DELETE FROM resident WHERE CodeChambre = @codeChambre";
                        MySqlCommand deleteResidentCmd = new MySqlCommand(deleteResidentQuery, connection);
                        deleteResidentCmd.Parameters.AddWithValue("@codeChambre", codeChambreToDelete);
                        deleteResidentCmd.ExecuteNonQuery();

                        MessageBox.Show("Chambre supprimée avec succès.");
                    }
                    else
                    {
                        MessageBox.Show("Aucune chambre trouvée avec le code spécifié.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression de la chambre : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion à la base de données
                connection.Close();
            }
        }

    }
}

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
    public partial class ManagePay : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public ManagePay()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void ManagePay_Load(object sender, EventArgs e)
        {
            // Charger les données de la table paiment depuis la base de données et les afficher dans le DataGridView
            LoadPaymentData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu2 MenuForm = new Menu2();
            MenuForm.Show();
            this.Hide();
        }

        private void LoadPaymentData()
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Sélectionner les données de la table paiment
                string query = "SELECT * FROM paiment";
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
                MessageBox.Show("Erreur lors du chargement des données de paiment : " + ex.Message);
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

        private void button4_Click(object sender, EventArgs e)
        {
            // Charger les données de la table paiment depuis la base de données et les afficher dans le DataGridView
            LoadPaymentData();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Demander le matricule de l'étudiant
                string matriculeToValidate = Interaction.InputBox("Entrez le matricule de l'étudiant à valider le paiement:", "Valider le paiement", "");

                // Vérifier si le matricule existe dans la table paiment
                string checkMatriculeQuery = "SELECT COUNT(*) FROM paiment WHERE MatriculeEtudiant = @matricule";
                MySqlCommand checkMatriculeCmd = new MySqlCommand(checkMatriculeQuery, connection);
                checkMatriculeCmd.Parameters.AddWithValue("@matricule", matriculeToValidate);

                int countMatricule = Convert.ToInt32(checkMatriculeCmd.ExecuteScalar());

                if (countMatricule > 0)
                {
                    // Matricule trouvé, demander confirmation pour valider le paiement
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment valider le paiement pour cet étudiant ?", "Valider le paiement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Mettre à jour la valeur de statu à true dans la table paiment
                        string updateStatuQuery = "UPDATE paiment SET statu = true WHERE MatriculeEtudiant = @matricule";
                        MySqlCommand updateStatuCmd = new MySqlCommand(updateStatuQuery, connection);
                        updateStatuCmd.Parameters.AddWithValue("@matricule", matriculeToValidate);

                        updateStatuCmd.ExecuteNonQuery();

                        MessageBox.Show("Paiement validé avec succès.");
                    }
                }
                else
                {
                    MessageBox.Show("Aucun paiement trouvé avec le matricule spécifié.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la validation du paiement : " + ex.Message);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Demander le matricule de l'étudiant
                string matriculeToCancel = Interaction.InputBox("Entrez le matricule de l'étudiant dont vous voulez annuler le paiement:", "Annuler le paiement", "");

                // Vérifier si le matricule existe dans la table paiment
                string checkMatriculeQuery = "SELECT COUNT(*) FROM paiment WHERE MatriculeEtudiant = @matricule";
                MySqlCommand checkMatriculeCmd = new MySqlCommand(checkMatriculeQuery, connection);
                checkMatriculeCmd.Parameters.AddWithValue("@matricule", matriculeToCancel);

                int countMatricule = Convert.ToInt32(checkMatriculeCmd.ExecuteScalar());

                if (countMatricule > 0)
                {
                    // Matricule trouvé, demander confirmation pour annuler le paiement
                    DialogResult result = MessageBox.Show("Voulez-vous vraiment annuler le paiement pour cet étudiant ?", "Annuler le paiement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Mettre à jour la valeur de statu à false dans la table paiment
                        string cancelPaymentQuery = "UPDATE paiment SET statu = false WHERE MatriculeEtudiant = @matricule";
                        MySqlCommand cancelPaymentCmd = new MySqlCommand(cancelPaymentQuery, connection);
                        cancelPaymentCmd.Parameters.AddWithValue("@matricule", matriculeToCancel);

                        cancelPaymentCmd.ExecuteNonQuery();

                        MessageBox.Show("Paiement annulé avec succès.");
                    }
                }
                else
                {
                    MessageBox.Show("Aucun paiement trouvé avec le matricule spécifié.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'annulation du paiement : " + ex.Message);
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

        private void button1_Click(object sender, EventArgs e)
        {
            ViewPay MenuForm = new ViewPay();
            MenuForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
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

                    // Supprimer le résident de la table Paiment
                    string deletePayQuery = "DELETE FROM paiment WHERE MatriculeEtudiant = @matricule";
                    MySqlCommand deletePayCmd = new MySqlCommand(deletePayQuery, connection);
                    deletePayCmd.Parameters.AddWithValue("@matricule", matriculeToDelete);
                    deletePayCmd.ExecuteNonQuery();

                    MessageBox.Show("Résident supprimé avec succès.");

                    // Mettre à jour le nombre de lits de la chambre dans la table Chambre
                    string updateNombreLitsQuery = "UPDATE Chambre SET NombreLitsOccupes = NombreLitsOccupes - 1 WHERE Code = @chambreCode";
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Demander le matricule de l'étudiant à rechercher dans la table paiment
                string matriculeToSearch = Interaction.InputBox("Entrez le matricule de l'étudiant à rechercher dans les paiements:", "Rechercher un paiement", "");

                // Vérifier si le matricule existe dans la table paiment
                string checkMatriculeQuery = "SELECT COUNT(*) FROM paiment WHERE MatriculeEtudiant = @matricule";
                MySqlCommand checkMatriculeCmd = new MySqlCommand(checkMatriculeQuery, connection);
                checkMatriculeCmd.Parameters.AddWithValue("@matricule", matriculeToSearch);

                int countMatricule = Convert.ToInt32(checkMatriculeCmd.ExecuteScalar());

                if (countMatricule > 0)
                {
                    // Matricule trouvé, récupérer toutes les informations de l'étudiant dans la table paiment
                    string getPaymentInfoQuery = "SELECT * FROM paiment WHERE MatriculeEtudiant = @matricule";
                    MySqlCommand getPaymentInfoCmd = new MySqlCommand(getPaymentInfoQuery, connection);
                    getPaymentInfoCmd.Parameters.AddWithValue("@matricule", matriculeToSearch);

                    // Utiliser un adaptateur de données pour remplir un DataSet
                    MySqlDataAdapter adapter = new MySqlDataAdapter(getPaymentInfoCmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Paiment");

                    // Afficher les données dans le DataGridView
                    dataGridViewBuildings.DataSource = dataSet.Tables["Paiment"];
                }
                else
                {
                    MessageBox.Show("Aucun paiement trouvé avec le matricule spécifié.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche du paiement : " + ex.Message);
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

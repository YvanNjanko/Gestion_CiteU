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
            LoadStudentData();

        }


        private void LoadStudentData()
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Demander le matricule de l'étudiant à supprimer
                string matriculeToDelete = Interaction.InputBox("Entrez le matricule de l'étudiant à supprimer:", "Supprimer un étudiant", "");

                // Vérifier si le matricule existe dans la base de données
                string checkMatriculeQuery = "SELECT COUNT(*) FROM etudiant WHERE Matricule = @matricule";
                MySqlCommand checkMatriculeCmd = new MySqlCommand(checkMatriculeQuery, connection);
                checkMatriculeCmd.Parameters.AddWithValue("@matricule", matriculeToDelete);

                int countMatricule = Convert.ToInt32(checkMatriculeCmd.ExecuteScalar());

                if (countMatricule > 0)
                {
                    // Matricule trouvé, procéder à la suppression
                    string deleteStudentQuery = "DELETE FROM etudiant WHERE Matricule = @matricule";
                    MySqlCommand deleteStudentCmd = new MySqlCommand(deleteStudentQuery, connection);
                    deleteStudentCmd.Parameters.AddWithValue("@matricule", matriculeToDelete);

                    deleteStudentCmd.ExecuteNonQuery();

                    MessageBox.Show("Étudiant supprimé avec succès de la base de données.");

                }
                else
                {
                    MessageBox.Show("Aucun étudiant trouvé avec le matricule spécifié.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression de l'étudiant : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion à la base de données dans le bloc finally
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }



        private bool GetStudentHandicapStatus(string matricule)
        {
            // Vérifier si l'étudiant est handicapé
            string checkHandicapQuery = "SELECT Handicap FROM etudiant WHERE Matricule = @matricule";
            MySqlCommand checkHandicapCmd = new MySqlCommand(checkHandicapQuery, connection);
            checkHandicapCmd.Parameters.AddWithValue("@matricule", matricule);

            return Convert.ToBoolean(checkHandicapCmd.ExecuteScalar());
        }

        private int GetChambreNumeroEtage(string codeChambre)
        {
            // Récupérer le numéro de l'étage de la chambre
            string getEtageQuery = "SELECT NumeroEtage FROM Chambre WHERE Code = @codeChambre";
            MySqlCommand getEtageCmd = new MySqlCommand(getEtageQuery, connection);
            getEtageCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

            return Convert.ToInt32(getEtageCmd.ExecuteScalar());
        }


        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Demander le matricule de l'étudiant
                string matricule = Interaction.InputBox("Entrez le matricule de l'étudiant:", "Ajouter un étudiant", "");

                // Vérifier si le matricule existe dans la base de données
                string checkMatriculeQuery = "SELECT COUNT(*) FROM etudiant WHERE Matricule = @matricule";
                MySqlCommand checkMatriculeCmd = new MySqlCommand(checkMatriculeQuery, connection);
                checkMatriculeCmd.Parameters.AddWithValue("@matricule", matricule);

                int countMatricule = Convert.ToInt32(checkMatriculeCmd.ExecuteScalar());

                if (countMatricule > 0)
                {
                    // Matricule trouvé, demander le code de la chambre
                    string codeChambre = Interaction.InputBox("Entrez le code de la chambre:", "Ajouter un étudiant", "");

                    // Vérifier si la chambre existe dans la base de données
                    string checkChambreQuery = "SELECT COUNT(*) FROM Chambre WHERE Code = @codeChambre";
                    MySqlCommand checkChambreCmd = new MySqlCommand(checkChambreQuery, connection);
                    checkChambreCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

                    int countChambre = Convert.ToInt32(checkChambreCmd.ExecuteScalar());

                    if (countChambre > 0)
                    {
                        // Chambre trouvée, demander le nombre de mois de location
                        int nombreMoisLocation;
                        if (int.TryParse(Interaction.InputBox("Entrez le nombre de mois de location:", "Ajouter un étudiant", ""), out nombreMoisLocation))
                        {
                            // Vérifier le nombre de lits occupés de la chambre
                            string checkLitsOccupesQuery = "SELECT NombreLitsOccupes FROM Chambre WHERE Code = @codeChambre";
                            MySqlCommand checkLitsOccupesCmd = new MySqlCommand(checkLitsOccupesQuery, connection);
                            checkLitsOccupesCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

                            int nombreLitsOccupes = Convert.ToInt32(checkLitsOccupesCmd.ExecuteScalar());

                            string checkLitsQuery = "SELECT NombreLits FROM Chambre WHERE Code = @codeChambre";
                            MySqlCommand checkLitsCmd = new MySqlCommand(checkLitsQuery, connection);
                            checkLitsCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

                            int nombreLits = Convert.ToInt32(checkLitsCmd.ExecuteScalar());

                            if (nombreLitsOccupes < nombreLits)
                            {

                                // Vérifier si la chambre est vide (pas encore d'occupant)
                                if (nombreLitsOccupes == 0)
                                {
                                    // Vérifier si l'étudiant est handicapé
                                    bool handicap = GetStudentHandicapStatus(matricule);

                                    // Si l'étudiant est handicapé, vérifier l'étage de la chambre
                                    if (handicap)
                                    {
                                        int numeroEtage = GetChambreNumeroEtage(codeChambre);

                                        // Vérifier si la chambre est au rez-de-chaussée (étage 0)
                                        if (numeroEtage == 0)
                                        {
                                            // Chambre vide, ajouter le résident à la table Resident
                                            AddResidentToChambre(matricule, codeChambre, nombreMoisLocation);

                                            MessageBox.Show("Étudiant ajouté en tant que résident avec succès.");

                                            // Mettre à jour le nombre de lits occupés dans la table Chambre
                                            UpdateLitsOccupes(codeChambre);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Un étudiant handicapé ne peut être affecté qu'à une chambre du rez-de-chaussée.");
                                        }
                                    }
                                    else
                                    {
                                        // Chambre vide, ajouter le résident à la table Resident
                                        AddResidentToChambre(matricule, codeChambre, nombreMoisLocation);

                                        MessageBox.Show("Étudiant ajouté en tant que résident avec succès.");

                                        // Mettre à jour le nombre de lits occupés dans la table Chambre
                                        UpdateLitsOccupes(codeChambre);
                                    }
                                }
                                else
                                {
                                    // Récupérer les informations de l'étudiant actuel dans la chambre
                                    string existingResidentMatricule = GetResidentMatricule(codeChambre);
                                    string existingResidentSexe = GetResidentSexe(existingResidentMatricule);
                                    int existingResidentAge = GetResidentAge(existingResidentMatricule);
                                    int existingResidentNiveauAcademique = GetResidentNiveauAcademique(existingResidentMatricule);

                                    // Récupérer les informations du nouvel étudiant
                                    string newStudentSexe = GetStudentSexe(matricule);
                                    int newStudentAge = GetStudentAge(matricule);
                                    int newStudentNiveauAcademique = GetStudentNiveauAcademique(matricule);

                                    // Vérifier les critères de compatibilité
                                    if (existingResidentSexe != newStudentSexe)
                                    {
                                        MessageBox.Show("Deux étudiants de sexes différents ne peuvent pas être dans la même chambre.");
                                    }
                                    else if ((existingResidentAge < 19 && newStudentAge >= 19) || (existingResidentAge >= 19 && newStudentAge < 19))
                                    {
                                        MessageBox.Show("Un mineur et un majeur ne peuvent pas être dans la même chambre.");
                                    }
                                    else if (existingResidentNiveauAcademique >= 4 && newStudentNiveauAcademique < 4)
                                    {
                                        MessageBox.Show("Un étudiant de niveau académique supérieur à 4 ne peut pas être mis avec un étudiant de niveau inferieur.");
                                    }
                                    else if (existingResidentNiveauAcademique < 4 && newStudentNiveauAcademique >= 4)
                                    {
                                        MessageBox.Show("Un étudiant de niveau académique supérieur à 4 ne peut pas être mis avec un étudiant de niveau inferieur.");
                                    }
                                    else
                                    {
                                        // Tous les critères sont satisfaits, ajouter le résident à la table Resident
                                        // Vérifier si l'étudiant est handicapé
                                        bool handicap = GetStudentHandicapStatus(matricule);


                                        // vérifier si l'étudiant est déjà résident de cette chambre
                                        string checkResidentQuery = "SELECT COUNT(*) FROM Resident WHERE MatriculeEtudiant = @matricule";
                                        MySqlCommand checkResidentCmd = new MySqlCommand(checkResidentQuery, connection);
                                        checkResidentCmd.Parameters.AddWithValue("@matricule", matricule);
                                        checkResidentCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

                                        int countResident = Convert.ToInt32(checkResidentCmd.ExecuteScalar());

                                        if (countResident == 0)
                                        {

                                            // Si l'étudiant est handicapé, vérifier l'étage de la chambre
                                            if (handicap)
                                            {
                                                int numeroEtage = GetChambreNumeroEtage(codeChambre);

                                                // Vérifier si la chambre est au rez-de-chaussée (étage 0)
                                                if (numeroEtage == 0)
                                                {
                                                    // Chambre vide, ajouter le résident à la table Resident
                                                    AddResidentToChambre(matricule, codeChambre, nombreMoisLocation);

                                                    MessageBox.Show("Étudiant ajouté en tant que résident avec succès.");

                                                    // Mettre à jour le nombre de lits occupés dans la table Chambre
                                                    UpdateLitsOccupes(codeChambre);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Un étudiant handicapé ne peut être affecté qu'à une chambre du rez-de-chaussée.");
                                                }
                                            }
                                            else
                                            {
                                                // Chambre vide, ajouter le résident à la table Resident
                                                AddResidentToChambre(matricule, codeChambre, nombreMoisLocation);
                                                MessageBox.Show("Étudiant ajouté en tant que résident avec succès.");

                                                // Mettre à jour le nombre de lits occupés dans la table Chambre
                                                UpdateLitsOccupes(codeChambre);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Cet étudiant est déjà résident de la cite.");
                                        }

                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("La chambre n'a plus de lit disponible.");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Veuillez entrer un nombre valide de mois de location.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucune chambre trouvée avec le code spécifié.");
                    }
                }
                else
                {
                    MessageBox.Show("Aucun étudiant trouvé avec le matricule spécifié.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'étudiant en tant que résident : " + ex.Message);
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

        private void AddResidentToChambre(string matricule, string codeChambre, int nombreMoisLocation)
        {
            // Ajouter le résident à la table Resident
            string addResidentQuery = "INSERT INTO Resident (MatriculeEtudiant, CodeChambre, NbreMoisLocation) VALUES (@matricule, @codeChambre, @nombreMoisLocation)";
            MySqlCommand addResidentCmd = new MySqlCommand(addResidentQuery, connection);
            addResidentCmd.Parameters.AddWithValue("@matricule", matricule);
            addResidentCmd.Parameters.AddWithValue("@codeChambre", codeChambre);
            addResidentCmd.Parameters.AddWithValue("@nombreMoisLocation", nombreMoisLocation);

            addResidentCmd.ExecuteNonQuery();
        }

        private void UpdateLitsOccupes(string codeChambre)
        {
            // Mettre à jour le nombre de lits occupés dans la table Chambre
            string updateLitsOccupesQuery = "UPDATE Chambre SET NombreLitsOccupes = NombreLitsOccupes + 1 WHERE Code = @codeChambre";
            MySqlCommand updateLitsOccupesCmd = new MySqlCommand(updateLitsOccupesQuery, connection);
            updateLitsOccupesCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

            updateLitsOccupesCmd.ExecuteNonQuery();
        }

        private string GetResidentMatricule(string codeChambre)
        {
            // Récupérer le matricule de l'étudiant résident dans la chambre
            string getResidentMatriculeQuery = "SELECT MatriculeEtudiant FROM Resident WHERE CodeChambre = @codeChambre";
            MySqlCommand getResidentMatriculeCmd = new MySqlCommand(getResidentMatriculeQuery, connection);
            getResidentMatriculeCmd.Parameters.AddWithValue("@codeChambre", codeChambre);

            return getResidentMatriculeCmd.ExecuteScalar().ToString();
        }

        private string GetResidentSexe(string matricule)
        {
            // Récupérer le sexe de l'étudiant résident
            string getResidentSexeQuery = "SELECT Sexe FROM etudiant WHERE Matricule = @matricule";
            MySqlCommand getResidentSexeCmd = new MySqlCommand(getResidentSexeQuery, connection);
            getResidentSexeCmd.Parameters.AddWithValue("@matricule", matricule);

            return getResidentSexeCmd.ExecuteScalar().ToString();
        }

        private int GetResidentAge(string matricule)
        {
            // Récupérer l'âge de l'étudiant résident
            string getResidentAgeQuery = "SELECT Age FROM etudiant WHERE Matricule = @matricule";
            MySqlCommand getResidentAgeCmd = new MySqlCommand(getResidentAgeQuery, connection);
            getResidentAgeCmd.Parameters.AddWithValue("@matricule", matricule);

            return Convert.ToInt32(getResidentAgeCmd.ExecuteScalar());
        }

        private int GetResidentNiveauAcademique(string matricule)
        {
            // Récupérer le niveau académique de l'étudiant résident
            string getResidentNiveauAcademiqueQuery = "SELECT NiveauAcademique FROM etudiant WHERE Matricule = @matricule";
            MySqlCommand getResidentNiveauAcademiqueCmd = new MySqlCommand(getResidentNiveauAcademiqueQuery, connection);
            getResidentNiveauAcademiqueCmd.Parameters.AddWithValue("@matricule", matricule);

            return Convert.ToInt32(getResidentNiveauAcademiqueCmd.ExecuteScalar());
        }

        private string GetStudentSexe(string matricule)
        {
            // Récupérer le sexe de l'étudiant
            string getStudentSexeQuery = "SELECT Sexe FROM etudiant WHERE Matricule = @matricule";
            MySqlCommand getStudentSexeCmd = new MySqlCommand(getStudentSexeQuery, connection);
            getStudentSexeCmd.Parameters.AddWithValue("@matricule", matricule);

            return getStudentSexeCmd.ExecuteScalar().ToString();
        }

        private int GetStudentAge(string matricule)
        {
            // Récupérer l'âge de l'étudiant
            string getStudentAgeQuery = "SELECT Age FROM etudiant WHERE Matricule = @matricule";
            MySqlCommand getStudentAgeCmd = new MySqlCommand(getStudentAgeQuery, connection);
            getStudentAgeCmd.Parameters.AddWithValue("@matricule", matricule);

            return Convert.ToInt32(getStudentAgeCmd.ExecuteScalar());
        }

        private int GetStudentNiveauAcademique(string matricule)
        {
            // Récupérer le niveau académique de l'étudiant
            string getStudentNiveauAcademiqueQuery = "SELECT NiveauAcademique FROM etudiant WHERE Matricule = @matricule";
            MySqlCommand getStudentNiveauAcademiqueCmd = new MySqlCommand(getStudentNiveauAcademiqueQuery, connection);
            getStudentNiveauAcademiqueCmd.Parameters.AddWithValue("@matricule", matricule);

            return Convert.ToInt32(getStudentNiveauAcademiqueCmd.ExecuteScalar());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckResd MenuForm = new CheckResd();
            MenuForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Demander le matricule de l'étudiant
                string matriculeToDisplay = Interaction.InputBox("Entrez le matricule de l'étudiant à afficher:", "Afficher les informations d'un étudiant", "");

                // Vérifier si le matricule existe dans la base de données
                string checkMatriculeQuery = "SELECT COUNT(*) FROM etudiant WHERE Matricule = @matricule";
                MySqlCommand checkMatriculeCmd = new MySqlCommand(checkMatriculeQuery, connection);
                checkMatriculeCmd.Parameters.AddWithValue("@matricule", matriculeToDisplay);

                int countMatricule = Convert.ToInt32(checkMatriculeCmd.ExecuteScalar());

                if (countMatricule > 0)
                {
                    // Matricule trouvé, récupérer toutes les informations de l'étudiant
                    string getStudentInfoQuery = "SELECT * FROM etudiant WHERE Matricule = @matricule";
                    MySqlCommand getStudentInfoCmd = new MySqlCommand(getStudentInfoQuery, connection);
                    getStudentInfoCmd.Parameters.AddWithValue("@matricule", matriculeToDisplay);

                    // Utiliser un adaptateur de données pour remplir un DataSet
                    MySqlDataAdapter adapter = new MySqlDataAdapter(getStudentInfoCmd);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Etudiant");

                    // Afficher les données dans le DataGridView
                    dataGridViewBuildings.DataSource = dataSet.Tables["Etudiant"];
                }
                else
                {
                    MessageBox.Show("Aucun étudiant trouvé avec le matricule spécifié.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des informations de l'étudiant : " + ex.Message);
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
            LoadStudentData();
        }
    }
}

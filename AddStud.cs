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
    public partial class AddStud : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=bdcite;User ID=root;Password=;";

        public AddStud()
        {
            InitializeComponent();
            // Initialiser la connexion dans le constructeur
            connection = new MySqlConnection(connectionString);
        }

        private void EnterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterSex_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterMat_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterNiveau_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Redirection vers la page CreateBuilding.cs
            Menu1 MenuForm = new Menu1();
            MenuForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            // Récupérer les informations du formulaire
            string nom = EnterName.Text;
            string matricule = enterMat.Text;
            int niveauAcademique = Convert.ToInt32(enterNiveau.Text);
            string sexe = enterSex.Text;
            int age = Convert.ToInt32(enterAge.Text);
            bool handicap = checkBox1.Checked;

            try
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Demander si l'étudiant est handicapé (vous pouvez personnaliser la boîte de dialogue selon vos besoins)
                DialogResult result = MessageBox.Show("L'étudiant est-il handicapé?", "Handicap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    handicap = true;
                }
                else
                {
                    handicap = false;
                }

                // Insérer un nouvel étudiant dans la table Etudiant
                string query = "INSERT INTO etudiant (Nom, Matricule, NiveauAcademique, Sexe, Age, Handicap) VALUES (@nom, @matricule, @niveauAcademique, @sexe, @age, @handicap)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@matricule", matricule);
                cmd.Parameters.AddWithValue("@niveauAcademique", niveauAcademique);
                cmd.Parameters.AddWithValue("@sexe", sexe);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@handicap", handicap);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Étudiant ajouté avec succès dans la base de données.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de l'étudiant : " + ex.Message);
            }
            finally
            {
                // Fermer la connexion à la base de données
                connection.Close();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayStud affiche = new DisplayStud();
            affiche.Show();
            this.Hide();
        }
    }
}

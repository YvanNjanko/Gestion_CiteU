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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            DisplayIntroductionText();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void DisplayIntroductionText()
        {
            // Texte d'introduction
            string introductionText = "\nCU Management est un logiciel qui vous permettra de gérer aisément l'intégralité d'une cité universitaire, allant de l'attribution\n des chambres aux étudiants suivants des critères précis à la consultation de revenus.\n" +
                                      "Vous disposez des fonctionnalités suivantes:\n\n" +
                                      "1- Gestion des bâtiments : création et suppression\n" +
                                      "2- Gestion des chambres : création et suppression\n" +
                                      "3- Gestion des lits : ajout et suppression\n" +
                                      "4- Management des étudiants : qui permet de voir la liste des étudiants en attente d'une chambre\n" +
                                      "5- Attribution des étudiants qui permet selon les critères de validation d'affecter un étudiant dans une chambre\n" +
                                      "6- Contrôle des résidents : voir l'historique des résidents des chambres, suppression\n" +
                                      "7- Gestion des paiements\n" +
                                      "8- Consultation des états (Bâtiments, Chambres, Résidents, Cité Universitaire)\n\n\n" +

                                      "CU Management is a software that will allow you to easily manage the entire university residence, from the allocation of rooms \nto students according to specific criteria to the consultation of income.\n" +
                                      "1- Building management: creation and deletion \n" +
                                      "2- Room management: creation and deletion \n" +
                                      "3- Bed management: addition and deletion \r\n4- Student management: which allows you to see the list of students waiting for a room\r\n5-Assignment of students which allows according to the validation criteria to assign a student to a room\r\n6- Resident Control: see the history of residents in the Guest Rooms, Removal \r\n7- Payment Management\r\n8- Consultation of the states (Buildings, Rooms, Residents, University Residence) ";

            Label introductionLabel = new Label();
            introductionLabel.Text = introductionText;
            introductionLabel.AutoSize = true;
            introductionLabel.Location = new Point(20, 20);
            this.Controls.Add(introductionLabel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu1 MenuForm = new Menu1();
            MenuForm.Show();
            this.Hide();
        }
    }
}

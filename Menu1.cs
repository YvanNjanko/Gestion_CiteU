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
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load_1(object sender, EventArgs e)
        {

        }

        private void Menu1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void GoToCreateRoomBtn_Click(object sender, EventArgs e)
        {
            // Redirection vers la page CreateBuilding.cs
            CreateRoom createBuildingForm = new CreateRoom();
            createBuildingForm.Show();
            this.Hide();

        }

        private void GoToCreateBedBtn_Click(object sender, EventArgs e)
        {
            AddBed AddBedForm = new AddBed();
            AddBedForm.Show();
            this.Hide();

        }

        private void GoToSaveStdBtn_Click(object sender, EventArgs e)
        {
            AddStudent AddStudForm = new AddStudent();
            AddStudForm.Show();
            this.Hide();

        }

        private void GoToAssStdBtn_Click(object sender, EventArgs e)
        {

        }

        private void GoToCheckStBtn_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}

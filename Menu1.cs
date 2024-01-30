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
            NewBuild CreateBuildForm = new NewBuild();
            CreateBuildForm.Show();
            this.Hide();


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
            AddStud AddStudForm = new AddStud();
            AddStudForm.Show();
            this.Hide();

        }

        private void GoToAssStdBtn_Click(object sender, EventArgs e)
        {
            DisplayStud MenuForm = new DisplayStud();
            MenuForm.Show();
            this.Hide();
        }

        private void GoToCheckStBtn_Click(object sender, EventArgs e)
        {
            BuildInfoForm BuildForm = new BuildInfoForm();
            BuildForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckRoom Form = new CheckRoom();
            Form.Show();
            this.Hide();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            ConnectPage MenuForm = new ConnectPage();
            MenuForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CiteStatus MenuForm = new CiteStatus();
            MenuForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu2 MenuForm = new Menu2();
            MenuForm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Settings MenuForm = new Settings();
            MenuForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}

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
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu1 MenuForm = new Menu1();
            MenuForm.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ConnectPage MenuForm = new ConnectPage();
            MenuForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuildInfoForm BuildForm = new BuildInfoForm();
            BuildForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckRoom Form = new CheckRoom();
            Form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CiteStatus MenuForm = new CiteStatus();
            MenuForm.Show();
            this.Hide();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            ConnectPage MenuForm = new ConnectPage();
            MenuForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManagePay MenuForm = new ManagePay();
            MenuForm.Show();
            this.Hide();
        }
    }
}

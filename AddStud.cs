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
        public AddStud()
        {
            InitializeComponent();
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
    }
}

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

        private void Menu2_Load(object sender, EventArgs e)
        {

        }

        private void GoToCreateBuilBtn_Click(object sender, EventArgs e)
        {
            CiteStatus MenuForm = new CiteStatus();
            MenuForm.Show();
            this.Hide();
        }
    }
}

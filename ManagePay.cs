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
        public ManagePay()
        {
            InitializeComponent();
        }

        private void ManagePay_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu2 MenuForm = new Menu2();
            MenuForm.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_paradigma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnSi_Click(object sender, EventArgs e)
        {
            Si Ventana2 = new Si();
            Ventana2.Show();
            this.Hide();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            No Ventana3 = new No();
            Ventana3.Show();
            this.Hide();
        }
    }
}

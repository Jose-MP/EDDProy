using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUnidad2
{
    public partial class ListasMenu : Form
    {
        public ListasMenu()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuFCL men = new MenuFCL();
            men.Show();
            Hide();
        }

        private void BtnSimples_Click(object sender, EventArgs e)
        {
            LSimples sim = new LSimples();
            sim.Show();
            Hide();
        }

        private void BtnDobles_Click(object sender, EventArgs e)
        {
            LDobles dob = new LDobles();
            dob.Show();
            Hide();
        }

        private void BtnCircu_Click(object sender, EventArgs e)
        {
            LCirculares cir = new LCirculares();
            cir.Show();
            Hide();
        }
    }
}

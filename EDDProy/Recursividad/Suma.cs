using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class Suma : Form
    {
        private static int llamadaCount = 0;
        public Suma()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            llamadaCount = 0;
            try
            {
                int numero = int.Parse(TxtNum.Text);
                if (numero < 1)
                {
                    MessageBox.Show("El numero debe ser mayor o igual a 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                int resultado = Sumar(numero);
                stopwatch.Stop();
                res.Text = $"{resultado}";
                long tiempoTranscurrido = stopwatch.ElapsedMilliseconds;
                comple.Text = $"{llamadaCount}";
                tiempoej.Text = $"{tiempoTranscurrido} ms";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese otro valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int Sumar(int n)
        {
            llamadaCount++;
            if (n < 0)
                return 0;
            return n + Sumar(n - 1);
        }
    }
}

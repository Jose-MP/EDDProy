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
    public partial class Factorial : Form
    {
        private static int llamadaCount = 0;
        public Factorial()
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
                if (numero < 0)
                {
                    MessageBox.Show("El número debe ser no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    long resultado = Fl(numero);
                    res.Text = $"El factorial de {numero} es {resultado}";
                    stopwatch.Stop();
                    long tiempoTranscurrido = stopwatch.ElapsedMilliseconds;
                    tiempoej.Text=$"{tiempoTranscurrido} ms";
                    comple.Text = $"{llamadaCount}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private long Fl(int n)
        {
            llamadaCount++;
            if (n == 0 || n == 1)
                return 1;
            return n * Fl(n - 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comple_Click(object sender, EventArgs e)
        {

        }

        private void tiempoej_Click(object sender, EventArgs e)
        {

        }

        private void res_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Fibonacci : Form
    {
        private static int llamadaCount = 0;
        public Fibonacci()
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
                int numTerminos = int.Parse(TxtNum.Text);
                if (numTerminos <= 0)
                {
                    MessageBox.Show("El numero debe ser positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                StringBuilder resultado = new StringBuilder();
                for (int i = 0; i < numTerminos; i++)
                {
                    resultado.Append(Fibo(i)).Append(", ");
                }
                stopwatch.Stop();
                rez.Text = $"{resultado.ToString().Trim()}";
                rex.Text = $"Secuencia de Fibonacci hasta {numTerminos} términos:";
                long tiempoTranscurrido = stopwatch.ElapsedMilliseconds;
                comple.Text = $"{llamadaCount}";
                tiempoej.Text = $"{tiempoTranscurrido} ms";
            }
            catch (FormatException)
            {
                MessageBox.Show("Numero invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int Fibo(int n)
        {
            llamadaCount++; 
            if (n <= 1)
                return n;
            return Fibo(n - 1) + Fibo(n - 2);       
        }
    }
}

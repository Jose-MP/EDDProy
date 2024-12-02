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
    public partial class Exponente : Form
    {
        private static int llamadaCount = 0;
        public Exponente()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            llamadaCount = 0;
            try
            {
                double baseNum = double.Parse(TxtNum.Text);
                int exponente = int.Parse(TxtExpo.Text);

                if (exponente < 0)
                {
                    MessageBox.Show("El exponente no puede ser negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    double resultado = Potencia(baseNum, exponente);
                    res.Text = $"El resultado de {baseNum} elevado a {exponente} es {resultado}";
                    stopwatch.Stop();
                    long tiempoTranscurrido = stopwatch.ElapsedMilliseconds;
                    comple.Text = $"{llamadaCount}";
                    tiempoej.Text = $"{tiempoTranscurrido} ms";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese otros valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double Potencia(double baseNum, int exp)
        {
            llamadaCount++;
            if (exp == 0)
                return 1;

            return baseNum * Potencia(baseNum, exp - 1);
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            
        }
    }
}

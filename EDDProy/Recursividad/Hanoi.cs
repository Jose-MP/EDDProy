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
    public partial class Hanoi : Form
    {
        private static int llamadaCount = 0;
        private int pasos = 0;
        public Hanoi()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            llamadaCount = 0;

            if (int.TryParse(TxtNum.Text, out int n) && n > 0)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                res.Clear();
                pasos = 0; 
                hanoi(n, 'A', 'B', 'C');
                res.AppendText($"El número total de pasos es: {pasos}\r\n");
                stopwatch.Stop();
                long tiempoTranscurrido = stopwatch.ElapsedMilliseconds;
                comple.Text = $"{llamadaCount}";
                tiempoej.Text = $"{tiempoTranscurrido} ms";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hanoi(int n, char c, char a, char f)
        {
            llamadaCount++;
            if (n == 1)
            {
                res.AppendText($"{c} -> {f}\r\n");
                pasos++;
            }
            else
            {
                hanoi(n - 1, c, f, a);
                res.AppendText($"{c} -> {f}\r\n");
                pasos++;
                hanoi(n - 1, a, c, f);
            }
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {

        }
    }
}

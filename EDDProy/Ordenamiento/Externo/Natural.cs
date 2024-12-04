using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Ordenamiento.Externo
{
    public partial class Natural : Form
    {
        public Natural()
        {
            InitializeComponent();
        }

        private void MetodoMezclaNatural(int[] arreglo)
        {
            int max = arreglo.Max();
            int[,] matrizMezcla = new int[arreglo.Length, max];

            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo[i]; j++)
                {
                    matrizMezcla[i, j] = 1;
                }
            }

            for (int j = 0; j < max; j++)
            {
                int suma = 0;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    suma += matrizMezcla[i, j];
                    matrizMezcla[i, j] = 0;
                }

                for (int i = arreglo.Length - 1; i >= arreglo.Length - suma; i--)
                {
                    arreglo[i] = j + 1;
                }
            }
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string datosEntrada = txtDatos.Text;

            try
            {
                int[] numeros = datosEntrada.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
                MetodoMezclaNatural(numeros);
                txtOrdenados.Text = string.Join(", ", numeros);
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos ingresados incorrectamente");
            }
        }
    }
}

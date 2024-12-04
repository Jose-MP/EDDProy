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
    public partial class Directa : Form
    {
        public Directa()
        {
            InitializeComponent();
        }

        private void MetodoMezclaDirecta(int[] arreglo, StringBuilder secuencia)
        {
            int tamaño = arreglo.Length;
            int[] listaAuxiliar = new int[tamaño];

            int paso = 1;
            while (paso < tamaño)
            {
                int inicio = 0;

                while (inicio < tamaño)
                {
                    int mitad = Math.Min(inicio + paso, tamaño);
                    int final = Math.Min(inicio + 2 * paso, tamaño);

                    MezclarSegmentos(arreglo, listaAuxiliar, inicio, mitad, final, secuencia);
                    inicio += 2 * paso;
                }

                Array.Copy(listaAuxiliar, arreglo, tamaño);
                paso *= 2;
            }
        }

        private void MezclarSegmentos(int[] arreglo, int[] listaAuxiliar, int inicio, int mitad, int final, StringBuilder secuencia)
        {
            int i = inicio, j = mitad, k = inicio;

            while (i < mitad && j < final)
            {
                if (arreglo[i] <= arreglo[j])
                {
                    listaAuxiliar[k] = arreglo[i];
                    i++;
                }
                else
                {
                    listaAuxiliar[k] = arreglo[j];
                    j++;
                }
                k++;
            }

            while (i < mitad)
            {
                listaAuxiliar[k] = arreglo[i];
                i++;
                k++;
            }

            while (j < final)
            {
                listaAuxiliar[k] = arreglo[j];
                j++;
                k++;
            }
            secuencia.AppendLine(string.Join(", ", listaAuxiliar.Take(final)));
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string datosEntrada = txtDatos.Text;

            try
            {
                int[] numeros = datosEntrada.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
                StringBuilder secuencia = new StringBuilder();
                MetodoMezclaDirecta(numeros, secuencia);
                txtOrdenados.Text = secuencia.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos ingresados incorrectamente");
            }
        }
    }
}

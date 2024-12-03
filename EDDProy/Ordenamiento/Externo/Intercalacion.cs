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
    public partial class Intercalacion : Form
    {
        public Intercalacion()
        {
            InitializeComponent();
        }
        private void MetodoIntercalacion(int[] arr, StringBuilder secuencia)
        {
            int n = arr.Length;
            int mid = n / 2;
            int[] leftArray = arr.Take(mid).ToArray();
            int[] rightArray = arr.Skip(mid).ToArray();
            Array.Sort(leftArray);
            Array.Sort(rightArray);
            int[] resultado = Intercalando(leftArray, rightArray, secuencia);
            Array.Copy(resultado, arr, n);
        }
        private int[] Intercalando(int[] left, int[] right, StringBuilder secuencia)
        {
            int n1 = left.Length;
            int n2 = right.Length;
            int[] result = new int[n1 + n2];
            int i = 0, j = 0, k = 0;

            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    result[k] = left[i];
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                result[k] = left[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                result[k] = right[j];
                j++;
                k++;
            }

            secuencia.AppendLine($"Intercalación: {string.Join(", ", result)}");
            return result;
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string datosEntrada = txtDatos.Text;

            try
            {
                int[] numeros = datosEntrada.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
                StringBuilder secuencia = new StringBuilder();
                MetodoIntercalacion(numeros, secuencia);
                txtOrdenados.Text = secuencia.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos ingresador incorrectamente");
            }
        }
        
    }
}

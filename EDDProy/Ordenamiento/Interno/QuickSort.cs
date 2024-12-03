using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Ordenamiento
{
    public partial class QuickSort : Form
    {
        public QuickSort()
        {
            InitializeComponent();
        }
        private void MetodoQuickSort(int[] arr, int inicio, int fin, StringBuilder secuencia)
        {
            if (inicio < fin)
            {
                int pivote = Particionar(arr, inicio, fin, secuencia);
                MetodoQuickSort(arr, inicio, pivote - 1, secuencia);
                MetodoQuickSort(arr, pivote + 1, fin, secuencia);
            }
        }
        private int Particionar(int[] arr, int inicio, int fin, StringBuilder secuencia)
        {
            int pivote = arr[fin];
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (arr[j] <= pivote)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[fin];
            arr[fin] = temp1;
            secuencia.AppendLine(string.Join(", ", arr));

            return i + 1;
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {           
            string datosEntrada = txtDatos.Text;

            try
            {
                int[] numeros = datosEntrada.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
                StringBuilder secuencia = new StringBuilder();
                MetodoQuickSort(numeros, 0, numeros.Length - 1, secuencia);
                txtOrdenados.Text = secuencia.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos ingresador incorrectamente");
            }
        }   
    }
}

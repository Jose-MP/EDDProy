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
    public partial class Radix : Form
    {
        public Radix()
        {
            InitializeComponent();
        }
        private void MetodoRadixSort(int[] arr, StringBuilder secuencia)
        {
            int max = arr.Max();
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSort(arr, exp, secuencia);
            }
        }
        private void CountSort(int[] arr, int exp, StringBuilder secuencia)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10]; 

            for (int i = 0; i < n; i++)
            {
                int digit = (arr[i] / exp) % 10;
                count[digit]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (arr[i] / exp) % 10;
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }

            secuencia.AppendLine($"{exp}ecimas: {string.Join(", ", arr)}");
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string datosEntrada = txtDatos.Text;
            try
            {
                int[] numeros = datosEntrada.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
                StringBuilder secuencia = new StringBuilder();
                MetodoRadixSort(numeros, secuencia);
                txtOrdenados.Text = secuencia.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos ingresador incorrectamente");
            }
        }       
    }
}

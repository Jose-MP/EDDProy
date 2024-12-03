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
        private void MetodoMerge(int[] arr, StringBuilder secuencia)
        {
            MergeSort(arr, 0, arr.Length - 1, secuencia);
        }

        private void MergeSort(int[] arr, int izquierda, int derecha, StringBuilder secuencia)
        {
            if (izquierda < derecha)
            {
                int medio = (izquierda + derecha) / 2;
                MergeSort(arr, izquierda, medio, secuencia);
                MergeSort(arr, medio + 1, derecha, secuencia);
                Merge(arr, izquierda, medio, derecha, secuencia);
            }
        }

        private void Merge(int[] arr, int izquierda, int medio, int derecha, StringBuilder secuencia)
        {
            int n1 = medio - izquierda + 1;
            int n2 = derecha - medio;
            int[] izquierdaArr = new int[n1];
            int[] derechaArr = new int[n2];

            for (int i = 0; i < n1; i++)
                izquierdaArr[i] = arr[izquierda + i];
            for (int j = 0; j < n2; j++)
                derechaArr[j] = arr[medio + 1 + j];

            int iLeft = 0, iRight = 0, k = izquierda;
            while (iLeft < n1 && iRight < n2)
            {
                if (izquierdaArr[iLeft] <= derechaArr[iRight])
                {
                    arr[k] = izquierdaArr[iLeft];
                    iLeft++;
                }
                else
                {
                    arr[k] = derechaArr[iRight];
                    iRight++;
                }
                k++;
            }

            while (iLeft < n1)
            {
                arr[k] = izquierdaArr[iLeft];
                iLeft++;
                k++;
            }

            while (iRight < n2)
            {
                arr[k] = derechaArr[iRight];
                iRight++;
                k++;
            }

            secuencia.AppendLine(string.Join(", ", arr));
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string datosEntrada = txtDatos.Text;

            try
            {
                int[] numeros = datosEntrada.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
                StringBuilder secuencia = new StringBuilder();
                MetodoMerge(numeros, secuencia);
                txtOrdenados.Text = secuencia.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos ingresador incorrectamente");
            }
        }
    }
}

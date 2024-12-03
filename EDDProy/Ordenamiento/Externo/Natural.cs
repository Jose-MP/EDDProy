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
        private void MetodoMergeNatural(int[] arr, StringBuilder secuencia)
        {
            List<List<int>> runs = GenerarRuns(arr, secuencia);

            while (runs.Count > 1)
            {
                List<List<int>> nuevasRuns = new List<List<int>>();

                for (int i = 0; i < runs.Count; i += 2)
                {
                    if (i + 1 < runs.Count)
                    {
                        List<int> combinado = Intercalar(runs[i], runs[i + 1]);
                        nuevasRuns.Add(combinado);
                        secuencia.AppendLine($"Intercalado: {string.Join(", ", combinado)}");
                    }
                    else
                    {
                        nuevasRuns.Add(runs[i]);
                    }
                }

                runs = nuevasRuns;
            }

            if (runs.Count > 0)
            {
                int[] resultado = runs[0].ToArray();
                Array.Copy(resultado, arr, resultado.Length);
                secuencia.AppendLine($"Ordenado final: {string.Join(", ", arr)}");
            }
        }
        private List<List<int>> GenerarRuns(int[] arr, StringBuilder secuencia)
        {
            List<List<int>> runs = new List<List<int>>();
            List<int> currentRun = new List<int>();

            currentRun.Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= arr[i - 1])
                {
                    currentRun.Add(arr[i]);
                }
                else
                {
                    runs.Add(currentRun);
                    currentRun = new List<int> { arr[i] };
                }
            }
            runs.Add(currentRun);

            foreach (var run in runs)
            {
                secuencia.AppendLine($"Run inicial: {string.Join(", ", run)}");
            }

            return runs;
        }

        private List<int> Intercalar(List<int> left, List<int> right)
        {
            int i = 0, j = 0;
            List<int> result = new List<int>();

            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Count)
            {
                result.Add(left[i]);
                i++;
            }

            while (j < right.Count)
            {
                result.Add(right[j]);
                j++;
            }

            return result;
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string datosEntrada = txtDatos.Text;

            try
            {
                int[] numeros = datosEntrada.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
                StringBuilder secuencia = new StringBuilder();
                MetodoMergeNatural(numeros, secuencia);
                txtOrdenados.Text = secuencia.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos ingresador incorrectamente");
            }
        } 
    }
}

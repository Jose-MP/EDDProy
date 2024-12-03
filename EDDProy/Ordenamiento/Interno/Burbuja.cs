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
    public partial class Burbuja : Form
    {
        public Burbuja()
        {
            InitializeComponent();
        }
        private string MetodoBurbuja(int[] numeros)
        {
            StringBuilder secuencia = new StringBuilder();

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - 1 - i; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                        secuencia.AppendLine(string.Join(", ", numeros));
                    }
                }
            }

            return secuencia.ToString();
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string datosEntrada = txtDatos.Text;

            try
            {
                int[] numeros = datosEntrada.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
                string resultado = MetodoBurbuja(numeros);

                txtOrdenados.Text = resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Datos ingresador incorrectamente");
            }
        }
    }
}

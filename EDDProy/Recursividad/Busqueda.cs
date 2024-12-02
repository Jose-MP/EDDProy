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
    public partial class Busqueda : Form
    {
        private static int llamadaCount = 0;
        private int[] arreglo;
        public Busqueda()
        {
            InitializeComponent();
            arreglo = new int[51];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[0] = 0;
                arreglo[1] = 2;
                arreglo[i] = (i) * 2;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnReg_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            llamadaCount = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string input = TxtNum.Text;
            int numero;

            if (int.TryParse(input, out numero))
            {

                int resultado = BusquedaBinariaRecursiva(arreglo, 0, arreglo.Length - 1, numero);
                if (resultado == -1)
                {
                    res.Text = "Número no encontrado en el arreglo.";
                }
                else
                {
                    res.Text = $"El numero esta en la posicion: {resultado}";
                }
            }
            else
            {
                res.Text = "Por favor, ingresa un número entero válido.";
            }
            stopwatch.Stop();
            long tiempoTranscurrido = stopwatch.ElapsedMilliseconds;
            comple.Text = $"{llamadaCount}";
            tiempoej.Text = $"{tiempoTranscurrido} ms";
        }
        private int BusquedaBinariaRecursiva(int[] arr, int izquierda, int derecha, int x)
        {
            llamadaCount++;
            if (izquierda > derecha)
            {
                return -1;
            }

            int medio = izquierda + (derecha - izquierda) / 2;
            if (arr[medio] == x)
            {
                return medio;
            }
            if (arr[medio] > x)
            {
                return BusquedaBinariaRecursiva(arr, izquierda, medio - 1, x);
            }
            return BusquedaBinariaRecursiva(arr, medio + 1, derecha, x);
        
        }
    }
}

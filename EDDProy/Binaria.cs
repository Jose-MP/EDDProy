using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class Binaria : Form
    {
        private List<int> datos;

        public Binaria()
        {
            InitializeComponent();
            datos = new List<int>();
        }
        private int BusquedaBinaria(List<int> datosOrdenados, int objetivo)
        {
            int inicio = 0;
            int fin = datosOrdenados.Count - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (datosOrdenados[medio] == objetivo)
                {
                    return medio;
                }
                else if (datosOrdenados[medio] < objetivo)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return -1;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {       
            string input = txtDatos.Text;

            try
            {
                datos = input.Split(new char[] { ',', '.' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                txtLista.Text = string.Join(Environment.NewLine, datos);
            }
            catch
            {
                MessageBox.Show("Datos ingresados incorrectamente", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (datos == null || !datos.Any())
            {
                MessageBox.Show("Ingresar los datos primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int numeroABuscar = int.Parse(txtBusqueda.Text);
                var datosOrdenados = datos.OrderBy(x => x).ToList();
                txtResultado.Text = string.Join(Environment.NewLine, datosOrdenados);
                int posicion = BusquedaBinaria(datosOrdenados, numeroABuscar);

                if (posicion != -1)
                {
                    MessageBox.Show($"Dato encontrado en la posicion: {posicion + 1}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Dato no encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un numero valido para buscar.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

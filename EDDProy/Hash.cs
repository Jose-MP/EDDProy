using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EDDemo
{
    public partial class Hash : Form
    {
        private Dictionary<string, string> hashTable;

        public Hash()
        {
            InitializeComponent();
            hashTable = new Dictionary<string, string>();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDato.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Ambos campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string clave = txtClave.Text.Trim();
            string dato = txtDato.Text.Trim();

            if (hashTable.ContainsKey(clave))
            {
                MessageBox.Show("La clave ya existe. Usa una clave diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            hashTable[clave] = dato;
            txtLista.AppendText($"{dato},{clave}{Environment.NewLine}");
            txtDato.Clear();
            txtClave.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCBU.Text))
            {
                MessageBox.Show("Por favor ingresa una clave para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string clave = txtCBU.Text.Trim();

            if (hashTable.TryGetValue(clave, out string dato))
            {
                MessageBox.Show($"Dato encontrado: {dato} con clave: {clave}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Clave no encontrada.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de texto (*.txt)|*.txt",
                Title = "Selecciona un archivo de texto"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var lineas = File.ReadAllLines(openFileDialog.FileName);

                    foreach (string linea in lineas)
                    {
                        var partes = linea.Split(',');
                        if (partes.Length == 2)
                        {
                            string dato = partes[0].Trim();
                            string clave = partes[1].Trim();

                            if (!hashTable.ContainsKey(clave))
                            {
                                hashTable[clave] = dato;
                                txtLista.AppendText($"{dato},{clave}{Environment.NewLine}");
                            }
                        }
                    }

                    MessageBox.Show("Datos cargados exitosamente desde el archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenUnidad2
{
    public partial class LSimples : Form
    {
        public class Nodo
        {
            public string nodod { get; set; }
            public int ID { get; set; }
            public Nodo Sig { get; set; }

            public Nodo(string dato, int id)
            {
                nodod = dato;
                ID = id;
                Sig = null;
            }
        }
        public class ListaSimple
        {
            private Nodo top; 

            public ListaSimple()
            {
                top = null;
            }
            public void Insertar(string dato, int id)
            {
                Nodo nuevoNodo = new Nodo(dato, id);
                if (top == null)
                {
                    top = nuevoNodo;
                }
                else
                {
                    Nodo actual = top;
                    while (actual.Sig != null)
                    {
                        actual = actual.Sig;
                    }
                    actual.Sig = nuevoNodo;
                }
            }
            public void Eliminar(int id)
            {
                if (top == null) return;

                if (top.ID == id)
                {
                    top = top.Sig;
                }
                else
                {
                    Nodo actual = top;
                    while (actual.Sig != null && actual.Sig.ID != id)
                    {
                        actual = actual.Sig;
                    }

                    if (actual.Sig != null)
                    {
                        actual.Sig = actual.Sig.Sig;
                    }
                }
            }
            public Nodo Buscar(int id)
            {
                Nodo actual = top;
                while (actual != null)
                {
                    if (actual.ID == id)
                    {
                        return actual;
                    }
                    actual = actual.Sig;
                }
                return null;
            }
            public bool Existe(int id)
            {
                return Buscar(id) != null;
            }
            public System.Collections.Generic.List<Nodo> ObtenerElementos()
            {
                var nodos = new System.Collections.Generic.List<Nodo>();
                Nodo actual = top;

                while (actual != null)
                {
                    nodos.Add(actual);
                    actual = actual.Sig;
                }

                return nodos;
            }
            public string MostrarLista()
            {
                string resultado = "";
                Nodo actual = top;

                while (actual != null)
                {
                    resultado += $"ID: {actual.ID}, Valor: {actual.nodod}\n";
                    actual = actual.Sig;
                }

                return resultado;
            }
        }
        ListaSimple miLista = new ListaSimple();

        public LSimples()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            ListasMenu lm = new ListasMenu();
            lm.Show();
            Hide();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidarNodo())
            {
                return;
            }
            if (!ValidarID())
            {
                return;
            }
            if (miLista.Existe(int.Parse(txtID.Text)))
            {
                MessageBox.Show("El ID ya está registrado");
                txtID.Focus();
                return;
            }

            miLista.Insertar(TxtNodo.Text, int.Parse(txtID.Text));
            ActualizarLista();
            LimpiarControles();
            TxtNodo.Focus();
        }
        private void ActualizarLista()
        {
            txtLista.Clear();
            foreach (var nodo in miLista.ObtenerElementos())
            {
                txtLista.AppendText($"ID: {nodo.ID}, Nodo: {nodo.nodod}{Environment.NewLine}");
            }
        }
        private bool ValidarID()
        {
            int ID;
            if (!int.TryParse(txtID.Text, out ID) || txtID.Text == "")
            {
                MessageBox.Show("Ingrese el ID");
                return false;
            }
            return true;
        }
        private bool ValidarNodo()
        {
            if (string.IsNullOrEmpty(TxtNodo.Text))
            {
                MessageBox.Show("Debe ingresar el dato del nodo");
                return false;
            }
            return true;
        }
        private void LimpiarControles()
        {
            TxtNodo.Clear();
            txtID.Clear();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Ingrese el ID del nodo que quiere eliminar");
                LimpiarControles();
                txtID.Focus();
                return;
            }

            int id = int.Parse(txtID.Text);
            miLista.Eliminar(id);
            ActualizarLista();
            LimpiarControles();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string nodosl = miLista.MostrarLista();
            MessageBox.Show($"Datos ingresados:\n{nodosl}");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Ingrese el ID del nodo que quiere buscar");
                return;
            }

            int id = int.Parse(txtID.Text);
            Nodo resultado = miLista.Buscar(id);
            if (resultado != null)
            {
                MessageBox.Show($"Nodo encontrado: ID={resultado.ID}, Valor={resultado.nodod}");
            }
            else
            {
                MessageBox.Show($"No se encontró un nodo con ID={id}");
            }
        }
    }
}
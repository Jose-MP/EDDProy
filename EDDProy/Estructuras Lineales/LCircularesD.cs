using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class LCircularesD : Form
    {
        public class Nodo
        {
            public string Dato { get; set; }
            public int ID { get; set; }
            public Nodo Sig { get; set; }
            public Nodo Prev { get; set; }

            public Nodo(string dato, int id)
            {
                Dato = dato;
                ID = id;
                Sig = this; 
                Prev = this; 
            }
        }
        public LCircularesD()
        {
            InitializeComponent();
        }
        public class ListaCircularDoble
        {
            private Nodo Inicio;

            public ListaCircularDoble()
            {
                Inicio = null;
            }
            public void Insertar(int posicion, string dato, int id)
            {
                Nodo nuevo = new Nodo(dato, id);

                if (Inicio == null)
                {
                    Inicio = nuevo;
                    return;
                }

                if (posicion == 0 || posicion == 1)
                {
                    nuevo.Sig = Inicio;
                    nuevo.Prev = Inicio.Prev;
                    Inicio.Prev.Sig = nuevo;
                    Inicio.Prev = nuevo;
                    Inicio = nuevo;
                    return;
                }

                int pos = 1;
                Nodo aux = Inicio;

                while (pos < posicion && aux.Sig != Inicio)
                {
                    aux = aux.Sig;
                    pos++;
                }

                if (aux != null)
                {
                    nuevo.Sig = aux.Sig;
                    nuevo.Prev = aux;
                    aux.Sig.Prev = nuevo;
                    aux.Sig = nuevo;
                }
            }
            public string Eliminar(int posicion)
            {
                if (Inicio == null)
                {
                    MessageBox.Show("Lista vacía");
                    return null;
                }

                int pos = 1;
                Nodo aux = Inicio;

                while (pos < posicion && aux.Sig != Inicio)
                {
                    aux = aux.Sig;
                    pos++;
                }

                if (aux != null)
                {
                    aux.Prev.Sig = aux.Sig;
                    aux.Sig.Prev = aux.Prev;

                    if (aux == Inicio)
                    {
                        Inicio = aux.Sig;
                    }

                    string datoEliminado = aux.Dato;
                    aux = null;

                    return datoEliminado;
                }
                else
                {
                    MessageBox.Show("No se encontró el nodo en la posición indicada");
                    return null;
                }
            }
            public string MostrarLista()
            {
                if (Inicio == null)
                    return "La lista está vacía.";

                Nodo actual = Inicio;
                string resultado = "";

                do
                {
                    resultado += $"ID: {actual.ID}, Dato: {actual.Dato}\n";
                    actual = actual.Sig;
                } while (actual != Inicio);

                return resultado;
            }
            public Nodo Buscar(int id)
            {
                if (Inicio == null)
                    return null;

                Nodo actual = Inicio;

                do
                {
                    if (actual.ID == id)
                        return actual;
                    actual = actual.Sig;
                } while (actual != Inicio);

                return null;
            }
        }
        ListaCircularDoble miListaCircularDoble = new ListaCircularDoble();
        private void ActualizarLista()
        {
            txtLista.Clear();
            txtLista.AppendText(miListaCircularDoble.MostrarLista());
        }
        private bool ValidarEntrada()
        {
            if (string.IsNullOrWhiteSpace(TxtNodo.Text))
            {
                MessageBox.Show("Debe ingresar el dato del nodo.");
                return false;
            }

            if (!int.TryParse(txtID.Text, out _))
            {
                MessageBox.Show("El ID debe ser un número.");
                return false;
            }

            return true;
        }
        private void LimpiarControles()
        {
            TxtNodo.Clear();
            txtID.Clear();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada())
            {
                return;
            }

            int id = int.Parse(txtID.Text);
            string dato = TxtNodo.Text;
            miListaCircularDoble.Insertar(0, dato, id);
            ActualizarLista();
            LimpiarControles();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Debe ingresar un ID para eliminar.");
                return;
            }

            int posicion = int.Parse(txtID.Text);
            string datoEliminado = miListaCircularDoble.Eliminar(posicion);

            if (datoEliminado != null)
            {
                MessageBox.Show($"Nodo eliminado: {datoEliminado}");
                ActualizarLista();
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string nodos = miListaCircularDoble.MostrarLista();
            MessageBox.Show($"Datos en la lista:\n{nodos}");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Ingrese el ID para buscar.");
                return;
            }

            int id = int.Parse(txtID.Text);
            Nodo encontrado = miListaCircularDoble.Buscar(id);

            if (encontrado != null)
            {
                MessageBox.Show($"Nodo encontrado: ID={encontrado.ID}, Dato={encontrado.Dato}");
            }
            else
            {
                MessageBox.Show($"No se encontró ningún nodo con ID={id}");
            }
        }
    }
}

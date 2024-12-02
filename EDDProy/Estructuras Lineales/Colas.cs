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

namespace EDDemo
{
    public partial class Colas : Form
    {
        Cola miCola = new Cola();
        public class Nodo
        {
            public string Dato { get; set; }
            public Nodo Sig { get; set; }

            public Nodo(string dato)
            {
                Dato = dato;
                Sig = null;
            }
        }
        public class Cola
        {
            private Nodo inicio; 
            private Nodo final;   
            public int Count { get; private set; }
            public Cola()
            {
                inicio = null;
                final = null;
                Count = 0;
            }

            public void EnqueueInicio(string valor)
            {
                Nodo nuevoNodo = new Nodo(valor);

                if (final == null)
                {
                    inicio = nuevoNodo;
                    final = nuevoNodo;
                }
                else
                {
                    final.Sig = nuevoNodo;
                    final = nuevoNodo;
                }

                Count++;
            }
            public string DequeueInicio()
            {
                if (inicio == null) return null;

                string valorEliminado = inicio.Dato;
                inicio = inicio.Sig;

                if (inicio == null)
                {
                    final = null;
                }

                Count--;
                return valorEliminado;
            }
            public void EnqueueFinal(string valor)
            {
                Nodo nuevoNodo = new Nodo(valor);

                if (inicio == null)
                {
                    inicio = nuevoNodo;
                    final = nuevoNodo;
                }
                else
                {
                    nuevoNodo.Sig = inicio;
                    inicio = nuevoNodo;
                }

                Count++;
            }

            public string DequeueFinal()
            {
                if (inicio == null) return null;

                if (inicio.Sig == null)
                {
                    return DequeueFinal();
                }

                Nodo actual = inicio;
                while (actual.Sig.Sig != null)
                {
                    actual = actual.Sig;
                }

                string valorEliminado = actual.Sig.Dato;
                actual.Sig = null;
                final = actual;
                Count--;
                return valorEliminado;
            }
            public System.Collections.Generic.List<string> GetElements()
            {
                var nodos = new System.Collections.Generic.List<string>();
                Nodo actual = inicio;

                while (actual != null)
                {
                    nodos.Add(actual.Dato);
                    actual = actual.Sig;
                }

                return nodos;
            }
            public bool Buscar(string valor)
            {
                Nodo actual = inicio;

                while (actual != null)
                {
                    if (actual.Dato == valor)
                    {
                        return true;
                    }
                    actual = actual.Sig;
                }

                return false;
            }
        }
        public Colas()
        {
            InitializeComponent();
        }
        public void ListaCola()
        {
            lstCola.Items.Clear();
            if (miCola.Count > 0)
            {
                foreach (string valor in miCola.GetElements())
                {
                    lstCola.Items.Add(valor);
                }
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtNodo.Text != "")
            {
                if (ComboPosi.SelectedIndex != 0 && ComboPosi.SelectedIndex != 1)
                {
                    miCola.EnqueueInicio(TxtNodo.Text);
                }
                if (ComboPosi.SelectedIndex == 0)
                {
                    miCola.EnqueueInicio(TxtNodo.Text);
                }
                else if (ComboPosi.SelectedIndex == 1)
                {
                    miCola.EnqueueFinal(TxtNodo.Text);
                }
                TxtNodo.Text = "";
                TxtNodo.Focus();
                ListaCola();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (miCola.Count > 0)
            {
                if (ComboPosi.SelectedIndex != 0 && ComboPosi.SelectedIndex != 1)
                {
                    miCola.DequeueInicio();
                }
                if (ComboPosi.SelectedIndex == 0)
                {
                    miCola.DequeueInicio();
                }
                else if (ComboPosi.SelectedIndex == 1)
                {
                    miCola.DequeueFinal();
                }

                ListaCola();
            }
            else
            {
                MessageBox.Show("La cola está vacía");
                ListaCola();
            }
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (miCola.Count > 0)
            {
                string nodosmos = string.Join(Environment.NewLine, miCola.GetElements());
                MessageBox.Show($"Datos ingresados: \n{nodosmos}");
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtNodo.Text != "")
            {
                bool nodobus = miCola.Buscar(TxtNodo.Text);
                if (nodobus)
                {
                    MessageBox.Show($"Nodo '{TxtNodo.Text}' encontrado");
                }
                else
                {
                    MessageBox.Show($"Nodo '{TxtNodo.Text}' no encontrado");
                }
                TxtNodo.Text = "";
                TxtNodo.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese un valor para buscar");
            }
        }
    }
}
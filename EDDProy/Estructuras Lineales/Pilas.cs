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
    public partial class Pilas : Form
    {

        Pila miPila = new Pila();
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
        public class Pila
        {
            private Nodo top;
            public int Count { get; private set; }

            public Pila()
            {
                top = null;
                Count = 0;
            }
            public void PushInicio(string valor)
            {
                Nodo nuevoNodo = new Nodo(valor);
                nuevoNodo.Sig = top;
                top = nuevoNodo;
                Count++;
            }
            public string PopInicio()
            {
                if (top == null) return null;

                string valorEliminado = top.Dato;
                top = top.Sig;
                Count--;
                return valorEliminado;
            }
            public void PushFinal(string valor)
            {
                if (top == null)
                {
                    PushFinal(valor);
                }
                else
                {
                    Nodo nuevoNodo = new Nodo(valor);
                    Nodo actual = top;

                    while (actual.Sig != null)
                    {
                        actual = actual.Sig;
                    }

                    actual.Sig = nuevoNodo;
                    Count++;
                }
            }
            public string PopFinal()
            {
                if (top == null) return null;

                if (top.Sig == null)
                {
                    return PopFinal();
                }
                Nodo actual = top;
                while (actual.Sig.Sig != null)
                {
                    actual = actual.Sig;
                }
                string valorEliminado = actual.Sig.Dato;
                actual.Sig = null;
                Count--;
                return valorEliminado;
            }
            public System.Collections.Generic.List<string> GetElements()
            {
                var nodos = new System.Collections.Generic.List<string>();
                Nodo actual = top;

                while (actual != null)
                {
                    nodos.Add(actual.Dato);
                    actual = actual.Sig;
                }
                return nodos;
            }
            public bool Buscar(string valor)
            {
                Nodo actual = top;

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
        public Pilas()
        {
            InitializeComponent();
        }

        public void ListaPila()
        {
            lstPila.Items.Clear();
            if (miPila.Count > 0)
            {
                foreach (string pila in miPila.GetElements())
                {
                    lstPila.Items.Add(pila);
                }
            }
        }
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuFCL men = new MenuFCL();
            men.Show();
            Hide();
        }

        private void ComboPosi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (ComboPosi.SelectedIndex != 0 && ComboPosi.SelectedIndex != 1)
            {
                miPila.PushInicio(TxtNodo.Text);
            }
            if (TxtNodo.Text != "")
            {
                if (ComboPosi.SelectedIndex == 0)
                {
                    miPila.PushInicio(TxtNodo.Text);
                }
                else if (ComboPosi.SelectedIndex == 1)
                {
                    miPila.PushFinal(TxtNodo.Text);
                }
                TxtNodo.Text = "";
                TxtNodo.Focus();
                ListaPila();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ComboPosi.SelectedIndex != 0 && ComboPosi.SelectedIndex != 1)
            {
                miPila.PopInicio();
            }
            if (miPila.Count > 0)
            {
                if (ComboPosi.SelectedIndex == 0) 
                {
                    miPila.PopInicio();
                }
                else if (ComboPosi.SelectedIndex == 1) 
                {
                    miPila.PopFinal();
                }
                ListaPila();
            }
            else
            {
                MessageBox.Show("La pila está vacía");
                ListaPila();
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (miPila.Count > 0)
            {
                string nodosmos = string.Join(Environment.NewLine, miPila.GetElements());
                MessageBox.Show($"Datos ingresados: \n{nodosmos}");
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtNodo.Text != "")
            {
                bool nodobus = miPila.Buscar(TxtNodo.Text);
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

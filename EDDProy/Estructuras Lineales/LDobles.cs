using System;
using System.Collections;
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
    public partial class LDobles : Form
    {
        NodoDoble inicio = null;
        NodoDoble fin = null;

        public LDobles()
        {
            InitializeComponent();
        }

        public class NodoDoble
        {
            public string dato;
            public NodoDoble sig;
            public NodoDoble prev;

            public NodoDoble(string dato)
            {
                this.dato = dato;
                this.sig = null;
                this.prev = null;
            }
        }

        private void Insertar(int posicion, string dato)
        {
            NodoDoble nuevo = new NodoDoble(dato);

            if (inicio == null && fin == null)
            {
                inicio = nuevo;
                fin = nuevo;
                return;
            }
            if (posicion == 0 || posicion == 1)
            {
                nuevo.sig = inicio;
                inicio.prev = nuevo;
                inicio = nuevo;
                return;
            }

            NodoDoble aux = inicio;
            int pos = 1;

            while (pos < posicion && aux != null)
            {
                aux = aux.sig;
                pos++;
            }

            if (aux != null)
            {
                nuevo.sig = aux;
                nuevo.prev = aux.prev;
                aux.prev.sig = nuevo;
                aux.prev = nuevo;
            }
            else
            {
                fin.sig = nuevo;
                nuevo.prev = fin;
                fin = nuevo;
            }
        }

        private string Eliminar(int posicion)
        {
            if (inicio == null && fin == null)
            {
                MessageBox.Show("Lista vacía.");
                return null;
            }

            NodoDoble aux = inicio;
            int pos = 1;

            while (pos < posicion && aux != null)
            {
                aux = aux.sig;
                pos++;
            }

            if (aux != null)
            {
                if (aux == fin)
                {
                    fin = aux.prev;
                    if (fin != null) fin.sig = null;
                }
                else if (aux == inicio)
                {
                    inicio = aux.sig;
                    if (inicio != null) inicio.prev = null;
                }
                else
                {
                    aux.prev.sig = aux.sig;
                    if (aux.sig != null) aux.sig.prev = aux.prev;
                }

                string datoEliminado = aux.dato;
                aux = null;
                return datoEliminado;
            }
            else
            {
                MessageBox.Show("Posición no encontrada.");
                return null;
            }
        }

        private void MostrarLista()
        {
            NodoDoble aux = inicio;
            string lista = "";

            while (aux != null)
            {
                lista += aux.dato + Environment.NewLine;
                aux = aux.sig;
            }

            txtLista.Text = string.IsNullOrEmpty(lista) ? "Lista vacía." : lista;
        }

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            string dato = TxtNodo.Text;
            if (!string.IsNullOrEmpty(dato) && int.TryParse(txtID.Text, out int posicion))
            {
                Insertar(posicion, dato);
                MostrarLista();
            }
            else
            {
                MessageBox.Show("Ingrese una posición válida.");
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int posicion))
            {
                string eliminado = Eliminar(posicion);
                if (eliminado != null)
                {
                    MostrarLista();
                }
            }
            else
            {
                MessageBox.Show("Ingrese una posición válida.");
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

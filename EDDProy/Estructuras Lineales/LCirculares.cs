﻿using System;
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
    public partial class LCirculares : Form
    {
        public LCirculares()
        {
            InitializeComponent();
        }
        public class Nodo
        {
            public string Dato { get; set; }
            public int ID { get; set; }
            public Nodo Sig { get; set; }

            public Nodo(string dato, int id)
            {
                Dato = dato;
                ID = id;
                Sig = null;
            }
        }
        public class ListaCircularSimple
        {
            private Nodo Inicio;
            private Nodo Fin;

            public ListaCircularSimple()
            {
                Inicio = null;
                Fin = null;
            }

            public void Insertar(string dato, int id)
            {
                Nodo nuevo = new Nodo(dato, id);

                if (Inicio == null)
                {
                    Inicio = nuevo;
                    Fin = nuevo;
                    nuevo.Sig = Inicio;
                    return;
                }

                nuevo.Sig = Inicio;
                Fin.Sig = nuevo;
                Fin = nuevo;
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
                Nodo previo = null;

                while (pos < posicion && aux != null)
                {
                    if (aux.Sig != Inicio)
                    {
                        previo = aux;
                        aux = aux.Sig;
                    }
                    else
                    {
                        aux = null;
                    }
                    pos++;
                }

                if (aux != null)
                {
                    if (aux == Inicio)
                    {
                        if (Inicio.Sig == Inicio)
                        {
                            Inicio = null;
                        }
                        else
                        {
                            Inicio = Inicio.Sig;
                            previo.Sig = Inicio;
                        }
                    }
                    else
                    {
                        
                        if (aux.Sig == Inicio)
                        {
                            Fin = previo;
                        }
                        previo.Sig = aux.Sig;
                    }

                    string datoEliminado = aux.Dato;
                    aux = null;
                    return datoEliminado;
                }
                else
                {
                    MessageBox.Show("No lo encontramos");
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
        ListaCircularSimple miListaCircular = new ListaCircularSimple();
        private void ActualizarLista()
        {
            txtLista.Clear();
            txtLista.AppendText(miListaCircular.MostrarLista());
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

            miListaCircular.Insertar(dato, id);
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
            string datoEliminado = miListaCircular.Eliminar(posicion);

            if (datoEliminado != null)
            {
                MessageBox.Show($"Nodo eliminado: {datoEliminado}");
                ActualizarLista();
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string nodos = miListaCircular.MostrarLista();
            MessageBox.Show($"Datos en la lista:\n{nodos}");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Ingrese el ID para buscar.");
                return;
            }

            int id = int.Parse(txtID.Text);
            Nodo encontrado = miListaCircular.Buscar(id);

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

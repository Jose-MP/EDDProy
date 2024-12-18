﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            int dato = int.Parse(txtDato.Text);
            miRaiz = miArbol.RegresaRaiz();

            if (miArbol.BuscarNodo(dato, miRaiz))
            {
                MessageBox.Show("El nodo ya existe");
            }
            else
            {
                miArbol.InsertaNodo(dato, ref miRaiz);
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
            }
            txtDato.Text = "";
            //ol
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";

            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString = b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);


            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int datoABuscar))
            {
                miRaiz = miArbol.RegresaRaiz();
                bool encontrado = miArbol.BuscarNodo(datoABuscar, miRaiz);

                if (encontrado)
                    MessageBox.Show($"Se encontró el nodo '{txtDato.Text}'");
                else
                    MessageBox.Show($"No se encontró el nodo '{txtDato.Text}'");
                //cambio
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                miRaiz = miArbol.RegresaRaiz();
                miArbol.EliminarPredecesor(dato, ref miRaiz);
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido.");
            }
        }

        private void btnSuc_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                miRaiz = miArbol.RegresaRaiz();
                miArbol.EliminarSucesor(dato, ref miRaiz);
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
            }
        }

        private void btnRecorrerN_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            lblNiveles.Text = miArbol.RecorridoPorNiveles(miRaiz);
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            int altura = miArbol.Altura(miRaiz);
            lblAltura.Text = $"{altura}";
        }

        private void btnHojas_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            int hojas = miArbol.ContarHojas(miRaiz);
            lblHojas.Text = $"{hojas}";
        }

        private void btnNodos_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            int totalNodos = miArbol.ContarNodos(miRaiz);
            lblNodos.Text = $"{totalNodos}";
        }

        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if (miArbol.EsLleno(miRaiz))
                MessageBox.Show("Es un arbol lleno");
            else
                MessageBox.Show("No es un arbol lleno");
        }

        private void btnCompleto_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            if (miArbol.EsCompleto(miRaiz))
                MessageBox.Show("Es un arbol completo");
            else
                MessageBox.Show("No es un arbol completo");
        }
    }
}

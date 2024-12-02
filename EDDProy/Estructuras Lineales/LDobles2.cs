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

namespace ExamenUnidad2
{
    public partial class LDobles2 : Form
    {
        List<ClsLista> MiListas = new List<ClsLista>();

        public LDobles2()
        {
            InitializeComponent();
        }
        

        private bool Existe(string aide)
        {
            foreach (ClsLista miDato in MiListas)
            {
                if (miDato.ID == int.Parse(aide))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ValidarID()
        {
            int ID;
            if (!int.TryParse(txtID.Text, out ID) || txtID.Text == "")
            {
                MessageBox.Show("Ingrese el ID");
                return false;
            }
            else
            {
                return true;
            }

        }

        private bool ValidarNodo()
        {
            if (string.IsNullOrEmpty(TxtNodo.Text))
            {
                MessageBox.Show("Debe ingresar el dato del nodo");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void LimpiarControles()
        {
            TxtNodo.Clear();
            txtID.Clear();
        }
        
        private ClsLista GetDato(string id)
        {
            return MiListas.Find(dato => dato.ID.Equals(id));
        }

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            if (ValidarNodo() == false)
            {
                return;
            }
            if (ValidarID() == false)
            {
                return;
            }
            if (Existe(txtID.Text))
            {
                MessageBox.Show("El ID ya está registrado");
                txtID.Focus();
                return;
            }


            ClsLista miNodo = new ClsLista();
            miNodo.Nodo = TxtNodo.Text;
            miNodo.ID = int.Parse(txtID.Text);
            MiListas.Add(miNodo);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = MiListas;
            LimpiarControles();
            TxtNodo.Focus();
        }
        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Ingrese el ID del nodo que quiere eliminar");
                LimpiarControles();
                txtID.Focus();
                return;
            }
            else
            {
                foreach (ClsLista miDato in MiListas)
                {
                    if (miDato.ID == int.Parse(txtID.Text))
                    {
                        MiListas.Remove(miDato);
                        break;
                    }
                }
                LimpiarControles();
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = MiListas;
            }
        }

        private void BtnRegresar_Click_1(object sender, EventArgs e)
        {
            ListasMenu lm = new ListasMenu();
            lm.Show();
            Hide();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
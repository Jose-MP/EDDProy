using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }       

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }
        public bool BuscarNodo(int dato, NodoBinario nodo)
        {
            if (nodo == null)
                return false;
            if (nodo.Dato == dato)
                return true;
            return BuscarNodo(dato, nodo.Izq) || BuscarNodo(dato, nodo.Der);
        }
        public void EliminarPredecesor(int dato, ref NodoBinario raiz)
        {
            
        }
        public void EliminarSucesor(int dato, ref NodoBinario raiz)
        {
            
        }
        public string RecorridoPorNiveles(NodoBinario raiz)
        {
            if (raiz == null) return "El árbol está vacío";
            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            StringBuilder resultado = new StringBuilder();

            cola.Enqueue(raiz);

            while (cola.Count > 0)
            {
                NodoBinario nodoActual = cola.Dequeue();
                resultado.Append(nodoActual.Dato + " ");

                if (nodoActual.Izq != null) cola.Enqueue(nodoActual.Izq);
                if (nodoActual.Der != null) cola.Enqueue(nodoActual.Der);
            }

            return resultado.ToString();
        }
        public int Altura(NodoBinario nodo)
        {
            if (nodo == null) return -1;
            int alturaIzquierda = Altura(nodo.Izq);
            int alturaDerecha = Altura(nodo.Der);
            return Math.Max(alturaIzquierda, alturaDerecha) + 1;
        }
        public int ContarHojas(NodoBinario nodo)
        {
            if (nodo == null) return 0;
            if (nodo.Izq == null && nodo.Der == null) return 1;
            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }
        public int ContarNodos(NodoBinario nodo)
        {
            if (nodo == null) return 0;
            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }
    }
}

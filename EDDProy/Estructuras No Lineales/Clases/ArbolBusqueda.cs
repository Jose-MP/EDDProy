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
        private NodoBinario BuscarMayor(NodoBinario nodo)
        {
            while (nodo != null && nodo.Der != null)
            {
                nodo = nodo.Der;
            }
            return nodo;
        }
        private NodoBinario BuscarMenor(NodoBinario nodo)
        {
            while (nodo != null && nodo.Izq != null)
            {
                nodo = nodo.Izq;
            }
            return nodo;
        }
        public void EliminarPredecesor(int x, ref NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return;

            if (x < nodoPtr.Dato)
            {
                EliminarPredecesor(x, ref nodoPtr.Izq);
            }
            else if (x > nodoPtr.Dato)
            {
                EliminarPredecesor(x, ref nodoPtr.Der);
            }
            else if (nodoPtr.Izq != null && nodoPtr.Der != null)
            {
                NodoBinario mayor = BuscarMayor(nodoPtr.Izq);
                nodoPtr.Dato = mayor.Dato;
                EliminarPredecesor(mayor.Dato, ref nodoPtr.Izq);
            }
            else
            {
                NodoBinario temp = nodoPtr;
                if (nodoPtr.Izq == null)
                    nodoPtr = nodoPtr.Der;
                else
                    nodoPtr = nodoPtr.Izq;

                temp = null;
            }
        }     
        public void EliminarSucesor(int x, ref NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return;

            if (x < nodoPtr.Dato)
            {
                EliminarSucesor(x, ref nodoPtr.Izq);
            }
            else if (x > nodoPtr.Dato)
            {
                EliminarSucesor(x, ref nodoPtr.Der);
            }
            else if (nodoPtr.Izq != null && nodoPtr.Der != null)
            {
                NodoBinario menor = BuscarMenor(nodoPtr.Der);
                nodoPtr.Dato = menor.Dato;
                EliminarSucesor(menor.Dato, ref nodoPtr.Der);
            }
            else
            {
                NodoBinario temp = nodoPtr;
                if (nodoPtr.Izq == null)
                    nodoPtr = nodoPtr.Der;
                else
                    nodoPtr = nodoPtr.Izq;

                temp = null;
            }
        }        
        public string RecorridoPorNiveles(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return "El árbol está vacío";

            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
            colaAuxiliar.Enqueue(nodoPtr);

            StringBuilder resultado = new StringBuilder();

            while (colaAuxiliar.Count > 0)
            {
                NodoBinario nodoAuxiliar = colaAuxiliar.Dequeue();
                resultado.Append(nodoAuxiliar.Dato + " - ");

                if (nodoAuxiliar.Izq != null)
                    colaAuxiliar.Enqueue(nodoAuxiliar.Izq);

                if (nodoAuxiliar.Der != null)
                    colaAuxiliar.Enqueue(nodoAuxiliar.Der);
            }
            return resultado.ToString().TrimEnd(' ', '-');
        }
        public int Altura(NodoBinario nodo)
        {
            if (nodo == null) return 0;
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

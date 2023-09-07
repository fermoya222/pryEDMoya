using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDMoya
{
    internal class clsListaSimple
    {
        //metodo de la clase nodo 
        private clsNodo pri;

        //propiedades de la clase
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        //metodos de la clase
        public void Agregar(clsNodo nuevo)
        {
            if (pri == null)
            {
                pri = nuevo;
            }
            else
            {
                if (nuevo.Codigo <= pri.Codigo)
                {
                    nuevo.Siguiente = pri;
                    pri = nuevo;
                }
                else
                {
                    clsNodo aux = pri;
                    clsNodo ant = pri;
                    while (nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if ( aux == null)
                        {
                            break;
                        }
                    }
                    ant.Siguiente = nuevo;
                    nuevo.Siguiente = aux;
                }
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }

        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo.ToString() + "-" + aux.Nombre + "-" + aux.Tramite);
                aux = aux.Siguiente;
            }

        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }

        }

        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("ListaSimple.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de personas ordenada por codigo\n");
            AD.WriteLine("Código;NOmbre;Trámite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite); 
                aux = aux.Siguiente;
            }
            AD.Close();
        }

        public void Eliminar(Int32 Codigo)
        {
            if ( pri.Codigo == Codigo )
            {
                pri = pri.Siguiente;
            }
            else
            {
                clsNodo aux1 = Primero;
                clsNodo aux2 = Primero;
                while (aux1.Codigo != Codigo)
                {
                    aux2 = aux1;
                    aux1 = aux1.Siguiente;
                }
                aux2.Siguiente = aux1.Siguiente;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEDMoya
{
    internal class clsNodo
    {
        //Campos del Nodo
        private Int32 cod; 
        private String nom; 
        private String tra;
        

        private clsNodo sig;
        private clsNodo ant;


        private clsNodo izq;
        private clsNodo der;
        private clsNodo raiz;


        //propiedades del nodo
        public Int32 Codigo
        { 
            get { return cod; } 
            set { cod = value; } 

        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }

        }

        public string Tramite
        {
            get { return tra; }
            set { tra = value; }

        }

        //propiedad de la clase Nodo
        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }

        public clsNodo Izquierda
        {
            get { return izq; }
            set { izq = value; }
        }

        public clsNodo Derecha
        {
            get { return der; }
            set { der = value; }
        }

        public clsNodo Raiz
        {
            get { return raiz; }
            set { raiz = value; }
        }
    }
}

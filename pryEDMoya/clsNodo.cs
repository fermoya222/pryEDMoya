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


    }
}

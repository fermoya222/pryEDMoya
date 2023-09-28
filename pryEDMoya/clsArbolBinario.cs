using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDMoya
{
    internal class clsArbolBinario
    {
        private clsNodo Inicio;

        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        public void Agregar(clsNodo nvo)
        {
            nvo.Izquierda = null;
            nvo.Derecha = null;
            if (Raiz == null)
            {
                Raiz = nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo aux = Raiz;
                while (aux != null)
                {
                    NodoPadre = aux;
                    if (nvo.Codigo < aux.Codigo)
                    {
                        aux = aux.Izquierda;
                    }
                    else
                    {
                        aux = aux.Derecha;
                    }
                }
                if (nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierda = nvo;
                }
                else
                {
                    NodoPadre.Derecha = nvo;
                }
            }
        }
        private void InOrderAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierda != null) InOrderAsc(Dgv, R.Izquierda);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecha != null) InOrderAsc(Dgv, R.Derecha);
        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderAsc(Grilla, Raiz);
        }

        private void PreOrder(DataGridView Dgv, clsNodo R)
        {

            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierda != null) PreOrder(Dgv, R.Izquierda);
            if (R.Derecha != null) PreOrder(Dgv, R.Derecha);
        }
        public void RecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrder(Grilla, Raiz);
        }

        private void PostOrder(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierda != null) PostOrder(Dgv, R.Izquierda);
            if (R.Derecha != null) PostOrder(Dgv, R.Derecha);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);

        }
        public void RecorrerPost(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrder(Grilla, Raiz);
        }


        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierda != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierda);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecha != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecha);
            }
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierda != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierda, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecha != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecha, Codigo);
            }
        }
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }
        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierda != null)
            {
                PreOrden(R.Izquierda, NodoPadre);
            }

            if (R.Derecha != null)
            {
                PreOrden(R.Derecha, NodoPadre);
            }
        }

        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenAsc(ComboBox Lis, clsNodo R)
        {
            if (R.Izquierda != null)
            {
                InOrdenAsc(Lis, R.Izquierda);
            }
            Lis.Items.Add(R.Codigo);
            if (R.Derecha != null)
            {
                InOrdenAsc(Lis, R.Derecha);
            }
        }
        public void ExportarIn(DataGridView Grilla)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("arbolInOrden.txt", false))
                {
                    foreach (DataGridViewRow row in Grilla.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Escribe el valor de la celda en el archivo de texto
                            writer.Write(cell.Value + "\t");
                        }
                        writer.WriteLine(); // Salta a la siguiente línea
                    }
                }
                MessageBox.Show("Datos guardados correctamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }

        public void ExportarPre(DataGridView Grilla)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("arbolPreOrden.txt", false))
                {
                    foreach (DataGridViewRow row in Grilla.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Escribe el valor de la celda en el archivo de texto
                            writer.Write(cell.Value + "\t");
                        }
                        writer.WriteLine(); // Salta a la siguiente línea
                    }
                }
                MessageBox.Show("Datos guardadoscorrectamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }

        public void ExportarPost(DataGridView Grilla)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("arbolPostOrden.txt", false))
                {
                    foreach (DataGridViewRow row in Grilla.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Escribe el valor de la celda en el archivo de texto
                            writer.Write(cell.Value + "\t");
                        }
                        writer.WriteLine(); // Salta a la siguiente línea
                    }
                }
                MessageBox.Show("Datos guardados correctamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }
    }
}    


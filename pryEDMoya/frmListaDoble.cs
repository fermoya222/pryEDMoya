using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDMoya
{
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            
        }
        clsListaDoble Lista = new clsListaDoble();
        private void btnAgregarLD_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoLD.Text);
            ObjNodo.Nombre = txtNombreLD.Text;
            ObjNodo.Tramite = txtTramiteLD.Text;

            Lista.Agregar(ObjNodo);
            Lista.Recorrer(dgvListaDoble);
            Lista.Recorrer(lstListaDoble);
            Lista.Recorrer(cmbCodigoLD);
            
            txtCodigoLD.Text = "";
            txtNombreLD.Text = "";
            txtTramiteLD.Text = "";
        }

        private void btnEliminarLD_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigoLD.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvListaDoble);
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer(cmbCodigoLD);
                
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
            }
        }

        private void validardatos()
        {
            if (txtCodigoLD.Text != "" && txtNombreLD.Text != "" && txtTramiteLD.Text != "")
            {
                btnAgregarLD.Enabled = true;
                btnEliminarLD.Enabled = false;
            }
            else
            {
                btnAgregarLD.Enabled = false;
                btnEliminarLD.Enabled = false;
            }
        }

        private void cmbCodigoLD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigoLD.Text == "")
            {
                btnEliminarLD.Enabled = false;
            }
            else
            {
                btnEliminarLD.Enabled = true;
            }
        }

        private void txtCodigoLD_TextChanged(object sender, EventArgs e)
        {
            validardatos();
        }

        private void txtNombreLD_TextChanged(object sender, EventArgs e)
        {
            validardatos();
        }

        private void txtTramiteLD_TextChanged(object sender, EventArgs e)
        {
            validardatos();
        }

        private void rbtnAscendente_CheckedChanged(object sender, EventArgs e)
        {

                Lista.Recorrer(dgvListaDoble);
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer(cmbCodigoLD);
            
        }

        private void rbtnDescendente_CheckedChanged(object sender, EventArgs e)
        {
           
                Lista.RecorrerDes(dgvListaDoble);
                Lista.RecorrerDes(lstListaDoble);
                Lista.RecorrerDes(cmbCodigoLD);
           
        }

        private void rbtnAscendente_Click(object sender, EventArgs e)
        {
          
                Lista.Recorrer(dgvListaDoble);
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer(cmbCodigoLD);
           
        }

        private void rbtnDescendente_Click(object sender, EventArgs e)
        {
            
                Lista.RecorrerDes(dgvListaDoble);
                Lista.RecorrerDes(lstListaDoble);
                Lista.RecorrerDes(cmbCodigoLD);
           
        }
    }
}

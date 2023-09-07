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
    public partial class frmListaSimple : Form
    {
        clsListaSimple Lista = new clsListaSimple();
        public frmListaSimple()
        {
            InitializeComponent();
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarLS_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoLS.Text);
            ObjNodo.Nombre = txtNombreLS.Text;
            ObjNodo.Tramite = txtTramiteLS.Text;

            Lista.Agregar(ObjNodo);
            Lista.Recorrer(dgvColaLS);
            Lista.Recorrer(lstColaLS);
            Lista.Recorrer(cmbCodigoLS);
            Lista.Recorrer();

            txtCodigoLS.Text = "";
            txtNombreLS.Text = "";
            txtTramiteLS.Text = "";

            
        }

        private void btnEliminarLS_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigoLS.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvColaLS);
                Lista.Recorrer(lstColaLS);
                Lista.Recorrer(cmbCodigoLS);
                Lista.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
            }
            btnEliminarLS.Enabled = false;
        }

        private void validardatos()
        {
            if (txtCodigoLS.Text != "" && txtNombreLS.Text != "" && txtTramiteLS.Text != "")
            {
                btnAgregarLS.Enabled = true;
            }
            else
            {
                btnAgregarLS.Enabled=false;
            }
        }

        private void txtCodigoLS_TextChanged(object sender, EventArgs e)
        {
            validardatos();
        }

        private void txtNombreLS_TextChanged(object sender, EventArgs e)
        {
            validardatos();
        }

        private void txtTramiteLS_TextChanged(object sender, EventArgs e)
        {
            validardatos();
        }
    }
}

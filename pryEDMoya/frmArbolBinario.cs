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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario Arbol = new clsArbolBinario();
        private void rbtnIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnIn.Checked)
            {
                Arbol.Recorrer(dgvArbolBinario);
            }
        }

        private void rbtnPre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPre.Checked)
            {
                Arbol.RecorrerPre(dgvArbolBinario);
            }
        }

        private void rbtnPost_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPost.Checked)
            {
                Arbol.RecorrerPost(dgvArbolBinario);
            }
        }

        private void btnAgregarAr_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoAr.Text);
            ObjNodo.Nombre = txtNombreAr.Text;
            ObjNodo.Tramite = txtTramiteAr.Text;

            Arbol.Agregar(ObjNodo);
            Arbol.Recorrer(dgvArbolBinario);
            

            txtCodigoAr.Text = "";
            txtNombreAr.Text = "";
            txtTramiteAr.Text = "";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }
    }
}

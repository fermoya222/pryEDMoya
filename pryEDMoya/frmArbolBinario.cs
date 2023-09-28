using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if(rbtnIn.Checked)
            {
                Arbol.ExportarIn(dgvArbolBinario);
            }
            else
            {
                if (rbtnPre.Checked)
                {
                    Arbol.ExportarPre(dgvArbolBinario);
                }
                else
                {
                    if (rbtnPost.Checked)
                    {
                        Arbol.ExportarPost(dgvArbolBinario);
                    }
                }
            }
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarAr_Click(object sender, EventArgs e)
        {
            Arbol.Eliminar(Convert.ToInt32(cmbCodigoAr.Text));
            Arbol.Recorrer(dgvArbolBinario);
            Arbol.Recorrer(treeView1);
            Arbol.Recorrer(cmbCodigoAr);
            btnEliminarAr.Enabled = false;
        }

        private void txtTramiteAr_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoAr.Text != null && txtNombreAr.Text != null && txtTramiteAr.Text != null)
            {
                btnAgregarAr.Enabled = true;
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
        }
    }
}

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
    public partial class frmPila : Form


    {
        clsPila FiladePersonas = new clsPila();
        public frmPila()
        {
            InitializeComponent();
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigoP.Text);
            ObjNodo.Nombre = txtNombreP.Text;
            ObjNodo.Tramite = txtTramiteP.Text;

            FiladePersonas.Agregar(ObjNodo);
            FiladePersonas.Recorrer(dgvColaP);
            txtCodigoP.Text = "";
            txtNombreP.Text = "";
            txtTramiteP.Text = "";
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            if (FiladePersonas.Primero != null)
            {
                lblCodigoEP.Text = FiladePersonas.Primero.Codigo.ToString();
                lblNombreEP.Text = FiladePersonas.Primero.Nombre;
                lblTramiteEP.Text = FiladePersonas.Primero.Tramite;
                FiladePersonas.Eliminar();
                FiladePersonas.Recorrer(dgvColaP);
                FiladePersonas.Recorrer(lstColaP);
                FiladePersonas.Recorrer();
            }
            else
            {
                lblCodigoEP.Text = "";
                lblNombreEP.Text = "";
                lblTramiteEP.Text = "";
            }
        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }
    }
}

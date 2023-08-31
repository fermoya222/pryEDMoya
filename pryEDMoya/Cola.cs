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
    public partial class Cola : Form
    {
        clsCola FiladePersonas = new clsCola();
        public Cola()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            FiladePersonas.Agregar(ObjNodo);
            FiladePersonas.Recorrer(dgvCola);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(FiladePersonas.Primero != null)
            {
                lblCodigoE.Text = FiladePersonas.Primero.Codigo.ToString();
                lblNombreE.Text = FiladePersonas.Primero.Nombre;
                lblTramiteE.Text = FiladePersonas.Primero.Tramite;
                FiladePersonas.Eliminar();
                FiladePersonas.Recorrer(dgvCola);
                FiladePersonas.Recorrer(lstCola);
                FiladePersonas.Recorrer();
            }
            else
            {
                lblCodigoE.Text = "";
                lblNombreE.Text = "";
                lblTramiteE.Text = "";
            }
        }
    }
}

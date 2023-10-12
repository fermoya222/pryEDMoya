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
    public partial class frmRepaso : Form
    {
        clsBaseDatos ObjBD = new clsBaseDatos();

        public frmRepaso()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT + FROM LIBRO";
            switch(cmbConsulta.SelectedIndex)
            {
                case 0:
                    lblEnunciado.Text = cmbConsulta.Text + ": " + "Paises que no tienen libros";
                    varSQL = "select * from pais where " + "idpais not in " + "(select id pais from libro )";
                    break;
                case 1:
                    lblEnunciado

            }
        }
    }
}

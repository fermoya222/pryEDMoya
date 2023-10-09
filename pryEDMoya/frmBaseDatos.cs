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
    public partial class frmBaseDatos : Form
    {
        public frmBaseDatos()
        {
            InitializeComponent();
        }

        clsBaseDatos objBaseDatos = new clsBaseDatos();

        //operaciones de poryeccion - select
        private void btnPSimple_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT TITULO FROM LIBRO";
            objBaseDatos.Listar(dgv1, varSQL);
        }

        private void btnPMultiatributo_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT idlibro, TITULO, cantidad FROM LIBRO ORDER BY 1 DESC";
            objBaseDatos.Listar(dgv1, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {

        }

        //operaciones de seleccion - where 
        private void btnSSimple_Click(object sender, EventArgs e)
        {

        }

        private void btnSMultiatributo_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        //operaciones algebraicas
        private void btnUnion_Click(object sender, EventArgs e)
        {

        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string varSQL = "Select * from libro where idIdioma = 2 and idLibro in (Select idLibro from libro where idPais = 3) order by 1 asc";
            objBaseDatos.Listar(dgv1, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {

        }

        private void frmBaseDatos_Load(object sender, EventArgs e)
        {

        }
    }
}

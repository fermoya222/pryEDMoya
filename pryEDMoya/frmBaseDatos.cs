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
        String varSQL;

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
            varSQL = "SELECT Titulo, Nombre FROM libro, Pais  Where Libro.idlibro = Pais.IdPais ";
            objBaseDatos.Listar(dgv1, varSQL);
        }

        //operaciones de seleccion - where 
        private void btnSSimple_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM Libro WHERE Cantidad >= 1";
            objBaseDatos.Listar(dgv1, varSQL);
        }

        private void btnSMultiatributo_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM Libro WHERE Cantidad >= 1 AND Precio > 130";
            objBaseDatos.Listar(dgv1, varSQL);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM (SELECT * FROM Libro WHERE IDAUTOR = 5) AS X WHERE IDIDIOMA = 3";
            objBaseDatos.Listar(dgv1, varSQL);
        }

        //operaciones algebraicas
        private void btnUnion_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM Libro WHERE idIdioma = 2" +
                " Union " +
                "SELECT * FROM Libro WHERE idIdioma = 7";
            objBaseDatos.Listar(dgv1, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM Libro WHERE IdAutor > 10" +
                "INTERSECT" +
                "SELECT * FROM Libro WHERE IdIdioma > 5";

            objBaseDatos.Listar(dgv1, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM LIBRO WHERE IDIDIOMA NOT IN (SELECT DISTINCT IDIDIOMA FROM LIBRO WHERE IDIDIOMA < 5)";
            objBaseDatos.Listar(dgv1, varSQL);
        }

        private void frmBaseDatos_Load(object sender, EventArgs e)
        {

        }
    }
}

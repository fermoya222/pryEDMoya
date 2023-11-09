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
        string varSQL = "SELECT + FROM LIBRO";
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
                    lblEnunciado.Text = cmbConsulta.Text + ": " + "Libros con ID menores a 20 y con un precio menor a 600";
                    varSQL = "SELECT * FROM LIBRO WHERE IDLIBRO < 20 " +
                        "INTERSECT " +
                        "SELECT * FROM LIBRO WHERE PRECIO < 600";
                    break;
                case 2:
                    varSQL = "SELECT * FROM LIBRO WHERE IDIDIOMA = 4 " +
                        "UNION " +
                        "SELECT * FROM LIBRO WHERE PRECIO < 600";
                    break;
                case 3:
                    varSQL = "SELECT Titulo, Nombre FROM libro, Pais  Where Libro.idlibro = Pais.IdPais ";
                    break;
                case 4:
                    varSQL = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC";
                    break;
                case 5:
                    varSQL = "SELECT IDLIBRO,TITULO FROM LIBRO ORDER BY 1 DESC";
                    break;

            }

            ObjBD.Listar(dgvListado, varSQL);
        }

        private void frmRepaso_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmConsultaSQL : Form
    {
        public frmConsultaSQL()
        {
            InitializeComponent();
        }
        
        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBaseDatos = new clsBaseDatos();
            objBaseDatos.Listar(dgvDatos, txtSql.Text);

        }

        private void frmConsultaSQL_Load(object sender, EventArgs e)
        {

        }
    }
}

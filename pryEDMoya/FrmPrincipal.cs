﻿using System;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador v = new frmDatosDesarrollador();
            v.ShowDialog();

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola v = new frmCola();
            v.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila v = new frmPila();
            v.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple v = new frmListaSimple();
            v.ShowDialog();

        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble v = new frmListaDoble();
            v.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario v = new frmArbolBinario();
            v.ShowDialog();
        }

        private void operacionesConTablasDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatos v = new frmBaseDatos();
            v.ShowDialog();
        }

        private void consultasEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaSQL v = new frmConsultaSQL();
            v.ShowDialog();
        }

        private void repasoDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepaso v = new frmRepaso();
            v.ShowDialog();
        }
    }
}

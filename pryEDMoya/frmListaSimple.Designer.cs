namespace pryEDMoya
{
    partial class frmListaSimple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColaLS = new System.Windows.Forms.DataGridView();
            this.mrcListadoLista = new System.Windows.Forms.GroupBox();
            this.lstColaLS = new System.Windows.Forms.ListBox();
            this.lblNombreLS = new System.Windows.Forms.Label();
            this.lblCodigoLS = new System.Windows.Forms.Label();
            this.btnEliminarLS = new System.Windows.Forms.Button();
            this.lblCodigo2LS = new System.Windows.Forms.Label();
            this.btnAgregarLS = new System.Windows.Forms.Button();
            this.txtTramiteLS = new System.Windows.Forms.TextBox();
            this.txtNombreLS = new System.Windows.Forms.TextBox();
            this.txtCodigoLS = new System.Windows.Forms.TextBox();
            this.lblTramiteLS = new System.Windows.Forms.Label();
            this.mrcElementoEliminadoLS = new System.Windows.Forms.GroupBox();
            this.cmbCodigoLS = new System.Windows.Forms.ComboBox();
            this.mcrNuevoElementoLS = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaLS)).BeginInit();
            this.mrcListadoLista.SuspendLayout();
            this.mrcElementoEliminadoLS.SuspendLayout();
            this.mcrNuevoElementoLS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Trámite
            // 
            this.Trámite.HeaderText = "Trámite";
            this.Trámite.Name = "Trámite";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // dgvColaLS
            // 
            this.dgvColaLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Trámite});
            this.dgvColaLS.Location = new System.Drawing.Point(219, 20);
            this.dgvColaLS.Name = "dgvColaLS";
            this.dgvColaLS.Size = new System.Drawing.Size(475, 158);
            this.dgvColaLS.TabIndex = 1;
            // 
            // mrcListadoLista
            // 
            this.mrcListadoLista.Controls.Add(this.dgvColaLS);
            this.mrcListadoLista.Controls.Add(this.lstColaLS);
            this.mrcListadoLista.Location = new System.Drawing.Point(7, 253);
            this.mrcListadoLista.Name = "mrcListadoLista";
            this.mrcListadoLista.Size = new System.Drawing.Size(710, 191);
            this.mrcListadoLista.TabIndex = 7;
            this.mrcListadoLista.TabStop = false;
            this.mrcListadoLista.Text = "listado en una Lista y una grilla";
            // 
            // lstColaLS
            // 
            this.lstColaLS.FormattingEnabled = true;
            this.lstColaLS.Location = new System.Drawing.Point(6, 19);
            this.lstColaLS.Name = "lstColaLS";
            this.lstColaLS.Size = new System.Drawing.Size(200, 160);
            this.lstColaLS.TabIndex = 0;
            // 
            // lblNombreLS
            // 
            this.lblNombreLS.AutoSize = true;
            this.lblNombreLS.Location = new System.Drawing.Point(12, 84);
            this.lblNombreLS.Name = "lblNombreLS";
            this.lblNombreLS.Size = new System.Drawing.Size(47, 13);
            this.lblNombreLS.TabIndex = 1;
            this.lblNombreLS.Text = "Nombre:";
            // 
            // lblCodigoLS
            // 
            this.lblCodigoLS.AutoSize = true;
            this.lblCodigoLS.Location = new System.Drawing.Point(10, 47);
            this.lblCodigoLS.Name = "lblCodigoLS";
            this.lblCodigoLS.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoLS.TabIndex = 0;
            this.lblCodigoLS.Text = "Código:";
            // 
            // btnEliminarLS
            // 
            this.btnEliminarLS.Location = new System.Drawing.Point(51, 173);
            this.btnEliminarLS.Name = "btnEliminarLS";
            this.btnEliminarLS.Size = new System.Drawing.Size(139, 31);
            this.btnEliminarLS.TabIndex = 6;
            this.btnEliminarLS.Text = "Eliminar";
            this.btnEliminarLS.UseVisualStyleBackColor = true;
            this.btnEliminarLS.Click += new System.EventHandler(this.btnEliminarLS_Click);
            // 
            // lblCodigo2LS
            // 
            this.lblCodigo2LS.AutoSize = true;
            this.lblCodigo2LS.Location = new System.Drawing.Point(23, 125);
            this.lblCodigo2LS.Name = "lblCodigo2LS";
            this.lblCodigo2LS.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo2LS.TabIndex = 3;
            this.lblCodigo2LS.Text = "Código:";
            // 
            // btnAgregarLS
            // 
            this.btnAgregarLS.Location = new System.Drawing.Point(33, 173);
            this.btnAgregarLS.Name = "btnAgregarLS";
            this.btnAgregarLS.Size = new System.Drawing.Size(147, 31);
            this.btnAgregarLS.TabIndex = 6;
            this.btnAgregarLS.Text = "Agregar";
            this.btnAgregarLS.UseVisualStyleBackColor = true;
            this.btnAgregarLS.Click += new System.EventHandler(this.btnAgregarLS_Click);
            // 
            // txtTramiteLS
            // 
            this.txtTramiteLS.Location = new System.Drawing.Point(81, 118);
            this.txtTramiteLS.Name = "txtTramiteLS";
            this.txtTramiteLS.Size = new System.Drawing.Size(100, 20);
            this.txtTramiteLS.TabIndex = 5;
            this.txtTramiteLS.TextChanged += new System.EventHandler(this.txtTramiteLS_TextChanged);
            // 
            // txtNombreLS
            // 
            this.txtNombreLS.Location = new System.Drawing.Point(81, 81);
            this.txtNombreLS.Name = "txtNombreLS";
            this.txtNombreLS.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLS.TabIndex = 4;
            this.txtNombreLS.TextChanged += new System.EventHandler(this.txtNombreLS_TextChanged);
            // 
            // txtCodigoLS
            // 
            this.txtCodigoLS.Location = new System.Drawing.Point(81, 44);
            this.txtCodigoLS.Name = "txtCodigoLS";
            this.txtCodigoLS.Size = new System.Drawing.Size(75, 20);
            this.txtCodigoLS.TabIndex = 3;
            this.txtCodigoLS.TextChanged += new System.EventHandler(this.txtCodigoLS_TextChanged);
            // 
            // lblTramiteLS
            // 
            this.lblTramiteLS.AutoSize = true;
            this.lblTramiteLS.Location = new System.Drawing.Point(14, 121);
            this.lblTramiteLS.Name = "lblTramiteLS";
            this.lblTramiteLS.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteLS.TabIndex = 2;
            this.lblTramiteLS.Text = "Trámite:";
            // 
            // mrcElementoEliminadoLS
            // 
            this.mrcElementoEliminadoLS.Controls.Add(this.cmbCodigoLS);
            this.mrcElementoEliminadoLS.Controls.Add(this.btnEliminarLS);
            this.mrcElementoEliminadoLS.Controls.Add(this.lblCodigo2LS);
            this.mrcElementoEliminadoLS.Location = new System.Drawing.Point(484, 12);
            this.mrcElementoEliminadoLS.Name = "mrcElementoEliminadoLS";
            this.mrcElementoEliminadoLS.Size = new System.Drawing.Size(234, 221);
            this.mrcElementoEliminadoLS.TabIndex = 6;
            this.mrcElementoEliminadoLS.TabStop = false;
            this.mrcElementoEliminadoLS.Text = "Elemento Eliminado";
            // 
            // cmbCodigoLS
            // 
            this.cmbCodigoLS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoLS.FormattingEnabled = true;
            this.cmbCodigoLS.Location = new System.Drawing.Point(72, 121);
            this.cmbCodigoLS.Name = "cmbCodigoLS";
            this.cmbCodigoLS.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigoLS.TabIndex = 7;
            this.cmbCodigoLS.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoLS_SelectedIndexChanged);
            this.cmbCodigoLS.Click += new System.EventHandler(this.cmbCodigoLS_Click);
            // 
            // mcrNuevoElementoLS
            // 
            this.mcrNuevoElementoLS.Controls.Add(this.btnAgregarLS);
            this.mcrNuevoElementoLS.Controls.Add(this.txtTramiteLS);
            this.mcrNuevoElementoLS.Controls.Add(this.txtNombreLS);
            this.mcrNuevoElementoLS.Controls.Add(this.txtCodigoLS);
            this.mcrNuevoElementoLS.Controls.Add(this.lblTramiteLS);
            this.mcrNuevoElementoLS.Controls.Add(this.lblNombreLS);
            this.mcrNuevoElementoLS.Controls.Add(this.lblCodigoLS);
            this.mcrNuevoElementoLS.Location = new System.Drawing.Point(244, 12);
            this.mcrNuevoElementoLS.Name = "mcrNuevoElementoLS";
            this.mcrNuevoElementoLS.Size = new System.Drawing.Size(217, 222);
            this.mcrNuevoElementoLS.TabIndex = 5;
            this.mcrNuevoElementoLS.TabStop = false;
            this.mcrNuevoElementoLS.Text = "Nuevo Elemento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::pryEDMoya.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 225);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mrcListadoLista);
            this.Controls.Add(this.mrcElementoEliminadoLS);
            this.Controls.Add(this.mcrNuevoElementoLS);
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datis lineas: Lista Siumple";
            this.Load += new System.EventHandler(this.frmListaSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaLS)).EndInit();
            this.mrcListadoLista.ResumeLayout(false);
            this.mrcElementoEliminadoLS.ResumeLayout(false);
            this.mrcElementoEliminadoLS.PerformLayout();
            this.mcrNuevoElementoLS.ResumeLayout(false);
            this.mcrNuevoElementoLS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridView dgvColaLS;
        private System.Windows.Forms.GroupBox mrcListadoLista;
        private System.Windows.Forms.ListBox lstColaLS;
        private System.Windows.Forms.Label lblNombreLS;
        private System.Windows.Forms.Label lblCodigoLS;
        private System.Windows.Forms.Button btnEliminarLS;
        private System.Windows.Forms.Label lblCodigo2LS;
        private System.Windows.Forms.Button btnAgregarLS;
        private System.Windows.Forms.TextBox txtTramiteLS;
        private System.Windows.Forms.TextBox txtNombreLS;
        private System.Windows.Forms.TextBox txtCodigoLS;
        private System.Windows.Forms.Label lblTramiteLS;
        private System.Windows.Forms.GroupBox mrcElementoEliminadoLS;
        private System.Windows.Forms.GroupBox mcrNuevoElementoLS;
        private System.Windows.Forms.ComboBox cmbCodigoLS;
    }
}
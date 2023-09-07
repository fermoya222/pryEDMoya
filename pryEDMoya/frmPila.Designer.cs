namespace pryEDMoya
{
    partial class frmPila
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
            this.dgvColaP = new System.Windows.Forms.DataGridView();
            this.mrcListadoListaP = new System.Windows.Forms.GroupBox();
            this.lstColaP = new System.Windows.Forms.ListBox();
            this.lblTramiteEP = new System.Windows.Forms.Label();
            this.lblNombreEP = new System.Windows.Forms.Label();
            this.lblCodigoEP = new System.Windows.Forms.Label();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.lblTramite2P = new System.Windows.Forms.Label();
            this.lblNombre2P = new System.Windows.Forms.Label();
            this.lblCodigo2P = new System.Windows.Forms.Label();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.txtTramiteP = new System.Windows.Forms.TextBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.lblTramiteP = new System.Windows.Forms.Label();
            this.mrcElementoEliminadoP = new System.Windows.Forms.GroupBox();
            this.mcrNuevoElementoP = new System.Windows.Forms.GroupBox();
            this.pictureBox1P = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaP)).BeginInit();
            this.mrcListadoListaP.SuspendLayout();
            this.mrcElementoEliminadoP.SuspendLayout();
            this.mcrNuevoElementoP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1P)).BeginInit();
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
            // dgvColaP
            // 
            this.dgvColaP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Trámite});
            this.dgvColaP.Location = new System.Drawing.Point(219, 20);
            this.dgvColaP.Name = "dgvColaP";
            this.dgvColaP.Size = new System.Drawing.Size(475, 158);
            this.dgvColaP.TabIndex = 1;
            // 
            // mrcListadoListaP
            // 
            this.mrcListadoListaP.Controls.Add(this.dgvColaP);
            this.mrcListadoListaP.Controls.Add(this.lstColaP);
            this.mrcListadoListaP.Location = new System.Drawing.Point(7, 253);
            this.mrcListadoListaP.Name = "mrcListadoListaP";
            this.mrcListadoListaP.Size = new System.Drawing.Size(710, 191);
            this.mrcListadoListaP.TabIndex = 7;
            this.mrcListadoListaP.TabStop = false;
            this.mrcListadoListaP.Text = "listado en una Lista y una grilla";
            // 
            // lstColaP
            // 
            this.lstColaP.FormattingEnabled = true;
            this.lstColaP.Location = new System.Drawing.Point(6, 19);
            this.lstColaP.Name = "lstColaP";
            this.lstColaP.Size = new System.Drawing.Size(200, 160);
            this.lstColaP.TabIndex = 0;
            // 
            // lblTramiteEP
            // 
            this.lblTramiteEP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramiteEP.Location = new System.Drawing.Point(101, 118);
            this.lblTramiteEP.Name = "lblTramiteEP";
            this.lblTramiteEP.Size = new System.Drawing.Size(100, 23);
            this.lblTramiteEP.TabIndex = 9;
            // 
            // lblNombreEP
            // 
            this.lblNombreEP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEP.Location = new System.Drawing.Point(101, 81);
            this.lblNombreEP.Name = "lblNombreEP";
            this.lblNombreEP.Size = new System.Drawing.Size(100, 23);
            this.lblNombreEP.TabIndex = 8;
            // 
            // lblCodigoEP
            // 
            this.lblCodigoEP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEP.Location = new System.Drawing.Point(101, 47);
            this.lblCodigoEP.Name = "lblCodigoEP";
            this.lblCodigoEP.Size = new System.Drawing.Size(100, 17);
            this.lblCodigoEP.TabIndex = 7;
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(12, 84);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(47, 13);
            this.lblNombreP.TabIndex = 1;
            this.lblNombreP.Text = "Nombre:";
            // 
            // lblCodigoP
            // 
            this.lblCodigoP.AutoSize = true;
            this.lblCodigoP.Location = new System.Drawing.Point(10, 47);
            this.lblCodigoP.Name = "lblCodigoP";
            this.lblCodigoP.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoP.TabIndex = 0;
            this.lblCodigoP.Text = "Código:";
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Location = new System.Drawing.Point(51, 173);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(139, 31);
            this.btnEliminarP.TabIndex = 6;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // lblTramite2P
            // 
            this.lblTramite2P.AutoSize = true;
            this.lblTramite2P.Location = new System.Drawing.Point(21, 121);
            this.lblTramite2P.Name = "lblTramite2P";
            this.lblTramite2P.Size = new System.Drawing.Size(45, 13);
            this.lblTramite2P.TabIndex = 5;
            this.lblTramite2P.Text = "Trámite:";
            // 
            // lblNombre2P
            // 
            this.lblNombre2P.AutoSize = true;
            this.lblNombre2P.Location = new System.Drawing.Point(19, 84);
            this.lblNombre2P.Name = "lblNombre2P";
            this.lblNombre2P.Size = new System.Drawing.Size(47, 13);
            this.lblNombre2P.TabIndex = 4;
            this.lblNombre2P.Text = "Nombre:";
            // 
            // lblCodigo2P
            // 
            this.lblCodigo2P.AutoSize = true;
            this.lblCodigo2P.Location = new System.Drawing.Point(19, 47);
            this.lblCodigo2P.Name = "lblCodigo2P";
            this.lblCodigo2P.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo2P.TabIndex = 3;
            this.lblCodigo2P.Text = "Código:";
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(33, 173);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(147, 31);
            this.btnAgregarP.TabIndex = 6;
            this.btnAgregarP.Text = "Agregar";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // txtTramiteP
            // 
            this.txtTramiteP.Location = new System.Drawing.Point(81, 118);
            this.txtTramiteP.Name = "txtTramiteP";
            this.txtTramiteP.Size = new System.Drawing.Size(100, 20);
            this.txtTramiteP.TabIndex = 5;
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(81, 81);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(100, 20);
            this.txtNombreP.TabIndex = 4;
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(81, 44);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(75, 20);
            this.txtCodigoP.TabIndex = 3;
            // 
            // lblTramiteP
            // 
            this.lblTramiteP.AutoSize = true;
            this.lblTramiteP.Location = new System.Drawing.Point(14, 121);
            this.lblTramiteP.Name = "lblTramiteP";
            this.lblTramiteP.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteP.TabIndex = 2;
            this.lblTramiteP.Text = "Trámite:";
            // 
            // mrcElementoEliminadoP
            // 
            this.mrcElementoEliminadoP.Controls.Add(this.lblTramiteEP);
            this.mrcElementoEliminadoP.Controls.Add(this.lblNombreEP);
            this.mrcElementoEliminadoP.Controls.Add(this.lblCodigoEP);
            this.mrcElementoEliminadoP.Controls.Add(this.btnEliminarP);
            this.mrcElementoEliminadoP.Controls.Add(this.lblTramite2P);
            this.mrcElementoEliminadoP.Controls.Add(this.lblNombre2P);
            this.mrcElementoEliminadoP.Controls.Add(this.lblCodigo2P);
            this.mrcElementoEliminadoP.Location = new System.Drawing.Point(484, 12);
            this.mrcElementoEliminadoP.Name = "mrcElementoEliminadoP";
            this.mrcElementoEliminadoP.Size = new System.Drawing.Size(234, 221);
            this.mrcElementoEliminadoP.TabIndex = 6;
            this.mrcElementoEliminadoP.TabStop = false;
            this.mrcElementoEliminadoP.Text = "Elemento Eliminado";
            // 
            // mcrNuevoElementoP
            // 
            this.mcrNuevoElementoP.Controls.Add(this.btnAgregarP);
            this.mcrNuevoElementoP.Controls.Add(this.txtTramiteP);
            this.mcrNuevoElementoP.Controls.Add(this.txtNombreP);
            this.mcrNuevoElementoP.Controls.Add(this.txtCodigoP);
            this.mcrNuevoElementoP.Controls.Add(this.lblTramiteP);
            this.mcrNuevoElementoP.Controls.Add(this.lblNombreP);
            this.mcrNuevoElementoP.Controls.Add(this.lblCodigoP);
            this.mcrNuevoElementoP.Location = new System.Drawing.Point(244, 12);
            this.mcrNuevoElementoP.Name = "mcrNuevoElementoP";
            this.mcrNuevoElementoP.Size = new System.Drawing.Size(217, 222);
            this.mcrNuevoElementoP.TabIndex = 5;
            this.mcrNuevoElementoP.TabStop = false;
            this.mcrNuevoElementoP.Text = "Nuevo Elemento";
            // 
            // pictureBox1P
            // 
            this.pictureBox1P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1P.Image = global::pryEDMoya.Properties.Resources.Pilas_en_c__;
            this.pictureBox1P.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1P.Name = "pictureBox1P";
            this.pictureBox1P.Size = new System.Drawing.Size(231, 224);
            this.pictureBox1P.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1P.TabIndex = 4;
            this.pictureBox1P.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.pictureBox1P);
            this.Controls.Add(this.mrcListadoListaP);
            this.Controls.Add(this.mrcElementoEliminadoP);
            this.Controls.Add(this.mcrNuevoElementoP);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaP)).EndInit();
            this.mrcListadoListaP.ResumeLayout(false);
            this.mrcElementoEliminadoP.ResumeLayout(false);
            this.mrcElementoEliminadoP.PerformLayout();
            this.mcrNuevoElementoP.ResumeLayout(false);
            this.mcrNuevoElementoP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1P)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1P;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridView dgvColaP;
        private System.Windows.Forms.GroupBox mrcListadoListaP;
        private System.Windows.Forms.ListBox lstColaP;
        private System.Windows.Forms.Label lblTramiteEP;
        private System.Windows.Forms.Label lblNombreEP;
        private System.Windows.Forms.Label lblCodigoEP;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblCodigoP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Label lblTramite2P;
        private System.Windows.Forms.Label lblNombre2P;
        private System.Windows.Forms.Label lblCodigo2P;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.TextBox txtTramiteP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Label lblTramiteP;
        private System.Windows.Forms.GroupBox mrcElementoEliminadoP;
        private System.Windows.Forms.GroupBox mcrNuevoElementoP;
    }
}
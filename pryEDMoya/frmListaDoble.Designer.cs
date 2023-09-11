namespace pryEDMoya
{
    partial class frmListaDoble
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
            this.mrcListadoLista = new System.Windows.Forms.GroupBox();
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaDoble = new System.Windows.Forms.ListBox();
            this.mrcElementoAEliminarLD = new System.Windows.Forms.GroupBox();
            this.cmbCodigoLD = new System.Windows.Forms.ComboBox();
            this.btnEliminarLD = new System.Windows.Forms.Button();
            this.lblCodigo2LD = new System.Windows.Forms.Label();
            this.mcrNuevoElementoLD = new System.Windows.Forms.GroupBox();
            this.btnAgregarLD = new System.Windows.Forms.Button();
            this.txtTramiteLD = new System.Windows.Forms.TextBox();
            this.txtNombreLD = new System.Windows.Forms.TextBox();
            this.txtCodigoLD = new System.Windows.Forms.TextBox();
            this.lblTramiteLD = new System.Windows.Forms.Label();
            this.lblNombreLD = new System.Windows.Forms.Label();
            this.lblCodigoLD = new System.Windows.Forms.Label();
            this.pictureBoxLD = new System.Windows.Forms.PictureBox();
            this.cmdListarDatosLD = new System.Windows.Forms.GroupBox();
            this.rbtnAscendente = new System.Windows.Forms.RadioButton();
            this.rbtnDescendente = new System.Windows.Forms.RadioButton();
            this.mrcListadoLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            this.mrcElementoAEliminarLD.SuspendLayout();
            this.mcrNuevoElementoLD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLD)).BeginInit();
            this.cmdListarDatosLD.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcListadoLista
            // 
            this.mrcListadoLista.Controls.Add(this.dgvListaDoble);
            this.mrcListadoLista.Controls.Add(this.lstListaDoble);
            this.mrcListadoLista.Location = new System.Drawing.Point(6, 253);
            this.mrcListadoLista.Name = "mrcListadoLista";
            this.mrcListadoLista.Size = new System.Drawing.Size(710, 191);
            this.mrcListadoLista.TabIndex = 11;
            this.mrcListadoLista.TabStop = false;
            this.mrcListadoLista.Text = "listado en una Lista y una grilla";
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Trámite});
            this.dgvListaDoble.Location = new System.Drawing.Point(219, 20);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.Size = new System.Drawing.Size(475, 158);
            this.dgvListaDoble.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Trámite
            // 
            this.Trámite.HeaderText = "Trámite";
            this.Trámite.Name = "Trámite";
            // 
            // lstListaDoble
            // 
            this.lstListaDoble.FormattingEnabled = true;
            this.lstListaDoble.Location = new System.Drawing.Point(6, 19);
            this.lstListaDoble.Name = "lstListaDoble";
            this.lstListaDoble.Size = new System.Drawing.Size(200, 160);
            this.lstListaDoble.TabIndex = 0;
            // 
            // mrcElementoAEliminarLD
            // 
            this.mrcElementoAEliminarLD.Controls.Add(this.cmbCodigoLD);
            this.mrcElementoAEliminarLD.Controls.Add(this.btnEliminarLD);
            this.mrcElementoAEliminarLD.Controls.Add(this.lblCodigo2LD);
            this.mrcElementoAEliminarLD.Location = new System.Drawing.Point(483, 12);
            this.mrcElementoAEliminarLD.Name = "mrcElementoAEliminarLD";
            this.mrcElementoAEliminarLD.Size = new System.Drawing.Size(234, 121);
            this.mrcElementoAEliminarLD.TabIndex = 10;
            this.mrcElementoAEliminarLD.TabStop = false;
            this.mrcElementoAEliminarLD.Text = "Elemento a Eliminar";
            // 
            // cmbCodigoLD
            // 
            this.cmbCodigoLD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoLD.FormattingEnabled = true;
            this.cmbCodigoLD.Location = new System.Drawing.Point(81, 44);
            this.cmbCodigoLD.Name = "cmbCodigoLD";
            this.cmbCodigoLD.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigoLD.TabIndex = 7;
            // 
            // btnEliminarLD
            // 
            this.btnEliminarLD.Location = new System.Drawing.Point(49, 81);
            this.btnEliminarLD.Name = "btnEliminarLD";
            this.btnEliminarLD.Size = new System.Drawing.Size(139, 31);
            this.btnEliminarLD.TabIndex = 6;
            this.btnEliminarLD.Text = "Eliminar";
            this.btnEliminarLD.UseVisualStyleBackColor = true;
            // 
            // lblCodigo2LD
            // 
            this.lblCodigo2LD.AutoSize = true;
            this.lblCodigo2LD.Location = new System.Drawing.Point(15, 47);
            this.lblCodigo2LD.Name = "lblCodigo2LD";
            this.lblCodigo2LD.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo2LD.TabIndex = 3;
            this.lblCodigo2LD.Text = "Código:";
            // 
            // mcrNuevoElementoLD
            // 
            this.mcrNuevoElementoLD.Controls.Add(this.btnAgregarLD);
            this.mcrNuevoElementoLD.Controls.Add(this.txtTramiteLD);
            this.mcrNuevoElementoLD.Controls.Add(this.txtNombreLD);
            this.mcrNuevoElementoLD.Controls.Add(this.txtCodigoLD);
            this.mcrNuevoElementoLD.Controls.Add(this.lblTramiteLD);
            this.mcrNuevoElementoLD.Controls.Add(this.lblNombreLD);
            this.mcrNuevoElementoLD.Controls.Add(this.lblCodigoLD);
            this.mcrNuevoElementoLD.Location = new System.Drawing.Point(243, 12);
            this.mcrNuevoElementoLD.Name = "mcrNuevoElementoLD";
            this.mcrNuevoElementoLD.Size = new System.Drawing.Size(217, 222);
            this.mcrNuevoElementoLD.TabIndex = 9;
            this.mcrNuevoElementoLD.TabStop = false;
            this.mcrNuevoElementoLD.Text = "Nuevo Elemento";
            // 
            // btnAgregarLD
            // 
            this.btnAgregarLD.Location = new System.Drawing.Point(33, 173);
            this.btnAgregarLD.Name = "btnAgregarLD";
            this.btnAgregarLD.Size = new System.Drawing.Size(147, 31);
            this.btnAgregarLD.TabIndex = 6;
            this.btnAgregarLD.Text = "Agregar";
            this.btnAgregarLD.UseVisualStyleBackColor = true;
            // 
            // txtTramiteLD
            // 
            this.txtTramiteLD.Location = new System.Drawing.Point(81, 118);
            this.txtTramiteLD.Name = "txtTramiteLD";
            this.txtTramiteLD.Size = new System.Drawing.Size(100, 20);
            this.txtTramiteLD.TabIndex = 5;
            // 
            // txtNombreLD
            // 
            this.txtNombreLD.Location = new System.Drawing.Point(81, 81);
            this.txtNombreLD.Name = "txtNombreLD";
            this.txtNombreLD.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLD.TabIndex = 4;
            // 
            // txtCodigoLD
            // 
            this.txtCodigoLD.Location = new System.Drawing.Point(81, 44);
            this.txtCodigoLD.Name = "txtCodigoLD";
            this.txtCodigoLD.Size = new System.Drawing.Size(75, 20);
            this.txtCodigoLD.TabIndex = 3;
            // 
            // lblTramiteLD
            // 
            this.lblTramiteLD.AutoSize = true;
            this.lblTramiteLD.Location = new System.Drawing.Point(10, 121);
            this.lblTramiteLD.Name = "lblTramiteLD";
            this.lblTramiteLD.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteLD.TabIndex = 2;
            this.lblTramiteLD.Text = "Trámite:";
            // 
            // lblNombreLD
            // 
            this.lblNombreLD.AutoSize = true;
            this.lblNombreLD.Location = new System.Drawing.Point(10, 84);
            this.lblNombreLD.Name = "lblNombreLD";
            this.lblNombreLD.Size = new System.Drawing.Size(47, 13);
            this.lblNombreLD.TabIndex = 1;
            this.lblNombreLD.Text = "Nombre:";
            // 
            // lblCodigoLD
            // 
            this.lblCodigoLD.AutoSize = true;
            this.lblCodigoLD.Location = new System.Drawing.Point(10, 47);
            this.lblCodigoLD.Name = "lblCodigoLD";
            this.lblCodigoLD.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoLD.TabIndex = 0;
            this.lblCodigoLD.Text = "Código:";
            // 
            // pictureBoxLD
            // 
            this.pictureBoxLD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLD.Image = global::pryEDMoya.Properties.Resources.listar_datos;
            this.pictureBoxLD.Location = new System.Drawing.Point(6, 10);
            this.pictureBoxLD.Name = "pictureBoxLD";
            this.pictureBoxLD.Size = new System.Drawing.Size(224, 225);
            this.pictureBoxLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLD.TabIndex = 8;
            this.pictureBoxLD.TabStop = false;
            // 
            // cmdListarDatosLD
            // 
            this.cmdListarDatosLD.Controls.Add(this.rbtnDescendente);
            this.cmdListarDatosLD.Controls.Add(this.rbtnAscendente);
            this.cmdListarDatosLD.Location = new System.Drawing.Point(483, 143);
            this.cmdListarDatosLD.Name = "cmdListarDatosLD";
            this.cmdListarDatosLD.Size = new System.Drawing.Size(234, 91);
            this.cmdListarDatosLD.TabIndex = 12;
            this.cmdListarDatosLD.TabStop = false;
            this.cmdListarDatosLD.Text = "Listar Datos";
            // 
            // rbtnAscendente
            // 
            this.rbtnAscendente.AutoSize = true;
            this.rbtnAscendente.Location = new System.Drawing.Point(21, 27);
            this.rbtnAscendente.Name = "rbtnAscendente";
            this.rbtnAscendente.Size = new System.Drawing.Size(82, 17);
            this.rbtnAscendente.TabIndex = 0;
            this.rbtnAscendente.TabStop = true;
            this.rbtnAscendente.Text = "Ascendente";
            this.rbtnAscendente.UseVisualStyleBackColor = true;
            // 
            // rbtnDescendente
            // 
            this.rbtnDescendente.AutoSize = true;
            this.rbtnDescendente.Location = new System.Drawing.Point(21, 56);
            this.rbtnDescendente.Name = "rbtnDescendente";
            this.rbtnDescendente.Size = new System.Drawing.Size(89, 17);
            this.rbtnDescendente.TabIndex = 1;
            this.rbtnDescendente.TabStop = true;
            this.rbtnDescendente.Text = "Descendente";
            this.rbtnDescendente.UseVisualStyleBackColor = true;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.cmdListarDatosLD);
            this.Controls.Add(this.pictureBoxLD);
            this.Controls.Add(this.mrcListadoLista);
            this.Controls.Add(this.mrcElementoAEliminarLD);
            this.Controls.Add(this.mcrNuevoElementoLD);
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaDoble";
            this.mrcListadoLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.mrcElementoAEliminarLD.ResumeLayout(false);
            this.mrcElementoAEliminarLD.PerformLayout();
            this.mcrNuevoElementoLD.ResumeLayout(false);
            this.mcrNuevoElementoLD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLD)).EndInit();
            this.cmdListarDatosLD.ResumeLayout(false);
            this.cmdListarDatosLD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLD;
        private System.Windows.Forms.GroupBox mrcListadoLista;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.ListBox lstListaDoble;
        private System.Windows.Forms.GroupBox mrcElementoAEliminarLD;
        private System.Windows.Forms.ComboBox cmbCodigoLD;
        private System.Windows.Forms.Button btnEliminarLD;
        private System.Windows.Forms.Label lblCodigo2LD;
        private System.Windows.Forms.GroupBox mcrNuevoElementoLD;
        private System.Windows.Forms.Button btnAgregarLD;
        private System.Windows.Forms.TextBox txtTramiteLD;
        private System.Windows.Forms.TextBox txtNombreLD;
        private System.Windows.Forms.TextBox txtCodigoLD;
        private System.Windows.Forms.Label lblTramiteLD;
        private System.Windows.Forms.Label lblNombreLD;
        private System.Windows.Forms.Label lblCodigoLD;
        private System.Windows.Forms.GroupBox cmdListarDatosLD;
        private System.Windows.Forms.RadioButton rbtnDescendente;
        private System.Windows.Forms.RadioButton rbtnAscendente;
    }
}
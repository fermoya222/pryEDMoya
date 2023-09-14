namespace pryEDMoya
{
    partial class frmArbolBinario
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
            this.mrcArbolBinario = new System.Windows.Forms.GroupBox();
            this.dgvArbolBinario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcElementoAEliminarAr = new System.Windows.Forms.GroupBox();
            this.cmbCodigoAr = new System.Windows.Forms.ComboBox();
            this.btnEliminarAr = new System.Windows.Forms.Button();
            this.lblCodigo2Ar = new System.Windows.Forms.Label();
            this.mcrNuevoElementoAr = new System.Windows.Forms.GroupBox();
            this.btnAgregarAr = new System.Windows.Forms.Button();
            this.txtTramiteAr = new System.Windows.Forms.TextBox();
            this.txtNombreAr = new System.Windows.Forms.TextBox();
            this.txtCodigoAr = new System.Windows.Forms.TextBox();
            this.lblTramiteAr = new System.Windows.Forms.Label();
            this.lblNombreAr = new System.Windows.Forms.Label();
            this.lblCodigoAr = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.rbtnIn = new System.Windows.Forms.RadioButton();
            this.rbtnPre = new System.Windows.Forms.RadioButton();
            this.rbtnPost = new System.Windows.Forms.RadioButton();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.mrcArbolBinario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).BeginInit();
            this.mrcElementoAEliminarAr.SuspendLayout();
            this.mcrNuevoElementoAr.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcArbolBinario
            // 
            this.mrcArbolBinario.Controls.Add(this.rbtnPost);
            this.mrcArbolBinario.Controls.Add(this.rbtnPre);
            this.mrcArbolBinario.Controls.Add(this.rbtnIn);
            this.mrcArbolBinario.Controls.Add(this.dgvArbolBinario);
            this.mrcArbolBinario.Location = new System.Drawing.Point(5, 253);
            this.mrcArbolBinario.Name = "mrcArbolBinario";
            this.mrcArbolBinario.Size = new System.Drawing.Size(710, 191);
            this.mrcArbolBinario.TabIndex = 16;
            this.mrcArbolBinario.TabStop = false;
            this.mrcArbolBinario.Text = "listado en una Lista y una grilla";
            // 
            // dgvArbolBinario
            // 
            this.dgvArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Trámite});
            this.dgvArbolBinario.Location = new System.Drawing.Point(219, 20);
            this.dgvArbolBinario.Name = "dgvArbolBinario";
            this.dgvArbolBinario.Size = new System.Drawing.Size(475, 158);
            this.dgvArbolBinario.TabIndex = 1;
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
            // mrcElementoAEliminarAr
            // 
            this.mrcElementoAEliminarAr.Controls.Add(this.cmbCodigoAr);
            this.mrcElementoAEliminarAr.Controls.Add(this.btnEliminarAr);
            this.mrcElementoAEliminarAr.Controls.Add(this.lblCodigo2Ar);
            this.mrcElementoAEliminarAr.Location = new System.Drawing.Point(482, 12);
            this.mrcElementoAEliminarAr.Name = "mrcElementoAEliminarAr";
            this.mrcElementoAEliminarAr.Size = new System.Drawing.Size(234, 121);
            this.mrcElementoAEliminarAr.TabIndex = 15;
            this.mrcElementoAEliminarAr.TabStop = false;
            this.mrcElementoAEliminarAr.Text = "Elemento a Eliminar";
            // 
            // cmbCodigoAr
            // 
            this.cmbCodigoAr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoAr.FormattingEnabled = true;
            this.cmbCodigoAr.Location = new System.Drawing.Point(81, 44);
            this.cmbCodigoAr.Name = "cmbCodigoAr";
            this.cmbCodigoAr.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigoAr.TabIndex = 7;
            // 
            // btnEliminarAr
            // 
            this.btnEliminarAr.Location = new System.Drawing.Point(49, 81);
            this.btnEliminarAr.Name = "btnEliminarAr";
            this.btnEliminarAr.Size = new System.Drawing.Size(139, 31);
            this.btnEliminarAr.TabIndex = 6;
            this.btnEliminarAr.Text = "Eliminar";
            this.btnEliminarAr.UseVisualStyleBackColor = true;
            // 
            // lblCodigo2Ar
            // 
            this.lblCodigo2Ar.AutoSize = true;
            this.lblCodigo2Ar.Location = new System.Drawing.Point(15, 47);
            this.lblCodigo2Ar.Name = "lblCodigo2Ar";
            this.lblCodigo2Ar.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo2Ar.TabIndex = 3;
            this.lblCodigo2Ar.Text = "Código:";
            // 
            // mcrNuevoElementoAr
            // 
            this.mcrNuevoElementoAr.Controls.Add(this.btnAgregarAr);
            this.mcrNuevoElementoAr.Controls.Add(this.txtTramiteAr);
            this.mcrNuevoElementoAr.Controls.Add(this.txtNombreAr);
            this.mcrNuevoElementoAr.Controls.Add(this.txtCodigoAr);
            this.mcrNuevoElementoAr.Controls.Add(this.lblTramiteAr);
            this.mcrNuevoElementoAr.Controls.Add(this.lblNombreAr);
            this.mcrNuevoElementoAr.Controls.Add(this.lblCodigoAr);
            this.mcrNuevoElementoAr.Location = new System.Drawing.Point(242, 12);
            this.mcrNuevoElementoAr.Name = "mcrNuevoElementoAr";
            this.mcrNuevoElementoAr.Size = new System.Drawing.Size(217, 222);
            this.mcrNuevoElementoAr.TabIndex = 14;
            this.mcrNuevoElementoAr.TabStop = false;
            this.mcrNuevoElementoAr.Text = "Nuevo Elemento";
            // 
            // btnAgregarAr
            // 
            this.btnAgregarAr.Location = new System.Drawing.Point(33, 173);
            this.btnAgregarAr.Name = "btnAgregarAr";
            this.btnAgregarAr.Size = new System.Drawing.Size(147, 31);
            this.btnAgregarAr.TabIndex = 6;
            this.btnAgregarAr.Text = "Agregar";
            this.btnAgregarAr.UseVisualStyleBackColor = true;
            // 
            // txtTramiteAr
            // 
            this.txtTramiteAr.Location = new System.Drawing.Point(81, 118);
            this.txtTramiteAr.Name = "txtTramiteAr";
            this.txtTramiteAr.Size = new System.Drawing.Size(100, 20);
            this.txtTramiteAr.TabIndex = 5;
            // 
            // txtNombreAr
            // 
            this.txtNombreAr.Location = new System.Drawing.Point(81, 81);
            this.txtNombreAr.Name = "txtNombreAr";
            this.txtNombreAr.Size = new System.Drawing.Size(100, 20);
            this.txtNombreAr.TabIndex = 4;
            // 
            // txtCodigoAr
            // 
            this.txtCodigoAr.Location = new System.Drawing.Point(81, 44);
            this.txtCodigoAr.Name = "txtCodigoAr";
            this.txtCodigoAr.Size = new System.Drawing.Size(75, 20);
            this.txtCodigoAr.TabIndex = 3;
            // 
            // lblTramiteAr
            // 
            this.lblTramiteAr.AutoSize = true;
            this.lblTramiteAr.Location = new System.Drawing.Point(10, 121);
            this.lblTramiteAr.Name = "lblTramiteAr";
            this.lblTramiteAr.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteAr.TabIndex = 2;
            this.lblTramiteAr.Text = "Trámite:";
            // 
            // lblNombreAr
            // 
            this.lblNombreAr.AutoSize = true;
            this.lblNombreAr.Location = new System.Drawing.Point(10, 84);
            this.lblNombreAr.Name = "lblNombreAr";
            this.lblNombreAr.Size = new System.Drawing.Size(47, 13);
            this.lblNombreAr.TabIndex = 1;
            this.lblNombreAr.Text = "Nombre:";
            // 
            // lblCodigoAr
            // 
            this.lblCodigoAr.AutoSize = true;
            this.lblCodigoAr.Location = new System.Drawing.Point(10, 47);
            this.lblCodigoAr.Name = "lblCodigoAr";
            this.lblCodigoAr.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoAr.TabIndex = 0;
            this.lblCodigoAr.Text = "Código:";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(10, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(223, 221);
            this.treeView1.TabIndex = 18;
            // 
            // rbtnIn
            // 
            this.rbtnIn.AutoSize = true;
            this.rbtnIn.Location = new System.Drawing.Point(22, 56);
            this.rbtnIn.Name = "rbtnIn";
            this.rbtnIn.Size = new System.Drawing.Size(66, 17);
            this.rbtnIn.TabIndex = 19;
            this.rbtnIn.TabStop = true;
            this.rbtnIn.Text = "In-Orden";
            this.rbtnIn.UseVisualStyleBackColor = true;
            // 
            // rbtnPre
            // 
            this.rbtnPre.AutoSize = true;
            this.rbtnPre.Location = new System.Drawing.Point(22, 100);
            this.rbtnPre.Name = "rbtnPre";
            this.rbtnPre.Size = new System.Drawing.Size(73, 17);
            this.rbtnPre.TabIndex = 19;
            this.rbtnPre.TabStop = true;
            this.rbtnPre.Text = "Pre-Orden";
            this.rbtnPre.UseVisualStyleBackColor = true;
            // 
            // rbtnPost
            // 
            this.rbtnPost.AutoSize = true;
            this.rbtnPost.Location = new System.Drawing.Point(22, 144);
            this.rbtnPost.Name = "rbtnPost";
            this.rbtnPost.Size = new System.Drawing.Size(78, 17);
            this.rbtnPost.TabIndex = 19;
            this.rbtnPost.TabStop = true;
            this.rbtnPost.Text = "Post-Orden";
            this.rbtnPost.UseVisualStyleBackColor = true;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(529, 176);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(154, 39);
            this.btnEquilibrar.TabIndex = 19;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.mrcArbolBinario);
            this.Controls.Add(this.mrcElementoAEliminarAr);
            this.Controls.Add(this.mcrNuevoElementoAr);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas - Árbol Binario";
            this.mrcArbolBinario.ResumeLayout(false);
            this.mrcArbolBinario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).EndInit();
            this.mrcElementoAEliminarAr.ResumeLayout(false);
            this.mrcElementoAEliminarAr.PerformLayout();
            this.mcrNuevoElementoAr.ResumeLayout(false);
            this.mcrNuevoElementoAr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox mrcArbolBinario;
        private System.Windows.Forms.DataGridView dgvArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.GroupBox mrcElementoAEliminarAr;
        private System.Windows.Forms.ComboBox cmbCodigoAr;
        private System.Windows.Forms.Button btnEliminarAr;
        private System.Windows.Forms.Label lblCodigo2Ar;
        private System.Windows.Forms.GroupBox mcrNuevoElementoAr;
        private System.Windows.Forms.Button btnAgregarAr;
        private System.Windows.Forms.TextBox txtTramiteAr;
        private System.Windows.Forms.TextBox txtNombreAr;
        private System.Windows.Forms.TextBox txtCodigoAr;
        private System.Windows.Forms.Label lblTramiteAr;
        private System.Windows.Forms.Label lblNombreAr;
        private System.Windows.Forms.Label lblCodigoAr;
        private System.Windows.Forms.RadioButton rbtnPost;
        private System.Windows.Forms.RadioButton rbtnPre;
        private System.Windows.Forms.RadioButton rbtnIn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnEquilibrar;
    }
}
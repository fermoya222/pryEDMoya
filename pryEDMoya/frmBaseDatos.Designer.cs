namespace pryEDMoya
{
    partial class frmBaseDatos
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.mrcSelect = new System.Windows.Forms.GroupBox();
            this.mrcWhere = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPSimple = new System.Windows.Forms.Button();
            this.btnPMultiatributo = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSMultiatributo = new System.Windows.Forms.Button();
            this.btnSSimple = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.mrcSelect.SuspendLayout();
            this.mrcWhere.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 16);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(703, 236);
            this.dgv1.TabIndex = 0;
            // 
            // mrcSelect
            // 
            this.mrcSelect.Controls.Add(this.btnJuntar);
            this.mrcSelect.Controls.Add(this.btnPMultiatributo);
            this.mrcSelect.Controls.Add(this.btnPSimple);
            this.mrcSelect.Location = new System.Drawing.Point(12, 276);
            this.mrcSelect.Name = "mrcSelect";
            this.mrcSelect.Size = new System.Drawing.Size(214, 162);
            this.mrcSelect.TabIndex = 1;
            this.mrcSelect.TabStop = false;
            this.mrcSelect.Text = "Operaciones de Proyeccion - SELECT";
            // 
            // mrcWhere
            // 
            this.mrcWhere.Controls.Add(this.button4);
            this.mrcWhere.Controls.Add(this.btnSMultiatributo);
            this.mrcWhere.Controls.Add(this.btnSSimple);
            this.mrcWhere.Location = new System.Drawing.Point(260, 276);
            this.mrcWhere.Name = "mrcWhere";
            this.mrcWhere.Size = new System.Drawing.Size(214, 162);
            this.mrcWhere.TabIndex = 2;
            this.mrcWhere.TabStop = false;
            this.mrcWhere.Text = "Operaciones de Seleccion - WHERE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnInterseccion);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Location = new System.Drawing.Point(501, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 162);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebraicas";
            // 
            // btnPSimple
            // 
            this.btnPSimple.Location = new System.Drawing.Point(14, 37);
            this.btnPSimple.Name = "btnPSimple";
            this.btnPSimple.Size = new System.Drawing.Size(184, 27);
            this.btnPSimple.TabIndex = 0;
            this.btnPSimple.Text = "Proyeccion simple";
            this.btnPSimple.UseVisualStyleBackColor = true;
            // 
            // btnPMultiatributo
            // 
            this.btnPMultiatributo.Location = new System.Drawing.Point(14, 70);
            this.btnPMultiatributo.Name = "btnPMultiatributo";
            this.btnPMultiatributo.Size = new System.Drawing.Size(184, 27);
            this.btnPMultiatributo.TabIndex = 1;
            this.btnPMultiatributo.Text = "Proyeccion Multiatributo";
            this.btnPMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(14, 103);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(184, 27);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 27);
            this.button4.TabIndex = 5;
            this.button4.Text = "Seleccion por convolucion";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSMultiatributo
            // 
            this.btnSMultiatributo.Location = new System.Drawing.Point(15, 68);
            this.btnSMultiatributo.Name = "btnSMultiatributo";
            this.btnSMultiatributo.Size = new System.Drawing.Size(184, 27);
            this.btnSMultiatributo.TabIndex = 4;
            this.btnSMultiatributo.Text = "Seleccion Multiatributo";
            this.btnSMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnSSimple
            // 
            this.btnSSimple.Location = new System.Drawing.Point(15, 35);
            this.btnSSimple.Name = "btnSSimple";
            this.btnSSimple.Size = new System.Drawing.Size(184, 27);
            this.btnSSimple.TabIndex = 3;
            this.btnSSimple.Text = "Seleccion Simple";
            this.btnSSimple.UseVisualStyleBackColor = true;
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(15, 101);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(184, 27);
            this.btnDiferencia.TabIndex = 5;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(15, 68);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(184, 27);
            this.btnInterseccion.TabIndex = 4;
            this.btnInterseccion.Text = "Intersecccion";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(15, 35);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(184, 27);
            this.btnUnion.TabIndex = 3;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // frmBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.mrcWhere);
            this.Controls.Add(this.mrcSelect);
            this.Controls.Add(this.dgv1);
            this.Name = "frmBaseDatos";
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.mrcSelect.ResumeLayout(false);
            this.mrcWhere.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox mrcSelect;
        private System.Windows.Forms.GroupBox mrcWhere;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnPMultiatributo;
        private System.Windows.Forms.Button btnPSimple;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSMultiatributo;
        private System.Windows.Forms.Button btnSSimple;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}
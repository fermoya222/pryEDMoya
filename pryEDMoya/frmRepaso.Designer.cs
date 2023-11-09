namespace pryEDMoya
{
    partial class frmRepaso
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConsulta = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.lblEnunciado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operacion a realizar en las base de datos:";
            // 
            // cmbConsulta
            // 
            this.cmbConsulta.FormattingEnabled = true;
            this.cmbConsulta.Items.AddRange(new object[] {
            "Diferencia ",
            "Intersecion",
            "Juntar",
            "Proyeccion Simple",
            "Proyeccion Multiatributo",
            "Seleccion Multiatributo con operador AND",
            "Seleccion Multiatributo con operador OR",
            "Seleccion Multiatributo por convulación",
            "Seleccion Simple",
            "Unión"});
            this.cmbConsulta.Location = new System.Drawing.Point(223, 32);
            this.cmbConsulta.Name = "cmbConsulta";
            this.cmbConsulta.Size = new System.Drawing.Size(382, 21);
            this.cmbConsulta.TabIndex = 1;
            this.cmbConsulta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(623, 31);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(92, 21);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 192);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(703, 246);
            this.dgvListado.TabIndex = 4;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(12, 66);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(703, 109);
            this.lblEnunciado.TabIndex = 9;
            // 
            // frmRepaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbConsulta);
            this.Controls.Add(this.label1);
            this.Name = "frmRepaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRepaso";
            this.Load += new System.EventHandler(this.frmRepaso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConsulta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label lblEnunciado;
    }
}
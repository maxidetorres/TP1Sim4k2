namespace TPSIM
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_semilla = new System.Windows.Forms.TextBox();
            this.txt_k = new System.Windows.Forms.TextBox();
            this.txt_g = new System.Windows.Forms.TextBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.cmb_metodo = new System.Windows.Forms.ComboBox();
            this.lbl_semilla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNumeros = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_siguienteNumero = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(102, 26);
            this.txt_semilla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(76, 20);
            this.txt_semilla.TabIndex = 0;
            this.txt_semilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_semilla_KeyPress);
            // 
            // txt_k
            // 
            this.txt_k.Location = new System.Drawing.Point(102, 66);
            this.txt_k.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_k.Name = "txt_k";
            this.txt_k.Size = new System.Drawing.Size(76, 20);
            this.txt_k.TabIndex = 1;
            this.txt_k.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_k_KeyPress);
            // 
            // txt_g
            // 
            this.txt_g.Location = new System.Drawing.Point(102, 106);
            this.txt_g.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_g.Name = "txt_g";
            this.txt_g.Size = new System.Drawing.Size(76, 20);
            this.txt_g.TabIndex = 2;
            this.txt_g.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_g_KeyPress);
            // 
            // btn_generar
            // 
            this.btn_generar.Enabled = false;
            this.btn_generar.Location = new System.Drawing.Point(37, 231);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(61, 23);
            this.btn_generar.TabIndex = 3;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // cmb_metodo
            // 
            this.cmb_metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_metodo.FormattingEnabled = true;
            this.cmb_metodo.Items.AddRange(new object[] {
            "Congruencial Mixto",
            "Congruencial Multiplicativo"});
            this.cmb_metodo.Location = new System.Drawing.Point(102, 139);
            this.cmb_metodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_metodo.Name = "cmb_metodo";
            this.cmb_metodo.Size = new System.Drawing.Size(128, 21);
            this.cmb_metodo.TabIndex = 4;
            this.cmb_metodo.SelectedIndexChanged += new System.EventHandler(this.cmb_metodo_SelectedIndexChanged);
            // 
            // lbl_semilla
            // 
            this.lbl_semilla.AutoSize = true;
            this.lbl_semilla.Location = new System.Drawing.Point(58, 28);
            this.lbl_semilla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_semilla.Name = "lbl_semilla";
            this.lbl_semilla.Size = new System.Drawing.Size(40, 13);
            this.lbl_semilla.TabIndex = 5;
            this.lbl_semilla.Text = "Semilla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Constante k";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Constante g";
            // 
            // txt_c
            // 
            this.txt_c.Enabled = false;
            this.txt_c.Location = new System.Drawing.Point(102, 167);
            this.txt_c.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(76, 20);
            this.txt_c.TabIndex = 8;
            this.txt_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_c_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Constante c";
            // 
            // dgvNumeros
            // 
            this.dgvNumeros.AllowUserToAddRows = false;
            this.dgvNumeros.AllowUserToDeleteRows = false;
            this.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.numero});
            this.dgvNumeros.Location = new System.Drawing.Point(261, 17);
            this.dgvNumeros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNumeros.Name = "dgvNumeros";
            this.dgvNumeros.RowHeadersVisible = false;
            this.dgvNumeros.RowHeadersWidth = 51;
            this.dgvNumeros.RowTemplate.Height = 24;
            this.dgvNumeros.Size = new System.Drawing.Size(180, 305);
            this.dgvNumeros.TabIndex = 10;
            // 
            // iteracion
            // 
            this.iteracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iteracion.HeaderText = "Iteración";
            this.iteracion.MinimumWidth = 6;
            this.iteracion.Name = "iteracion";
            this.iteracion.Width = 73;
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.numero.HeaderText = "Numero";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.Width = 69;
            // 
            // btn_siguienteNumero
            // 
            this.btn_siguienteNumero.Enabled = false;
            this.btn_siguienteNumero.Location = new System.Drawing.Point(122, 231);
            this.btn_siguienteNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_siguienteNumero.Name = "btn_siguienteNumero";
            this.btn_siguienteNumero.Size = new System.Drawing.Size(106, 23);
            this.btn_siguienteNumero.TabIndex = 11;
            this.btn_siguienteNumero.Text = "Siguiente numero";
            this.btn_siguienteNumero.UseVisualStyleBackColor = true;
            this.btn_siguienteNumero.Click += new System.EventHandler(this.btn_siguienteNumero_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_semilla);
            this.groupBox1.Controls.Add(this.btn_siguienteNumero);
            this.groupBox1.Controls.Add(this.txt_k);
            this.groupBox1.Controls.Add(this.dgvNumeros);
            this.groupBox1.Controls.Add(this.txt_g);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_generar);
            this.groupBox1.Controls.Add(this.txt_c);
            this.groupBox1.Controls.Add(this.cmb_metodo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_semilla);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(453, 334);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Punto a)";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(92, 278);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 27);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Limpiar todo";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Metodo";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 609);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Principal";
            this.Text = "Generador de Números Aleatorios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_semilla;
        private System.Windows.Forms.TextBox txt_k;
        private System.Windows.Forms.TextBox txt_g;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.ComboBox cmb_metodo;
        private System.Windows.Forms.Label lbl_semilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.Button btn_siguienteNumero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_clear;
    }
}


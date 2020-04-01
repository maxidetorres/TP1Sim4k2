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
            this.rdb_Cong_Mixto = new System.Windows.Forms.RadioButton();
            this.rdb_Cong_Multiplicativo = new System.Windows.Forms.RadioButton();
            this.dataNumeros = new System.Windows.Forms.DataGridView();
            this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_divisor = new System.Windows.Forms.TextBox();
            this.txt_sumatorio = new System.Windows.Forms.TextBox();
            this.txt_multiplicativo = new System.Windows.Forms.TextBox();
            this.txt_semilla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tam_muestra = new System.Windows.Forms.TextBox();
            this.lbl_tamuestra = new System.Windows.Forms.Label();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb_Cong_Mixto
            // 
            this.rdb_Cong_Mixto.AutoSize = true;
            this.rdb_Cong_Mixto.Location = new System.Drawing.Point(13, 27);
            this.rdb_Cong_Mixto.Name = "rdb_Cong_Mixto";
            this.rdb_Cong_Mixto.Size = new System.Drawing.Size(111, 17);
            this.rdb_Cong_Mixto.TabIndex = 0;
            this.rdb_Cong_Mixto.TabStop = true;
            this.rdb_Cong_Mixto.Text = "Congruelcial Mixto";
            this.rdb_Cong_Mixto.UseVisualStyleBackColor = true;
            // 
            // rdb_Cong_Multiplicativo
            // 
            this.rdb_Cong_Multiplicativo.AutoSize = true;
            this.rdb_Cong_Multiplicativo.Location = new System.Drawing.Point(13, 50);
            this.rdb_Cong_Multiplicativo.Name = "rdb_Cong_Multiplicativo";
            this.rdb_Cong_Multiplicativo.Size = new System.Drawing.Size(147, 17);
            this.rdb_Cong_Multiplicativo.TabIndex = 1;
            this.rdb_Cong_Multiplicativo.TabStop = true;
            this.rdb_Cong_Multiplicativo.Text = "Congruelcial Multiplicativo";
            this.rdb_Cong_Multiplicativo.UseVisualStyleBackColor = true;
            // 
            // dataNumeros
            // 
            this.dataNumeros.AllowUserToAddRows = false;
            this.dataNumeros.AllowUserToDeleteRows = false;
            this.dataNumeros.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicion,
            this.numero});
            this.dataNumeros.Location = new System.Drawing.Point(207, 11);
            this.dataNumeros.Margin = new System.Windows.Forms.Padding(2);
            this.dataNumeros.Name = "dataNumeros";
            this.dataNumeros.ReadOnly = true;
            this.dataNumeros.RowHeadersVisible = false;
            this.dataNumeros.RowTemplate.Height = 28;
            this.dataNumeros.Size = new System.Drawing.Size(164, 173);
            this.dataNumeros.TabIndex = 5;
            // 
            // posicion
            // 
            this.posicion.FillWeight = 80F;
            this.posicion.HeaderText = "Posicion";
            this.posicion.Name = "posicion";
            this.posicion.ReadOnly = true;
            this.posicion.Width = 80;
            // 
            // numero
            // 
            this.numero.FillWeight = 80F;
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 80;
            // 
            // txt_divisor
            // 
            this.txt_divisor.Location = new System.Drawing.Point(90, 163);
            this.txt_divisor.Margin = new System.Windows.Forms.Padding(2);
            this.txt_divisor.Name = "txt_divisor";
            this.txt_divisor.Size = new System.Drawing.Size(84, 20);
            this.txt_divisor.TabIndex = 13;
            // 
            // txt_sumatorio
            // 
            this.txt_sumatorio.Location = new System.Drawing.Point(90, 137);
            this.txt_sumatorio.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sumatorio.Name = "txt_sumatorio";
            this.txt_sumatorio.Size = new System.Drawing.Size(84, 20);
            this.txt_sumatorio.TabIndex = 12;
            // 
            // txt_multiplicativo
            // 
            this.txt_multiplicativo.Location = new System.Drawing.Point(90, 112);
            this.txt_multiplicativo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_multiplicativo.Name = "txt_multiplicativo";
            this.txt_multiplicativo.Size = new System.Drawing.Size(84, 20);
            this.txt_multiplicativo.TabIndex = 11;
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(90, 85);
            this.txt_semilla.Margin = new System.Windows.Forms.Padding(2);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(84, 20);
            this.txt_semilla.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Divisor M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sumatorio C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Multiplicativo A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Semilla";
            // 
            // txt_tam_muestra
            // 
            this.txt_tam_muestra.Location = new System.Drawing.Point(90, 211);
            this.txt_tam_muestra.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tam_muestra.Name = "txt_tam_muestra";
            this.txt_tam_muestra.Size = new System.Drawing.Size(83, 20);
            this.txt_tam_muestra.TabIndex = 15;
            // 
            // lbl_tamuestra
            // 
            this.lbl_tamuestra.AutoSize = true;
            this.lbl_tamuestra.Location = new System.Drawing.Point(6, 214);
            this.lbl_tamuestra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tamuestra.Name = "lbl_tamuestra";
            this.lbl_tamuestra.Size = new System.Drawing.Size(86, 13);
            this.lbl_tamuestra.TabIndex = 14;
            this.lbl_tamuestra.Text = "Tamaño muestra";
            // 
            // btn_proximo
            // 
            this.btn_proximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proximo.Location = new System.Drawing.Point(87, 248);
            this.btn_proximo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(65, 30);
            this.btn_proximo.TabIndex = 17;
            this.btn_proximo.Text = "Proximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generar.Location = new System.Drawing.Point(9, 248);
            this.btn_generar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(65, 31);
            this.btn_generar.TabIndex = 16;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 561);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.txt_tam_muestra);
            this.Controls.Add(this.lbl_tamuestra);
            this.Controls.Add(this.txt_divisor);
            this.Controls.Add(this.txt_sumatorio);
            this.Controls.Add(this.txt_multiplicativo);
            this.Controls.Add(this.txt_semilla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataNumeros);
            this.Controls.Add(this.rdb_Cong_Multiplicativo);
            this.Controls.Add(this.rdb_Cong_Mixto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.Text = "Ventana";
            ((System.ComponentModel.ISupportInitialize)(this.dataNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_Cong_Mixto;
        private System.Windows.Forms.RadioButton rdb_Cong_Multiplicativo;
        private System.Windows.Forms.DataGridView dataNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.TextBox txt_divisor;
        private System.Windows.Forms.TextBox txt_sumatorio;
        private System.Windows.Forms.TextBox txt_multiplicativo;
        private System.Windows.Forms.TextBox txt_semilla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tam_muestra;
        private System.Windows.Forms.Label lbl_tamuestra;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_generar;
    }
}


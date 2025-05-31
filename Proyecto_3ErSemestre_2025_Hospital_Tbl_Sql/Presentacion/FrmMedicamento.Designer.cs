namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Presentacion
{
    partial class FrmMedicamento
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
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnagregar = new FontAwesome.Sharp.IconButton();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxtipomed = new System.Windows.Forms.ComboBox();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.CboxEstado = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblCodHab = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTituloFecha = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.dgvmedicamentos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnsalir.IconColor = System.Drawing.Color.Black;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.Location = new System.Drawing.Point(1483, 816);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(176, 54);
            this.btnsalir.TabIndex = 52;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.Location = new System.Drawing.Point(1284, 816);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(176, 54);
            this.btneliminar.TabIndex = 51;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboxtipomed);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMedicamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtpFechaVencimiento);
            this.groupBox1.Controls.Add(this.CboxEstado);
            this.groupBox1.Controls.Add(this.LblEstado);
            this.groupBox1.Controls.Add(this.LblFechaNacimiento);
            this.groupBox1.Controls.Add(this.LblCodHab);
            this.groupBox1.Location = new System.Drawing.Point(23, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1666, 361);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.btnagregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnagregar.IconColor = System.Drawing.Color.Black;
            this.btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregar.Location = new System.Drawing.Point(1460, 41);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(176, 54);
            this.btnagregar.TabIndex = 45;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(390, 224);
            this.txtStock.Margin = new System.Windows.Forms.Padding(6);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(266, 31);
            this.txtStock.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 43;
            this.label1.Text = "Stock:";
            // 
            // cboxtipomed
            // 
            this.cboxtipomed.FormattingEnabled = true;
            this.cboxtipomed.Items.AddRange(new object[] {
            "Jarabe",
            "Suero",
            "Crema",
            "Tableta",
            "Inyeccion"});
            this.cboxtipomed.Location = new System.Drawing.Point(390, 106);
            this.cboxtipomed.Margin = new System.Windows.Forms.Padding(6);
            this.cboxtipomed.Name = "cboxtipomed";
            this.cboxtipomed.Size = new System.Drawing.Size(266, 33);
            this.cboxtipomed.TabIndex = 42;
            this.cboxtipomed.SelectedIndexChanged += new System.EventHandler(this.cboxtipomed_SelectedIndexChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btncancelar.IconColor = System.Drawing.Color.Black;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.Location = new System.Drawing.Point(1460, 192);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(176, 54);
            this.btncancelar.TabIndex = 41;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btneditar.IconColor = System.Drawing.Color.Black;
            this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneditar.Location = new System.Drawing.Point(1460, 119);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(176, 54);
            this.btneditar.TabIndex = 40;
            this.btneditar.Text = "Editar";
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(390, 158);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(6);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(266, 31);
            this.txtCosto.TabIndex = 37;
            this.txtCosto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 37);
            this.label4.TabIndex = 36;
            this.label4.Text = "Costo:";
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Location = new System.Drawing.Point(380, 53);
            this.txtMedicamento.Margin = new System.Windows.Forms.Padding(6);
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.ReadOnly = true;
            this.txtMedicamento.Size = new System.Drawing.Size(264, 31);
            this.txtMedicamento.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tipo Medicamento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DtpFechaVencimiento
            // 
            this.DtpFechaVencimiento.Location = new System.Drawing.Point(1114, 54);
            this.DtpFechaVencimiento.Margin = new System.Windows.Forms.Padding(6);
            this.DtpFechaVencimiento.Name = "DtpFechaVencimiento";
            this.DtpFechaVencimiento.Size = new System.Drawing.Size(264, 31);
            this.DtpFechaVencimiento.TabIndex = 7;
            this.DtpFechaVencimiento.ValueChanged += new System.EventHandler(this.DtpFechaVencimiento_ValueChanged);
            // 
            // CboxEstado
            // 
            this.CboxEstado.FormattingEnabled = true;
            this.CboxEstado.Items.AddRange(new object[] {
            "Estable",
            "Critico",
            "Observacion",
            "Aislamiento",
            "Fallecido"});
            this.CboxEstado.Location = new System.Drawing.Point(1117, 106);
            this.CboxEstado.Margin = new System.Windows.Forms.Padding(6);
            this.CboxEstado.Name = "CboxEstado";
            this.CboxEstado.Size = new System.Drawing.Size(266, 33);
            this.CboxEstado.TabIndex = 6;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(695, 108);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(143, 37);
            this.LblEstado.TabIndex = 4;
            this.LblEstado.Text = "Estado: ";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(688, 48);
            this.LblFechaNacimiento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(318, 37);
            this.LblFechaNacimiento.TabIndex = 2;
            this.LblFechaNacimiento.Text = "Fecha Vencimiento:";
            // 
            // LblCodHab
            // 
            this.LblCodHab.AutoSize = true;
            this.LblCodHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodHab.Location = new System.Drawing.Point(21, 41);
            this.LblCodHab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCodHab.Name = "LblCodHab";
            this.LblCodHab.Size = new System.Drawing.Size(347, 37);
            this.LblCodHab.TabIndex = 1;
            this.LblCodHab.Text = "Codigo Medicamento:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(1435, 59);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(224, 36);
            this.lblFecha.TabIndex = 49;
            this.lblFecha.Text = "Imprimir Fecha";
            // 
            // lblTituloFecha
            // 
            this.lblTituloFecha.AutoSize = true;
            this.lblTituloFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFecha.Location = new System.Drawing.Point(1295, 59);
            this.lblTituloFecha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTituloFecha.Name = "lblTituloFecha";
            this.lblTituloFecha.Size = new System.Drawing.Size(111, 36);
            this.lblTituloFecha.TabIndex = 48;
            this.lblTituloFecha.Text = "Fecha:";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.Location = new System.Drawing.Point(713, 47);
            this.lblHabitaciones.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(280, 44);
            this.lblHabitaciones.TabIndex = 47;
            this.lblHabitaciones.Text = "Medicamentos";
            this.lblHabitaciones.Click += new System.EventHandler(this.lblHabitaciones_Click);
            // 
            // dgvmedicamentos
            // 
            this.dgvmedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmedicamentos.Location = new System.Drawing.Point(23, 480);
            this.dgvmedicamentos.Margin = new System.Windows.Forms.Padding(6);
            this.dgvmedicamentos.Name = "dgvmedicamentos";
            this.dgvmedicamentos.RowHeadersWidth = 82;
            this.dgvmedicamentos.Size = new System.Drawing.Size(1666, 327);
            this.dgvmedicamentos.TabIndex = 46;
            this.dgvmedicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmedicamentos_CellClick);
            // 
            // FrmMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 972);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTituloFecha);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.dgvmedicamentos);
            this.Name = "FrmMedicamento";
            this.Text = "FrmMedicamento";
            this.Load += new System.EventHandler(this.FrmMedicamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btneditar;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaVencimiento;
        private System.Windows.Forms.ComboBox CboxEstado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblCodHab;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTituloFecha;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.DataGridView dgvmedicamentos;
        private System.Windows.Forms.ComboBox cboxtipomed;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnagregar;
    }
}
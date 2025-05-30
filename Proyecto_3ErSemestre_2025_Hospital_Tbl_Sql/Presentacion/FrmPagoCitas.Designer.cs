namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.presentacion
{
    partial class FrmPagoCitas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxcodigocita = new System.Windows.Forms.ComboBox();
            this.txttotalpago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.txtmontocita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblCodHab = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTituloFecha = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.dgvpagocitas = new System.Windows.Forms.DataGridView();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.btnagregar = new FontAwesome.Sharp.IconButton();
            this.txtimpuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxtipopago = new System.Windows.Forms.ComboBox();
            this.lblsa = new System.Windows.Forms.Label();
            this.DtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpagocitas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpFechaPago);
            this.groupBox1.Controls.Add(this.cboxtipopago);
            this.groupBox1.Controls.Add(this.lblsa);
            this.groupBox1.Controls.Add(this.txtimpuesto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboxcodigocita);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.txttotalpago);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCodigoPago);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdescuento);
            this.groupBox1.Controls.Add(this.txtmontocita);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblEstado);
            this.groupBox1.Controls.Add(this.LblCodHab);
            this.groupBox1.Location = new System.Drawing.Point(90, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1666, 361);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // cboxcodigocita
            // 
            this.cboxcodigocita.FormattingEnabled = true;
            this.cboxcodigocita.Location = new System.Drawing.Point(364, 123);
            this.cboxcodigocita.Margin = new System.Windows.Forms.Padding(6);
            this.cboxcodigocita.Name = "cboxcodigocita";
            this.cboxcodigocita.Size = new System.Drawing.Size(266, 33);
            this.cboxcodigocita.TabIndex = 42;
            // 
            // txttotalpago
            // 
            this.txttotalpago.Location = new System.Drawing.Point(1035, 126);
            this.txttotalpago.Margin = new System.Windows.Forms.Padding(6);
            this.txttotalpago.Name = "txttotalpago";
            this.txttotalpago.Size = new System.Drawing.Size(266, 31);
            this.txttotalpago.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 37);
            this.label4.TabIndex = 36;
            this.label4.Text = "Total Pago:";
            // 
            // txtCodigoPago
            // 
            this.txtCodigoPago.Location = new System.Drawing.Point(366, 68);
            this.txtCodigoPago.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigoPago.Name = "txtCodigoPago";
            this.txtCodigoPago.ReadOnly = true;
            this.txtCodigoPago.Size = new System.Drawing.Size(264, 31);
            this.txtCodigoPago.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Codigo Cita:";
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(1035, 72);
            this.txtdescuento.Margin = new System.Windows.Forms.Padding(6);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(266, 31);
            this.txtdescuento.TabIndex = 32;
            // 
            // txtmontocita
            // 
            this.txtmontocita.Location = new System.Drawing.Point(364, 185);
            this.txtmontocita.Margin = new System.Windows.Forms.Padding(6);
            this.txtmontocita.Name = "txtmontocita";
            this.txtmontocita.Size = new System.Drawing.Size(266, 31);
            this.txtmontocita.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 37);
            this.label3.TabIndex = 30;
            this.label3.Text = "Monto Cita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(691, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "Descuento:";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(690, 192);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(210, 37);
            this.LblEstado.TabIndex = 4;
            this.LblEstado.Text = "Fecha Pago:";
            // 
            // LblCodHab
            // 
            this.LblCodHab.AutoSize = true;
            this.LblCodHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodHab.Location = new System.Drawing.Point(20, 62);
            this.LblCodHab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCodHab.Name = "LblCodHab";
            this.LblCodHab.Size = new System.Drawing.Size(234, 37);
            this.LblCodHab.TabIndex = 1;
            this.LblCodHab.Text = "Codigo Pago: ";
            this.LblCodHab.Click += new System.EventHandler(this.LblCodHab_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(1502, 94);
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
            this.lblTituloFecha.Location = new System.Drawing.Point(1362, 94);
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
            this.lblHabitaciones.Location = new System.Drawing.Point(780, 82);
            this.lblHabitaciones.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(214, 44);
            this.lblHabitaciones.TabIndex = 47;
            this.lblHabitaciones.Text = "Pago Citas";
            // 
            // dgvpagocitas
            // 
            this.dgvpagocitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpagocitas.Location = new System.Drawing.Point(90, 515);
            this.dgvpagocitas.Margin = new System.Windows.Forms.Padding(6);
            this.dgvpagocitas.Name = "dgvpagocitas";
            this.dgvpagocitas.RowHeadersWidth = 82;
            this.dgvpagocitas.Size = new System.Drawing.Size(1666, 327);
            this.dgvpagocitas.TabIndex = 46;
            this.dgvpagocitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpagocitas_CellClick);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnsalir.IconColor = System.Drawing.Color.Black;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.Location = new System.Drawing.Point(1550, 851);
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
            this.btneliminar.Location = new System.Drawing.Point(1351, 851);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(176, 54);
            this.btneliminar.TabIndex = 51;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
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
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.btnagregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnagregar.IconColor = System.Drawing.Color.Black;
            this.btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregar.Location = new System.Drawing.Point(1460, 41);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(176, 54);
            this.btnagregar.TabIndex = 39;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtimpuesto
            // 
            this.txtimpuesto.Location = new System.Drawing.Point(366, 244);
            this.txtimpuesto.Margin = new System.Windows.Forms.Padding(6);
            this.txtimpuesto.Name = "txtimpuesto";
            this.txtimpuesto.Size = new System.Drawing.Size(266, 31);
            this.txtimpuesto.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 37);
            this.label5.TabIndex = 43;
            this.label5.Text = "Impuesto:";
            // 
            // cboxtipopago
            // 
            this.cboxtipopago.FormattingEnabled = true;
            this.cboxtipopago.Items.AddRange(new object[] {
            "Efectivo",
            "Transferencia",
            "Tarjeta"});
            this.cboxtipopago.Location = new System.Drawing.Point(1035, 246);
            this.cboxtipopago.Margin = new System.Windows.Forms.Padding(6);
            this.cboxtipopago.Name = "cboxtipopago";
            this.cboxtipopago.Size = new System.Drawing.Size(266, 33);
            this.cboxtipopago.TabIndex = 46;
            // 
            // lblsa
            // 
            this.lblsa.AutoSize = true;
            this.lblsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsa.Location = new System.Drawing.Point(696, 244);
            this.lblsa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblsa.Name = "lblsa";
            this.lblsa.Size = new System.Drawing.Size(183, 37);
            this.lblsa.TabIndex = 45;
            this.lblsa.Text = "Tipo Pago:";
            // 
            // DtpFechaPago
            // 
            this.DtpFechaPago.Location = new System.Drawing.Point(1037, 192);
            this.DtpFechaPago.Margin = new System.Windows.Forms.Padding(6);
            this.DtpFechaPago.Name = "DtpFechaPago";
            this.DtpFechaPago.Size = new System.Drawing.Size(264, 31);
            this.DtpFechaPago.TabIndex = 47;
            // 
            // FrmPagoCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1846, 986);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTituloFecha);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.dgvpagocitas);
            this.Name = "FrmPagoCitas";
            this.Text = "FrmPagoCitas";
            this.Load += new System.EventHandler(this.FrmPagoCitas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpagocitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxcodigocita;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btnagregar;
        private System.Windows.Forms.TextBox txttotalpago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.TextBox txtmontocita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblCodHab;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTituloFecha;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.DataGridView dgvpagocitas;
        private System.Windows.Forms.ComboBox cboxtipopago;
        private System.Windows.Forms.Label lblsa;
        private System.Windows.Forms.TextBox txtimpuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpFechaPago;
    }
}
namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.presentacion
{
    partial class FrmPEmpleados
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
            this.lblmonto = new System.Windows.Forms.Label();
            this.txtmontohoras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.CboxEstado = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblTipoPaciente = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblCodHab = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTituloFecha = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.dgvpagoempleados = new System.Windows.Forms.DataGridView();
            this.cboxcodigoempleado = new System.Windows.Forms.ComboBox();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.btnagregar = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpagoempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxcodigoempleado);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.lblmonto);
            this.groupBox1.Controls.Add(this.txtmontohoras);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCodigoPago);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBono);
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtpFechaPago);
            this.groupBox1.Controls.Add(this.CboxEstado);
            this.groupBox1.Controls.Add(this.LblEstado);
            this.groupBox1.Controls.Add(this.LblTipoPaciente);
            this.groupBox1.Controls.Add(this.LblFechaNacimiento);
            this.groupBox1.Controls.Add(this.LblCodHab);
            this.groupBox1.Location = new System.Drawing.Point(166, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1666, 361);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // lblmonto
            // 
            this.lblmonto.AutoSize = true;
            this.lblmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonto.Location = new System.Drawing.Point(1105, 119);
            this.lblmonto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(332, 37);
            this.lblmonto.TabIndex = 38;
            this.lblmonto.Text = "Imprimir Total Monto";
            this.lblmonto.Click += new System.EventHandler(this.lblmonto_Click);
            // 
            // txtmontohoras
            // 
            this.txtmontohoras.Location = new System.Drawing.Point(364, 306);
            this.txtmontohoras.Margin = new System.Windows.Forms.Padding(6);
            this.txtmontohoras.Name = "txtmontohoras";
            this.txtmontohoras.Size = new System.Drawing.Size(266, 31);
            this.txtmontohoras.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 37);
            this.label4.TabIndex = 36;
            this.label4.Text = "Monto Horas:";
            // 
            // txtCodigoPago
            // 
            this.txtCodigoPago.Location = new System.Drawing.Point(364, 119);
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
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Codigo Empleado: ";
            // 
            // txtBono
            // 
            this.txtBono.Location = new System.Drawing.Point(364, 252);
            this.txtBono.Margin = new System.Windows.Forms.Padding(6);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(266, 31);
            this.txtBono.TabIndex = 32;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(364, 185);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(6);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(266, 31);
            this.txtSueldo.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sueldo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "Bono:";
            // 
            // DtpFechaPago
            // 
            this.DtpFechaPago.Location = new System.Drawing.Point(1114, 54);
            this.DtpFechaPago.Margin = new System.Windows.Forms.Padding(6);
            this.DtpFechaPago.Name = "DtpFechaPago";
            this.DtpFechaPago.Size = new System.Drawing.Size(264, 31);
            this.DtpFechaPago.TabIndex = 7;
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
            this.CboxEstado.Location = new System.Drawing.Point(1112, 190);
            this.CboxEstado.Margin = new System.Windows.Forms.Padding(6);
            this.CboxEstado.Name = "CboxEstado";
            this.CboxEstado.Size = new System.Drawing.Size(266, 33);
            this.CboxEstado.TabIndex = 6;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(690, 192);
            this.LblEstado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(143, 37);
            this.LblEstado.TabIndex = 4;
            this.LblEstado.Text = "Estado: ";
            // 
            // LblTipoPaciente
            // 
            this.LblTipoPaciente.AutoSize = true;
            this.LblTipoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoPaciente.Location = new System.Drawing.Point(688, 125);
            this.LblTipoPaciente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblTipoPaciente.Name = "LblTipoPaciente";
            this.LblTipoPaciente.Size = new System.Drawing.Size(208, 37);
            this.LblTipoPaciente.TabIndex = 3;
            this.LblTipoPaciente.Text = "Total Monto:";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(688, 48);
            this.LblFechaNacimiento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(210, 37);
            this.LblFechaNacimiento.TabIndex = 2;
            this.LblFechaNacimiento.Text = "Fecha Pago:";
            // 
            // LblCodHab
            // 
            this.LblCodHab.AutoSize = true;
            this.LblCodHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodHab.Location = new System.Drawing.Point(18, 119);
            this.LblCodHab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCodHab.Name = "LblCodHab";
            this.LblCodHab.Size = new System.Drawing.Size(234, 37);
            this.LblCodHab.TabIndex = 1;
            this.LblCodHab.Text = "Codigo Pago: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(1578, 125);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(224, 36);
            this.lblFecha.TabIndex = 42;
            this.lblFecha.Text = "Imprimir Fecha";
            // 
            // lblTituloFecha
            // 
            this.lblTituloFecha.AutoSize = true;
            this.lblTituloFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFecha.Location = new System.Drawing.Point(1438, 125);
            this.lblTituloFecha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTituloFecha.Name = "lblTituloFecha";
            this.lblTituloFecha.Size = new System.Drawing.Size(111, 36);
            this.lblTituloFecha.TabIndex = 41;
            this.lblTituloFecha.Text = "Fecha:";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.Location = new System.Drawing.Point(856, 113);
            this.lblHabitaciones.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(322, 44);
            this.lblHabitaciones.TabIndex = 40;
            this.lblHabitaciones.Text = "Pago Empleados";
            // 
            // dgvpagoempleados
            // 
            this.dgvpagoempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpagoempleados.Location = new System.Drawing.Point(166, 546);
            this.dgvpagoempleados.Margin = new System.Windows.Forms.Padding(6);
            this.dgvpagoempleados.Name = "dgvpagoempleados";
            this.dgvpagoempleados.RowHeadersWidth = 82;
            this.dgvpagoempleados.Size = new System.Drawing.Size(1666, 327);
            this.dgvpagoempleados.TabIndex = 39;
            this.dgvpagoempleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpagoempleados_CellClick);
            // 
            // cboxcodigoempleado
            // 
            this.cboxcodigoempleado.FormattingEnabled = true;
            this.cboxcodigoempleado.Location = new System.Drawing.Point(364, 62);
            this.cboxcodigoempleado.Margin = new System.Windows.Forms.Padding(6);
            this.cboxcodigoempleado.Name = "cboxcodigoempleado";
            this.cboxcodigoempleado.Size = new System.Drawing.Size(266, 33);
            this.cboxcodigoempleado.TabIndex = 42;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnsalir.IconColor = System.Drawing.Color.Black;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.Location = new System.Drawing.Point(1626, 882);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(176, 54);
            this.btnsalir.TabIndex = 45;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click_1);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.Location = new System.Drawing.Point(1427, 882);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(176, 54);
            this.btneliminar.TabIndex = 44;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
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
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click_1);
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
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click_1);
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
            // FrmPEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2191, 999);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTituloFecha);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.dgvpagoempleados);
            this.Name = "FrmPEmpleados";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmPEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpagoempleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaPago;
        private System.Windows.Forms.ComboBox CboxEstado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblTipoPaciente;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblCodHab;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTituloFecha;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.DataGridView dgvpagoempleados;
        private System.Windows.Forms.Label lblmonto;
        private System.Windows.Forms.TextBox txtmontohoras;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnagregar;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.ComboBox cboxcodigoempleado;
    }
}
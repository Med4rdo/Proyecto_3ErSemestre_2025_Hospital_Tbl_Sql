namespace Proyecto3er_SEMESTRE_Hospital_2025
{
    partial class FrmPacientes
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
            this.LblCodHab = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.LblTipoPaciente = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.CboxTipoPaciente = new System.Windows.Forms.ComboBox();
            this.CboxEstado = new System.Windows.Forms.ComboBox();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.DgvPacientes = new System.Windows.Forms.DataGridView();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTituloFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxCodHabitacion = new System.Windows.Forms.ComboBox();
            this.txtCodigoPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCodHab
            // 
            this.LblCodHab.AutoSize = true;
            this.LblCodHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodHab.Location = new System.Drawing.Point(9, 62);
            this.LblCodHab.Name = "LblCodHab";
            this.LblCodHab.Size = new System.Drawing.Size(166, 20);
            this.LblCodHab.TabIndex = 1;
            this.LblCodHab.Text = "Codigo Habitación: ";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacimiento.Location = new System.Drawing.Point(344, 25);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(186, 20);
            this.LblFechaNacimiento.TabIndex = 2;
            this.LblFechaNacimiento.Text = "Fecha de nacimiento: ";
            // 
            // LblTipoPaciente
            // 
            this.LblTipoPaciente.AutoSize = true;
            this.LblTipoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoPaciente.Location = new System.Drawing.Point(344, 65);
            this.LblTipoPaciente.Name = "LblTipoPaciente";
            this.LblTipoPaciente.Size = new System.Drawing.Size(152, 20);
            this.LblTipoPaciente.TabIndex = 3;
            this.LblTipoPaciente.Text = "Tipo de paciente :";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(345, 100);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(76, 20);
            this.LblEstado.TabIndex = 4;
            this.LblEstado.Text = "Estado: ";
            // 
            // CboxTipoPaciente
            // 
            this.CboxTipoPaciente.FormattingEnabled = true;
            this.CboxTipoPaciente.Items.AddRange(new object[] {
            "Cita",
            "Emergencia",
            "Quirurgicos",
            "Infeccioso",
            "Terminal"});
            this.CboxTipoPaciente.Location = new System.Drawing.Point(556, 61);
            this.CboxTipoPaciente.Name = "CboxTipoPaciente";
            this.CboxTipoPaciente.Size = new System.Drawing.Size(135, 21);
            this.CboxTipoPaciente.TabIndex = 5;
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
            this.CboxEstado.Location = new System.Drawing.Point(556, 99);
            this.CboxEstado.Name = "CboxEstado";
            this.CboxEstado.Size = new System.Drawing.Size(135, 21);
            this.CboxEstado.TabIndex = 6;
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(557, 28);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(134, 20);
            this.DtpFechaNacimiento.TabIndex = 7;
            // 
            // DgvPacientes
            // 
            this.DgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPacientes.Location = new System.Drawing.Point(7, 232);
            this.DgvPacientes.Name = "DgvPacientes";
            this.DgvPacientes.ReadOnly = true;
            this.DgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPacientes.Size = new System.Drawing.Size(833, 170);
            this.DgvPacientes.TabIndex = 8;
            this.DgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPacientes_CellClick);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.Black;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btncancelar.IconColor = System.Drawing.Color.Black;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.IconSize = 25;
            this.btncancelar.Location = new System.Drawing.Point(709, 120);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(118, 39);
            this.btncancelar.TabIndex = 27;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.ForeColor = System.Drawing.Color.Black;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btneditar.IconColor = System.Drawing.Color.Black;
            this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneditar.IconSize = 25;
            this.btneditar.Location = new System.Drawing.Point(709, 76);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(118, 39);
            this.btneditar.TabIndex = 26;
            this.btneditar.Text = "Editar";
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(709, 31);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 39);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "NIT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(182, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 20);
            this.txtNombre.TabIndex = 31;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(182, 131);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(135, 20);
            this.txtNit.TabIndex = 32;
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.Black;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.Bomb;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 25;
            this.btneliminar.Location = new System.Drawing.Point(598, 420);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(118, 39);
            this.btneliminar.TabIndex = 34;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnsalir.IconColor = System.Drawing.Color.Black;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.IconSize = 25;
            this.btnsalir.Location = new System.Drawing.Point(732, 420);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(91, 39);
            this.btnsalir.TabIndex = 33;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.Location = new System.Drawing.Point(352, 7);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(101, 24);
            this.lblHabitaciones.TabIndex = 35;
            this.lblHabitaciones.Text = "Pacientes";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(713, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(120, 18);
            this.lblFecha.TabIndex = 37;
            this.lblFecha.Text = "Imprimir Fecha";
            // 
            // lblTituloFecha
            // 
            this.lblTituloFecha.AutoSize = true;
            this.lblTituloFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFecha.Location = new System.Drawing.Point(643, 13);
            this.lblTituloFecha.Name = "lblTituloFecha";
            this.lblTituloFecha.Size = new System.Drawing.Size(59, 18);
            this.lblTituloFecha.TabIndex = 36;
            this.lblTituloFecha.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxCodHabitacion);
            this.groupBox1.Controls.Add(this.txtCodigoPaciente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNit);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btneditar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.DtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.CboxEstado);
            this.groupBox1.Controls.Add(this.CboxTipoPaciente);
            this.groupBox1.Controls.Add(this.LblEstado);
            this.groupBox1.Controls.Add(this.LblTipoPaciente);
            this.groupBox1.Controls.Add(this.LblFechaNacimiento);
            this.groupBox1.Controls.Add(this.LblCodHab);
            this.groupBox1.Location = new System.Drawing.Point(7, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 175);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // cboxCodHabitacion
            // 
            this.cboxCodHabitacion.FormattingEnabled = true;
            this.cboxCodHabitacion.Location = new System.Drawing.Point(182, 64);
            this.cboxCodHabitacion.Name = "cboxCodHabitacion";
            this.cboxCodHabitacion.Size = new System.Drawing.Size(135, 21);
            this.cboxCodHabitacion.TabIndex = 36;
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.Location = new System.Drawing.Point(181, 31);
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.ReadOnly = true;
            this.txtCodigoPaciente.Size = new System.Drawing.Size(134, 20);
            this.txtCodigoPaciente.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Codigo Paciente: ";
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTituloFecha);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.DgvPacientes);
            this.Name = "FrmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.frm_Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodHab;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.Label LblTipoPaciente;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.ComboBox CboxTipoPaciente;
        private System.Windows.Forms.ComboBox CboxEstado;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.DataGridView DgvPacientes;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNit;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTituloFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxCodHabitacion;
    }
}
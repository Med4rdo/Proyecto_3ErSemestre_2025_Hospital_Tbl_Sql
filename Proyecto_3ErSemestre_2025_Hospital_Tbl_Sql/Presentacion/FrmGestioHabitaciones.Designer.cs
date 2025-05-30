namespace Proyecto3er_SEMESTRE_Hospital_2025
{
    partial class FrmGestioHabitaciones
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
            this.LblImprimirCodHab = new System.Windows.Forms.Label();
            this.DgvGestionHabitacion = new System.Windows.Forms.DataGridView();
            this.DtFechaGestion = new System.Windows.Forms.DateTimePicker();
            this.CboxEstado = new System.Windows.Forms.ComboBox();
            this.CboxTipoPaciente = new System.Windows.Forms.ComboBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblTipoGestion = new System.Windows.Forms.Label();
            this.LblFechaGestion = new System.Windows.Forms.Label();
            this.LblCodHab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCodEmpleado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGestionHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // LblImprimirCodHab
            // 
            this.LblImprimirCodHab.AutoSize = true;
            this.LblImprimirCodHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImprimirCodHab.Location = new System.Drawing.Point(263, 57);
            this.LblImprimirCodHab.Name = "LblImprimirCodHab";
            this.LblImprimirCodHab.Size = new System.Drawing.Size(164, 20);
            this.LblImprimirCodHab.TabIndex = 18;
            this.LblImprimirCodHab.Text = "Imprimir Habitación";
            // 
            // DgvGestionHabitacion
            // 
            this.DgvGestionHabitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvGestionHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGestionHabitacion.Location = new System.Drawing.Point(23, 222);
            this.DgvGestionHabitacion.Name = "DgvGestionHabitacion";
            this.DgvGestionHabitacion.ReadOnly = true;
            this.DgvGestionHabitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGestionHabitacion.Size = new System.Drawing.Size(589, 187);
            this.DgvGestionHabitacion.TabIndex = 17;
            // 
            // DtFechaGestion
            // 
            this.DtFechaGestion.Location = new System.Drawing.Point(267, 138);
            this.DtFechaGestion.Name = "DtFechaGestion";
            this.DtFechaGestion.Size = new System.Drawing.Size(160, 20);
            this.DtFechaGestion.TabIndex = 16;
            // 
            // CboxEstado
            // 
            this.CboxEstado.FormattingEnabled = true;
            this.CboxEstado.Items.AddRange(new object[] {
            "Creada",
            "Pendiente",
            "Progreso",
            "Completa",
            "Cancelada"});
            this.CboxEstado.Location = new System.Drawing.Point(267, 179);
            this.CboxEstado.Name = "CboxEstado";
            this.CboxEstado.Size = new System.Drawing.Size(161, 21);
            this.CboxEstado.TabIndex = 15;
            // 
            // CboxTipoPaciente
            // 
            this.CboxTipoPaciente.FormattingEnabled = true;
            this.CboxTipoPaciente.Items.AddRange(new object[] {
            "Preparacion",
            "Limpieza",
            "Observacion",
            "Alimentacion"});
            this.CboxTipoPaciente.Location = new System.Drawing.Point(267, 92);
            this.CboxTipoPaciente.Name = "CboxTipoPaciente";
            this.CboxTipoPaciente.Size = new System.Drawing.Size(161, 21);
            this.CboxTipoPaciente.TabIndex = 14;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(54, 177);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(76, 20);
            this.LblEstado.TabIndex = 13;
            this.LblEstado.Text = "Estado: ";
            // 
            // LblTipoGestion
            // 
            this.LblTipoGestion.AutoSize = true;
            this.LblTipoGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoGestion.Location = new System.Drawing.Point(54, 93);
            this.LblTipoGestion.Name = "LblTipoGestion";
            this.LblTipoGestion.Size = new System.Drawing.Size(137, 20);
            this.LblTipoGestion.TabIndex = 12;
            this.LblTipoGestion.Text = "Tipo de gestion:";
            // 
            // LblFechaGestion
            // 
            this.LblFechaGestion.AutoSize = true;
            this.LblFechaGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaGestion.Location = new System.Drawing.Point(54, 135);
            this.LblFechaGestion.Name = "LblFechaGestion";
            this.LblFechaGestion.Size = new System.Drawing.Size(186, 20);
            this.LblFechaGestion.TabIndex = 11;
            this.LblFechaGestion.Text = "Fecha de nacimiento: ";
            // 
            // LblCodHab
            // 
            this.LblCodHab.AutoSize = true;
            this.LblCodHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodHab.Location = new System.Drawing.Point(54, 57);
            this.LblCodHab.Name = "LblCodHab";
            this.LblCodHab.Size = new System.Drawing.Size(166, 20);
            this.LblCodHab.TabIndex = 10;
            this.LblCodHab.Text = "Codigo Habitación: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Imprimir Empleado";
            // 
            // LblCodEmpleado
            // 
            this.LblCodEmpleado.AutoSize = true;
            this.LblCodEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodEmpleado.Location = new System.Drawing.Point(54, 13);
            this.LblCodEmpleado.Name = "LblCodEmpleado";
            this.LblCodEmpleado.Size = new System.Drawing.Size(155, 20);
            this.LblCodEmpleado.TabIndex = 19;
            this.LblCodEmpleado.Text = "Codigo Empleado ";
            // 
            // tbl_GestioHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblCodEmpleado);
            this.Controls.Add(this.LblImprimirCodHab);
            this.Controls.Add(this.DgvGestionHabitacion);
            this.Controls.Add(this.DtFechaGestion);
            this.Controls.Add(this.CboxEstado);
            this.Controls.Add(this.CboxTipoPaciente);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblTipoGestion);
            this.Controls.Add(this.LblFechaGestion);
            this.Controls.Add(this.LblCodHab);
            this.Name = "tbl_GestioHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestio De Habitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.DgvGestionHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblImprimirCodHab;
        private System.Windows.Forms.DataGridView DgvGestionHabitacion;
        private System.Windows.Forms.DateTimePicker DtFechaGestion;
        private System.Windows.Forms.ComboBox CboxEstado;
        private System.Windows.Forms.ComboBox CboxTipoPaciente;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblTipoGestion;
        private System.Windows.Forms.Label LblFechaGestion;
        private System.Windows.Forms.Label LblCodHab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCodEmpleado;
    }
}
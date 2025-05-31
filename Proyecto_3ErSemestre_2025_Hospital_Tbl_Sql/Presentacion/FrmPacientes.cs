using Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Datos;
using Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3er_SEMESTRE_Hospital_2025
{
    public partial class FrmPacientes : Form
    {

        CDpacientes CapDatPacientes = new CDpacientes();
        ClaseFechas CapDatFecha = new ClaseFechas();
        public FrmPacientes()
        {
            InitializeComponent();
        }

        // Metodo que imprime la lista de citas en el combobox
        private void MtdMostrarListaCitas()
        {
            var ListaHabitacion = CapDatPacientes.MtdListaHabitacion();

            foreach (var Habitacion in ListaHabitacion)
            {
                cboxCodHabitacion.Items.Add(Habitacion);
            }

            cboxCodHabitacion.DisplayMember = "Text";
            cboxCodHabitacion.ValueMember = "Value";
        }

        private void frm_Pacientes_Load(object sender, EventArgs e)
        {
            lblFecha.Text = CapDatFecha.MtdFechaHoy().ToString("d");
            MtdMostrarListaCitas();
            MtdConsultarPacientes();
        }

        private void MtdConsultarPacientes()
        {

            DataTable Dt = CapDatPacientes.MtdConsultarPacientes();
            DgvPacientes.DataSource = Dt;

        }



        private void MtdLimpiaCampos()
        {
            txtCodigoPaciente.Text = "";
            cboxCodHabitacion.Text = "";
            txtNombre.Text = "";
            txtNit.Text = "";
            DtpFechaNacimiento.Text = "";
            CboxTipoPaciente.Text = "";
            CboxEstado.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cboxCodHabitacion.Text) || string.IsNullOrEmpty(txtNombre.Text) 
                || string.IsNullOrEmpty(txtNit.Text) || string.IsNullOrEmpty(DtpFechaNacimiento.Text) || string.IsNullOrEmpty(CboxEstado.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var SelectedHabitacion = (dynamic)cboxCodHabitacion.SelectedItem;
                int CodigoHabitacion = (int)SelectedHabitacion.Value;

                string Nombres = (txtNombre.Text);
                string Nit = txtNit.Text;
                DateTime FechaNacimiento = DtpFechaNacimiento.Value;
                string TipoPaciente = CboxTipoPaciente.Text;
                string Estado = CboxEstado.Text;
                DateTime FechaAuditoria = CapDatFecha.MtdFechaHoy();
                string UsuarioAuditoria = "Oscar";

                try
                {
                    CapDatPacientes.MtdAgregarPacientes(CodigoHabitacion, Nombres, Nit, FechaNacimiento, TipoPaciente, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPacientes();
                    MtdLimpiaCampos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }


        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCodigoPaciente.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNit.Text) || string.IsNullOrEmpty(DtpFechaNacimiento.Text)
            || string.IsNullOrEmpty(CboxEstado.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoPacientes = int.Parse(txtCodigoPaciente.Text);
                string Nombres = (txtNombre.Text);
                string Nit = txtNit.Text;
                DateTime FechaNacimiento = DtpFechaNacimiento.Value;
                string TipoPaciente = CboxTipoPaciente.Text;
                string Estado = CboxEstado.Text;
                DateTime FechaAuditoria = CapDatFecha.MtdFechaHoy();
                string UsuarioAuditoria = "Oscar";

                try
                {
                    CapDatPacientes.MtdEditarPacientes(CodigoPacientes, Nombres, Nit, FechaNacimiento, TipoPaciente, Estado, UsuarioAuditoria, FechaAuditoria);
                    MessageBox.Show("Datos Editado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPacientes();
                    MtdLimpiaCampos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiaCampos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCodigoPaciente.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHabitacion = int.Parse(txtCodigoPaciente.Text);

                try
                {
                    CapDatPacientes.MtdEliminarPacientes(CodigoHabitacion);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPacientes();
                    MtdLimpiaCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var FilaSeleccionada = DgvPacientes.SelectedRows[0];

            if (FilaSeleccionada.Index == DgvPacientes.Rows.Count - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoPaciente.Text = DgvPacientes.SelectedCells[0].Value.ToString();
                cboxCodHabitacion.Text = DgvPacientes.SelectedCells[1].Value.ToString();
                txtNombre.Text = DgvPacientes.SelectedCells[2].Value.ToString();
                txtNit.Text = DgvPacientes.SelectedCells[3].Value.ToString();
                DtpFechaNacimiento.Text = DgvPacientes.SelectedCells[4].Value.ToString();
                CboxTipoPaciente.Text = DgvPacientes.SelectedCells[5].Value.ToString();
                CboxEstado.Text = DgvPacientes.SelectedCells[6].Value.ToString();
            }


        }
    }
}

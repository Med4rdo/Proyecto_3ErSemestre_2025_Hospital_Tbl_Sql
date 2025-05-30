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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto3er_SEMESTRE_Hospital_2025
{
    public partial class Frm_Habitaciones : Form
    {
        CLhabitaciones CapLogHab = new CLhabitaciones();
        CDhabitaciones CapDatHab = new CDhabitaciones();

        public Frm_Habitaciones()
        {
            InitializeComponent();
        }

        private void cboxTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblCostoHabitacion.Text = CapLogHab.MtdCostoHabitacion(cboxTipoHabitacion.Text).ToString("c");
        }

        private void tbl_Habitaciones_Load(object sender, EventArgs e)
        {
            lblFecha.Text = CapLogHab.MtdFechaHoy().ToString("d");
            MtdConsultarhabitaciones();
        }

        private void MtdConsultarhabitaciones()
        {

            DataTable Dthabitaciones = CapDatHab.MtdConsultarHabitaciones();
            DgvHabitaciones.DataSource = Dthabitaciones;

        }

        public void MtdLimpiaCampos()
        {
            txtCodigoHabitacion.Text = "";
            txtNumero.Text = "";
            txtUbicacion.Text = "";
            cboxTipoHabitacion.Text = "";
            LblCostoHabitacion.Text = "";
            CboxEstado.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text)|| string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(cboxTipoHabitacion.Text) || string.IsNullOrEmpty(CboxEstado.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string Numero = (txtNumero.Text);
                string Ubicacion = txtUbicacion.Text;
                string TipoHabitacion = cboxTipoHabitacion.Text;
                double Costo = CapLogHab.MtdCostoHabitacion(cboxTipoHabitacion.Text);
                string Estado = CboxEstado.Text;
                DateTime FechaAuditoria = CapLogHab.MtdFechaHoy();
                string UsuarioAuditoria = "Oscar";

                try
                {
                    CapDatHab.MtdAgregarHabitaciones(Numero, Ubicacion, TipoHabitacion,Costo, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarhabitaciones();
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

            if (string.IsNullOrEmpty(txtCodigoHabitacion.Text) || string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(cboxTipoHabitacion.Text) || string.IsNullOrEmpty(CboxEstado.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHabitacion = int.Parse(txtCodigoHabitacion.Text);
                string Numero = (txtNumero.Text);
                string Ubicacion = txtUbicacion.Text;
                string TipoHabitacion = cboxTipoHabitacion.Text;
                double Costo = CapLogHab.MtdCostoHabitacion(cboxTipoHabitacion.Text);
                string Estado = CboxEstado.Text;
                DateTime FechaAuditoria = CapLogHab.MtdFechaHoy();
                string UsuarioAuditoria = "Oscar";

                try
                {
                    CapDatHab.MtdEditarHabitaciones(CodigoHabitacion, Numero, Ubicacion, TipoHabitacion, Costo, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarhabitaciones();
                    MtdLimpiaCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void DgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var FilaSeleccionada = DgvHabitaciones.SelectedRows[0];

            if (FilaSeleccionada.Index == DgvHabitaciones.Rows.Count - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoHabitacion.Text = DgvHabitaciones.SelectedCells[0].Value.ToString();
                txtNumero.Text = DgvHabitaciones.SelectedCells[1].Value.ToString();
                txtUbicacion.Text = DgvHabitaciones.SelectedCells[2].Value.ToString();
                cboxTipoHabitacion.Text = DgvHabitaciones.SelectedCells[3].Value.ToString();
                LblCostoHabitacion.Text = DgvHabitaciones.SelectedCells[4].Value.ToString();
                CboxEstado.Text = DgvHabitaciones.SelectedCells[5].Value.ToString();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiaCampos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCodigoHabitacion.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHabitacion = int.Parse(txtCodigoHabitacion.Text);

                try
                {
                    CapDatHab.MtdEliminarHabitaciones(CodigoHabitacion);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarhabitaciones();
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
    }
}

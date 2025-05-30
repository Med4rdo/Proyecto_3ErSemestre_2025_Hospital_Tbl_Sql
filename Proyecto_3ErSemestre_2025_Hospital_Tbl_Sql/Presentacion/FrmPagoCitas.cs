using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.datos;
using Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Logica;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.presentacion
{
    public partial class FrmPagoCitas : Form
    {
        CLPagoCitas CapLogPC = new CLPagoCitas();
        CDPagoCitas CapDatPC = new CDPagoCitas();
        ClaseFechas CapFechas = new ClaseFechas();
        public FrmPagoCitas()
        {
            InitializeComponent();
        }

        public void MtdLimpiarCampos()
        {
            txtCodigoPago.Text = "";
            cboxcodigocita.Text = "";
            txtmontocita.Text = "";
            txtimpuesto.Text = "";
            txtdescuento.Text = "";
            txttotalpago.Text = "";
            cboxtipopago.Text = "";

        }

        private void LblCodHab_Click(object sender, EventArgs e)
        {

        }

        private void MtdConsultarPagoEmpleados()
        {

            DataTable DtPagocitas = CapDatPC.MtdConsultarPagoCitas();
            dgvpagocitas.DataSource = DtPagocitas;

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmontocita.Text) || string.IsNullOrEmpty(txtimpuesto.Text) || string.IsNullOrEmpty(txtdescuento.Text) || string.IsNullOrEmpty(txttotalpago.Text) || string.IsNullOrEmpty(cboxtipopago.Text))
            {
                {
                    MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                double MontoCita = double.Parse(txtmontocita.Text);
                double Impuesto = double.Parse(txtimpuesto.Text);
                double Descuento = double.Parse(txtdescuento.Text);
                double TotalPago = double.Parse(txttotalpago.Text);
                string TipoPago = cboxtipopago.Text;
                DateTime FechaAuditoria = CapFechas.MtdFechaHoy();
                DateTime FechaPago = DtpFechaPago.Value;
                string UsuarioAuditoria = "Josue";

                try
                {
                    CapDatPC.MtdAgregar(FechaPago, MontoCita, Impuesto, Descuento, TotalPago, TipoPago, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagoEmpleados();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void FrmPagoCitas_Load(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmontocita.Text) || string.IsNullOrEmpty(txtimpuesto.Text) || string.IsNullOrEmpty(txtdescuento.Text) || string.IsNullOrEmpty(txttotalpago.Text) || string.IsNullOrEmpty(cboxtipopago.Text))
            {
                {
                    MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                double MontoCita = double.Parse(txtmontocita.Text);
                double Impuesto = double.Parse(txtimpuesto.Text);
                double Descuento = double.Parse(txtdescuento.Text);
                double TotalPago = double.Parse(txttotalpago.Text);
                string TipoPago = cboxtipopago.Text;
                DateTime FechaAuditoria = CapFechas.MtdFechaHoy();
                DateTime FechaPago = DtpFechaPago.Value;
                string UsuarioAuditoria = "Josue";

                try
                {
                    CapDatPC.MtdEditar(FechaPago, MontoCita, Impuesto, Descuento, TotalPago, TipoPago, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagoEmpleados();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCodigoPago.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHabitacion = int.Parse(txtCodigoPago.Text);

                try
                {
                    CapDatPC.MtdEliminar(CodigoHabitacion);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagoEmpleados();
                    MtdLimpiarCampos();
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

        private void dgvpagocitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvpagocitas.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvpagocitas.Rows.Count - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoPago.Text = dgvpagocitas.SelectedCells[0].Value.ToString();
                cboxcodigocita.Text = dgvpagocitas.SelectedCells[1].Value.ToString();
                txtmontocita.Text = dgvpagocitas.SelectedCells[2].Value.ToString();
                txtimpuesto.Text = dgvpagocitas.SelectedCells[3].Value.ToString();
                txtdescuento.Text = dgvpagocitas.SelectedCells[4].Value.ToString();
                txttotalpago.Text = dgvpagocitas.SelectedCells[5].Value.ToString();
                DtpFechaPago.Text = dgvpagocitas.SelectedCells[6].Value.ToString();
                cboxtipopago.Text = dgvpagocitas.SelectedCells[7].Value.ToString();

            }
        }
    }
}

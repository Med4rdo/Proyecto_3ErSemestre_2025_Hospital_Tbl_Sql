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
using Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Datos;
using Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Logica;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Presentacion
{
    public partial class FrmMedicamento : Form
    {
        CLMedicamentos CapLogMedicamentos = new CLMedicamentos();
        CDMedicamentos CapDatMedicamentos = new CDMedicamentos();
        ClaseFechas ClaseFechas = new ClaseFechas();
        public FrmMedicamento()
        {
            InitializeComponent();
        }

        private void lblHabitaciones_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {



        }

        private void MtdConsultarMedicamentos()
        {

            DataTable Dthabitaciones = CapDatMedicamentos.MtdConsultar();
            dgvmedicamentos.DataSource = Dthabitaciones;

        }

        private void MtdLimpiarCampos()
        {
            cboxtipomed.Text = "";
            txtCosto.Text = "";
            txtStock.Text = "";
            CboxEstado.Text = "";
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxtipomed.Text) || string.IsNullOrEmpty(CboxEstado.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string TipoMed = cboxtipomed.Text;
                string Estado = CboxEstado.Text;
                DateTime FechaAuditoria = ClaseFechas.MtdFechaHoy();
                DateTime FechaVencimiento = DtpFechaVencimiento.Value;
                string UsuarioAuditoria = "Josue";
                double Costo = CapLogMedicamentos.MtdCostoMedicamentos(cboxtipomed.Text);
                string Nombre = cboxtipomed.Text;
                int Stock = int.Parse(txtStock.Text);

                try
                {
                    CapDatMedicamentos.MtdAgregar(FechaVencimiento, TipoMed, Costo, Estado, Nombre, Stock, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarMedicamentos();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxtipomed.Text) || string.IsNullOrEmpty(CboxEstado.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string TipoMed = cboxtipomed.Text;
                string Estado = CboxEstado.Text;
                DateTime FechaAuditoria = ClaseFechas.MtdFechaHoy();
                DateTime FechaVencimiento = DtpFechaVencimiento.Value;
                string UsuarioAuditoria = "Josue";
                double Costo = CapLogMedicamentos.MtdCostoMedicamentos(cboxtipomed.Text);
                string Nombre = cboxtipomed.Text;
                int Stock = int.Parse(txtStock.Text);

                try
                {
                    CapDatMedicamentos.MtdEditar(FechaVencimiento, TipoMed, Costo, Estado, Nombre, Stock, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarMedicamentos();
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMedicamento.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHabitacion = int.Parse(txtMedicamento.Text);

                try
                {
                    CapDatMedicamentos.MtdEliminar(CodigoHabitacion);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarMedicamentos();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMedicamento_Load(object sender, EventArgs e)
        {
            MtdConsultarMedicamentos();
            lblFecha.Text = ClaseFechas.MtdFechaHoy().ToString("d");
        }

        private void dgvpagoempleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvmedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvmedicamentos.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvmedicamentos.Rows.Count - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtMedicamento.Text = dgvmedicamentos.SelectedCells[0].Value.ToString();
                cboxtipomed.Text = dgvmedicamentos.SelectedCells[1].Value.ToString();
                cboxtipomed.Text = dgvmedicamentos.SelectedCells[2].Value.ToString();
                txtCosto.Text = dgvmedicamentos.SelectedCells[3].Value.ToString();
                txtStock.Text = dgvmedicamentos.SelectedCells[4].Value.ToString();
                DtpFechaVencimiento.Text = dgvmedicamentos.SelectedCells[5].Value.ToString();
                CboxEstado.Text = dgvmedicamentos.SelectedCells[6].Value.ToString();

            }
        }

        private void cboxtipomed_SelectedIndexChanged(object sender, EventArgs e)
        {
            double costo = CapLogMedicamentos.MtdCostoMedicamentos(cboxtipomed.Text);

            txtCosto.Text = costo.ToString();
        }

        private void DtpFechaVencimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

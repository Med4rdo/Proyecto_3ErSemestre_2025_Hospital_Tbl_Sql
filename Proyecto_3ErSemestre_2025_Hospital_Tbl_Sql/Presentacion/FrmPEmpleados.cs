using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.datos;
using Proyecto3er_SEMESTRE_Hospital_2025;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.presentacion
{
    public partial class FrmPEmpleados : Form
    {
        CLPagoEmpleados CapLogPE = new CLPagoEmpleados();
        CDPagoEmpleados CapDatPE = new CDPagoEmpleados();

        public FrmPEmpleados()
        {
            InitializeComponent();
        }

        private void MtdConsultarPagoEmpleados()
        {

            DataTable Dthabitaciones = CapDatPE.MtdConsultarPagoEmpleados();
            dgvpagoempleados.DataSource = Dthabitaciones;

        }

        public void MtdLimpiaCampos()
        {
            cboxcodigoempleado.Text = "";
            txtSueldo.Text = "";
            txtBono.Text = "";
            txtmontohoras.Text = "";
            lblFecha.Text = "";
            CboxEstado.Text = "";
            txtCodigoPago.Text = "";
            lblmonto.Text = "";
        }

        private void btneditar_Click(object sender, EventArgs e)
        {




        }

        private void MtdListaPagoE()
        {

 
        }

        private void DgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MtdLimpiaCampos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {




        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void FrmPEmpleados_Load(object sender, EventArgs e)
        {
            lblFecha.Text = CapLogPE.MtdFechaHoy().ToString("d");
            MtdConsultarPagoEmpleados();
            MtdMostrarListaEmpleados();


        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBono.Text) || string.IsNullOrEmpty(txtSueldo.Text) || string.IsNullOrEmpty(txtmontohoras.Text) || string.IsNullOrEmpty(CboxEstado.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                double Bono = double.Parse(txtBono.Text);
                double Sueldo = double.Parse(txtSueldo.Text);
                double MontoHorasE = double.Parse(txtmontohoras.Text);
                string Estado = CboxEstado.Text;
                DateTime FechaAuditoria = CapLogPE.MtdFechaHoy();
                DateTime FechaPago = DtpFechaPago.Value;
                double TM = double.Parse(lblmonto.Text);
                string UsuarioAuditoria = "Josue";

                try
                {
                    CapDatPE.MtdAgregar(FechaPago, Sueldo, Bono, MontoHorasE, Estado, FechaAuditoria, UsuarioAuditoria, TM);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagoEmpleados();
                    MtdLimpiaCampos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btneditar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBono.Text) || string.IsNullOrEmpty(txtSueldo.Text) || string.IsNullOrEmpty(txtmontohoras.Text) || string.IsNullOrEmpty(CboxEstado.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                double Bono = double.Parse(txtBono.Text);
                double Sueldo = double.Parse(txtSueldo.Text);
                double MontoHorasE = double.Parse(txtmontohoras.Text);
                string Estado = CboxEstado.Text;
                DateTime FechaAuditoria = CapLogPE.MtdFechaHoy();
                DateTime FechaPago = DtpFechaPago.Value;
                double TM = double.Parse(lblmonto.Text);
                string UsuarioAuditoria = "Josue";

                try
                {
                    CapDatPE.MtdEditarPagoEmpleados(FechaPago, Sueldo, Bono, MontoHorasE, Estado, FechaAuditoria, UsuarioAuditoria, TM);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagoEmpleados();
                    MtdLimpiaCampos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            MtdLimpiaCampos();
        }

        private void dgvpagoempleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvpagoempleados.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvpagoempleados.Rows.Count - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cboxcodigoempleado.Text = dgvpagoempleados.SelectedCells[0].Value.ToString();
                txtCodigoPago.Text = dgvpagoempleados.SelectedCells[1].Value.ToString();
                DtpFechaPago.Text = dgvpagoempleados.SelectedCells[2].Value.ToString();
                txtSueldo.Text = dgvpagoempleados.SelectedCells[3].Value.ToString();
                txtBono.Text = dgvpagoempleados.SelectedCells[4].Value.ToString();
                txtmontohoras.Text = dgvpagoempleados.SelectedCells[5].Value.ToString();
                lblmonto.Text = dgvpagoempleados.SelectedCells[6].Value.ToString();
                CboxEstado.Text = dgvpagoempleados.SelectedCells[7].Value.ToString();
                txtmontohoras.Text = dgvpagoempleados.SelectedCells[5].Value.ToString();

            }
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
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
                    CapDatPE.MtdEliminarPagoEmpleados(CodigoHabitacion);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPagoEmpleados();
                    MtdLimpiaCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void lblmonto_Click(object sender, EventArgs e)
        {
            double sueldo = double.Parse(txtSueldo.Text);
            double montohorase = double.Parse(txtmontohoras.Text);
            double bono = CapLogPE.MtdSueldoBono(sueldo);
            double tm = CapLogPE.MtdTotalMonto(sueldo, bono, montohorase);


            lblmonto.Text = tm.ToString("c");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        private void MtdMostrarListaEmpleados()
        {
            var ListaEmpleados = CapDatPE.MtdListaEmpleados();

            foreach (var Empleados in ListaEmpleados)
            {
                cboxcodigoempleado.Items.Add(Empleados);
            }

            cboxcodigoempleado.DisplayMember = "Text";
            cboxcodigoempleado.ValueMember = "Value";
        }

        private void DtpFechaPago_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

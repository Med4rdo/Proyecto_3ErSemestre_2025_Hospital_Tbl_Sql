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

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql
{
    public partial class FrmUsuarios : Form
    {
        ClaseFechas CapLogFechas = new ClaseFechas();
        CDusuarios CapDatUsuarios = new CDusuarios();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            lblFecha.Text = CapLogFechas.MtdFechaHoy().ToString("d");
            MtdConsultarUsuarios();
        }

        private void MtdConsultarUsuarios()
        {

            DataTable Dthabitaciones = CapDatUsuarios.MtdConsultarPagoEmpleados();
            dgvUsuarios.DataSource = Dthabitaciones;

        }

        private void LblCodHab_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void MtdLimpiaCampos()
        {
            txtusuario.Text = "";
            txtclave.Text = "";
            txtcodusu.Text = "";
            txttusu.Text = "";
            cboxempleado.Text = "";
            CboxEstado.Text = "";
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtclave.Text) || string.IsNullOrEmpty(txttusu.Text) || string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(CboxEstado.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Clave = txtclave.Text;
                string Usuario = txtusuario.Text;
                string TipoUsuario = txttusu.Text;
                string Estado = CboxEstado.Text;
                DateTime FechaAuditoria = CapLogFechas.MtdFechaHoy();
                string UsuarioAuditoria = "Josue";

                try
                {
                    CapDatUsuarios.MtdAgregarUsuarios(Usuario, Clave, TipoUsuario, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuarios();
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
            if (string.IsNullOrEmpty(txtclave.Text) || string.IsNullOrEmpty(txttusu.Text) || string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(CboxEstado.Text))
            {
                MessageBox.Show("Favor completar formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Clave = txtclave.Text;
                string Usuario = txtusuario.Text;
                string TipoUsuario = txttusu.Text;
                string Estado = CboxEstado.Text;
                DateTime FechaAuditoria = CapLogFechas.MtdFechaHoy();
                string UsuarioAuditoria = "Josue";

                try
                {
                    CapDatUsuarios.MtdEditarUsuarios(Usuario, Clave, TipoUsuario, Estado, FechaAuditoria, UsuarioAuditoria);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuarios();
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvUsuarios.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvUsuarios.Rows.Count - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtcodusu.Text = dgvUsuarios.SelectedCells[0].Value.ToString();
                cboxempleado.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
                txtusuario.Text = dgvUsuarios.SelectedCells[2].Value.ToString();
                txtclave.Text = dgvUsuarios.SelectedCells[3].Value.ToString();
                txtusuario.Text = dgvUsuarios.SelectedCells[4].Value.ToString();
                CboxEstado.Text = dgvUsuarios.SelectedCells[5].Value.ToString();


            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodusu.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoUsuario = int.Parse(txtcodusu.Text);

                try
                {
                    CapDatUsuarios.MtdEliminarUsuarios(CodigoUsuario);
                    MessageBox.Show("Dato eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuarios();
                    MtdLimpiaCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

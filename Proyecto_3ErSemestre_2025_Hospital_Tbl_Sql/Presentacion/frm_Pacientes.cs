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
    public partial class frm_Pacientes : Form
    {
        //    CLhabitaciones CapLogHab = new CLhabitaciones(); queda pendiente
        CDpacientes CapDatPacientes = new CDpacientes();
        public frm_Pacientes()
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
            MtdMostrarListaCitas();
        }
    }
}

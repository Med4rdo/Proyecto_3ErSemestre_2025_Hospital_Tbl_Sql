using Proyecto3er_SEMESTRE_Hospital_2025;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Datos
{
    internal class CDgestionhabitaciones
    {
        CDconexion CapDatConexiones = new CDconexion();

        // Metdo que envia a llmar cbox empleados
        public List<dynamic> MtdListaEmpleados()
        {
            List<dynamic> Listaempleados = new List<dynamic>();
            string QueryListaEmpleados = "select codigoEmpleados , Nombres from  tbl_empleados";
            SqlCommand cmd = new SqlCommand(QueryListaEmpleados, CapDatConexiones.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Listaempleados.Add(new
                {
                    Value = reader["CodigoHabitacion"],
                    Text = $"{reader["CodigoHabitacion"]} - {reader["TipoHabitacion"]}"
                });
            }

            CapDatConexiones.MtdCerrarConexion();
            return Listaempleados;
        }



        // Metdo que envia a llmar cbox Habitacion
        public List<dynamic> MtdListaHabitacion()
        {
            List<dynamic> ListaHabitaciones = new List<dynamic>();
            string QueryListaHabitaciones = "select  CodigoHabitacion, TipoHabitacion from tbl_Habitaciones";
            SqlCommand cmd = new SqlCommand(QueryListaHabitaciones, CapDatConexiones.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaHabitaciones.Add(new
                {
                    Value = reader["CodigoHabitacion"],
                    Text = $"{reader["CodigoHabitacion"]} - {reader["TipoHabitacion"]}"
                });
            }

            CapDatConexiones.MtdCerrarConexion();
            return ListaHabitaciones;
        }


        // Consulta tratamientos en la base de datos para cargar en el DataGridView
        public DataTable MtdConsultarPacientes()
        {
            string QueryConsultar = "Select * from tbl_GestionHabitacion";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, CapDatConexiones.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            CapDatConexiones.MtdCerrarConexion();
            return Dt;
        }





    }
}

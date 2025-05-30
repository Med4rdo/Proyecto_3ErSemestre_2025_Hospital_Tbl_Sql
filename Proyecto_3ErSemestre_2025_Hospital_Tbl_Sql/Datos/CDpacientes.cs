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
    public class CDpacientes
    {
        CDconexion CapDatConexiones = new CDconexion();

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
            string QueryConsultar = "Select * from tbl_Pacientes";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, CapDatConexiones.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            CapDatConexiones.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarPacientes(string Nombres, string nit, DateTime FechaNacimiento , string TipoPaciente, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregar = "Insert into tbl_Pacientes (Nombres, nit, FechaNacimiento, TipoPaciente, Estado, UsuarioAuditoria, FechaAuditoria) values (@Nombres, @nit, @FechaNacimiento, @TipoPaciente, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombres", Nombres);
            cmd.Parameters.AddWithValue("@nit", nit);
            cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            cmd.Parameters.AddWithValue("@TipoPaciente", TipoPaciente);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public void MtdEditarPacientes(int CodigoPacientes, string Nombres, string nit, DateTime FechaNacimiento, string TipoPaciente, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryEditar = "Update tbl_Pacientes set Numero=@Numero, Ubicacion=@Ubicacion, TipoHabitacion=@TipoHabitacion, Costo=@Costo, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand cmd = new SqlCommand(QueryEditar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPacientes", CodigoPacientes);
            cmd.Parameters.AddWithValue("@Nombres", Nombres);
            cmd.Parameters.AddWithValue("@nit", nit);
            cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            cmd.Parameters.AddWithValue("@TipoPaciente", TipoPaciente);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public void MtdEliminarPacientes(int CodigoPacientes)
        {
            string QueryEliminar = "Delete from tbl_Pacientes where CodigoPacientes=@CodigoPacientes";
            SqlCommand cmd = new SqlCommand(QueryEliminar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPacientes", CodigoPacientes);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }











    }
}

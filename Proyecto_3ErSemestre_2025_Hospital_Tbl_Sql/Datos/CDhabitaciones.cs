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
    public class CDhabitaciones
    {

        CDconexion CapDatConexiones = new CDconexion();

        // Consulta tratamientos en la base de datos para cargar en el DataGridView
        public DataTable MtdConsultarHabitaciones()
        {
            string QueryConsultar = "Select * from tbl_Habitaciones";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, CapDatConexiones.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            CapDatConexiones.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarHabitaciones(string Numero, string Ubicacion, string TipoHabitacion, double Costo, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregar = "Insert into tbl_Habitaciones (Numero, Ubicacion, TipoHabitacion, Costo, Estado, FechaAuditoria, UsuarioAuditoria) values (@Numero, @Ubicacion, @TipoHabitacion, @costo, @Estado, @FechaAuditoria, @UsuarioAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@TipoHabitacion", TipoHabitacion);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public void MtdEditarHabitaciones(int CodigoHabitacion, string Numero, string Ubicacion, string TipoHabitacion, double Costo, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryEditar = "Update tbl_Habitaciones set Numero=@Numero, Ubicacion=@Ubicacion, TipoHabitacion=@TipoHabitacion, Costo=@Costo, Estado=@Estado, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand cmd = new SqlCommand(QueryEditar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@TipoHabitacion", TipoHabitacion);
            cmd.Parameters.AddWithValue("@Costo", Costo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public void MtdEliminarHabitaciones(int CodigoHabitacion)
        {
            string QueryEliminar = "Delete from tbl_Habitaciones where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand cmd = new SqlCommand(QueryEliminar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }






    }
}

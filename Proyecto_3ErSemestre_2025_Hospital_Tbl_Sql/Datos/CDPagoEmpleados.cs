using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto3er_SEMESTRE_Hospital_2025;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.datos
{ //hola mundo
    internal class CDPagoEmpleados
    {

        CDconexion CapDatConexiones = new CDconexion();

        public DataTable MtdConsultarPagoEmpleados()
        {
            string QueryConsultar = "Select * from tbl_PagoEmpleados";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, CapDatConexiones.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            CapDatConexiones.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregar(DateTime FechaPago, double Sueldo, double Bn, double Mh, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria, double tm)
        {
            string QueryAgregar = "Insert into tbl_PagoEmpleados (CodigoPago, CodigoEmpleado, FechaPago, Sueldo, Estado, FechaAuditoria, UsuarioAuditoria, Bono, MontoHorasE, TotalMonto) values (@CodigoPago, @CodigoEmpleado, @FechaPago, @Sueldo, @Estado, @FechaAuditoria, @UsuarioAuditoria, @Bono, @MontoHorasE, @TotalMonto)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@Bono", Bn);
            cmd.Parameters.AddWithValue("@MontoHorasE", Mh);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@TotalMonto", tm);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public void MtdEditarPagoEmpleados(DateTime FechaPago, double Sueldo, double Bn, double Mh, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria, double tm)
        {
            string QueryEditar = "Update tbl_PagoEmpleados set FechaPago=@FechaPago, Sueldo=@Sueldo, Bono=@Bono, MontoHorasE=@MontoHorasE, TotalMonto=@TotalMonto, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria, Estado=@Estado where CodigoHabitacion=@CodigoHabitacion, CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryEditar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@Sueldo", Sueldo);
            cmd.Parameters.AddWithValue("@Bono", Bn);
            cmd.Parameters.AddWithValue("@MontoHorasE", Mh);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@TotalMonto", tm);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public void MtdEliminarPagoEmpleados(int CodigoPago)
        {
            string QueryEliminar = "Delete from tbl_PagoEmpleados where CodigoPago=@CodigoPago";
            SqlCommand cmd = new SqlCommand(QueryEliminar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPago", CodigoPago);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public List<dynamic> MtdListaEmpleados()
        {
            List<dynamic> ListaEmpleados = new List<dynamic>();
            string QueryListaEmpleados = "select codigoEmpleados, Nombres from tbl_Empleados";
            SqlCommand cmd = new SqlCommand(QueryListaEmpleados, CapDatConexiones.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaEmpleados.Add(new
                {
                    Value = reader["codigoEmpleados"],
                    Text = $"{reader["codigoEmpleados"]} - {reader["Nombres"]}"
                });
            }

            CapDatConexiones.MtdCerrarConexion();
            return ListaEmpleados;
        }
    }
}

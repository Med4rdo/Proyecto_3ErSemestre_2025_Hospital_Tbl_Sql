using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto3er_SEMESTRE_Hospital_2025;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.datos
{
    internal class CDPagoCitas
    {

        CDconexion CapDatConexiones = new CDconexion();

        public DataTable MtdConsultarPagoCitas()
        {
            string QueryConsultar = "Select * from tbl_PagoCitas";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, CapDatConexiones.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            CapDatConexiones.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregar(DateTime FechaPago, double MontoCita, double Impuesto, double Descuento, double TotalPago, string TipoPago, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregar = "Insert into tbl_PagoCitas (CodigoPagoCita, CodigoCita, MontoCita, Impuesto, Descuento, TotalPago, FechaPago, TipoPago, UsuarioAuditoria, FechaAuditoria) values (@CodigoPagoCita, @CodigoCita, @MontoCita, @Impuesto, @Descuento, @TotalPago, @FechaPago, @TipoPago, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@MontoCita", MontoCita);
            cmd.Parameters.AddWithValue("@Impuesto", Impuesto);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.Parameters.AddWithValue("@TotalPago", TotalPago);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@TipoPago", TipoPago);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public void MtdEditar(DateTime FechaPago, double MontoCita, double Impuesto, double Descuento, double TotalPago, string TipoPago, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryEditar = "Update tbl_PagoCitas set FechaPago=@FechaPago, MontoCita=@MontoCita, Impuesto=@Impuesto, Descuento=@Descuento, TotalPago=@TotalPago, FechaAuditoria=@FechaAuditoria, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria, TipoPago=@TipoPago  where CodigoPagoCita=@CodigoPagoCita, CodigoCita=@CodigoCita";
            SqlCommand cmd = new SqlCommand(QueryEditar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@MontoCita", MontoCita);
            cmd.Parameters.AddWithValue("@Impuesto", Impuesto);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.Parameters.AddWithValue("@TotalPago", TotalPago);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@TipoPago", TipoPago);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public void MtdEliminar(int CodigoPago)
        {
            string QueryEliminar = "Delete from tbl_PagoCitas where CodigoPagoCita=@CodigoPagoCita";
            SqlCommand cmd = new SqlCommand(QueryEliminar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPagoCita", CodigoPago);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public List<dynamic> MtdListaCodeCita()
        {
            string Query = "select CodigoEmpleados, Nombres from tbl_PagoCitas";
            List<dynamic> ListaCod_Empleado = new List<dynamic>();

            using (SqlConnection connection = CapDatConexiones.MtdAbrirConexion())
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(Query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListaCod_Empleado.Add(new
                            {
                                Value = reader["CodigoEmpleados"],
                                Text = $"{reader["CodigoEmpleados"]} - {reader["Nombres"]}"
                            });
                        }
                    }
                }
            }

            return ListaCod_Empleado;
        }
    }
}

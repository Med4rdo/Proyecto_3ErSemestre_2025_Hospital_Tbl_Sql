using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto3er_SEMESTRE_Hospital_2025;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Datos
{
    internal class CDMedicamentos
    {
        CDconexion CapDatConexiones = new CDconexion();

        public DataTable MtdConsultar()
        {
            string QueryConsultar = "Select * from tbl_Medicamentos";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, CapDatConexiones.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            CapDatConexiones.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregar(DateTime FechaVencimiento, string TipoMedicamento, double costo, string Estado, string Nombre, int stock, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregar = "Insert into tbl_Medicamentos (Nombre, TipoMedicamento, Costo, Stock, FechaVencimineto, Estado, UsuarioAuditoria, FechaAuditoria) values (@Nombre, @TipoMedicamento, @Costo, @Stock, @FechaVencimineto, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@TipoMedicamento", TipoMedicamento);
            cmd.Parameters.AddWithValue("@Costo", costo);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@FechaVencimineto", FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public void MtdEditar(DateTime FechaVencimiento, string TipoMedicamento, double costo, string Estado, string Nombre, int stock, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryEditar = "Update tbl_Medicamentos set Nombre=@Nombre, TipoMedicamento=@TipoMedicamento, Costo=@Costo, Stock=@Stock, FechaVencimineto=@FechaVencimineto, Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria where CodigoMedicamento=@CodigoMedicamento";
            SqlCommand cmd = new SqlCommand(QueryEditar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@TipoMedicamento", TipoMedicamento);
            cmd.Parameters.AddWithValue("@Costo", costo);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@FechaVencimineto", FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public void MtdEliminar(int CodigoMedicamento)
        {
            string QueryEliminar = "Delete from tbl_Medicamentos where CodigoMedicamento=@CodigoMedicamento";
            SqlCommand cmd = new SqlCommand(QueryEliminar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoMedicamento", CodigoMedicamento);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }
    }
}

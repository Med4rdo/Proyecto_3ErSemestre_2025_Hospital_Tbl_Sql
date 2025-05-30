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
    internal class CDusuarios
    {
        CDconexion CapDatConexiones = new CDconexion();

        public DataTable MtdConsultarPagoEmpleados()
        {
            string QueryConsultar = "Select * from tbl_Usuarios";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, CapDatConexiones.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            SqlAdap.Fill(Dt);
            CapDatConexiones.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarUsuarios(string usuario, string Clave, string TipoUsuario, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryAgregar = "Insert into tbl_Usuarios (CodigoUsuario, CodigoEmpleados, Usuario, Clave, Estado, FechaAuditoria, UsuarioAuditoria, TipoUsuario) values (@CodigoUsuario, @CodigoEmpleados, @Usuario, @Clave, @Estado, @FechaAuditoria, @UsuarioAuditoria, @TipoUsuario)";
            SqlCommand cmd = new SqlCommand(QueryAgregar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Clave", Clave);
            cmd.Parameters.AddWithValue("@TipoUsuario", TipoUsuario);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public void MtdEditarUsuarios(string usuario, string Clave, string TipoUsuario, string Estado, DateTime FechaAuditoria, string UsuarioAuditoria)
        {
            string QueryEditar = "Update tbl_Usuarios set Usuario=@Usuario, Clave=@Clave, TipoUsuario=@TipoUsuario, FechaAuditoria=@FechaAuditoria, UsuarioAuditoria=@UsuarioAuditoria, Estado=@Estado where CodigoUsuario=@CodigoUsuario";
            SqlCommand cmd = new SqlCommand(QueryEditar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Clave", Clave);
            cmd.Parameters.AddWithValue("@TipoUsuario", TipoUsuario);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }

        public void MtdEliminarUsuarios(int CodigoUsuario)
        {
            string QueryEliminar = "Delete from tbl_Usuarios where CodigoUsuario=@CodigoUsuario";
            SqlCommand cmd = new SqlCommand(QueryEliminar, CapDatConexiones.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
            cmd.ExecuteNonQuery();
            CapDatConexiones.MtdCerrarConexion();
        }
    }
}

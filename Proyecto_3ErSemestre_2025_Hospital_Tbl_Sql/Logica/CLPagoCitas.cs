using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto3er_SEMESTRE_Hospital_2025;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Logica
{
    internal class CLPagoCitas
    {
        CDconexion CapDatConexiones = new CDconexion();

        public double MtdMontoCita(int CodigoCita)
        {
            double costoTratamientos = 0;
            double costoHabitacion = 0;

            string query = "SELECT CostoTratamientos, CostoHabitacion From tbl_citas WHERE CodigoCita = @Codigo";

            using (SqlConnection con = CapDatConexiones.MtdAbrirConexion())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Codigo", CodigoCita);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    costoTratamientos = Convert.ToDouble(reader["CostoTratamientos"]);
                    costoHabitacion = Convert.ToDouble(reader["CostoHabitacion"]);
                }

                reader.Close();
                CapDatConexiones.MtdCerrarConexion(); 
            }

            return costoTratamientos + costoHabitacion;
        
        }
        public double MtdImpuestoPago(double MontoCita)
        {
            return MontoCita * 0.12;

        }

        public double MtdDescuentoPago(double MontoCita, double MontoPago)
        {
            if (MontoCita > 0 && MontoCita <= 500) return MontoPago * 0.03;
            else if (MontoCita > 500 && MontoCita <= 5000) return MontoPago * 0.5;
            else if (MontoCita > 5000) return MontoCita * 0.07;
            else return 0;


        }

        public double MtdTotalPago(double MontoCita, double Impuesto,  double descuento)
        {
            return MontoCita + Impuesto - descuento;
        }
    }
}

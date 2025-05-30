using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto3er_SEMESTRE_Hospital_2025;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql
{
    internal class CLPagoEmpleados
    {
        CDconexion CapDatConexiones = new CDconexion();


        public double MtdSueldoBono (double sueldo) 
        {

            return sueldo * 0.12;
        
        }

        public double MtdTotalMonto (double sueldo, double bono, double MontoHorasE)
        {
            return sueldo + bono + (MontoHorasE * 20);
        }

        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }

    }
}

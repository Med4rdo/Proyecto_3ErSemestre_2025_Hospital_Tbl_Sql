using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Logica
{
    internal class CLhabitaciones
    {
        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }

        public double MtdCostoHabitacion (string TipoHabitacion)
        {

            if (TipoHabitacion == "General") return 300;
            else if (TipoHabitacion == "Maternidad") return 1000;
            else if (TipoHabitacion == "Pediatria") return 500;
            else if (TipoHabitacion == "Aislamiento") return 300;
            else if (TipoHabitacion == "Observacion") return 100;
            else return 0;
            
        }


    }
}

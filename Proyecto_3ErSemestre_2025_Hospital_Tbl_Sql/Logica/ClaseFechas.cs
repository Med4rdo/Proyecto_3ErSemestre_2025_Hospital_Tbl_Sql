using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto3er_SEMESTRE_Hospital_2025;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Logica
{
    internal class ClaseFechas
    {
        CDconexion CapLogFechas = new CDconexion();

        public DateTime MtdFechaHoy()
        {
            return DateTime.Now;
        }

    }
}

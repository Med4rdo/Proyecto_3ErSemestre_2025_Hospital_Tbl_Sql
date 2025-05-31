using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto3er_SEMESTRE_Hospital_2025;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.Logica
{
    internal class CLMedicamentos
    {
        CDconexion CapDatConexiones = new CDconexion();
        public double MtdCostoMedicamentos(string tipoMedicamento)
        {
            switch (tipoMedicamento)
            {
                case "Jarabe":
                    return 150;
                case "Suero":
                    return 25;
                case "Crema":
                    return 75;
                case "Tableta":
                    return 25;
                case "Inyeccion":
                    return 125;
                default:

                    return 0;
            }
        }

    }
}

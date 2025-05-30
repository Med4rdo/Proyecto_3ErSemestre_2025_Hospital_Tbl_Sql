using Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql.presentacion;
using Proyecto3er_SEMESTRE_Hospital_2025;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_3ErSemestre_2025_Hospital_Tbl_Sql
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPacientes());
        }
    }
}

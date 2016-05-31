using BussinessLayer;
using System;
using System.Windows.Forms;

namespace Medit
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PacientesManager pm = new PacientesManager();
            MedicosManager mm = new MedicosManager();
            IngresosManager im = new IngresosManager();
            Application.Run(new Recipe(im.getIngresoDat(7),mm.GetDoctor(1),pm.GetPaciente(2)));
        }
    }
}

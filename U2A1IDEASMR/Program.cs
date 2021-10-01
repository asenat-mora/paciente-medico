using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using U2A1IDEASMR.Model;

namespace U2A1IDEASMR
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

            Application.Run(new Menu());

           // Application.Run(new FormularioPaciente());
                                  
           // Application.Run(new FrmBuscarAMR());

            //Application.Run(new FrmMedicosAdmAMR());
           // Application.Run(new FrmMedicosAMR());


        }
    }
}

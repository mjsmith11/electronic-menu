using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using menu_manager.Forms;
using data_models;

namespace menu_manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NetFrameworkMenuContext context = NetFrameworkMenuContext.GetContext();
            context.Database.CreateIfNotExists();
            Application.Run(new MenuForm(context));
        }
    }
}

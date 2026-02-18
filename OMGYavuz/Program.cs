using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMGYavuz
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IModel model = new Model();
            IView view = new View();
            IController controller = new Controller();

            model.setView(view);
            model.setController(controller);

            view.setModel(model);
            view.setController(controller);

            controller.setModel(model);
            controller.setView(view);

            Application.Run((Form)view);

            //Hallo!
        }
    }
}
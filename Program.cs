using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace desk
{
    static class Program
    {
        private static Mutex mutex = null;
        [STAThread]
        static void Main()
        {
            const string appName = "desk";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

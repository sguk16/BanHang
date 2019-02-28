using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
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
            //Application.Run(new Form1());
            ThietBi tb = new ThietBi("1111111112", "CPU Intel Core I5", "1", 5, 1000);
            
            Console.WriteLine(ThietBiBUS.EditThietBi(tb));
        }
    }
}

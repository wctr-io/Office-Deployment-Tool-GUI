using ODTGUI.ApplicationModels.Enums;
using ODTGUI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODTGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //global exception logger
#if DEBUG
            var applicationLogger = new ApplicationLogger(LogLevel.Info);
#else
            var applicationLogger = new ApplicationLogger(LogLevel.Error);
#endif

            var hierarchy = new Element("Add") { Children = new List<Element> {
                    new Element("Product"),
                    new Element("Product")
            } }; 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new MainForm(applicationLogger));
            }
            catch (Exception ex)
            {
                applicationLogger.Log(ex.ToString(), LogLevel.Error);
#if DEBUG
                throw;
#endif
            }
            
        }
    }
    class Element
    {
        public Element(string name)
        {
            Name = name;
        }

        public string Name { get;  private set; }
        public List<Element> Children { get; set; }
    }
}

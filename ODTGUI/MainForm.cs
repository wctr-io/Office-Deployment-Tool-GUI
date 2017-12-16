using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Configuration;
using System.Xml.Serialization;
using System.IO;
using ODTGUI.DomainModels;
using ODTGUI.Utils;
using ODTGUI.ApplicationModels.Enums;
using ODTGUI.ApplicationModels;

namespace ODTGUI
{
    public partial class MainForm : Form
    {
        private ILogger _applicationLogger;

        public MainForm(ILogger applicationLogger)
        {
            _applicationLogger = applicationLogger;
            InitializeComponent();
            SetupHelpLinks();
        }

        private void SetupHelpLinks()
        {
            var helpMenuItem = new ToolStripMenuItem("Help");
            mainMenuStrip.Items.Add(helpMenuItem);
            try
            {
                var helpLinksFile = ConfigurationManager.AppSettings["HelpLinksFile"];
                var xmlSerializer = new ObjectSerializationExtension(_applicationLogger);
                var menuItems = xmlSerializer.DeSerializeObject<List<HelpLink>>(helpLinksFile);

                foreach (var menuItem in menuItems)
                {
                    var toolStripMenuItem = new ToolStripMenuItem(menuItem.Text, null, OnHelpMenuItemClick);
                    toolStripMenuItem.Tag = menuItem.Link;

                    helpMenuItem.DropDownItems.Add(toolStripMenuItem);
                }
            }
            catch (Exception ex)
            {
                mainMenuStrip.Items.Remove(helpMenuItem);
                _applicationLogger.Log(ex.ToString(), LogLevel.Error);
                MessageBox.Show("Help links menu init failed");
            }
            
        }
            

        private void OnHelpMenuItemClick(object sender, EventArgs e)
        {
            Process.Start(((ToolStripMenuItem)sender).Tag.ToString());
        }
    }
}

//XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
//ns.Add("", "");
//var xmlSerializer = new XmlSerializer(typeof(Configuration));

//var testObject = new Configuration {
//    Add = new Add
//    {
//        SourcePath = @"\\Server\Share",
//        Channel = "Broad",
//        OfficeClientEdition = 32,
//        Products = new List<Product>() {
//            new Product { Id = "O365ProPlusRetail",
//                Languages = new List<Language>() {
//                    new Language {Id = "en-us" },
//                    new Language {Id = "ja-jp" }
//                }
//            },
//            new Product { Id = "VisioProRetail" ,
//                Languages = new List<Language>() {
//                    new Language {Id = "en-us" },
//                }
//            }
//        }
//    }
//};

//string xml;
//using (StringWriter textWriter = new StringWriter())
//{
//    xmlSerializer.Serialize(textWriter, testObject, ns);
//    xml =  textWriter.ToString();
//}
// Process.Start(configurationOptionsForTheOffice2016DeploymentToolToolStripMenuItemLink);
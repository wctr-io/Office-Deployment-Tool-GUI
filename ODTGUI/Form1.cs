using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Configuration;
using System.Xml.Serialization;
using System.IO;
using ODTGUI.DomainModels;

namespace ODTGUI
{
    public partial class mainForm : Form
    {
        private string configurationOptionsForTheOffice2016DeploymentToolToolStripMenuItemLink;
        private string overviewOfSharedComputerActivationForOffice365ProPlusToolStripMenuItemLink;
        public mainForm()
        {
            configurationOptionsForTheOffice2016DeploymentToolToolStripMenuItemLink = ConfigurationSettings.AppSettings["link1"];
            overviewOfSharedComputerActivationForOffice365ProPlusToolStripMenuItemLink = ConfigurationSettings.AppSettings["link2"];
            InitializeComponent();
        }

        private void configurationOptionsForTheOffice2016DeploymentToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
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


            Process.Start(configurationOptionsForTheOffice2016DeploymentToolToolStripMenuItemLink);
        }

        private void overviewOfSharedComputerActivationForOffice365ProPlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(overviewOfSharedComputerActivationForOffice365ProPlusToolStripMenuItemLink);
        }
    }
}

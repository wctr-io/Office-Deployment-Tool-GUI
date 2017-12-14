using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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
            
            Process.Start(configurationOptionsForTheOffice2016DeploymentToolToolStripMenuItemLink);
        }

        private void overviewOfSharedComputerActivationForOffice365ProPlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(overviewOfSharedComputerActivationForOffice365ProPlusToolStripMenuItemLink);
        }
    }
}

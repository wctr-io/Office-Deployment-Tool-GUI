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

namespace ODTGUI
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void configurationOptionsForTheOffice2016DeploymentToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://support.office.com/en-us/article/Configuration-options-for-the-Office-2016-Deployment-Tool-d3879f0d-766c-469c-9440-0a9a2a905ca8?ui=en-US&rs=en-US&ad=US");
        }

        private void overviewOfSharedComputerActivationForOffice365ProPlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://support.office.com/en-us/article/Overview-of-shared-computer-activation-for-Office-365-ProPlus-836f882c-8ff6-4f19-8b24-0212e0111c94");
        }
    }
}

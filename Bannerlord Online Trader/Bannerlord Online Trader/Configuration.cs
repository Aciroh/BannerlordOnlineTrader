using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bannerlord_Online_Trader
{
    public partial class Form1 : Form
    {
        private ConfigurationParameters configuration = new ConfigurationParameters();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void configurationForm_Load(object sender, EventArgs e)
        {
            configuration.launcherPathChanged += changeLauncherPathTextOnEvent;
        }


        private void pathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files (.exe)|*.exe|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 0;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Contains("BannerlordOnline.exe"))
                {
                    configuration.LauncherPath = openFileDialog.FileName;
                }
            }
        }

        private void changeLauncherPathTextOnEvent(object o, EventArgs e)
        {
            try
            {
                this.launcherPathTextBox.Text = o as string;
            }
            catch (Exception exception)
            {
                
            }
        }
    }
}
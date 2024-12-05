using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ps2ls
{
    partial class AboutForm : Form
    {
        #region Singleton
        private static AboutForm instance = null;

        public static void CreateInstance()
        {
            instance = new AboutForm();
        }

        public static void DeleteInstance()
        {
            instance = null;
        }

        public static AboutForm Instance { get { return instance; } }
        #endregion

        public AboutForm()
        {
            InitializeComponent();
            labelVersion.Text = "Version " + Assembly.GetEntryAssembly().GetName().Version.ToString();
        }
    }
}

using codepush_winform.helper;
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
using static codepush_winform.helper.Http;

namespace codepush_winform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            List<App> Apps = null;
            Task t =Task.Run(() =>
            {
                Apps = Http.GetAppsAsync().Result;
                Debug.WriteLine(Apps);
            });

            t.Wait();

            foreach (var item in Apps)
            {
                listBox4.Items.Add(item.display_name + " " + item.platform + " " + item.os);
            }
        }
    }
}

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
        List<App> apps = new List<App>();
        User user = new User();

        //Key is the App, each app has N deployments such as Staging and Production
        Dictionary<string, App> all_apps = new Dictionary<string, App>();
        Dictionary<App, List<Deployment>> all_deployments = new Dictionary<App, List<Deployment>>();
        Dictionary<Deployment, List<Release>> all_releases = new Dictionary<Deployment, List<Release>>();

        public MainForm()
        {
            InitializeComponent();
        }

        async void RefreshAppList()
        {
            SetStatus("Login ... ");
            user = await GetLoginUser();
            UserLabel.Text = user.display_name;

            SetStatus("Get all apps ... ");
            apps = await GetAppsAsync();

            foreach (var app in apps)
            {                
                AppList.BeginInvoke((Action)(async () =>
                {
                    AppList.Items.Add(app.display_name, app.os == "Android" ? 0 : 1);
                    all_apps[app.name] = app;
                    await RefreshDepolymentListAsync(user.display_name, app);
                }));                
            }            
        }

        private void SetStatus(string info)
        {
            BeginInvoke((Action)(()=>{
                StatusLabel.Text = info;
            }));
        }
        private async Task RefreshDepolymentListAsync(string owner_name, App app)
        {
            List<Deployment> deploys = new List<Deployment>();
            deploys = await GetDeploymentsAsync(owner_name, app.name);

            all_deployments[app] = deploys;
            SetStatus("Get all deployment for App " + app.display_name);
            foreach (var deployment in deploys)
                RefreshReleaseList(owner_name, app, deployment);            
        }

        private async void RefreshReleaseList(string owner_name, App app, Deployment deployment)
        {
            List<Release> releases = new List<Release>();
            SetStatus("Get all releases for deployment " + deployment.name);
            releases = await GetReleasesAsync(owner_name, app.name, deployment.name);
            releases = releases.OrderByDescending(item => item.upload_time).ToList();
            all_releases[deployment] = releases;
        }    
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            Task.Run(() => {
                RefreshAppList();                
            });
            
        }

        private void AppList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AppList.SelectedItems.Count > 0)
            {
                var selected_item = AppList.SelectedItems[0].Text;
                if (all_deployments.Count > 0)
                {
                    var selected_app = all_apps[selected_item];
                    DeploymentList.DataSource = all_deployments[selected_app];
                }
            }
        }

        private void DeploymentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeploymentList.SelectedItems.Count > 0)
            {
                var selected_deployment = DeploymentList.SelectedItems[0] as Deployment;
                if (selected_deployment != null && all_releases.Count > 0 && all_releases.ContainsKey(selected_deployment))
                {
                    var selected_releases = all_releases[selected_deployment];
                    ReleaseList.DataSource = selected_releases;
                }
            }
        }     
    }
}

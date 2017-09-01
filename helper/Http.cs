using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Diagnostics;
using Newtonsoft.Json;

namespace codepush_winform.helper
{
    public partial class Http
    {
        //curl -X GET --header 'Accept: application/json' --header 'X-API-Token: 40abb7297a4f02904832decd9800aa573e4b131f' 
        //'https://api.mobile.azure.com/v0.1/user'

        const string app_token = "40abb7297a4f02904832decd9800aa573e4b131f";
        static Uri url_base = new Uri("https://api.mobile.azure.com/");





        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint">e.g. "/Membership/exists" or "/account"</param>
        /// <returns></returns>
        public static async Task<string> GetAsync(string path)
        { 
            using (var client = new HttpClient())
            {
                client.BaseAddress = url_base;
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-API-Token", "40abb7297a4f02904832decd9800aa573e4b131f");

                var response = await client.GetStringAsync(path); //.Result;
                return response;
            }
        }

        public static async Task<User> GetLoginUser()
        {
            var json = await GetAsync("v0.1/user");
            var output = JsonConvert.DeserializeObject<User>(json);
            return output; // !=null? output.display_name: null;
        }
        
        public static async Task<List<App>> GetAppsAsync()
        {
            var json =await GetAsync("v0.1/apps");
            var output = JsonConvert.DeserializeObject<List<App>>(json);
            return output;
        }

        public static async Task<List<Deployment>> GetDeploymentsAsync(string owner_name, string app_name)
        {
            //v0.1/apps/cityuxykou/idemo/deployments'
            var path = string.Format("v0.1/apps/{0}/{1}/deployments", owner_name, app_name);
            var json = await GetAsync(path);
            var output = JsonConvert.DeserializeObject<List<Deployment>>(json);
            return output;
        }

        //GET /v0.1/apps/{owner_name}/{app_name}/deployments/{deployment_name}/releases
        public static async Task<List<Release>> GetReleasesAsync(string owner_name, string app_name, string deployment_name)
        {
            //v0.1/apps/cityuxykou/idemo/deployments'
            var path = string.Format("v0.1/apps/{0}/{1}/deployments/{2}/releases", owner_name, app_name, deployment_name);
            var json = await GetAsync(path);
            var output = JsonConvert.DeserializeObject<List<Release>>(json);
            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codepush_winform.helper
{
    public class CodepushHelper
    {
        /// <summary>
        /// Run code-push command with fixed prefix: "code-push "
        /// </summary>
        /// <param name="Command"></param>
        /// <returns></returns>
        private static string Run(string Command)
        {
            return JSHelper.RunCommand("code-push " + Command);
        }
        public static bool IsLogined()
        {
            var output = Run("whoami");
            return !output.StartsWith("[Error]");              
        }

        public static string Whoami()
        {
            var output = Run("whoami");
            return output.StartsWith("[Error]") ? "Not Logined" : output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_TestAutomationFramework
{
    public class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string User = ConfigurationManager.AppSettings["user"];
        public static readonly string Password = ConfigurationManager.AppSettings["password"];
        public static readonly string LockedOut = ConfigurationManager.AppSettings["locked_out"];
        public static readonly string Problem = ConfigurationManager.AppSettings["problem"];
        public static readonly string PerformanceGlitch = ConfigurationManager.AppSettings["performance_glitch"];
        public static readonly string InvalidUser = ConfigurationManager.AppSettings["invalid_user"];
        public static readonly string InvalidPswd = ConfigurationManager.AppSettings["invalid_password"];
    }
}

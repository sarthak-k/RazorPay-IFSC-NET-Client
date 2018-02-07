using System.Configuration;

namespace RazorPay.Indian.Financial.System.Code.Client.Configuration
{
    public static class Settings
    {
        public static class Configuration
        {
            public static string Base => ConfigurationManager.AppSettings["RazorPayEndpoint"];
        }
    }
}
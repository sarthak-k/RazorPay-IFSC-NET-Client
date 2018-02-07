using RazorPay.Indian.Financial.System.Code.Client.Configuration;
using RazorPay.Indian.Financial.System.Code.Client.Contract;
using RestSharp;

namespace RazorPay.Indian.Financial.System.Code.Client.Implementation
{
    internal class Base
    {
        public static RestClient Client => GetClient();

        public static RestRequest Request(string resourceEndpoint, Method method) =>
            new RestRequest(resourceEndpoint, method)
            {
                JsonSerializer = JsonSerializer.Default,
                RequestFormat = DataFormat.Json
            };

        private static RestClient GetClient()
        {
            var client = new RestClient(Settings.Configuration.Base);

            client.AddHandler("application/json", JsonSerializer.Default);
            client.AddHandler("text/json", JsonSerializer.Default);
            client.AddHandler("text/x-json", JsonSerializer.Default);
            client.AddHandler("text/javascript", JsonSerializer.Default);
            client.AddHandler("*+json", JsonSerializer.Default);

            return client;
        }

    }
}
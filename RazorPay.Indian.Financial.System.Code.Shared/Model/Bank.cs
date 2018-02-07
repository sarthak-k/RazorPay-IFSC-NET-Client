using Newtonsoft.Json;

namespace RazorPay.Indian.Financial.System.Code.Shared.Model
{
    public class Bank
    {
        [JsonProperty("BRANCH")]
        public string Branch { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("CONTACT")]
        public string Contact { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("DISTRICT")]
        public string District { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("RTGS")]
        public bool IsRTGS { get; set; }

        [JsonProperty("BANK")]
        public string Name { get; set; }

        [JsonProperty("BANKCODE")]
        public string BankCode { get; set; }

        [JsonProperty("IFSC")]
        public string IFSC { get; set; }
    }
}
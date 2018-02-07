using System.Net;

namespace RazorPay.Indian.Financial.System.Code.Shared.Model
{
    public class SearchRequestResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public Bank Bank { get; set; }
    }
}
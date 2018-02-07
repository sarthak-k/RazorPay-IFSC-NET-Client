using System;
using RazorPay.Indian.Financial.System.Code.Client.Configuration;
using RazorPay.Indian.Financial.System.Code.Shared.Model;
using RestSharp;

namespace RazorPay.Indian.Financial.System.Code.Client.Implementation
{
    public class IFSC
    {
        private readonly string _mSearchCode;

        private IFSC(string searchCode)
        {
            _mSearchCode = searchCode;
        }

        public SearchRequestResponse Search()
        {
            var searchRequest =
                Base.Request($"{_mSearchCode.ToUpper()}", Method.GET);

            var response = Base.Client.Get<Bank>(searchRequest);

            return new SearchRequestResponse()
            {
                StatusCode = response.StatusCode,
                IsSuccess = response.IsSuccessful,
                Bank = response.Data
            };
        }

        public static IFSC Create(string bankCode)
        {
            if (bankCode == null || string.IsNullOrWhiteSpace(bankCode))
            {
                throw new ArgumentNullException(nameof(bankCode));
            }

            return new IFSC(bankCode);
        }
    }
}
# RazorPay-IFSC-NET-Client
Implementation of RazorPay IFSC https://github.com/razorpay/ifsc for .NET

# Implementation
```
Install-Package RestSharp 
Install-Package Newtonsoft.Json
Install-Package System.Configuration.ConfigurationManager
```

```csharp
 var searchResponse = IFSC.Create("SBIN0021527").Search();
 if (searchResponse.IsSuccess) {
    var bankDetails = searchResponse.Bank;
 }
 ```

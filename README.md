# RazorPay-IFSC-NET-Client
Implementation of RazorPay IFSC https://github.com/razorpay/ifsc for .NET

# Implementation
```
Install-Package RestSharp 
Install-Package Newtonsoft.Json
Install-Package System.Configuration.ConfigurationManager
```

```
 <appSettings>
    <add key="RazorPayEndpoint" value="https://ifsc.razorpay.com" />
  </appSettings>
```

```csharp
 var searchResponse = IFSC.Create("SBIN0021527").Search();
 if (searchResponse.IsSuccess) {
    var bankDetails = searchResponse.Bank;
 }
 ```

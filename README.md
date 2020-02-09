# C# - WCF RESTFull Service Example Application [Year of Development: 2017]

### Technologies:
- Programming Language: C#
- BackEnd Side: Windows Communication Foundation (WCF) - .NET Framework 4.6.1

### Installation/ Configuration:

1. Restore necessary Packages on the selected project, run the following command in **PM Console**

   ```
   Update-Package -reinstall
   ```

### About the application:

I've read many WCF Rest service articles and have a hard time understanding the concept of new students, so I'm trying to create a simple WCF REST Service template, and I'll show you this in the code that how to use GET to send data and how to use POST to receive data.

The RESTful service follows the architectural style of REST (representative government transfer). The WCF service allows you to make calls and exchange data over SOAP over various protocols (HTTP, TCP, MSMQ, etc.) and uses a complex mechanism such as SOAP for communication.

Easy to use REST service, uses HTTP for all operations, simple and fast, uses .json and .xml formats.

### Useful Highlights:

**1. Concepts**

#### UriTemplate:

REST Service mainly depending on the service URL to fetch the data, we can define any name here and the service can access using the URI.

#### ResponseFormat and RequestFormat:

It defines in which format data should be transformed, we can select XML or JSON formats here.

**2. Configure the Service behavior and endpoint behavior in web.config file**

#### The following code to the web.config file of the service just under <system.serviceModel>

```XML
<behaviors>
  <endpointBehaviors>
    <behavior name="ProductServiceBehavior">
      <webHttp helpEnabled="true" />
    </behavior>
  </endpointBehaviors>
</behaviors>
```

#### Change the Behavior Configuration element of the ProductService Service section as shown below.

```XML
<service name="RESTFullWCFService.ProductService">
  <endpoint address="" behaviorConfiguration="ProductServiceBehavior" binding="webHttpBinding" contract="RESTFullWCFService.IProductService" />
</service>
```

**3. How to make POST request**

Add the following JSON object for your POST request

```JSON
{
  "Id": 1,
  "Name": "Apple",
  "Price": 60
}
```

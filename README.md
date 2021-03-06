# Summary
EMC Isilon is a scale-out NAS storage platform designed to be a powerful, simple, and efficient way to consolidate and manage enterprise data and applications. Isilon is a clustered storage system that consists of multiple independent nodes that are all integrated with the OneFS operating system. Nodes effectively pool all storage, compute, and network resources into a single entity capable of providing petabyte scale storage in a single namespace or filesystem. For organizations who wish to automate the administration tasks of OneFS, the platform provides a REST API. This project is a wrapper library written in C# .NET.

# Installation

Download the code to your local system, and include it as a class library in your solution. Set the project dependencies to include the IsilonAPI, and then include a reference to the library in your production code.

# Using .NET Isilon API

The entry points into the API are defined in the IsilonAPI.Requests namespace. For example, if your application requires automatically creating or modifying SMB shares, that functionality is located in the IsilonAPI.Requests.SMB class.

# Example

The first step is to create an instance of the IsilonService class. This class contains the authentication methods to the Isilon cluster. The constructor expects the credentials (User/Password) of the user account you wish to access the API with, the Url of the Isilon cluster, and a boolean variable indicating whether or not to ignore invalid SSL certificates (for testing).

```
IsilonService service = new IsilonService("username", "password", "https://192.168.1.240:8080", true);
````

Next you will need to create a request object that corresponds to one of the Isilon API resources. For example, if you want to get data on or modify Smart Quotas, create an instance of the IsilonAPI.Requests.SmartQuotas class, and pass the IsilonService object as a parameter to the SmartQuotas constructor.

````
SmartQuotas quotas = new SmartQuotas(service);
````

Now you can view or modify the Isilon clusters Smart Quotas using the methods provided by the SmartQuotas resource.

```
Quota[] quota = quotas.GetQuotas();
foreach(Quota q in quota)
{
   Console.WriteLine("Quota: " + q.Path + ", Type: " + q.Type);
}
```

# Future

Please contribute in any way to the project. Specifically need help filling out the remaining components of the API not yet implemented, and making the wrapper easier to use in other use cases.

# Licensing

The .NET Isilon REST API code is freely distributed under the MIT License. See LICENSE for details.

# Support

Please file bugs and issues at the Github issues page. For more general discussions you can contact the EMC Code team at [Google Groups](https://groups.google.com/forum/#!forum/emccode-users). The code and documentation are released with no warranties or SLAs and are intended to be supported through a community driven process.

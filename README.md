InControl-ServiceReferences
===========================

This is a test solution used to interact with the InControl service in your own Visual Studio 2010 solution.

Use
===
1. Make sure your project's target framework is .NET Framework 4 or higher. Note that the Client Profile framework will not work.
2. Add a reference to InControlServiceReference.dll.
3. Add a reference to System.Runtime.Serialization.


```csharp

// Customize these values to match your own server's ip, port and password
var server = "192.168.10.4";
var port = 1178;
var password = "yourpassword";

// Get the service
var service = InControlServiceReference.HaService.getService(server, port);

// Get all devices
var devices = service.devices(password);
```

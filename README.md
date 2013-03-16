About InControl-ServiceReferences
=====
InControl Home Automation (http://www.incontrolzwave.com) is a software program that can interact with your home automation. It currently has plugins to support Z-Wave (zwave), Clipsal/Cbus, Foscam IP Cameras and Sonos.

This project is a sample solution that requires you have InControl installed and running on your home network. This project can talk to InControl to retrieve and interact with all your home automation devices. 

Use
===
* Make sure InControl Home Automation is installed on your network (http://www.incontrolzwave.com)
* Make sure your project's target framework is .NET Framework 4 or higher. Note that the Client Profile framework will not work.
* Add a reference to InControlServiceReference.dll.
* Add a reference to System.Runtime.Serialization.

Here's some sample code to get your started. See the test project for some more syntax and commands.

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

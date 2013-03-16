using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InControlServiceReference.InControlService;

namespace InControl_Console_Test_application {
    class Program {
        static void Main(string[] args) {
            
            // Enter your password here
            var pwd = "yourpassword";
            var server = "10.4.3.178";
            var port = 1178;

            // The deviceId of the thermostat to change
            var tstatDeviceId = "63708030-8ce0-4dd6-9ab7-adaa406c3f2f";

            // Get the service
            var service = InControlServiceReference.HaService.getService(server, port);

            // Gets a list of all devices (not required, just here as a sample)
            var devices = service.devices(pwd);

            // Get the thermostat device from the list of devices that came back
            var tstatDevice = devices.Where(d => d.deviceId.ToString() == tstatDeviceId).FirstOrDefault() as Thermostat;

            // Gets a device from the server
            var tstat = service.getDevice(pwd, tstatDeviceId);

            if (tstat != null) {
                // Sets the thermostat setpoint named Heating1 to a value of 71 degrees
                service.setThermoSetpoint(pwd, tstatDeviceId, "Heating1", 71);

                // Sets the thermostat fan to Auto
                service.setThermoFanMode(pwd, tstatDeviceId, ThermoFanMode.Auto);

                // Sets the htermostat to heating mode
                service.setThermoSystemMode(pwd, tstatDeviceId, ThermoSystemMode.Heat);
            }
        }
    }
}

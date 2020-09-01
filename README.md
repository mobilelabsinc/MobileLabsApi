## MobileLabsApi

The MobileLabsApi library assists in writing C# programs that use the
Mobile Labs GigaFox/deviceConnect REST API, which is documented at
<http://docs.mobilelabsinc.com/GigaFox/restAPI.html>.

The library can be installed via the NuGet Gallery.  Package information is
available at <https://www.nuget.org/packages/MobileLabs.DeviceConnect.RestApi/>.

The source code for the package available is available at
<https://github.com/mobilelabsinc/MobileLabsApi>.

## Getting Started

The following is a simple walkthrough of using Visual Studio 2017 and the
MobileLabsApi library to write a program that gets a list of devices from a
GigaFox server.

1. Launch Visual Studio 2017.

2. Create a new project using the "C# Console App (.NET Core)" or "C# Console App (.NET Framework)" template.  Name it "ApiTest".

3. Choose Visual Studio's **Tools** > **NuGet Package Manager** > **Package Manager Console** menu item.  At the `PM>` prompt, enter this command:

```
Install-Package MobileLabs.DeviceConnect.RestApi
```

You should see messages indicating that the `MobileLabs.DeviceConnect.RestApi` has been installed, along with the `NewtonSoft.Json` package upon which it depends.

4. If you are using .NET Framework rather than .NET Core, open the project's settings, select the **Build** tab, and in the **Platform Target** section, choose "Any CPU" and uncheck the **Prefer 32-bit** checkbox. (If you are using .NET Core, no settings change is needed.)

5. Replace the contents of `Program.cs` with the following:

```csharp
using System;

using MobileLabs.DeviceConnect.RestApi;
using MobileLabs.DeviceConnect.RestApi.v1.EndPoint;

namespace ApiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read command-line arguments.
            if (args.Length != 3)
            {
                Console.Error.WriteLine(
                    "error: three command-line arguments are required: SERVERURL USERNAME APITOKEN");
                return;
            }
            var serverUrl = args[0];
            var user = args[1];
            var apiToken = args[2];

            // Construct the MobileLabsApi client.
            var api = new MobileLabsApi(user, apiToken, serverUrl);

            // Call the Device endpoint to get a list of all devices.
            // See <http://docs.mobilelabsinc.com/GigaFox/restAPI.html#apiDeviceRequests>
            var devices = api.GetDevice();

            // Print the results.
            foreach (var device in devices)
            {
                Console.WriteLine($"{device.Id} {device.FriendlyModel}");
            }
        }
    }
}
```

6. At a command line prompt in the project directory, run the program, passing the server URL, username, and API token as parameters.

For example, for .NET Core:

    dotnet run "http://10.211.55.2" "tester@mobilelabsinc.com" "12d3d7d3-857e-4f31-a3ff-2691700d5fce"

or for .NET Framework:

    .\ApiTest.exe "http://10.211.55.2" "tester@mobilelabsinc.com" "12d3d7d3-857e-4f31-a3ff-2691700d5fce"

It should print a list of the device IDs and model names.

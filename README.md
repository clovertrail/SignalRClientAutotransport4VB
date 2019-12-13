# SignalR client of net45 cannot select Websockets when using AutoTransport, the workaround method is listed here:

1. Update net framework to be 4.7.2

2. Change the SignalR client framework from net45 to netstandard2.0:
```
    <Reference Include="Microsoft.AspNet.SignalR.Client, Version=2.4.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL">
      <HintPath>packages\Microsoft.AspNet.SignalR.Client.2.4.1\lib\netstandard2.0\Microsoft.AspNet.SignalR.Client.dll</HintPath>
    </Reference>
```

3. Reload the project file in Visual Studio. You will see build errors which say something wrong about Newtonsoft.Json, please use "Update-Package Newtonsoft.Json" in Package Management Console.

4. Rebuild the package and it should be successful, and run it you will see websockets is selected when using AutoTransport.

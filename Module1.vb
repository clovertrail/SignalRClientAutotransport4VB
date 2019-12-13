Imports Microsoft.AspNet.SignalR.Client

Module Module1

    Sub Main()
        Dim hubProxy As IHubProxy
        Dim connection As HubConnection
        connection = New HubConnection("http://localhost:14162")
        hubProxy = connection.CreateHubProxy("SignalRBench")
        connection.Start().Wait(New TimeSpan(0, 0, 110))
    End Sub

End Module

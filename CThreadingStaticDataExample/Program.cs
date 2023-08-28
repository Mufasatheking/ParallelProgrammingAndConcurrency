// See https://aka.ms/new-console-template for more information
using CThreadingStaticDataExample;

Console.WriteLine("Hello, World!");

Console.WriteLine($"Current datetime:{ DateTime.UtcNow}");

var helper = new WorkstationHelper();
Parallel.For(1, 30, async (x) =>
{
    await helper.GetNetworkAvailability();

});
await helper.GetNetworkAvailability();

Console.WriteLine($"Network availability last updated{ WorkstationState.NetworkConnectivityLastUpdated}for computer { WorkstationState.Name}at IP{ WorkstationState.IpAddress }");
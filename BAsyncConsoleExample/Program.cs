// See https://aka.ms/new-console-template for more information
using BAsyncConsoleExample;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, async!");

var networkHelper = new NetworkHelper();

await networkHelper.CheckNetworkStatusAsync();

Console.WriteLine("Main method complete.");

Console.ReadKey();
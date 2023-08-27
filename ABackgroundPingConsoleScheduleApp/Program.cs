//using ABackgroundPingConsoleScheduleApp;

//Console.WriteLine("Hello, World!");

//var networkingWork = new NetworkingWork();

//var bgThread1 = new

//    Thread(networkingWork.CheckNetworkStatus);

//var bgThread2 = new

//    Thread(networkingWork.CheckNetworkStatus);

//var bgThread3 = new

//    Thread(networkingWork.CheckNetworkStatus);

//var bgThread4 = new

//    Thread(networkingWork.CheckNetworkStatus);

//var bgThread5 = new

//    Thread(networkingWork.CheckNetworkStatus);

//bgThread1.Priority = ThreadPriority.Lowest;

//bgThread2.Priority = ThreadPriority.BelowNormal;

//bgThread3.Priority = ThreadPriority.Normal;

//bgThread4.Priority = ThreadPriority.AboveNormal;

//bgThread5.Priority = ThreadPriority.Highest;

//bgThread1.Start("Lowest");

//bgThread2.Start("BelowNormal");

//bgThread3.Start("Normal");

//bgThread4.Start("AboveNormal");

//bgThread5.Start("Highest");

//for (int i = 0; i < 10; i++)

//{

//    Console.WriteLine("Main thread working...");

//}

//Console.WriteLine("Done");

//Console.ReadKey();

using ABackgroundPingConsoleScheduleApp;

Console.WriteLine("Hello, World!");
var networkingWork = new NetworkingWork();

var pingThread = new Thread(networkingWork.CheckNetworkStatus);
var ctSource = new CancellationTokenSource();

pingThread.Start(ctSource.Token);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Main thread working...");
    Thread.Sleep(100);
}

ctSource.Cancel();
pingThread.Join();
ctSource.Dispose();

Console.WriteLine("Done");
Console.ReadKey();
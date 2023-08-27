using System;
namespace ABackgroundPingConsoleScheduleApp
{
	public class NetworkingWork
	{
		public NetworkingWork()
		{
		}
        public void CheckNetworkStatus(object data)

        {

            var cancelToken = (CancellationToken)data;

            while (!cancelToken.IsCancellationRequested)

            {

                bool isNetworkUp = System.Net

                    .NetworkInformation.NetworkInterface

                        .GetIsNetworkAvailable();

                Console.WriteLine($"Is network available? Answer: { isNetworkUp}");
        
    }

        }
    }
}


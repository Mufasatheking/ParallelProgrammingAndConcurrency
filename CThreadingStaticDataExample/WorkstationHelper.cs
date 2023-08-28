using System;
using System.Net.NetworkInformation;

namespace CThreadingStaticDataExample
{
	public class WorkstationHelper
	{
        private static object _workstationLock = new object();

        internal async Task<bool> GetNetworkAvailability()
        {
            await Task.Delay(100);

            lock (_workstationLock)
            {
                WorkstationState.IsNetworkAvailable = NetworkInterface.GetIsNetworkAvailable();

                WorkstationState.NetworkConnectivityLastUpdated = DateTime.UtcNow;

                return WorkstationState.IsNetworkAvailable;
            }
        }
    }
}


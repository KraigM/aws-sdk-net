using System;
using System.Net;
using SystemConfiguration;
using CoreFoundation;
using System.Diagnostics;
using System.Threading.Tasks;
using Foundation;

namespace Amazon.Util.Internal.PlatformServices
{
    public class NetworkReachability : INetworkReachability
    {

        public NetworkReachability()
        {
            CheckConnectivitiy();
        }

        private NetworkStatus _networkStatus;
        private NetworkStatus _previousNetworkState;

        public NetworkStatus NetworkStatus
        {
            get
            {
                return _networkStatus;
            }
        }

        public event EventHandler<NetworkStatusEventArgs> NetworkReachabilityChanged;

        SystemConfiguration.NetworkReachability reachability;

        //read http://iosapi.xamarin.com/?link=T%3aSystemConfiguration.NetworkReachability

        private NetworkStatus CheckConnectivitiy()
        {
            reachability = new SystemConfiguration.NetworkReachability(IPAddress.Parse("0.0.0.0"));
            NetworkReachabilityFlags flags;
            bool reachable = reachability.TryGetFlags(out flags);
            reachability.SetNotification(NetworkChangeDelegate);
            reachability.Schedule(CFRunLoop.Current, CFRunLoop.ModeDefault);
            if (reachable)
                return NetworkStatusHelper(flags);
            else
                return NetworkStatus.NotReachable;
        }

        private void NetworkChangeDelegate(NetworkReachabilityFlags flags)
        {
            NetworkStatusHelper(flags);
            if (NetworkReachabilityChanged != null)
                NetworkReachabilityChanged(this, new NetworkStatusEventArgs(_networkStatus));
        }

        private NetworkStatus NetworkStatusHelper(NetworkReachabilityFlags flags)
        {
            if (!IsReachableWithoutRequiringConnection(flags))
                _networkStatus = NetworkStatus.NotReachable;
            else
                _networkStatus = NetworkStatus.ReachableViaWiFiNetwork;

            return _networkStatus;
        }

        private static bool IsReachableWithoutRequiringConnection(NetworkReachabilityFlags flags)
        {
            // Is it reachable with the current network configuration?
            bool isReachable = (flags & NetworkReachabilityFlags.Reachable) != 0;

            // Do we need a connection to reach it?
            bool noConnectionRequired = (flags & NetworkReachabilityFlags.ConnectionRequired) == 0;

            return isReachable && noConnectionRequired;
        }
    }
}
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaiterLibrary
{
    public static class Global
    {
        private static GrpcChannel? _channel;

        public static string ServerURL = "https://theam-grpc.gyx.moe";
        public static GrpcChannel Channel
        {
            get => _channel ??= GrpcChannel.ForAddress(ServerURL);
            set => _channel = value;
        }
    }
}

using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WaiterLibrary
{
    public static class Global
    {
        static Global()
        {
            var systemProxy = WebRequest.GetSystemWebProxy();
            var httpProxy = new WebProxy(systemProxy.GetProxy(new Uri("https://google.com")));
            var httpHandler = new HttpClientHandler();
            httpHandler.Proxy = httpProxy;
            //httpHandler.SslProtocols = System.Security.Authentication.SslProtocols.Tls13;
            httpHandler.UseProxy = true;
            var httpClient = new HttpClient(httpHandler, true);
            ChannelOptions = new GrpcChannelOptions();
            ChannelOptions.HttpClient = httpClient;
        }
        private static GrpcChannel? _channel;

        public static string ServerURL = "https://theam-grpc.gyx.moe";
        public static GrpcChannelOptions ChannelOptions;
        public static GrpcChannel Channel
        {
            get => _channel ??= GrpcChannel.ForAddress(ServerURL, ChannelOptions);
            set => _channel = value;
        }
    }
}

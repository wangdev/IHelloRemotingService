﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;

namespace RemotingServiceHost {
    class Program {
        static void Main(string[] args) {
            HelloRemotingService.HelloRemotingService remotingService = new HelloRemotingService.HelloRemotingService();
            TcpChannel channel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(HelloRemotingService.HelloRemotingService), "GetMessage", WellKnownObjectMode.Singleton);
            Console.WriteLine("Remoting service started @ " + DateTime.Now);
            Console.ReadLine();
        }
    }
}

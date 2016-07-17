using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace sipswitch
{
    class TransportLayer
    {
        List<ListeningPoint> listeningPoints;

        public TransportLayer()
        {
            listeningPoints = new List<ListeningPoint>();
            listeningPoints.Add(new ListeningPoint(ProtocolType.Udp, IPAddress.Parse("192.168.1.101"), 5060));
            listeningPoints.Add(new ListeningPoint(ProtocolType.Tcp, IPAddress.Parse("192.168.1.101"), 5060));

            foreach (ListeningPoint lp in listeningPoints)
            {
                Console.WriteLine("LP-{0}: {1} {2}:{3}", lp.id, lp.protocol, lp.address, lp.port );
            }
        }
    }
}
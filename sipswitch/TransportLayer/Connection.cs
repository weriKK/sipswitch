using System.Net;
using System.Net.Sockets;

namespace sipswitch
{
    public enum ConnectionType : byte { Unknown, Opened, Accepted };

    public class Connection
    {
        public ConnectionType type;
        public ProtocolType protocol;
        public IPAddress dest_address;
        public int dest_port;
        public int last_activity; // unix time of last activity on this connection >= 64*T1 (64*500ms ~32seconds) (enough for one transaction)
        public int id;

        private static int nextConnectionId = 0;

        private int generateNextConnectionId()
        {
            int retVal = nextConnectionId;
            nextConnectionId = (nextConnectionId + 1) % int.MaxValue;
            return retVal;
        }
    }

    public class ListeningPoint
    {
        public ProtocolType protocol;
        public IPAddress address;
        public int port;
        public int id;

        private static int nextListeningPointId = 0;
        private IPEndPoint endPoint;
        private Socket socket;

        public ListeningPoint( ProtocolType lpProtocol, IPAddress lpAddress, int lpPort = 5060)
        {
            protocol = lpProtocol;
            address = lpAddress;
            port = lpPort;

            //endPoint = new IPEndPoint(address, port);

            id = generateNextListeningPointId();

        }

        private int generateNextListeningPointId()
        {
            int retVal = nextListeningPointId;
            nextListeningPointId = (nextListeningPointId + 1) % int.MaxValue;
            return retVal;
        }
    }
}

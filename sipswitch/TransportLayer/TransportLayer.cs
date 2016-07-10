using System;
using System.Threading;

namespace sipswitch
{
    class TransportLayer
    {
        public void Start(object param)
        {
            Thread.CurrentThread.Name = "TLCore";
            throw new NotImplementedException();
        }
    }
}
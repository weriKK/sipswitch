using System;
using System.Threading;

namespace sipswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "main";

            TransportLayer TL = new TransportLayer();
            Thread TLCore = new Thread(TL.Start);
            TLCore.Start(666);
        }

    }
}

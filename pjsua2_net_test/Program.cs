using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PJSIP;

namespace pjsua2_net_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var endpoint = new PJSIP.Endpoint();
            endpoint.libCreate();

            endpoint.libInit(new EpConfig
            {
                uaConfig = { maxCalls = 6 },
                medConfig =
                {
                    sndClockRate = 16000,
                    //noVad = true,
                    ecTailLen = 0,
                    hasIoqueue = true
                }
            });
            
            var randomPort = new Random().Next(1025, 65534);
            endpoint.transportCreate(pjsip_transport_type_e.PJSIP_TRANSPORT_UDP, new TransportConfig() { port = (uint)randomPort });

            endpoint.libStart();

            endpoint.libRegisterThread(Thread.CurrentThread.Name ?? "");

            Console.ReadKey();
        }
    }
}

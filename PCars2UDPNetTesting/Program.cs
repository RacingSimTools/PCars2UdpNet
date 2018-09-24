namespace PCars2UDPNetTesting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reactive;
    using System.Reactive.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using PCars2UdpNet;
    using PCars2UdpNet.Structs;

    public class Program
    {
        public static void Main(string[] args)
        {
            TestPacketTypes();
            while (true)
            {
                Thread.Sleep(30);
            }
        }

        private static void TestPacketTypes()
        {
            int telemCount = 0;
            int raceCount = 0;
            int participantsCount = 0;
            int timingsCount = 0;
            int gameStateCount = 0;
            int timeStatsCount = 0;
            int partVehicleCount = 0;
            int otherCount = 0;

            var client = new PCars2UDPClient(5606);
            client.StartRead().Do(o =>
            {
                switch (o.PacketType)
                {
                    case EPacketType.CarPhysics:
                        telemCount++;
                        break;
                    case EPacketType.RaceDefinition:
                        raceCount++;
                        break;
                    case EPacketType.Participants:
                        participantsCount++;
                        break;
                    case EPacketType.Timings:
                        timingsCount++;
                        break;
                    case EPacketType.GameState:
                        gameStateCount++;
                        break;
                    case EPacketType.TimeStats:
                        timeStatsCount++;
                        break;
                    case EPacketType.ParticipantVehicleNames:
                        partVehicleCount++;
                        break;
                    default:
                        otherCount++;
                        break;
                }
            })
            .Buffer(200).Subscribe(_ =>
            {
                Console.WriteLine("==============================");
                Console.WriteLine("telemCount: {0}", telemCount);
                Console.WriteLine("raceCount: {0}", raceCount);
                Console.WriteLine("participantsCount: {0}", partVehicleCount);
                Console.WriteLine("timingsCount: {0}", timingsCount);
                Console.WriteLine("gameStateCount: {0}", gameStateCount);
                Console.WriteLine("timeStatsCount: {0}", timeStatsCount);
                Console.WriteLine("partVehicleCount: {0}", partVehicleCount);
                Console.WriteLine("otherCount: {0}", otherCount);
                Console.WriteLine("==============================");
            });
        }
    }
}

// <copyright file="PCars2UDPClient.cs" company="Racing Sim Tools">
// Original work Copyright (c) MWL. All rights reserved.
//
// Modified work Copyright 2015 - 2018, Jim Britton and Contributors. [Crew Chief]
// Copyright (c) Racing Sim Tools. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
namespace PCars2UdpNet
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.MemoryMappedFiles;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using System.Reactive;
    using System.Reactive.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using PCars2UdpNet.Structs;

    public class PCars2UDPClient : IDisposable
    {
        private UdpClient udpClient;

        public PCars2UDPClient()
            : this(5606)
        {
        }

        public PCars2UDPClient(int port)
        {
            this.udpClient = new UdpClient();
            this.udpClient.Client.Blocking = false;
            this.udpClient.ExclusiveAddressUse = false;
            this.udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            this.udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, port));
        }

        ~PCars2UDPClient()
        {
            this.Dispose();
        }

        /// <summary>
        /// Gets the observable stream of packets.
        /// </summary>
        public IObservable<IPCars2Packet> CarInfoStream { get; private set; }

        public IObservable<IPCars2Packet> StartRead()
        {
            CarInfoStream = Observable.FromAsync(this.udpClient.ReceiveAsync)
                 .Repeat()
                 .Publish()
                 .RefCount()
                 .Select(MarshalPacket)
                 .Sort(p => p.Base.mPacketNumber);
            return CarInfoStream;
        }

        public IPCars2Packet MarshalPacket(UdpReceiveResult result)
        {
            byte[] arr = result.Buffer;
            switch (arr.Length)
            {
                case 559:
                    return MarshalType<sTelemetryData>(arr);
                case 308:
                    return MarshalType<sRaceData>(arr);
                case 1136:
                    return MarshalType<sParticipantsData>(arr);
                case 1063:
                    return MarshalType<sTimingsData>(arr);
                case 24:
                    return MarshalType<sGameStateData>(arr);
                case 1040:
                    return MarshalType<sTimeStatsData>(arr);
                case 1164:
                    return MarshalType<sParticipantVehicleNamesData>(arr);
                case 1452:
                    Console.WriteLine("Recieved Class Names Packet");
                    return MarshalType<sVehicleClassNamesData>(arr);
                default:
                    return null;
            }
        }

        private static T MarshalType<T>(byte[] arr)
        {
            T str = default(T);

            int size = Marshal.SizeOf(str);
            IntPtr ptr = Marshal.AllocHGlobal(size);

            Marshal.Copy(arr, 0, ptr, size);

            str = (T)Marshal.PtrToStructure(ptr, str.GetType());
            Marshal.FreeHGlobal(ptr);

            return str;
        }

        public void Dispose()
        {
            this.udpClient.Close();
            this.udpClient.Dispose();
        }

    }
}

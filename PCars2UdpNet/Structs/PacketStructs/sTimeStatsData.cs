using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PCars2UdpNet.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sTimeStatsData : IPCars2Packet
    {
        public PacketBase sBase;

        public uint sParticipantsChangedTimestamp;                  // 12

        public sParticipantsStats sStats; // 16 + 768

        public PacketBase Base => this.sBase;

        public EPacketType PacketType => (EPacketType)this.sBase.mPacketType;
    }
}

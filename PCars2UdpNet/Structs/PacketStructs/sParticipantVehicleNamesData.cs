using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PCars2UdpNet.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sParticipantVehicleNamesData : IPCars2Packet
    {
        public PacketBase sBase;

        /// <summary>
        /// 12 16*72
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
        public sVehicleInfo[] sVehicles;

        public PacketBase Base => this.sBase;

        public EPacketType PacketType => (EPacketType)this.sBase.mPacketType;
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PCars2UdpNet.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sVehicleClassNamesData : IPCars2Packet
    {
        public PacketBase sBase;

        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60)]
        public sClassInfo[] sClasses; //12 24*60

        public PacketBase Base => this.sBase;

        public EPacketType PacketType => (EPacketType)this.sBase.mPacketType;
    }
}

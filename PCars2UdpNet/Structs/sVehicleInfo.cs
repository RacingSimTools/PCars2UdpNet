using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PCars2UdpNet.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sVehicleInfo
    {
        /// <summary>
        /// 0 2
        /// </summary>
        public ushort sIndex;

        /// <summary>
        /// 2 6 
        /// </summary>
        public uint sClass;

        /// <summary>
        /// 6 70
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] sName;

        /// <summary>
        /// Two byte padding for the struct;
        /// </summary>
        public short padding;
    }
}

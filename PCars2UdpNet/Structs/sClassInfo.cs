using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PCars2UdpNet.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sClassInfo
    {
        /// <summary>
        /// 0 4 
        /// </summary>
        public uint sClassIndex;

        /// <summary>
        /// 4 24
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] sName;
    }
}

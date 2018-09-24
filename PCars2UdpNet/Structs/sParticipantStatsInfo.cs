using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PCars2UdpNet.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sParticipantStatsInfo
    {
        /// <summary>
        /// 0
        /// </summary>
        public float sFastestLapTime;

        /// <summary>
        /// 4
        /// </summary>
        public float sLastLapTime;

        /// <summary>
        /// 8
        /// </summary>
        public float sLastSectorTime;

        /// <summary>
        /// 11
        /// </summary>
        public float sFastestSector1Time;

        /// <summary>
        /// 16
        /// </summary>
        public float sFastestSector2Time;

        /// <summary>
        /// 20
        /// </summary>
        public float sFastestSector3Time;

        /// <summary>
        /// 24 (u16 rank type + u16 strength, 0 in SP races)
        /// </summary>
        public uint sParticipantOnlineRep;

        /// <summary>
        /// 28 -- matching sIndex from sParticipantsData
        /// </summary>
        public ushort sMPParticipantIndex;

        /// <summary>
        /// Two byte padding for the struct;
        /// </summary>
        public short padding;

    }
}

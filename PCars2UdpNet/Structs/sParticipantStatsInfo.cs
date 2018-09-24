// <copyright file="sParticipantStatsInfo.cs" company="Racing Sim Tools">
// Original work Copyright (c) MWL. All rights reserved.
//
// Modified work Copyright 2015 - 2018, Jim Britton and Contributors. [Crew Chief]
// Copyright (c) Racing Sim Tools. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace PCars2UdpNet.Structs
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Text;

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

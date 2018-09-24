// <copyright file="sRaceData.cs" company="Racing Sim Tools">
// Original work Copyright (c) MWL. All rights reserved.
//
// Modified work Copyright 2015 - 2018, Jim Britton and Contributors. [Crew Chief]
// Copyright (c) Racing Sim Tools. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PCars2UdpNet.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sRaceData : IPCars2Packet
    {
        /// <summary>
        /// 0 12
        /// </summary>
        public PacketBase sBase;

        /// <summary>
        /// 12
        /// </summary>
        public float sWorldFastestLapTime;

        /// <summary>
        /// 16
        /// </summary>
        public float sPersonalFastestLapTime;

        /// <summary>
        /// 20
        /// </summary>
        public float sPersonalFastestSector1Time;

        /// <summary>
        /// 24
        /// </summary>
        public float sPersonalFastestSector2Time;

        /// <summary>
        /// 28
        /// </summary>
        public float sPersonalFastestSector3Time;

        /// <summary>
        /// 32
        /// </summary>
        public float sWorldFastestSector1Time;

        /// <summary>
        /// 36
        /// </summary>
        public float sWorldFastestSector2Time;

        /// <summary>
        /// 40
        /// </summary>
        public float sWorldFastestSector3Time;

        /// <summary>
        /// 44
        /// </summary>
        public float sTrackLength;

        /// <summary>
        /// 48
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] sTrackLocation;

        /// <summary>
        /// 112
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] sTrackVariation;

        /// <summary>
        /// 176
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] sTranslatedTrackLocation;

        /// <summary>
        /// 240
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] sTranslatedTrackVariation;

        /// <summary>
        /// 304 contains lap number for lap based session or quantized session duration (number of 5mins) for timed sessions, the top bit is 1 for timed sessions
        /// </summary>
        public ushort sLapsTimeInEvent;

        /// <summary>
        /// 306
        /// </summary>
        public sbyte sEnforcedPitStopLap;

        /// <summary>
        /// Padded byte.
        /// </summary>
        public byte Padding;

        public PacketBase Base => this.sBase;

        public EPacketType PacketType => (EPacketType)this.sBase.mPacketType;
    }
}

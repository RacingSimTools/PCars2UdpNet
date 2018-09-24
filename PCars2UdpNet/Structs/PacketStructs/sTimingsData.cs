// <copyright file="sTimingsData.cs" company="Racing Sim Tools">
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
    public struct sTimingsData : IPCars2Packet
    {
        public PacketBase sBase;

        /// <summary>
        /// 12 --
        /// </summary>
        public sbyte sNumParticipants;

        /// <summary>
        /// 13 -- 
        /// </summary>
        public uint sParticipantsChangedTimestamp;

        /// <summary>
        /// 17  // time remaining, -1 for invalid time,  -1 - laps remaining in lap based races  --
        /// </summary>
        public float sEventTimeRemaining;

        /// <summary>
        /// 21 --
        /// </summary>
        public float sSplitTimeAhead;

        /// <summary>
        /// 25 -- 
        /// </summary>
        public float sSplitTimeBehind;

        /// <summary>
        /// 29 --
        /// </summary>
        public float sSplitTime;

        /// <summary>
        /// 33 1024
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public sParticipantInfo[] sParticipants;

        /// <summary>
        /// 1057 -- identifies which of the MP participants is the local player
        /// </summary>
        public ushort sLocalParticipantIndex;

        /// <summary>
        /// Tick count of the game
        /// TODO: Detailed explanation
        /// </summary>
        public uint TickCount;

        /// <inheritdoc/>
        public PacketBase Base => this.sBase;

        /// <inheritdoc/>
        public EPacketType PacketType => (EPacketType)this.sBase.mPacketType;
    }
}

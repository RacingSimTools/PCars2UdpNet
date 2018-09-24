// <copyright file="sTimeStatsData.cs" company="Racing Sim Tools">
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
    public struct sTimeStatsData : IPCars2Packet
    {
        public PacketBase sBase;

        public uint sParticipantsChangedTimestamp;                  // 12

        public sParticipantsStats sStats; // 16 + 768

        /// <inheritdoc/>
        public PacketBase Base => this.sBase;

        /// <inheritdoc/>
        public EPacketType PacketType => (EPacketType)this.sBase.mPacketType;
    }
}

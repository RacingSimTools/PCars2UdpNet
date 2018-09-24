// <copyright file="sParticipantsData.cs" company="Racing Sim Tools">
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
    public struct sParticipantsData : IPCars2Packet
    {
        public PacketBase sBase;

        public uint sParticipantsChangedTimestamp;

        /// <summary>
        /// 323
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
        public NameBytes[] sName;

        /// <summary>
        /// 1040 64 
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
        public uint[] sNationality;

        /// <summary>
        /// 1104 32 -- session unique index for MP races
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
        public ushort[] sIndex;

        /// <inheritdoc/>
        public PacketBase Base => this.sBase;

        /// <inheritdoc/>
        public EPacketType PacketType => (EPacketType)this.sBase.mPacketType;

    }
}

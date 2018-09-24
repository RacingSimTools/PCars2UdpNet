// <copyright file="sGameStateData.cs" company="Racing Sim Tools">
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
    public struct sGameStateData : IPCars2Packet
    {
        public PacketBase sBase;

        /// <summary>
        /// 12
        /// </summary>
        public ushort mBuildVersionNumber;

        /// <summary>
        /// 15 -- first 3 bits are used for game state enum, second 3 bits for session state enum See shared memory example file for the enums
        /// </summary>
        public byte mGameState;

        /// <summary>
        /// 16
        /// </summary>
        public sbyte sAmbientTemperature;

        /// <summary>
        /// 17
        /// </summary>
        public sbyte sTrackTemperature;

        /// <summary>
        /// 18
        /// </summary>
        public byte sRainDensity;

        /// <summary>
        /// 19
        /// </summary>
        public byte sSnowDensity;

        /// <summary>
        /// 20
        /// </summary>
        public sbyte sWindSpeed;

        /// <summary>
        /// 21
        /// </summary>
        public sbyte sWindDirectionX;

        /// <summary>
        /// 22 padded to 24
        /// </summary>
        public sbyte sWindDirectionY;

        /// <summary>
        /// Two byte padding for the struct;
        /// </summary>
        public short padding;

        public PacketBase Base => this.sBase;

        public EPacketType PacketType => (EPacketType)this.sBase.mPacketType;

        public EGameState GameState => (EGameState)(this.mGameState >> 4);

        public ESessionState SessionState => (ESessionState)(this.mGameState & 15);
    }
}

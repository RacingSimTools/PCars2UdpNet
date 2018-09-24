// <copyright file="PacketBase.cs" company="Racing Sim Tools">
// Copyright (c) Racing Sim Tools. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace PCars2UdpNet.Structs
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Text;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PacketBase
    {
        /// <summary>
        /// 0 counter reflecting all the packets that have been sent during the game run
        /// </summary>
        public uint mPacketNumber;

        /// <summary>
        /// 4 counter of the packet groups belonging to the given category
        /// </summary>
        public uint mCategoryPacketNumber;

        /// <summary>
        /// 8 If the data from this class had to be sent in several packets, the index number
        /// </summary>
        public byte mPartialPacketIndex;

        /// <summary>
        /// 9 If the data from this class had to be sent in several packets, the total number
        /// </summary>
        public byte mPartialPacketNumber;

        /// <summary>
        /// 10 what is the type of this packet (see EUDPStreamerPacketHanlderType for details)
        /// </summary>
        public byte mPacketType;

        /// <summary>
        /// 11 what is the version of protocol for this handler, to be bumped with data structure change
        /// </summary>
        public byte mPacketVersion;

    }
}

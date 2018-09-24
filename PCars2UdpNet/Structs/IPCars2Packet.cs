// <copyright file="IPCars2Packet.cs" company="Racing Sim Tools">
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
    using System.Text;

    /// <summary>
    /// Interface representing a packet recieved from project cars 2.
    /// </summary>
    public interface IPCars2Packet
    {
        /// <summary>
        /// Gets the base of the packet containing data sent in every packet.
        /// </summary>
        PacketBase Base { get; }

        /// <summary>
        /// Gets the type of the packet. <see cref="EPacketType"/>
        /// </summary>
        EPacketType PacketType { get; }
    }
}

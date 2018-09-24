// <copyright file="sParticipantInfo.cs" company="Racing Sim Tools">
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
    public struct sParticipantInfo
    {
        /// <summary>
        /// 0 -- 
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
        public short[] sWorldPosition;

        /// <summary>
        /// 6 -- Quantized heading (-PI .. +PI) , Quantized pitch (-PI / 2 .. +PI / 2),  Quantized bank (-PI .. +PI).
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
        public short[] sOrientation;

        /// <summary>
        /// 12 --
        /// </summary>
        public ushort sCurrentLapDistance;

        /// <summary>
        /// 14 -- holds the race position, + top bit shows if the participant is active or not
        /// </summary>
        public byte sRacePosition;

        /// <summary>
        /// 15 -- sector + extra precision bits for x/z position
        /// </summary>
        public byte sSector;

        /// <summary>
        /// 16 -- (enum 3 bits/enum 2 bits) Flag colour and reason
        /// </summary>
        public byte sHighestFlag;

        /// <summary>
        /// 17 -- (enum 3 bits/enum 2 bits) Pit mode and Pit schedule 
        /// </summary>
        public byte sPitModeSchedule;

        /// <summary>
        /// 18 -- top bit shows if participant is (local or remote) human player or not
        /// </summary>
        public ushort sCarIndex;

        /// <summary>
        /// 20 -- race state flags + invalidated lap indication --
        /// </summary>
        public byte sRaceState;

        /// <summary>
        /// 21 -- 
        /// </summary>
        public byte sCurrentLap;

        /// <summary>
        /// 22 --
        /// </summary>
        public float sCurrentTime;

        /// <summary>
        /// 26 --
        /// </summary>
        public float sCurrentSectorTime;

        /// <summary>
        /// 30 -- matching sIndex from sParticipantsData
        /// </summary>
        public ushort sMPParticipantIndex;

        public EFlagColour FlagColour => (EFlagColour)(this.sHighestFlag >> 4);

        public EFlagReason FlagReason => (EFlagReason)(this.sHighestFlag & 15);

        public EPitMode PitMode => (EPitMode)(this.sPitModeSchedule >> 4);

        public EPitSchedule PitSchedule => (EPitSchedule)(this.sPitModeSchedule & 15);
    }
}

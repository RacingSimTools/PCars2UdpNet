// <copyright file="sVehicleInfo.cs" company="Racing Sim Tools">
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
    public struct sVehicleInfo
    {
        /// <summary>
        /// 0 2
        /// </summary>
        public ushort sIndex;

        /// <summary>
        /// 2 6 
        /// </summary>
        public uint sClass;

        /// <summary>
        /// 6 70
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] sName;

        /// <summary>
        /// Two byte padding for the struct;
        /// </summary>
        public short padding;
    }
}

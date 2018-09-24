// <copyright file="NameBytes.cs" company="Racing Sim Tools">
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
    public struct NameBytes
    {
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] nameByteArray;
    }
}

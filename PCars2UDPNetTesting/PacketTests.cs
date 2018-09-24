// <copyright file="PacketTests.cs" company="Racing Sim Tools">
// Original work Copyright (c) MWL. All rights reserved.
//
// Modified work Copyright 2015 - 2018, Jim Britton and Contributors. [Crew Chief]
// Copyright (c) Racing Sim Tools. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace PCars2UDPNetTesting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;
    using PCars2UdpNet.Structs;
    using Xunit;

    public class PacketTests
    {
        [Fact]
        public void TelemSizeTest()
        {
            Assert.Equal(559, Marshal.SizeOf<sTelemetryData>());
        }

        [Fact]
        public void RaceSizeTest()
        {
            Assert.Equal(308, Marshal.SizeOf<sRaceData>());
        }

        [Fact]
        public void PartSizeTest()
        {
            Assert.Equal(1136, Marshal.SizeOf<sParticipantsData>());
        }

        [Fact]
        public void TimingsSizeTest()
        {
            Assert.Equal(1063, Marshal.SizeOf<sTimingsData>());
        }

        [Fact]
        public void StateSizeTest()
        {
            Assert.Equal(24, Marshal.SizeOf<sGameStateData>());
        }

        [Fact]
        public void TimeStatsSizeTest()
        {
            Assert.Equal(1040, Marshal.SizeOf<sTimeStatsData>());
        }

        [Fact]
        public void PartVehicleSizeTest()
        {
            Assert.Equal(1164, Marshal.SizeOf<sParticipantVehicleNamesData>());
        }

        [Fact]
        public void VehicleClassSizeTest()
        {
            Assert.Equal(1452, Marshal.SizeOf<sVehicleClassNamesData>());
        }
    }
}

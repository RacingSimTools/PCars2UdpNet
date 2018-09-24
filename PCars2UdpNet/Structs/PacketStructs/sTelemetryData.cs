// <copyright file="sTelemetryData.cs" company="Racing Sim Tools">
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
    using System.Runtime.InteropServices;

    /// <summary>
    /// Structure of the telemetry packet
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct sTelemetryData : IPCars2Packet
    {
        public PacketBase sBase;

        /// <summary>
        /// Index of the participant run in the game client.
        /// Byte: 12
        /// </summary>
        public sbyte sViewedParticipantIndex;

        /// <summary>
        /// Unfiltered throttle input - quite noisy. [RANGE = 0 -> 255]
        /// </summary>
        public byte sUnfilteredThrottle;

        /// <summary>
        /// Unfiltered brake input - quite noisiy. [RANGE = 0 -> 255]
        /// </summary>
        public byte sUnfilteredBrake;

        /// <summary>
        /// Unfiltered steering input - quite noisy. [RANGE = -127 -> +127]
        /// </summary>
        public sbyte sUnfilteredSteering;

        /// <summary>
        /// Unfiltered clutch input - quite noisy.
        /// </summary>
        public byte sUnfilteredClutch;

        /// <summary>
        /// Flags for different car states. <see cref="ECarFlags"/>
        /// </summary>
        public byte sCarFlags;

        /// <summary>
        /// Engine oil temperature in degrees celsius.
        /// </summary>
        public short sOilTempCelsius;

        /// <summary>
        /// Engine oil pressure in kPa.
        /// </summary>
        public ushort sOilPressureKPa;

        /// <summary>
        /// Engine water temperature in degrees celsius.
        /// </summary>
        public short sWaterTempCelsius;

        /// <summary>
        /// Engine water pressure in kPa.
        /// </summary>
        public ushort sWaterPressureKPa;

        /// <summary>
        /// Fuel pressure in kPa.
        /// </summary>
        public ushort sFuelPressureKPa;

        /// <summary>
        /// Fuel capacity in litres
        /// </summary>
        public byte sFuelCapacity;

        /// <summary>
        /// Filtered brake input. [RANGE = 0 -> 255]
        /// </summary>
        public byte sBrake;

        /// <summary>
        /// Filtered throttle input. [RANGE = 0 -> 255]
        /// </summary>
        public byte sThrottle;

        /// <summary>
        /// Filtered clutch input. [RANGE = 0 -> 255]
        /// </summary>
        public byte sClutch;

        /// <summary>
        /// Fuel level of the car as a fraction of 1. [RANGE = 0.0f -> 1.0f]
        /// TODO: Confirm range.
        /// </summary>
        public float sFuelLevel;

        /// <summary>
        /// Speed of the car in meters-per-second (m/s).
        /// </summary>
        public float sSpeed;

        /// <summary>
        /// Revolutions per minute of the drivetrain.
        /// </summary>
        public ushort sRpm;

        /// <summary>
        /// Maximum RPM of the car.
        /// </summary>
        public ushort sMaxRpm;

        /// <summary>
        /// Filtered steering input [RANGE = -127 -> +127].
        /// TODO: Confirm range.
        /// </summary>
        public sbyte sSteering;

        /// <summary>
        /// Byte containing data for the number of gears and the currently selected gears.
        /// <see cref="SelectedGear"/> and <see cref="NumGears"/>.
        /// </summary>
        public byte sGearNumGears;

        /// <summary>
        /// Current boost amount as a percentage.
        /// TODO: Confirm unit.
        /// </summary>
        public byte sBoostAmount;

        /// <summary>
        /// Crash damage state of the car. <see cref="ECrashDamageState"/>
        /// </summary>
        public byte sCrashState;

        /// <summary>
        /// The odometer of the car in km.
        /// </summary>
        public float sOdometerKM;

        /// <summary>
        /// Orientation of the car in Euler Angles.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] sOrientation;

        /// <summary>
        /// Local velocity of the car in m/s.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] sLocalVelocity;

        /// <summary>
        /// Velocity of the car relative to the world in m/s.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] sWorldVelocity;

        /// <summary>
        /// Angular Velocity of the car in Radians per second.
        /// TODO: Confirm unit.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] sAngularVelocity;

        /// <summary>
        /// Local acceleration of the car in m/s.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] sLocalAcceleration;

        /// <summary>
        /// Acceleration of the car relative to the world in m/s.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] sWorldAcceleration;

        /// <summary>
        /// Centre position of the world.
        /// TODO: Confirm.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] sExtentsCentre;

        /// <summary>
        /// Flags related to each tyre. <see cref="ETyreFlags"/>
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] sTyreFlags;

        /// <summary>
        /// Terrain touched by each tyre. <see cref="ETerrainMaterial"/>
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] sTerrain;

        /// <summary>
        /// Local tyre Y position.
        /// [ FL , FR, RL, RR ]
        /// TODO: Confirm??
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] sTyreY;

        /// <summary>
        /// Angular velocity of each wheel in revolutions per second.
        /// [ FL , FR, RL, RR ].
        /// TODO: Confirm unit.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] sTyreRPS;

        /// <summary>
        /// Temperature for each tyre in degress Celsius.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] sTyreTemp;

        /// <summary>
        /// Height of each tyre above ground in meters.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] sTyreHeightAboveGround;

        /// <summary>
        /// Wear for each tyre as a fraction of 255.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] sTyreWear;

        /// <summary>
        /// Brake damage at each wheel as a fraction of 255.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] sBrakeDamage;

        /// <summary>
        /// Suspension damage at each wheel as a fraction of 255.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] sSuspensionDamage;

        /// <summary>
        /// Temperature of the brakes at each wheel in degrees Celsius.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public short[] sBrakeTempCelsius;

        /// <summary>
        /// Temperature of the tread for each tyre in Kelvin.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] sTyreTreadTemp;

        /// <summary>
        /// Temperature of the layer for each tyre in Kelvin.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] sTyreLayerTemp;

        /// <summary>
        /// Temperature of the carcass for each tyre in Kelvin.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] sTyreCarcassTemp;

        /// <summary>
        /// Temperature of the rim for each wheel in Kelvin.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] sTyreRimTemp;

        /// <summary>
        /// Temperature of the air inside each wheel in Kelvin.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] sTyreInternalAirTemp;

        /// <summary>
        /// Temperature on the left side of each tyre in degrees Celsius.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] sTyreTempLeft;

        /// <summary>
        /// Temperature in the centre of each tyre in degrees Celsius.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] sTyreTempCenter;

        /// <summary>
        /// Temperature on the right side of each tyre in degrees Celsius.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] sTyreTempRight;

        /// <summary>
        /// Position of the wheel relative to the car.
        /// [ FL , FR, RL, RR ]
        /// TODO: Unit and centre point.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] sWheelLocalPositionY;

        /// <summary>
        /// Ride height of the car at each wheel in meters.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] sRideHeight;

        /// <summary>
        /// Travel of the suspension at each wheel in meters.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] sSuspensionTravel;

        /// <summary>
        /// Rate of change of pushrod deflection at each wheel in m/s.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] sSuspensionVelocity;

        /// <summary>
        /// Ride heigth of the suspension at each wheel in centimeters.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] sSuspensionRideHeight;

        /// <summary>
        /// Air pressure of each tyre in centibar.
        /// [ FL , FR, RL, RR ]
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] sAirPressure;

        /// <summary>
        /// Speed of the engine in Rad/s.
        /// </summary>
        public float sEngineSpeed;

        /// <summary>
        /// Torque of the engine in Nm.
        /// </summary>
        public float sEngineTorque;

        /// <summary>
        /// Value that shows how much of the available wing is used.
        /// 0 = Least amount of wing for car | 255 = Max amount of wing for car
        /// Wings[0] = front | Wings[1] = Rear
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] sWings;

        /// <summary>
        /// Amount of handbrake applied as a fraction of 255.
        /// </summary>
        public byte sHandBrake;

        /// <summary>
        /// Damage to the aerodynamics of the car as a fraction of 255.
        /// </summary>
        public byte sAeroDamage;

        /// <summary>
        /// Damage to the engine of the car as a fraction of 255.
        /// </summary>
        public byte sEngineDamage;

        /// <summary>
        /// Joy pad ? TODO: Figure out.
        /// </summary>
        public uint sJoyPad0;

        /// <summary>
        /// Dpad ? TODO: Figure out
        /// </summary>
        public byte sDPad;

        /// <summary>
        /// Front left tyre compound name.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40)]
        public byte[] flTyreCompound;

        /// <summary>
        /// Front right tyre compound name.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40)]
        public byte[] frTyreCompound;

        /// <summary>
        /// Rear left tyre compound name.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40)]
        public byte[] rlTyreCompound;

        /// <summary>
        /// Rear right tyre compound name.
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40)]
        public byte[] rrTyreCompound;

        /// <summary>
        /// Turbo boost pressure.
        /// TODO: unit of fraction?
        /// </summary>
        public float sTurboBoostPressure;

        /// <summary>
        /// position of the viewed participant.
        /// TODO: unit or fraction?
        /// </summary>
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
        public float[] sFullPosition;

        /// <summary>
        /// Quantized brake bias.
        /// TODO: Unit/explain value.
        /// </summary>
        public byte sBrakeBias;

        /// <summary>
        /// Tick count of the game
        /// TODO: Detailed explanation
        /// </summary>
        public uint TickCount;

        /// <summary>
        /// Gets the currently selected gear.
        /// [ -1 = reverse | 0 = neutral | 1 = gear 1 | etc. ]
        /// </summary>
        public byte SelectedGear { get => (byte)(this.sGearNumGears & 15); }

        /// <summary>
        /// Gets the number of gears in the car.
        /// </summary>
        public byte NumGears { get => (byte)(this.sGearNumGears >> 4); }

        /// <inheritdoc/>
        public PacketBase Base => this.sBase;

        /// <inheritdoc/>
        public EPacketType PacketType => (EPacketType)this.sBase.mPacketType;
    }
}

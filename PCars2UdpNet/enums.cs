// <copyright file="enums.cs" company="Racing Sim Tools">
// Original work Copyright (c) MWL. All rights reserved.
//
// Modified work Copyright 2015 - 2018, Jim Britton and Contributors. [Crew Chief]
// Copyright (c) Racing Sim Tools. All rights reserved.
//
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
#pragma warning disable SA1602 // Enumeration items must be documented
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace PCars2UdpNet
{
    using System;

    /// <summary>
    /// Type of the packet.
    /// </summary>
    public enum EPacketType
    {
        CarPhysics = 0,
        RaceDefinition = 1,
        Participants = 2,
        Timings = 3,
        GameState = 4,
        WeatherState = 5, // not sent at the moment, information can be found in the game state packet
        VehicleNames = 6, //  sent at the moment
        TimeStats = 7,
        ParticipantVehicleNames = 8
    }

    /// <summary>
    /// (Type#1) GameState (to be used with 'mGameState')
    /// </summary>
    public enum EGameState
    {
        Exited = 0,
        FrontEnd = 1,
        Playing = 2,
        Paused = 3,
        InMenuTimeTicking = 4,
        Restarting = 5,
        Replay = 6,
        FrontEndReplay = 7,
    }

    /// <summary>
    /// /// (Type#2) Session state (to be used with 'mSessionState')
    /// </summary>
    public enum ESessionState
    {
        Invalid = 0,
        Practice = 1,
        Test = 2,
        Qualify = 3,
        FormationLap = 4,
        Race = 5,
        TimeAttack = 6,
    }

    /// <summary>
    /// (Type#3) RaceState (to be used with 'mRaceState' and 'mRaceStates')
    /// </summary>
    public enum ERaceState
    {
        Invalid = 0,
        NotStarted = 1,
        Racing = 2,
        Finished = 3,
        Disqualified = 4,
        Retired = 5,
        Dnf = 6,
    }

    /// <summary>
    /// (Type#5) Flag Colours (to be used with 'mHighestFlagColour')
    /// </summary>
    public enum EFlagColour
    {
        /// <summary>
        /// Not used for actual flags, only for some query functions
        /// </summary>
        None = 0,

        /// <summary>
        /// End of danger zone, or race started
        /// </summary>
        Green = 1,

        /// <summary>
        /// Faster car wants to overtake the participant
        /// </summary>
        Blue = 2,

        /// <summary>
        /// Slow car in area
        /// </summary>
        WhiteSlowCar = 3,

        /// <summary>
        /// Final Lap
        /// </summary>
        WhiteFinalLap = 4,

        /// <summary>
        /// Huge collisions where one or more cars become wrecked and block the track
        /// </summary>
        Red = 5,

        /// <summary>
        /// Danger on the racing surface itself
        /// </summary>
        Yellow = 6,

        /// <summary>
        /// Danger that wholly or partly blocks the racing surface
        /// </summary>
        DoubleYellow = 7,

        /// <summary>
        /// Unsportsmanlike conduct
        /// </summary>
        BlackAndWhite = 8,

        /// <summary>
        /// Mechanical Failure
        /// </summary>
        BlackOrangeCircle = 9,

        /// <summary>
        /// Participant disqualified
        /// </summary>
        Black = 10,

        /// <summary>
        /// Chequered flag
        /// </summary>
        Chequered = 11
    }

    /// <summary>
    /// (Type#6) Flag Reason (to be used with 'mHighestFlagReason')
    /// </summary>
    public enum EFlagReason
    {
        None = 0,
        SoloCrash = 1,
        VehicleCrash = 2,
        VehicleObstruction = 3,
    }

    /// <summary>
    /// (Type#7) Pit Mode (to be used with 'mPitMode')
    /// </summary>
    public enum EPitMode
    {
        None = 0,
        DrivingIntoPits = 1,
        InPit = 2,
        DrivingOutPits = 3,
        InGarage = 4,
        DrivingOutGarage = 5
    }

    /// <summary>
    /// (Type#8) Pit Stop Schedule (to be used with 'mPitSchedule')
    /// </summary>
    public enum EPitSchedule
    {
        None = 0,            // Nothing scheduled
        PlayerRequested = 1,    // Used for standard pit sequence - requested by player
        EngineerRequested = 2,  // Used for standard pit sequence - requested by engineer
        PitScheduleDamageRequested = 3,    // Used for standard pit sequence - requested by engineer for damage
        PitScheduleMandatory = 4,           // Used for standard pit sequence - requested by engineer from career enforced lap number
        PitScheduleDriveThrough = 5,       // Used for drive-through penalty
        PitScheduleStopGo = 6,             // Used for stop-go penalty
        PitSchedulePitspotOccupied = 7,    // Used for drive-through when pitspot is occupied
    }

    /// <summary>
    /// (Type#9) Car Flags (to be used with 'mCarFlags')
    /// </summary>
    [Flags]
    public enum ECarFlags
    {
        None = 0,
        CarHeadlight = 1 << 0,
        CarEngineActive = 1 << 1,
        CarEngineWarning = 1 << 2,
        CarSpeedLimiter = 1 << 3,
        CarAbs = 1 << 4,
        CarHandbrake = 1 << 5,
    }

    /// <summary>
    /// (Type#10) Tyre Flags (to be used with 'mTyreFlags')
    /// </summary>
    [Flags]
    public enum ETyreFlags
    {
        None = 0,
        TyreAttached = 1 << 0,
        TyreInflated = 1 << 1,
        TyreIsOnGround = 1 << 2,
    }

    /// <summary>
    /// (Type#11) Terrain Materials (to be used with 'mTerrain')
    /// </summary>
    public enum ETerrainMaterial
    {
        TerrainRoad = 0,
        TerrainLowGripRoad = 1,
        TerrainBumpyRoad1 = 2,
        TerrainBumpyRoad2 = 3,
        TerrainBumpyRoad3 = 4,
        TerrainMarbles = 5,
        TerrainGrassyBerms = 6,
        TerrainGrass = 7,
        TerrainGravel = 8,
        TerrainBumpyGravel = 9,
        TerrainRumbleStrips = 10,
        TerrainDrains = 11,
        TerrainTyrewalls = 12,
        TerrainCementwalls = 13,
        TerrainGuardrails = 14,
        TerrainSand = 15,
        TerrainBumpySand = 16,
        TerrainDirt = 17,
        TerrainBumpyDirt = 18,
        TerrainDirtRoad = 19,
        TerrainBumpyDirtRoad = 20,
        TerrainPavement = 21,
        TerrainDirtBank = 22,
        TerrainWood = 23,
        TerrainDryVerge = 24,
        TerrainExitRumbleStrips = 25,
        TerrainGrasscrete = 26,
        TerrainLongGrass = 27,
        TerrainSlopeGrass = 28,
        TerrainCobbles = 29,
        TerrainSandRoad = 30,
        TerrainBakedClay = 31,
        TerrainAstroturf = 32,
        TerrainSnowhalf = 33,
        TerrainSnowfull = 34,
        TerrainDamagedRoad1 = 35,
        TerrainTrainTrackRoad = 36,
        TerrainBumpycobbles = 37,
        TerrainAriesOnly = 38,
        TerrainOrionOnly = 39,
        TerrainB1rumbles = 40,
        TerrainB2rumbles = 41,
        TerrainRoughSandMedium = 42,
        TerrainRoughSandHeavy = 43,
        TerrainSnowwalls = 44,
        TerrainIceRoad = 45,
        TerrainRunoffRoad = 46,
        TerrainIllegalStrip = 47,
        TerrainPaintConcrete = 48,
        TerrainPaintConcreteIllegal = 49,
        TerrainRallyTarmac = 50
    }

    /// <summary>
    /// (Type#12) Crash Damage State  (to be used with 'mCrashState')
    /// </summary>
    public enum ECrashDamageState
    {
        CrashDamageNone = 0,
        CrashDamageOfftrack = 1,
        CrashDamageLargeProp = 2,
        CrashDamageSpinning = 3,
        CrashDamageRolling = 4,
    }
}

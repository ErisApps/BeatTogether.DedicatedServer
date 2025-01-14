﻿using BeatTogether.DedicatedServer.Messaging.Enums;
using BeatTogether.LiteNetLib.Abstractions;
using BeatTogether.LiteNetLib.Extensions;
using Krypton.Buffers;

namespace BeatTogether.DedicatedServer.Messaging.Models
{
    public sealed class LevelCompletionResults : INetSerializable
    {
        public GameplayModifiers GameplayModifiers { get; set; } = new();
        public int ModifiedScore { get; set; }
        public int RawScore { get; set; }
        public Rank Rank { get; set; }
        public bool FullCombo { get; set; }
        public float LeftSaberMovementDistance { get; set; }
        public float RightSaberMovementDistance { get; set; }
        public float LeftHandMovementDistance { get; set; }
        public float RightHandMovementDistance { get; set; }
        public float SongDuration { get; set; }
        public LevelEndStateType LevelEndStateType { get; set; }
        public LevelEndAction LevelEndAction { get; set; }
        public float Energy { get; set; }
        public int GoodCutsCount { get; set; }
        public int BadCutsCount { get; set; }
        public int MissedCount { get; set; }
        public int NotGoodCount { get; set; }
        public int OkCount { get; set; }
        public int AverageCutScore { get; set; }
        public int MaxCutScore { get; set; }
        public float AverageCutDistanceRawScore { get; set; }
        public int MaxCombo { get; set; }
        public float MinDirDeviation { get; set; }
        public float MaxDirDeviation { get; set; }
        public float AverageDirDeviation { get; set; }
        public float MinTimeDeviation { get; set; }
        public float MaxTimeDeviation { get; set; }
        public float AverageTimeDeviation { get; set; }
        public float EndSongTime { get; set; }

        public void ReadFrom(ref SpanBufferReader reader)
        {
            GameplayModifiers.ReadFrom(ref reader);
            ModifiedScore = reader.ReadVarInt();
            RawScore = reader.ReadVarInt();
            Rank = (Rank)reader.ReadVarInt();
            FullCombo = reader.ReadBool();
            LeftSaberMovementDistance = reader.ReadFloat32();
            RightSaberMovementDistance = reader.ReadFloat32();
            LeftHandMovementDistance = reader.ReadFloat32();
            RightHandMovementDistance = reader.ReadFloat32();
            SongDuration = reader.ReadFloat32();
            LevelEndStateType = (LevelEndStateType)reader.ReadVarInt();
            LevelEndAction = (LevelEndAction)reader.ReadVarInt();
            Energy = reader.ReadFloat32();
            GoodCutsCount = reader.ReadVarInt();
            BadCutsCount = reader.ReadVarInt();
            MissedCount = reader.ReadVarInt();
            NotGoodCount = reader.ReadVarInt();
            OkCount = reader.ReadVarInt();
            AverageCutScore = reader.ReadVarInt();
            MaxCutScore = reader.ReadVarInt();
            AverageCutDistanceRawScore = reader.ReadFloat32();
            MaxCombo = reader.ReadVarInt();
            MinDirDeviation = reader.ReadFloat32();
            MaxDirDeviation = reader.ReadFloat32();
            AverageDirDeviation = reader.ReadFloat32();
            MinTimeDeviation = reader.ReadFloat32();
            MaxTimeDeviation = reader.ReadFloat32();
            AverageTimeDeviation = reader.ReadFloat32();
            EndSongTime = reader.ReadFloat32();
        }

        public void WriteTo(ref SpanBufferWriter writer)
        {
            GameplayModifiers.WriteTo(ref writer);
            writer.WriteVarInt(ModifiedScore);
            writer.WriteVarInt(RawScore);
            writer.WriteVarInt((int)Rank);
            writer.WriteBool(FullCombo);
            writer.WriteFloat32(LeftSaberMovementDistance);
            writer.WriteFloat32(RightSaberMovementDistance);
            writer.WriteFloat32(LeftHandMovementDistance);
            writer.WriteFloat32(RightHandMovementDistance);
            writer.WriteFloat32(SongDuration);
            writer.WriteVarInt((int)LevelEndStateType);
            writer.WriteVarInt((int)LevelEndAction);
            writer.WriteFloat32(Energy);
            writer.WriteVarInt(GoodCutsCount);
            writer.WriteVarInt(BadCutsCount);
            writer.WriteVarInt(MissedCount);
            writer.WriteVarInt(NotGoodCount);
            writer.WriteVarInt(OkCount);
            writer.WriteVarInt(AverageCutScore);
            writer.WriteVarInt(MaxCutScore);
            writer.WriteFloat32(AverageCutDistanceRawScore);
            writer.WriteVarInt(MaxCombo);
            writer.WriteFloat32(MinDirDeviation);
            writer.WriteFloat32(MaxDirDeviation);
            writer.WriteFloat32(AverageDirDeviation);
            writer.WriteFloat32(MinTimeDeviation);
            writer.WriteFloat32(MaxTimeDeviation);
            writer.WriteFloat32(AverageTimeDeviation);
            writer.WriteFloat32(EndSongTime);
        }
    }
}

﻿using BeatTogether.DedicatedServer.Messaging.Abstractions;
using BeatTogether.DedicatedServer.Messaging.Models;
using Krypton.Buffers;

namespace BeatTogether.DedicatedServer.Messaging.Packets.MultiplayerSession.GameplayRpc
{
    public sealed class LevelFinishedPacket : BaseRpcPacket
    {
        public MultiplayerLevelCompletionResults Results { get; set; } = new();

        public override void ReadFrom(ref SpanBufferReader reader)
        {
            base.ReadFrom(ref reader);
            Results.ReadFrom(ref reader);
        }

        public override void WriteTo(ref SpanBufferWriter writer)
        {
            base.WriteTo(ref writer);
            Results.WriteTo(ref writer);
        }
    }
}

﻿using BeatTogether.DedicatedServer.Messaging.Abstractions;
using BeatTogether.DedicatedServer.Messaging.Models;
using Krypton.Buffers;

namespace BeatTogether.DedicatedServer.Messaging.Packets.MultiplayerSession.MenuRpc
{
    public sealed class SetRecommendedBeatmapPacket : BaseRpcPacket
    {
        public BeatmapIdentifier BeatmapIdentifier { get; set; } = new();

        public override void ReadFrom(ref SpanBufferReader reader)
        {
            base.ReadFrom(ref reader);
            BeatmapIdentifier.ReadFrom(ref reader);
        }

        public override void WriteTo(ref SpanBufferWriter writer)
        {
            base.WriteTo(ref writer);
            BeatmapIdentifier.WriteTo(ref writer);
        }
    }
}

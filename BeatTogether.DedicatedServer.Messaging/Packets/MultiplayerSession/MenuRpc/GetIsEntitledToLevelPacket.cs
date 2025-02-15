﻿using BeatTogether.DedicatedServer.Messaging.Abstractions;
using BeatTogether.LiteNetLib.Extensions;
using Krypton.Buffers;

namespace BeatTogether.DedicatedServer.Messaging.Packets.MultiplayerSession.MenuRpc
{
    public sealed class GetIsEntitledToLevelPacket : BaseRpcPacket
    {
        public string LevelId { get; set; } = null!;

        public override void ReadFrom(ref SpanBufferReader reader)
        {
            base.ReadFrom(ref reader);
            LevelId = reader.ReadString();
        }

        public override void WriteTo(ref SpanBufferWriter writer)
        {
            base.WriteTo(ref writer);
            writer.WriteString(LevelId);
        }
    }
}

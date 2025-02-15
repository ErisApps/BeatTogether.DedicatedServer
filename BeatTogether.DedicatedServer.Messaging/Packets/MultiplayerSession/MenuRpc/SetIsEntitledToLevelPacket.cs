﻿using BeatTogether.DedicatedServer.Messaging.Abstractions;
using BeatTogether.DedicatedServer.Messaging.Enums;
using BeatTogether.LiteNetLib.Extensions;
using Krypton.Buffers;

namespace BeatTogether.DedicatedServer.Messaging.Packets.MultiplayerSession.MenuRpc
{
    public sealed class SetIsEntitledToLevelPacket : BaseRpcPacket
    {
        public string LevelId { get; set; } = null!;
        public EntitlementStatus Entitlement { get; set; }

        public override void ReadFrom(ref SpanBufferReader reader)
        {
            base.ReadFrom(ref reader);
            LevelId = reader.ReadString();
            Entitlement = (EntitlementStatus)reader.ReadVarInt();
        }

        public override void WriteTo(ref SpanBufferWriter writer)
        {
            base.WriteTo(ref writer);
            writer.WriteString(LevelId);
            writer.WriteVarInt((int)Entitlement);
        }
    }
}

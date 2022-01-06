﻿using BeatTogether.DedicatedServer.Messaging.Abstractions;
using BeatTogether.DedicatedServer.Messaging.Models;
using Krypton.Buffers;

namespace BeatTogether.DedicatedServer.Messaging.Packets.MultiplayerSession.GameplayRpc
{
    public sealed class SetPlayerDidConnectLatePacket : BaseRpcPacket
    {
        public string UserId { get; set; } = null!;
        public PlayerSpecificSettingsAtStart PlayersAtStart { get; set; } = new();
        public string SessionGameId { get; set; } = null!;

        public override void ReadFrom(ref SpanBufferReader reader)
        {
            base.ReadFrom(ref reader);
            UserId = reader.ReadUTF8String();
            PlayersAtStart.ReadFrom(ref reader);
            SessionGameId = reader.ReadUTF8String();
        }

        public override void WriteTo(ref SpanBufferWriter writer)
        {
            base.WriteTo(ref writer);
            writer.WriteUTF8String(UserId);
            PlayersAtStart.WriteTo(ref writer);
            writer.WriteUTF8String(SessionGameId);
        }
    }
}

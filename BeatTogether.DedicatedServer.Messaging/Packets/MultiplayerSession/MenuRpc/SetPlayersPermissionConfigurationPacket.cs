﻿using BeatTogether.DedicatedServer.Messaging.Abstractions;
using BeatTogether.DedicatedServer.Messaging.Models;
using Krypton.Buffers;

namespace BeatTogether.DedicatedServer.Messaging.Packets.MultiplayerSession.MenuRpc
{
    public sealed class SetPlayersPermissionConfigurationPacket : BaseRpcPacket
    {
        public PlayersPermissionConfiguration PermissionConfiguration { get; set; } = new();

        public override void ReadFrom(ref SpanBufferReader reader)
        {
            base.ReadFrom(ref reader);
            PermissionConfiguration.ReadFrom(ref reader);
        }

        public override void WriteTo(ref SpanBufferWriter writer)
        {
            base.WriteTo(ref writer);
            PermissionConfiguration.WriteTo(ref writer);
        }
    }
}

﻿using BeatTogether.DedicatedServer.Messaging.Abstractions;
using BeatTogether.DedicatedServer.Messaging.Enums;
using BeatTogether.LiteNetLib.Extensions;
using Krypton.Buffers;

namespace BeatTogether.DedicatedServer.Messaging.Packets.MultiplayerSession.MenuRpc
{
    public sealed class SetMultiplayerGameStatePacket : BaseRpcPacket
    {
        public MultiplayerGameState State { get; set; }

        public override void ReadFrom(ref SpanBufferReader reader)
        {
            base.ReadFrom(ref reader);
            State = (MultiplayerGameState)reader.ReadVarInt();
        }

        public override void WriteTo(ref SpanBufferWriter writer)
        {
            base.WriteTo(ref writer);
            writer.WriteVarInt((int)State);
        }
    }
}

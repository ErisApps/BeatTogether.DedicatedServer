﻿using BeatTogether.LiteNetLib.Abstractions;
using BeatTogether.LiteNetLib.Enums;

namespace BeatTogether.DedicatedServer.Kernel.Abstractions
{
    public interface IPacketDispatcher
    {
        void SendToPlayer(IPlayer player, INetSerializable packet, DeliveryMethod deliveryMethod);
        void SendFromPlayerToPlayer(IPlayer fromPlayer, IPlayer toPlayer, INetSerializable packet, DeliveryMethod deliveryMethod);
        void SendToNearbyPlayers(INetSerializable packet, DeliveryMethod deliveryMethod);
		void SendExcludingPlayer(IPlayer excludedPlayer, INetSerializable packet, DeliveryMethod deliveryMethod);
		void SendFromPlayer(IPlayer fromPlayer, INetSerializable packet, DeliveryMethod deliveryMethod);
	}
}

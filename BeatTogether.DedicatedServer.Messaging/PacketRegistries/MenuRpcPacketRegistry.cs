﻿using BeatTogether.DedicatedServer.Messaging.Enums;
using BeatTogether.DedicatedServer.Messaging.Packets.MultiplayerSession.MenuRpc;

namespace BeatTogether.DedicatedServer.Messaging.PacketRegistries
{
    public sealed class MenuRpcPacketRegistry : BasePacketRegistry
    {
        public override void Register()
        {
            AddPacket<GetMultiplayerGameStatePacket>(MenuRpcPacketType.GetMultiplayerGameState);
            AddPacket<SetMultiplayerGameStatePacket>(MenuRpcPacketType.SetMultiplayerGameState);
            AddPacket<GetIsReadyPacket>(MenuRpcPacketType.GetIsReady);
            AddPacket<SetIsReadyPacket>(MenuRpcPacketType.SetIsReady);
            AddPacket<GetIsInLobbyPacket>(MenuRpcPacketType.GetIsInLobby);
            AddPacket<SetIsInLobbyPacket>(MenuRpcPacketType.SetIsInLobby);
            AddPacket<GetOwnedSongPacksPacket>(MenuRpcPacketType.GetOwnedSongPacks);
            AddPacket<SetOwnedSongPacksPacket>(MenuRpcPacketType.SetOwnedSongPacks);
            AddPacket<GetPlayersPermissionConfigurationPacket>(MenuRpcPacketType.GetPermissionConfiguration);
            AddPacket<SetPlayersPermissionConfigurationPacket>(MenuRpcPacketType.SetPermissionConfiguration);
            AddPacket<GetRecommendedBeatmapPacket>(MenuRpcPacketType.GetRecommendedBeatmap);
            AddPacket<GetRecommendedGameplayModifiersPacket>(MenuRpcPacketType.GetRecommendedGameplayModifiers);
            AddPacket<GetStartedLevelPacket>(MenuRpcPacketType.GetStartedLevel);
            AddPacket<SetIsEntitledToLevelPacket>(MenuRpcPacketType.SetIsEntitledToLevel);
            AddPacket<GetIsEntitledToLevelPacket>(MenuRpcPacketType.GetIsEntitledToLevel);
            AddPacket<GetCountdownEndTimePacket>(MenuRpcPacketType.GetCountdownEndTime);
        }
    }
}

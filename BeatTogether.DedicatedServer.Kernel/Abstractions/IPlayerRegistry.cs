﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace BeatTogether.DedicatedServer.Kernel.Abstractions
{
    public interface IPlayerRegistry
    {
        List<IPlayer> Players { get; }

        void AddPlayer(IPlayer player);
        void RemovePlayer(IPlayer player);

        IPlayer GetPlayer(EndPoint remoteEndPoint);
        IPlayer GetPlayer(byte connectionId);
        IPlayer GetPlayer(string userId);
        bool TryGetPlayer(EndPoint remoteEndPoint, [MaybeNullWhen(false)] out IPlayer player);
        bool TryGetPlayer(byte connectionId, [MaybeNullWhen(false)] out IPlayer player);
        bool TryGetPlayer(string userId, [MaybeNullWhen(false)] out IPlayer player);
    }
}

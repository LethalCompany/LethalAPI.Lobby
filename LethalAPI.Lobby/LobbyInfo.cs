// -----------------------------------------------------------------------
// <copyright file="LobbyInfo.cs" company="LethalAPI Modding Community">
// Copyright (c) LethalAPI Modding Community. All rights reserved.
// Licensed under the LGPL-3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LethalAPI.Lobby;

using System.Collections.Generic;
using System.Linq;

using GameNetcodeStuff;
using UnityEngine;

/// <summary>
/// Gets information about the current lobby.
/// </summary>
public static class LobbyInfo
{
    static LobbyInfo()
    {
    }

    /// <summary>
    /// Gets a readonly list of unlockable items.
    /// </summary>
    public static IReadOnlyList<UnlockableItem> UnlockableItems => StartOfRound.Instance.unlockablesList.unlockables.AsReadOnly();

    /// <summary>
    /// Gets the rate at which the company is buying at.
    /// </summary>
    public static float CompanyBuyingRate => StartOfRound.Instance.companyBuyingRate;

    /// <summary>
    /// Gets a value indicating whether or not the ship is in space.
    /// </summary>
    public static bool InSpace => StartOfRound.Instance.inShipPhase;

    /// <summary>
    /// Gets a list of all players.
    /// </summary>
    public static List<PlayerControllerB> Players => StartOfRound.Instance.allPlayerScripts.ToList();

    /// <summary>
    /// Gets a count of the connected players.
    /// </summary>
    public static int PlayerCount => StartOfRound.Instance.connectedPlayersAmount;
}
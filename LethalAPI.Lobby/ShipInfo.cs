// -----------------------------------------------------------------------
// <copyright file="ShipInfo.cs" company="LethalAPI Modding Community">
// Copyright (c) LethalAPI Modding Community. All rights reserved.
// Licensed under the LGPL-3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LethalAPI.Lobby;

using System.Collections.Generic;
using System.Linq;

using UnityEngine;

/// <summary>
/// Gets information about the ship info.
/// </summary>
public static class ShipInfo
{
    /// <summary>
    /// Gets a readonly list of all items that are in the ship.
    /// </summary>
    public static IReadOnlyList<GrabbableObject> ItemsInShip => Object.FindObjectsOfType<GrabbableObject>().Where(x => x.isInShipRoom).ToList().AsReadOnly();

}
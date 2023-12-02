// -----------------------------------------------------------------------
// <copyright file="LevelInfo.cs" company="LethalAPI Modding Community">
// Copyright (c) LethalAPI Modding Community. All rights reserved.
// Licensed under the LGPL-3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace LethalAPI.Lobby;

using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Gets information about the game destination levels.
/// </summary>
public static class LevelInfo
{
    /// <summary>
    /// Gets the current level.
    /// </summary>
    public static SelectableLevel CurrentLevel => StartOfRound.Instance.currentLevel;

    /// <summary>
    /// Gets the currently available levels.
    /// </summary>
    public static List<SelectableLevel> AvailableLevels => StartOfRound.Instance.levels.ToList();

    /// <summary>
    /// Gets the current hour.
    /// </summary>
    public static int Hour => TimeOfDay.Instance.hour;

    /// <summary>
    /// Gets the current day. todo: fix this.
    /// </summary>
    public static int Day => -1;

    /// <summary>
    /// Gets the current <see cref="DayMode">phase</see> of the day.
    /// </summary>
    public static DayMode PhaseOfDay => TimeOfDay.Instance.dayMode;
}
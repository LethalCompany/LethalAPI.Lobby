// -----------------------------------------------------------------------
// <copyright file="Quota.cs" company="LethalAPI Modding Community">
// Copyright (c) LethalAPI Modding Community. All rights reserved.
// Licensed under the LGPL-3.0 license.
// </copyright>
// -----------------------------------------------------------------------

// ReSharper disable UnusedMember.Global
namespace LethalAPI.Lobby;

/// <summary>
/// Gets information about the ship quota.
/// </summary>
public static class Quota
{
    /// <summary>
    /// Gets or sets the current worth of the lobby specifically for fulfilling the quota.
    /// </summary>
    /// <remarks>This money cannot be used in the shop.</remarks>
    public static int QuotaWorth
    {
        get => TimeOfDay.Instance.quotaFulfilled;
        set => TimeOfDay.Instance.quotaFulfilled = value;
    }

    /// <summary>
    /// Gets the <see cref="QuotaSettings"/> for the current quota.
    /// </summary>
    public static QuotaSettings QuotaSettings => TimeOfDay.Instance.quotaVariables;

    /// <summary>
    /// Gets the total amount of quota money that must be payed to prevent ejection.
    /// </summary>
    public static int CurrentQuotaAmount => TimeOfDay.Instance.profitQuota;

    /// <summary>
    /// Gets the hours left until the quota deadline is hit.
    /// </summary>
    public static int HoursLeft => TimeOfDay.Instance.hoursUntilDeadline;

    /// <summary>
    /// Gets the days left until the quota deadline is hit.
    /// </summary>
    public static int DaysLeft => TimeOfDay.Instance.daysUntilDeadline;
}
﻿using GangsAPI.Permissions;

namespace GangsAPI.Struct;

/// <summary>
/// Represents an instance of a gang.
/// </summary>
public interface IGang {
  /// <summary>
  /// The unique identifier of the gang.
  /// All gangs have a unique identifier.
  /// </summary>
  int Id { get; }

  /// <summary>
  /// The name of the gang.
  /// Gang names are not necessarily unique.
  /// (Up to implementation)
  /// </summary>
  string Name { get; set; }

  /// <summary>
  /// The members of the gang.
  /// </summary>
  IDictionary<ulong, IGangRank> Members { get; }

  /// <summary>
  /// The amount of currency the gang has in its bank.
  /// </summary>
  int? Bank {
    get {
      var stat = GetStat("gang_bank") as IStat<ulong, int>;
      return stat?.Value;
    }

    set {
      ArgumentNullException.ThrowIfNull(value);
      if (GetStat("gang_bank") is IStat<ulong, int> stat)
        stat.Value = value.Value;
    }
  }

  /// <summary>
  /// The set of perks the gang has.
  /// </summary>
  ISet<IPerk> Perks { get; }

  /// <summary>
  /// The set of statistics the gang has.
  /// </summary>
  ISet<IStat> Stats { get; }

  /// <summary>
  /// The gang's capacity. Underlying implementation
  /// should be a perk with the id "gang_capacity".
  /// </summary>
  /// <exception cref="ArgumentNullException"></exception>
  int? GangCapacity {
    get {
      var perk = GetPerk("gang_capacity") as IGangPerk<int>;
      return perk?.Value;
    }

    set {
      ArgumentNullException.ThrowIfNull(value);

      if (GetPerk("gang_capacity") is IGangPerk<int> perk)
        perk.Value = value.Value;
    }
  }

  /// <summary>
  /// The gang's "message of the day".
  /// Underlying implementation should be a perk with the id "gang_motd".
  /// </summary>
  /// <exception cref="ArgumentNullException"></exception>
  string? MOTD {
    get {
      var perk = GetPerk("gang_motd") as IGangPerk<string>;
      return perk?.Value;
    }

    set {
      if (value == null)
        throw new ArgumentNullException(nameof(value),
          "To un-set MOTD, remove the perk from the gang.");

      if (GetPerk("gang_motd") is IGangPerk<string> perk) perk.Value = value;
    }
  }

  IPerk? GetPerk(string perkId) {
    return Perks.FirstOrDefault(p => p.PerkId.Equals(perkId));
  }

  IStat? GetStat(string statId) {
    return Stats.FirstOrDefault(s => s.StatId.Equals(statId));
  }
}
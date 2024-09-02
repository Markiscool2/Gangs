using GangsAPI.Data;
using GangsAPI.Data.Stat;

namespace GangsAPI.Services;

public interface IPlayerStatManager : IPluginBehavior, ICacher {
  Task<IPlayerStat<V>?> GetForPlayer<V>(ulong key, string statId);

  Task<bool> PushToPlayer<V>(ulong key, IPlayerStat<V> value) {
    return PushToPlayer(key, value.StatId, value.Value);
  }

  Task<bool> PushToPlayer<V>(ulong key, string statId, V value);
}
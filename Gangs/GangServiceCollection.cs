﻿using Commands;
using CounterStrikeSharp.API.Core;
using GangsAPI.Extensions;
using GangsAPI.Services;
using GangsAPI.Services.Commands;
using Microsoft.Extensions.DependencyInjection;
using Mock;
using SQLImpl;

namespace GangsImpl;

public class GangServiceCollection : IPluginServiceCollection<CS2Gangs> {
  public void ConfigureServices(IServiceCollection serviceCollection) {
    serviceCollection.AddPluginBehavior<IGangManager, MockGangManager>();
    serviceCollection.AddPluginBehavior<IPlayerManager, MockPlayerManager>();
    serviceCollection.AddPluginBehavior<IStatManager, MockStatManager>();
    serviceCollection
     .AddPluginBehavior<IGangStatManager, MockInstanceStatManager>();
    serviceCollection
     .AddPluginBehavior<IPlayerStatManager, MockInstanceStatManager>();
    serviceCollection.RegisterCommands();
    serviceCollection.AddPluginBehavior<ICommandManager, CommandManager>();
  }
}
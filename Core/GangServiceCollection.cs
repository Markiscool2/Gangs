﻿using Commands;
using CounterStrikeSharp.API.Core;
using GangsAPI;
using Microsoft.Extensions.DependencyInjection;

namespace GangsImpl;

public class GangServiceCollection : IPluginServiceCollection<IGangPlugin> {
  public void ConfigureServices(IServiceCollection serviceCollection) {
    serviceCollection.RegisterCommands();
  }
}
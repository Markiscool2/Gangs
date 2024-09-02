﻿using Commands;
using GangsAPI.Data.Command;
using GangsAPI.Services.Commands;

namespace GangsTest.Commands;

public class GangCommandTestses(ICommandManager commands)
  : CommandTests(commands, new GangCommand()) {
  [Fact]
  public async Task Gang_TestBase() {
    Assert.Equal("css_gang", Command.Name);
    Assert.Equal(CommandResult.INVALID_ARGS,
      await Commands.ProcessCommand(TestPlayer, Command.Name));
  }

  [Fact]
  public async Task Gang_TestUnknown() {
    Assert.Equal(CommandResult.UNKNOWN_COMMAND,
      await Commands.ProcessCommand(TestPlayer, Command.Name, "foobar"));
  }

  [Fact]
  public async Task Gang_TestHelp() {
    Assert.Equal(CommandResult.SUCCESS,
      await Commands.ProcessCommand(TestPlayer, "css_gang", "help"));
  }

  [Fact]
  public async Task Gang_TestHelp_Single() {
    Assert.Equal(CommandResult.UNKNOWN_COMMAND,
      await Commands.ProcessCommand(TestPlayer, "css_gang help"));
  }
}
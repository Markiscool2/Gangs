﻿using GangsAPI.Data;
using GangsAPI.Data.Command;
using GangsAPI.Services.Commands;

namespace Commands.gang;

public class CreateCommand : ICommand {
  public string Name => "create";
  public string? Description => "Creates a new gang";

  public CommandResult
    Execute(PlayerWrapper? executor, CommandInfoWrapper info) {
    throw new NotImplementedException();
  }
}
﻿using System.Collections;
using Commands;
using GangsAPI;
using Mock;

namespace GangsTest.Commands.ManagerTests;

public class ManagerData : IEnumerable<object[]> {
  private readonly IBehavior[] behaviors = [
    new MockCommandManager(), new CommandManager(new MockGangManager())
  ];

  public ManagerData() {
    foreach (var behavior in behaviors) behavior.Start();
  }

  public IEnumerator<object[]> GetEnumerator() {
    return behaviors.Select(behavior => (object[]) [behavior]).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
}
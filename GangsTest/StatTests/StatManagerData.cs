using System.Collections;
using GangsAPI;
using GangsImpl.Memory;

namespace GangsTest.StatTests;

public class StatManagerData : IEnumerable<object[]> {
  private readonly IBehavior[] behaviors = [new MockStatManager()];

  public StatManagerData() {
    foreach (var behavior in behaviors) behavior.Start();
  }

  public IEnumerator<object[]> GetEnumerator() {
    return behaviors.Select(behavior => (object[]) [behavior]).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
}
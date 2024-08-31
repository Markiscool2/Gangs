﻿namespace GangsAPI.Data;

public interface Cacheable {
  void ClearCache();
  Task Load();
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alword.Buisiness
{
  public class InMemoryStorage<T>: IStorageProvider<T>
  {
    private readonly Dictionary<int, T> memStorage;
    public InMemoryStorage()
    {
      memStorage = new Dictionary<int, T>();
    }
    public T Read(int id)
    {
      return memStorage[id];
    }

    public int Save(T entity)
    {
      int id = 0;
      if (memStorage.Any())
      {
        id = memStorage.Max(e => e.Key) + 1;
      }
      memStorage.Add(id, entity);
      return id;
    }
  }
}

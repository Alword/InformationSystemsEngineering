using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alword.Buisiness
{
  public class FileStorage<T> : IStorageProvider<T> where T : class
  {

    private readonly string path = "memory";

    int id = 0;
    public FileStorage()
    {
      if (File.Exists(path))
      {
        File.Delete(path);
      }
    }
    public T Read(int id)
    {
      return File.ReadAllLines(path)[id] as T;
    }

    public int Save(T entity)
    {
      File.AppendAllText(path, entity.ToString());
      return id++;
    }
  }
}

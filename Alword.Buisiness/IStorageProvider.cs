using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness
{
  public interface IStorageProvider<T> 
  {
    int Save(T entity);
    T Read(int id);
  }
}

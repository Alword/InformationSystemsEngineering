using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Alword.Buisiness
{
  public class CloudStorage<T> : IStorageProvider<T> where T : class
  {
    int id = 0;
    private readonly string url = "https://keyvalue.immanuel.co/api/KeyVal";
    private readonly string appKey;
    public CloudStorage()
    {
      using (HttpClient http = new HttpClient())
      {
        appKey = http.GetStringAsync($"{url}/GetAppKey").GetAwaiter().GetResult();
        appKey = Clear(appKey);
      }
    }
    public T Read(int id)
    {

      using (var http = new HttpClient())
      {
        var getUrl = $"{url}/GetValue/{appKey}/{id}";
        var result = http.GetStringAsync(getUrl).GetAwaiter().GetResult();
        return Clear(result) as T;
      }
    }

    public int Save(T entity)
    {
      using (var http = new HttpClient())
      {
        var postUrl = $"{url}/UpdateValue/{appKey}/{id}/{entity as string}";
        HttpContent httpContent = new StringContent("", Encoding.UTF8, "application/json");
        var result = http.PostAsync(postUrl, httpContent).GetAwaiter().GetResult();
      }
      return id++;
    }

    private string Clear(string str) => str.Replace("\"", "");
  }
}

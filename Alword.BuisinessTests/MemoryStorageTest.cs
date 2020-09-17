using Alword.Buisiness;
using System;
using Xunit;

namespace Alword.BuisinessTests
{
  public class MemoryStorageTest
  {
    [Fact]
    public void TestInMemory()
    {
      var inMemoryStorage = new InMemoryStorage<string>();
      TestStrategy(inMemoryStorage);
    }

    [Fact]
    public void TestFile()
    {
      var localFileStorage = new FileStorage<string>();
      TestStrategy(localFileStorage);
    }

    [Fact]
    public void TestCloud()
    {
      var cloudStorage = new CloudStorage<string>();
      TestStrategy(cloudStorage);
    }

    private void TestStrategy(IStorageProvider<string> storage)
    {
      var expected = "test";
      var id = storage.Save(expected);
      var actual = storage.Read(id);
      Assert.Equal(expected, actual);
    }
  }
}

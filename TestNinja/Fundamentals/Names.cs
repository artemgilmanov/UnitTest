using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
  public class Names
  {
    public string NickName { get; set; }

    public string Name { get; set; } = "John";
    public int Age { get; set; } = 35;

    public string MakeFullName(string firstName, string lastName)
    {
      return $"{firstName} {lastName}";
    }

    public int GetSomethingByName(string name)
    {
      if (string.IsNullOrWhiteSpace(name))
        throw new ArgumentException("Name is required");

      return 1;
    }
  }

  public class ShortNames : Names
  {
    public string ShortName { get; set; }

    public ShortNames()
    {
      Name = "John";
      Age = 35;
      NickName = "John";
      ShortName = "J";
    }
  }

  public static class NamesFactory
  {
    public static Names CreateName(int nameLength)
    {
      if (nameLength > 10)
      {
        return new Names();
      }
      else
      {
        return new ShortNames();
      }
    }
  }
}

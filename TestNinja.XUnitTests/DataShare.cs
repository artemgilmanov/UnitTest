using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.XUnitTests;

  public static class DataShare
  {
    public static IEnumerable<object[]> AlwaysReturnValue
    {
      get
      {
        yield return new object[] { "Tim", "Tom", "Tim Tom" };
        yield return new object[] { "Tim", "", "Tim " };
        yield return new object[] { "", "Tom", " Tom" };
      }
    }

    //public static IEnumerable<object[]> AlwaysReturnValueExternalFile
    //{
    //  get
    //  {
    //    var allLines = System.IO.File.ReadAllLines("AlwaysReturnValueWithNull.txt");
    //    return allLines.Select(line => line.Split(','));
    //  }
    //}
  }


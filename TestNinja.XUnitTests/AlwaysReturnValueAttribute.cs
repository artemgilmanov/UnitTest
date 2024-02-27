using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace TestNinja.XUnitTests;

public class AlwaysReturnValueAttribute : DataAttribute
{
  public override IEnumerable<object[]> GetData(MethodInfo testMethod)
  {
    yield return new object[] { "Tim", "Tom", "Tim Tom" };
    yield return new object[] { "Tim", "", "Tim " };
    yield return new object[] { "", "Tom", " Tom" };
  }
}


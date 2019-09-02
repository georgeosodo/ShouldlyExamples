using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Democode
{
    public class Calculator
    {
      public  Func<int, int, int> AddInts = (a, b) => {          
          return (a + b); };
      public Func<double, double, double> AddDoubles = (a, b) => (a + b);
      public Func<int, int, int> Divide = (number, by) => {
          if (number > 100)
              throw new ArgumentOutOfRangeException("number");
          return (number / by);
          };
    }
}

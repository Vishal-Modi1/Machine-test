using System.Collections.Generic;
using System.Linq;
using Task8.Interface;

namespace Task8.Implementation
{
    public class Multiply : IMultiply
    {
        public int Multiplication(List<int> values)
        {
            return values.Aggregate(1, (a, b) => a * b);
        }
    }
}

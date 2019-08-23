using System.Collections.Generic;
using System.Linq;
using Task5.Interface;

namespace Task5.Implementation
{
    public class Sum : ISum
    {
        public int Addition(List<int> values)
        {
            return values.Sum();
        }
    }
}

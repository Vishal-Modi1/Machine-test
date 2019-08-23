using System.Collections.Generic;
using System.Linq;
using Task1.Interface;

namespace Task1.Implementation
{
    public class Sum : ISum
    {
        public int Addition(List<int> values)
        {
            return values.Sum();
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using Task4.Interface;

namespace Task4.Implementation
{
    public class Sum : ISum
    {
        public int Addition(List<int> values)
        {
            return values.Sum();
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using Task6.Interface;

namespace Task6.Implementation
{
    public class Sum : ISum
    {
        public int Addition(List<int> values)
        {
            return values.Sum();
        }
    }
}

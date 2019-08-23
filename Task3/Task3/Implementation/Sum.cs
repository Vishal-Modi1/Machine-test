using System.Collections.Generic;
using System.Linq;
using Task3.Interface;

namespace Task3.Implementation
{
    public class Sum : ISum
    {
        public int Addition(List<int> values)
        {
            return values.Sum();
        }
    }
}

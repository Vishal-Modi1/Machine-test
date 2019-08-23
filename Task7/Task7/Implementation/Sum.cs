using System.Collections.Generic;
using System.Linq;
using Task7.Interface;

namespace Task7.Implementation
{
    public class Sum : ISum
    {
        public int Addition(List<int> values)
        {
            return values.Sum();
        }
    }
}

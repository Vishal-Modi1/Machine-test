using System.Collections.Generic;
using Task8.Models;

namespace Task8.Interface
{
    interface IValidation
    {
        ValidationResponse ValidateData(List<string> args);
    }
}

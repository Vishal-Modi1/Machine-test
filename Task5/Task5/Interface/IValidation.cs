using System.Collections.Generic;
using Task5.Models;

namespace Task5.Interface
{
    interface IValidation
    {
        ValidationResponse ValidateData(List<string> args);
    }
}

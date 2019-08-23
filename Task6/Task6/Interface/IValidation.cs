using System.Collections.Generic;
using Task6.Models;

namespace Task6.Interface
{
    interface IValidation
    {
        ValidationResponse ValidateData(List<string> args);
    }
}

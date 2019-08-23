using System.Collections.Generic;
using Task7.Models;

namespace Task7.Interface
{
    interface IValidation
    {
        ValidationResponse ValidateData(List<string> args);
    }
}

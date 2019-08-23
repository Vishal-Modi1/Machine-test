using System.Collections.Generic;
using Task4.Models;

namespace Task4.Interface
{
    interface IValidation
    {
        ValidationResponse ValidateData(List<string> args);
    }
}

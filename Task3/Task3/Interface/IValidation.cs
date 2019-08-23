using System.Collections.Generic;
using Task3.Models;
namespace Task3.Interface
{
    interface IValidation
    {
        ValidationResponse ValidateData(List<string> args);
    }
}

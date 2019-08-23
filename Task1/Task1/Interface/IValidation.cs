using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Task1.Models;

namespace Task1.Interface
{
    interface IValidation
    {
        ValidationResponse ValidateData(List<string> args);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Task2.Models;

namespace Task2.Interface
{
    interface IValidation
    {
        ValidationResponse ValidateData(List<string> args);
    }
}

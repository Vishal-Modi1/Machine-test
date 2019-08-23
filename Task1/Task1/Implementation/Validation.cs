using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Task1.Interface;
using Task1.Models;

namespace Task1.Implementation
{
    public class Validation : IValidation
    {
        readonly static string operation = Convert.ToString(ConfigurationManager.AppSettings["operation"]);
        ValidationResponse response = new ValidationResponse();

        public ValidationResponse ValidateData(List<string> args)
        {
            if (args.Count == 0)
            {
                response.IsValid = false;
                response.ResponseMessage = "Please enter atlest one value.";
            }
            else if (args.Count == 1)
            {
                if (args[0] != operation)
                {
                    response.IsValid = false;
                    response.ResponseMessage = "Please enter valid operation.";
                }
                else
                {
                    response.IsValid = false;
                    response.ResponseMessage = "0";
                }
            }
            else if (args.Count == 2)
            {
                if (args[0] != operation)
                {
                    response.IsValid = false;
                    response.ResponseMessage = "Please enter valid operation.";
                    return response;
                }

                var values = args[1].Split(',').ToList();

                try
                {
                    List<int> intList = values.ConvertAll(int.Parse);
                }
                catch (FormatException e)
                {
                    response.IsValid = false;
                    response.ResponseMessage = "Please enter only numeric values.";
                    return response;
                }

                if (values.Count == 1)
                {
                    response.IsValid = false;
                    response.ResponseMessage = values[0];
                }
                else if (values.Count == 2)
                    response.IsValid = true;

                else if (values.Count > 2)
                {
                    response.IsValid = false;
                    response.ResponseMessage = "Please enter only two values.";
                }
                else
                {
                    response.IsValid = true;
                }
            }
            else
            {
                response.IsValid = false;
                response.ResponseMessage = "Please enter values.";
            }
            return response;
        }

    }
}

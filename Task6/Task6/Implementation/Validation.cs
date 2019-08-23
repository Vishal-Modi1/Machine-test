﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Task6.Interface;
using Task6.Models;

namespace Task6.Implementation
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
                else
                {

                    string[] stringSeparators = new string[] { "\\", "," };
                    var values = args[1].Split(stringSeparators, StringSplitOptions.None).Where(p=> !string.IsNullOrWhiteSpace(p)).ToList();

                    try
                    {
                       var listData= values.ConvertAll(int.Parse);
                        var negativeNumbers = listData.Where(p => p < 0);
                        if (negativeNumbers.Count() > 0)
                        {
                            response.IsValid = false;
                            response.ResponseMessage = "Negative numbers (" + string.Join(",",negativeNumbers.ToArray()) +  ") not allowed.";
                            return response;
                        }

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
                    else
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using Task3.Implementation;
using Task3.Interface;

namespace Task3
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            try
            {
                ISum sum = new Sum();
                IValidation validation = new Validation();
                List<int> values = new List<int>();
                var response = validation.ValidateData(args.ToList());
                if (response.IsValid)
                {
                    var operation = args[0];
                    string[] stringSeparators = new string[] { "\\n", "," };
                    var argsValues = args[1].Split(stringSeparators, StringSplitOptions.None).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();
                    values = Array.ConvertAll(argsValues, p => int.Parse(p)).ToList();
                    Console.WriteLine(sum.Addition(values));
                }
                else
                {
                    Console.WriteLine(response.ResponseMessage);
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong, Please try again later.");
            }
            Console.ReadLine();
        }
    }
}

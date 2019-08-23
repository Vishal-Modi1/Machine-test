using System;
using System.Collections.Generic;
using System.Linq;
using Task2.Implementation;
using Task2.Interface;

namespace Task2
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
                    var argsValues = args[1].Split(',');
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

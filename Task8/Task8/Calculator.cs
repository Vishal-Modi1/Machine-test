using System;
using System.Collections.Generic;
using System.Linq;
using Task8.Implementation;
using Task8.Interface;

namespace Task8
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            try
            {
                IMultiply multiply = new Multiply();
                IValidation validation = new Validation();
                List<int> values = new List<int>();
                var response = validation.ValidateData(args.ToList());
                if (response.IsValid)
                {
                    var operation = args[0];
                    string[] stringSeparators = new string[] { "\\n", ",","\\",";" };
                    var argsValues = args[1].Split(stringSeparators, StringSplitOptions.None).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();
                    values = Array.ConvertAll(argsValues, p => int.Parse(p)).ToList();
                    if(values.Where(p => p < 1000).Count() > 0)
                    Console.WriteLine(multiply.Multiplication(values.Where(p=>p < 1000).ToList()));
                    else
                        Console.WriteLine("0");
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

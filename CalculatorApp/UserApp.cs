using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class UserApp
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double result { get; set; }
        bool keepRunning = true;
        List<string> calculations = new List<string>();


        public void Start()
        {
            userMenu();
        }
        public void Exit()
        {
            Console.WriteLine("Thank you for trying the calculator! Goodbye!");
            Console.ReadKey();
            keepRunning= false;
        }

        public void userMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome! Make your choice: ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Division");
                Console.WriteLine("4. Multiplication");
                Console.WriteLine("5. Print Calculations");
                Console.WriteLine("6. Exit");

                try
                {
                    string selection = Console.ReadLine();
                    switch (selection)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Enter your first number: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter your second number: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Addition(num1, num2);
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Enter your first number: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter your second number: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Subtraction(num1, num2);
                            Console.ReadKey();
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Enter your first number: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter your second number: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Division(num1, num2);
                            Console.ReadKey();
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Enter your first number: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter your second number: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Multiplication(num1, num2);
                            Console.ReadKey();
                            break;
                        case "5":
                            Console.Clear();
                            Print();
                            Console.ReadKey();
                            break;
                        case "6":
                            Exit();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Select a valid choice: ");
                    Console.ReadKey();
                    userMenu();
                }


            } while (keepRunning == true);
        }

        public double Addition(double num1, double num2)
        {
            result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
            AddToLog($"{num1} + {num2} = {result}");
            return result;
        }
        public double Subtraction(double num1, double num2)
        {
            result = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {result}");
            AddToLog($"{num1} - {num2} = {result}");
            return result;
        }
        public double Division(double num1, double num2)
        {
            result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result}");
            AddToLog($"{num1} / {num2} = {result}");
            return result;
        }
        public double Multiplication(double num1, double num2)
        {
            result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
            AddToLog($"{num1} * {num2} = {result}");
            return result;
        }

        public void AddToLog(string Calculations)
        {
            calculations.Add(Calculations);
        }
        public void Print()
        {
            foreach (string Calculations in calculations)
            {
                Console.WriteLine(Calculations);
            }
        }
    }
}

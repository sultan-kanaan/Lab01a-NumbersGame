using System;

namespace Lab01a_NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartSequence();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program is complete!");
            }

        }

        static void StartSequence()
        {
            try
            {
                Console.WriteLine("welcome to my game! lets do some math!");
                Console.WriteLine("Enter a number greater than zero");

                int input = Convert.ToInt32(Console.ReadLine());
                if (input < 0)
                {
                    throw new Exception("opps the number is lees then zero");
                }
                int[] myarr = new int[input];
                Populate(myarr);
                Console.WriteLine("------------------------------");
                Console.WriteLine("your Array is  Size: " + input);
                Console.WriteLine("the number in the Array are ");
                foreach (int e in myarr)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine("------------------------------");

                int sum = GetSum(myarr);
                Console.WriteLine("the sum of Array is: " + sum);
                Console.WriteLine("------------------------------");

                int product = GetProduct(myarr, sum);
                Console.WriteLine("the Product of Array is: " + product);
                Console.WriteLine("------------------------------");

                decimal Quotient = GetQuotient(product);
                Console.WriteLine("the Quotient of Array is: " + Quotient);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong! " + ex);

            }
            
        }

        static int[] Populate(int[] args)
        {
            string n;
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1} of {args.Length} ");
                n = Console.ReadLine();
                args[i] = Convert.ToInt32(n);
            }
            return args;
        }
        static int GetSum(int[] args)
        {
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                sum += args[i];
            }
            if (sum < 20)
            {
                throw new Exception($"Value of {sum} is too low");
            }
            return sum;
        }
        static int GetProduct(int[] args, int sum)
        {
            int num = 0;
            Console.WriteLine($"please select a random number between 1 and {args.Length} ");
            string random = Console.ReadLine();

            try
            {
                num = Convert.ToInt32(random);
                if (num < 1 || num > args.Length)
                {
                    throw new IndexOutOfRange();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            int product = sum * num;

            return product;
        }
        static decimal GetQuotient(int product)
        {
            Console.WriteLine($"Enter number to divide by {product}:");
            String input = Console.ReadLine();
            decimal result = 0;
            try
            {
                int num = Convert.ToInt32(input);
                result = Decimal.Divide(product, num);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide on Zero!" + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong! " + e);
            }

            return result;
        }

    }

}

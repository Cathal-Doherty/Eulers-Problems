using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulersProblem
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadLine();
        }
        //Natural Numbers that are multiple of 3 or 5. Find the sum of all the multiples below 1000
        static void Prob1()
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) 
                {
                    Console.WriteLine(i);
                    sum += i;
                }   
            }
            Console.WriteLine("sum total: {0}", sum);
        }

        static void Prob2()
        {
            int[] arr = new int[1000000];
            int i = 2;
            arr[i - 2] = 1;
            arr[i - 1] = 2;
            int n = arr[i];

            int s = 0;
            for (i = 2; arr[(i - 1)] < 4000000; i++)
            {
                arr[i] = arr[(i - 1)] + arr[(i - 2)];
            }
            for (int f = 0; f <= arr.Length - 1; f++)
            {
                if (arr[f] % 2 == 0)
                    s += arr[f];
            }
            Console.Write(s);
            Console.Read();
        }

        static void Prob3()
        {
            int a, b;

            Console.WriteLine("Please enter your number: ");
            a = int.Parse(Console.ReadLine());

            for (b = 2; a > 1; b++)
            {
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b ==0)
                    {
                        a /= b;
                        x++;
                    }
                    Console.WriteLine("{0} is a prime factor {1} times!", b, x);

                }
            }
            
        }
    }
}

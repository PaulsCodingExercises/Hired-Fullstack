using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hired_FullStackAssessments
{
    class Question1
    {
        public static long[] Solution(long n)
        {
            // First we need to calculate the first n numbers of the Fibonncci Sequence
            List<long> fibs = CalculateFibonnacci(n);
            List<long> primes = CheckPrimes(fibs);
            return primes.ToArray();
        }

        private static List<long> CheckPrimes(List<long> fibs)
        {
            //a number is only a prime if it is divisible by itself and 1
            List<long> result = new List<long>();

            foreach (long n in fibs)
            {
                int count = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2) result.Add(n);
            }
            return result;
        }

        private static List<long> CalculateFibonnacci(long n)
        {
            //Fibonacci sequence is summed up as n3 = n1 + n2
            List<long> result = new List<long>();
            result.Add(1);

            int n1 = 0, n2 = 1, n3;

            for (int i = 2; i < n + 1; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                result.Add(n3);
                n1 = n2;
                n2 = n3;
            }
            return result;
        }

    }
}

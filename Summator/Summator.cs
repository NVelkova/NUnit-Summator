using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
       
        public static long Sum(double[] arr)
        { 
            
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
        
        return (long)sum;
        }

        public static long Average(double[] arr)
        {

            double sum1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum1 += arr[i]/arr.Length;
            }

            return (long)sum1;
        }

        public static long Multiplication(double[] arr)
        {
            double result = 1;
            
            for (int i = 0; i < arr.Length; i++)
            {
                result *= arr[i] ;
            }
            return (long) result;
        }

        public static long Division(double[] arr)
        {
            double result = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                result /= arr[i];
            }
            return (long)result;
        }


    }
}

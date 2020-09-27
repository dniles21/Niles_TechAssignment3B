using System;
/*
  Programmer: Daniel Niles
  Date: 9/27/2020
  Purpose: To demonstrate a simple array

 */
namespace Niles_TechAssignment3B
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defines the Array
            int[] outputNum = { 1, 2, 3, 4, 5, 6, 7, 8 ,9 ,10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
           //The loop measures the array length and calls on the numbers until it reaches that length

            for (int i = 0; i < outputNum.Length; i++)
            {
                //The process of the loop
                Console.WriteLine("Element Value = " + outputNum[i]);
            }
        }
    }
}

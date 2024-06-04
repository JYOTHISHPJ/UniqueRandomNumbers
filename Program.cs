using System;
using  System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Generate a list of 10,000 random numbers
        List<int> finalresult = GenerateUniqueRandomNumbers(10000);
        
        // Output the numbers to verify
        int count=1;
        foreach (int number in finalresult)
        { 
         Console.WriteLine($"Index: {count}, Number: {number}");
            count++;
        }
    }

    // Generates a list of unique random numbers between 1 and the specified count.

    static List<int> GenerateUniqueRandomNumbers(int count)
    {
        //list to store random number
        List<int> result = new List<int>();

        //populate the list with numbers from 1 to the count
        for  (int i = 1;i<=count;i++){
            result.Add(i);
        }

        //intialize the random number generator

        Random random = new Random();

        // Shuffle the numbers using the Fisher-Yates algorithm
        int n = result.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            int value = result[k];
            result[k] = result[n];
            result[n] = value;
        }
        return result;
    }
}
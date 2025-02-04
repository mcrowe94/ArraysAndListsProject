﻿using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            int[] numbersArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            var evenNumbers = new List<int>();
            var oddNumbers = new List<int>();

            foreach (var number in numbersArray)
            {
                if (number %2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Add(number);
                }
            }






            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("List of even numbers!");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("List of odd numbers!");
            foreach (var number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}

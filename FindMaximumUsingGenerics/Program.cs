﻿using System;

namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Number Using Generics Program ");
            Console.WriteLine("1.Compare three integer numbers \n2.Compare three float numbers");
            Console.WriteLine("Please choose the option to execute : ");

            int option = Convert.ToInt32(Console.ReadLine());

            while (option < 1 || option > 7)
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            switch (option)
            {

                case 1:
                    Console.WriteLine("Executing three test cases for Finding Maximum Integer Value");
                    Console.WriteLine(MaximumInteger.MaxIntegerNumber(20, 20, 20));
                    Console.WriteLine(MaximumInteger.MaxIntegerNumber(65, 20, 10));
                    Console.WriteLine(MaximumInteger.MaxIntegerNumber(5, 45, 98));
                    break;
                case 2:
                    Console.WriteLine("Executing three test cases for Finding Maximum Float Value");
                    Console.WriteLine(MaximumFloats.MaxFloatNumber(34.2f, 25.7f, 20.5f));
                    Console.WriteLine(MaximumFloats.MaxFloatNumber(60f, 88.9f, 100.0f));
                    Console.WriteLine(MaximumFloats.MaxFloatNumber(5.5f, 45.5f, 2.9f));
                    break;
            }
        }
    }
}
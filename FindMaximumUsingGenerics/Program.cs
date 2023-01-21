﻿using System;

namespace FindMaximumUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Number Using Generics Program ");
            Console.WriteLine("1.Compare three integer numbers \n2.Compare three float numbers \n3.Compare three string values \n4.Compare three values using Generic Method \n5.Compare three values using Generic Class \n6.Compare more than three values \n7.print method");
            Console.WriteLine("Please choose the option to execute : ");

            int option = Convert.ToInt32(Console.ReadLine());

            while (option < 1 || option > 8)
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
                case 3:
                    Console.WriteLine("Executing three test cases for Finding Maximum String Value");
                    Console.WriteLine(MaximumString.MaxStringValue("2", "40", "8"));
                    Console.WriteLine(MaximumString.MaxStringValue("1", "5", "6"));
                    Console.WriteLine(MaximumString.MaxStringValue("90", "7", "3"));
                    break;
                case 4:
                    Console.WriteLine("Executing three test cases for Finding Maximum Value using Generic Method");
                    Console.WriteLine(RefectorMethod.MaximumValue(65, 20, 10));
                    Console.WriteLine(RefectorMethod.MaximumValue(10.2f, 20.5f, 20.5f));
                    Console.WriteLine(RefectorMethod.MaximumValue("90", "7", "3"));
                    break;
                case 5:
                    Console.WriteLine("Executing three test cases for Finding Maximum Value using Generic Class");
                    Console.WriteLine(RefactorClass<int>.MaximumValue(30, 65, 20));
                    Console.WriteLine(RefactorClass<float>.MaximumValue(10.2f, 20.5f, 20.5f));
                    Console.WriteLine(RefactorClass<string>.MaximumValue("1", "89", "3"));
                    break;
                case 6:
                    int[] array1 = { 10, 20, 30, 40, 50 };
                    ExtendFindMethod<int> obj = new ExtendFindMethod<int>(array1);
                    Console.WriteLine("Maximum value amongst the provided numbers is : {0}", obj.MaxValue(array1));
                    // obj.printMax();
                    break;
                case 7:
                    //Test case for int
                    int[] intarray = { 10, 20, 30, 40, 50 };
                    PrintMethod<int> intobj = new PrintMethod<int>(intarray);
                    intobj.printMax();
                    //Test case for Float
                    float[] floatarray = { 10.3f, 20.3f, 30.2f, 40.7f, 50.8f };
                    PrintMethod<float> floatobj = new PrintMethod<float>(floatarray);
                    floatobj.printMax();
                    //Test case for String
                    string[] stringArray = { "Apple", "Peach", "Banana" };
                    PrintMethod<string> stringobj = new PrintMethod<string>(stringArray);
                    stringobj.printMax();
                    break;
                default:
                    Console.WriteLine("Invalid option, please choose again.");
                    break;
            }
        }
    }
}
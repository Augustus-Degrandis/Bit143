using System;
using System.Collections;
using System.Collections.Generic;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using_DotNets_Stack uds = new Using_DotNets_Stack();
            //uds.RunExercise();

            //Reversing_User_Input rui = new Reversing_User_Input();
            //rui.RunExercise();

            Basic_Generic_Test_Code bgtc = new Basic_Generic_Test_Code();
            bgtc.RunExercise();

            //Basic_AbsValComparer_Test_Code bavctc = new Basic_AbsValComparer_Test_Code();
            //bavctc.RunExercise();

            // add more here, as you need
        }
    }

    class What_Is_A_Stack 
    {
        // Put your answer here (in comments)
    }


    class Car
    {
    }

    class Using_DotNets_Stack 
    {
        // Your comment explaining the running time of
        // Push goes here

		// Make sure that "using System.Collections;" is at the top of this file
        public void RunExercise()
        {
        }
    }

    class Reversing_User_Input
    {
        public void RunExercise()
        {
            // I'm leaving these here in case they're useful:
            //Console.WriteLine("Please type a number");
            //Console.WriteLine("Please type a negative number to stop");
            //Console.WriteLine("Here's what you typed, backwards:");
        }
    }

    class Basic_Generic_Test_Code
    {
        public void RunExercise()
        {
            //These lines of code have been commented out.
            // They won't compile until you implement the generic
            // BasicGeneric class.

            // Note that you should NOT modify this code at all:

            //////////////// ints /////////////////////////////////////////////
            Console.WriteLine("=============================");
            Console.WriteLine("Test for INT");
            Console.WriteLine("=============================\n");

            BasicGeneric<int> basic_int = new BasicGeneric<int>();
            int intValueToStore = 100;
            basic_int.SetItem(intValueToStore);

            Console.WriteLine("Stored {0}, Print() tells us:", intValueToStore );
            basic_int.Print();

            double intCheckVal = basic_int.GetItem();
            Console.WriteLine("Using Get, got back: {0}", intCheckVal);
            if (intCheckVal != intValueToStore )
                Console.WriteLine("\tERROR: checkVal is not {0}", intValueToStore );
            else
                Console.WriteLine("\tGetItem appeared to work!");

            //////////////// doubles //////////////////////////////////////////
            Console.WriteLine("\n=============================");
            Console.WriteLine("Test for DOUBLE");
            Console.WriteLine("=============================\n");
            BasicGeneric<double> basic_double = new BasicGeneric<double>();
            double doubleValueToStore = 3.14159;
            basic_double.SetItem(doubleValueToStore);

            Console.WriteLine("Stored {0}, Print() tells us:", doubleValueToStore);
            basic_double.Print();

            double doubleCheckVal = basic_double.GetItem();
            Console.WriteLine("Using Get, got back: {0}", doubleCheckVal);
            if (doubleCheckVal != doubleValueToStore)
                Console.WriteLine("\tERROR: checkVal is not {0}", doubleValueToStore);
            else
                Console.WriteLine("\tGetItem appeared to work!");

            //////////////// strings //////////////////////////////////////////
            Console.WriteLine("\n=============================");
            Console.WriteLine("Test for STRING");
            Console.WriteLine("=============================\n");

            BasicGeneric<string> basic_string = new BasicGeneric<string>();
            string stringValueToStore  = "fun  text here";
            basic_string.SetItem(stringValueToStore );

            Console.WriteLine("Stored {0}, Print() tells us:", stringValueToStore );
            basic_string.Print();

            string stringCheckVal = basic_string.GetItem();
            Console.WriteLine("Using Get, got back: {0}", stringCheckVal);

            // != is ok for strings in C#, but not in Java
            if (stringCheckVal != stringValueToStore ) 
                Console.WriteLine("\tERROR: checkVal is not {0}", stringValueToStore );
            else
                Console.WriteLine("\tGetItem appeared to work!");
        }
    }

    // please put your 'BasicGeneric' class here

    class Basic_AbsValComparer_Test_Code
    {
        public void RunExercise()
        {
            //AbsValComparer absolute_val_comp = new AbsValComparer();

            //List<double> nums = new List<double>();

            //nums.Add(20.4);
            //nums.Add(-20.4);
            //nums.Add(-10.3);
            //nums.Add(3.1);
            //nums.Add(-4.2);

            //Console.WriteLine("Before sorting:\n");
            //foreach( double num in nums)
            //{
            //    Console.WriteLine(num);
            //}

            //nums.Sort(absolute_val_comp);

            //Console.WriteLine("\nAfter sorting\n");

            //foreach (double num in nums)
            //{
            //    Console.WriteLine(num);
            //}

            //double[] nums_to_find = { 3.1, -4.2, -20.4, 999 };
            //foreach( double targetNum in nums_to_find)
            //{
            //    int loc = nums.BinarySearch(targetNum, absolute_val_comp);
            //    if (loc >= 0)
            //        Console.WriteLine("Found {0} at location {1}", targetNum, loc);
            //    else
            //        Console.WriteLine("Did not find {0}", targetNum);
            //}
        }
    }

    // please put your 'AbsValComparer' class here


    class What_Is_An_Enum
    {
        // What is an enum? Why would you want to use one?

        // Why is an enum better than a public const int? (or a public static readonly int)?
    }
}


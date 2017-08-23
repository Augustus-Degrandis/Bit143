using System;
using System.Collections;
using System.Collections.Generic;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Using_DotNets_Stack uds = new Using_DotNets_Stack();
            uds.RunExercise();

            //Reversing_User_Input rui = new Reversing_User_Input();
            //rui.RunExercise();

            //Basic_Generic_Test_Code bgtc = new Basic_Generic_Test_Code();
            //bgtc.RunExercise();

            //Basic_AbsValComparer_Test_Code bavctc = new Basic_AbsValComparer_Test_Code();
            //bavctc.RunExercise();

            // add more here, as you need
        }
    }

    class What_Is_A_Stack 
    {
        /// a stack is a LIFO system last in first off when you push something on
        /// to a stack your are in a sense "Stacking" the items
        /// on top of eachother
        /// 
        /// when you pop something off the stack you start from the top!
        /// 
        /// the answer to the question there is a 1 and 4 on the stack with 4 being on the top
    }


    class Car
    {
    }

    class Using_DotNets_Stack 
    {
        /// The running time for push pop and peek are all O(1)
        /// Constant time even if the stack has 1 million things in it
        /// it only takes a constant amount of time 
        /// to add or remove another thing to the top
        /// 
        /// the N in Big O notation mean the number of times a certant action needs
        /// to be taken for the worst case senario
        /// since we only care overall how effiecent a method is we dont actually care
        /// how many times it needs to run but just if it runs "N" times how fast is it?

		// Make sure that "using System.Collections;" is at the top of this file
        public void RunExercise()
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            Console.WriteLine(st.Peek());
            st.Pop();
            Console.WriteLine(st.Peek());
            st.Pop();
			Console.WriteLine(st.Peek());
			st.Pop();
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
        // A enum is a word representation of a int value so intead of your programing passing around ints such 1 or 0 you 
        // could use the enum yes an no.

        // Why is an enum better than a public const int? (or a public static readonly int)?
        // A big advantage of an Enum is that they can have logic inside the enum such as contructors 
        // using a enum gives you type safty making sure that when camparing things your getting the
        // type you want
    }
}


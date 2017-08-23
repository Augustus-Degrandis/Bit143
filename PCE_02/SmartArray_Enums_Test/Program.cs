using System;

namespace SmartArray_Test
{

    //    // Your enum goes here:


    class SmartArray
    {
        int[] rgNums;

        //// Running time for this method:
        //// Explanation (Why did you choose that running time?):
        public SmartArray()
        {
        }

        //// Running time for this method:
        //// Explanation (Why did you choose that running time?):
        public SmartArray(int howMany)
        {
        }

        //// Running time for this method:
        //// Explanation (Why did you choose that running time?):
        //public ErrorCode SetAtIndex(int idx, int val)
        //{
        //    return ErrorCode.Underflow;
        //}

        //// Running time for this method:
        //// Explanation (Why did you choose that running time?):
        //public ErrorCode GetAtIndex(int idx, out int val)
        //{
        //    return ErrorCode.Overflow;
        //}

        //// Running time for this method:
        //// Explanation (Why did you choose that running time?):
        //public void PrintAllElements()
        //{

        //}


        //// Running time for this method:
        //// Explanation (Why did you choose that running time?):
        //public bool Find(int val)
        //{
        //    return false;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            //            SmartArray sa = new SmartArray();
            //            const int SMART_ARRAY_SIZE = 5;
            //            bool testPassed = false;
            //            ErrorCode ec;

            //            Console.WriteLine("CHECK THIS: SmartArray starts with all zeros");
            //            sa.PrintAllElements();
            //            Console.WriteLine("\n*******************\n");


            //            Console.WriteLine("================= SetAtIndex =================");
            //            Console.WriteLine("AutoChecked: Can add at slot 0?");
            //            if ( (ec = sa.SetAtIndex(0, 10))!= ErrorCode.NoError)
            //                Console.WriteLine("TEST FAILED: UNABLE TO SET ELEMENT 0! (ErrorCode: {0})", ec);
            //            else
            //                Console.WriteLine("Test Passed: Able to set element 0!");
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Can add at slots 0-4?");
            //            testPassed = true;
            //            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            //            {
            //                if ((ec = sa.SetAtIndex(i, 10 * i)) != ErrorCode.NoError)
            //                {
            //                    Console.WriteLine("TEST FAILED: UNABLE TO SET ELEMENT {0}! (ErrorCode: {1})", i, ec);
            //                    testPassed = false;
            //                    break; // out of the loop
            //                }
            //            }
            //            if(testPassed)
            //                Console.WriteLine("Test Passed: Able to set all elements!");
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Should NOT be able to add at slot {0}?", SMART_ARRAY_SIZE);

            //            if ((ec = sa.SetAtIndex(SMART_ARRAY_SIZE, 10)) != ErrorCode.Overflow)
            //                Console.WriteLine("TEST FAILED: SET ELEMENT {0} DIDN'T OVERFLOW (ErrorCode: {1})", SMART_ARRAY_SIZE, ec);
            //            else
            //                Console.WriteLine("Test Passed: Unable to set element {0}!", SMART_ARRAY_SIZE);
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Should NOT be able to add at slot {0}?", SMART_ARRAY_SIZE+10);
            //            if ((ec = sa.SetAtIndex(SMART_ARRAY_SIZE+10, 10)) != ErrorCode.Overflow)
            //                Console.WriteLine("TEST FAILED: SET ELEMENT {0} DIDN'T OVERFLOW (ErrorCode: {1})", SMART_ARRAY_SIZE+10, ec); 
            //            else
            //                Console.WriteLine("Test Passed: Unable to set element {0}!", SMART_ARRAY_SIZE + 10);
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Should NOT be able to add at slot -1?");
            //            if ((ec = sa.SetAtIndex(-1, 10)) != ErrorCode.Underflow)
            //                Console.WriteLine("TEST FAILED: SET ELEMENT -1 DIDN'T UNDERFLOW! ErrorCode: {0})", ec);
            //            else
            //                Console.WriteLine("Test Passed: Unable to set element -1!");
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Should NOT be able to add at slot -10?");
            //            if ((ec = sa.SetAtIndex(-10, 10)) != ErrorCode.Underflow)
            //                Console.WriteLine("TEST FAILED: SET ELEMENT -10 DIDN'T UNDERFLOW! ErrorCode: {0})", ec);
            //            else
            //                Console.WriteLine("Test Passed: Unable to set element -1!");
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("CHECK THIS: Should see 0, 10, 20, 30, 40");
            //            sa.PrintAllElements();
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("================= GetAtIndex =================");
            //            int valueGotten;
            //            Console.WriteLine("AutoChecked: Can get from slot 0?");
            //            ec = sa.GetAtIndex(0, out valueGotten);
            //            if (ec != ErrorCode.NoError)
            //            {
            //                Console.WriteLine("TEST FAILED: UNABLE TO GET FROM SLOT 0 (ErrorCode: {0})", ec);
            //            }
            //            else if (valueGotten != 0)
            //            {
            //                Console.WriteLine("TEST FAILED: UNEXPECTED VALUE FROM SLOT 0: (EXPECTED 0, GOT {0})", valueGotten);
            //            }
            //            else
            //                Console.WriteLine("Test Passed: Able to get expected value from slot 0!");
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Can get from slots 0-4?");
            //            testPassed = true;
            //            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            //            {
            //                ec = sa.GetAtIndex(i, out valueGotten);
            //                if (ec != ErrorCode.NoError)
            //                {
            //                    Console.WriteLine("TEST FAILED: UNABLE TO GET FROM SLOT {0} (ErrorCode: {1})", i, ec);
            //                }
            //                else if (valueGotten != 10 * i)
            //                {
            //                    Console.WriteLine("TEST FAILED:  UNEXPECTED VALUE AT SLOT {0} (EXPECTED {1}, GOT {2})", i, i*10, valueGotten);
            //                    testPassed = false;
            //                    break; // out of the loop
            //                }
            //            }
            //            if (testPassed)
            //                Console.WriteLine("Test Passed: Able to get expected values!");
            //            Console.WriteLine("\n*******************\n");


            //            Console.WriteLine("AutoChecked: Should NOT be able to get from slot {0}?", SMART_ARRAY_SIZE);
            //            if ( (ec = sa.GetAtIndex(SMART_ARRAY_SIZE, out valueGotten)) != ErrorCode.Overflow)
            //                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T OVERFLOW (ErrorCode: {1})?", SMART_ARRAY_SIZE, ec);
            //            else if (valueGotten != Int32.MinValue)
            //                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T PRODUCE Int32.MinValue", SMART_ARRAY_SIZE);
            //            else
            //                Console.WriteLine("Test Passed: Unable to get from slot {0}!", SMART_ARRAY_SIZE);
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Should NOT be able to get from slot {0}?", SMART_ARRAY_SIZE+10);
            //            if ((ec = sa.GetAtIndex(SMART_ARRAY_SIZE+10, out valueGotten)) != ErrorCode.Overflow)
            //                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T OVERFLOW (ErrorCode: {1})?", SMART_ARRAY_SIZE+10, ec);
            //            else if (valueGotten != Int32.MinValue)
            //                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T PRODUCE Int32.MinValue", SMART_ARRAY_SIZE+10);
            //            else
            //                Console.WriteLine("Test Passed: Unable to get from slot {0}!", SMART_ARRAY_SIZE+10);
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Should NOT be able to get from slot -1?");
            //            if ((ec = sa.GetAtIndex(-1, out valueGotten)) != ErrorCode.Underflow)
            //                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T UNDERFLOW(ErrorCode: {1})", -1, ec);
            //            else if (valueGotten != Int32.MinValue)
            //                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T PRODUCE Int32.MinValue", -1);
            //            else
            //                Console.WriteLine("Test Passed: Unable to get from slot {0}!", SMART_ARRAY_SIZE); 

            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Should NOT be able to get from slot -10?");
            //            if ((ec = sa.GetAtIndex(-10, out valueGotten)) != ErrorCode.Underflow)
            //                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T UNDERFLOW(ErrorCode:{1})", -10, ec);
            //            else if (valueGotten != Int32.MinValue)
            //                Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T PRODUCE Int32.MinValue", -10);
            //            else
            //                Console.WriteLine("Test Passed: Unable to get from slot {0}!", SMART_ARRAY_SIZE);
            //            Console.WriteLine("\n*******************\n");


            //            Console.WriteLine("================= Find =================");
            //            Console.WriteLine("AutoChecked: Can find 0?");
            //            if (! sa.Find(0))
            //                Console.WriteLine("TEST FAILED: UNABLE TO FIND VALUE 0!");
            //            else
            //                Console.WriteLine("Test Passed: Able to find value 0!");
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Can find the values in slots 0-4?");
            //            testPassed = true;
            //            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            //            {
            //                ec = sa.GetAtIndex(i, out valueGotten);
            //                if (ec != ErrorCode.NoError)
            //                {
            //                    Console.WriteLine("TEST FAILED:UNABLE TO GET ELEMENT AT SLOT {0} (ErrorCode: {1})!", i, ec);
            //                    testPassed = false;
            //                    break;
            //                }  // technically don't need the 'else'....
            //                else if (!sa.Find(valueGotten)) // test by getting from array
            //                {
            //                    Console.WriteLine("TEST FAILED: UNABLE TO FIND {0}!", valueGotten);
            //                    testPassed = false;
            //                    break; // out of the loop
            //                }
            //            }
            //            if (testPassed)
            //                Console.WriteLine("Test Passed: Able to find values that are already in the array!");
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Can find the values calculated to be in slots 0-4?");
            //            testPassed = true;
            //            for (int i = 0; i < SMART_ARRAY_SIZE; i++)
            //            {
            //                if (!sa.Find(i * 10)) // test by re-calculating the result
            //                {
            //                    Console.WriteLine("TEST FAILED: UNABLE TO FIND {0}!", i * 10);
            //                    testPassed = false;
            //                    break; // out of the loop
            //                }
            //            }
            //            if (testPassed)
            //                Console.WriteLine("Test Passed: Able to find values calculated to be in the array!");
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Should NOT be able to find -1?");
            //            if (sa.Find(-1))
            //                Console.WriteLine("TEST FAILED: ABLE TO FIND -1, WHICH SHOULD NOT BE PRESENT");
            //            else
            //                Console.WriteLine("Test Passed: Unable to find nonexistent value -1!");
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Should NOT be able to find -10?");
            //            if (sa.Find(-10))
            //                Console.WriteLine("TEST FAILED: ABLE TO FIND -10, WHICH SHOULD NOT BE PRESENT");
            //            else
            //                Console.WriteLine("Test Passed: Unable to find nonexistent value -10!");
            //            Console.WriteLine("\n*******************\n");

            //            Console.WriteLine("AutoChecked: Should NOT be able to find 11?");
            //            if (sa.Find(11))
            //                Console.WriteLine("TEST FAILED: ABLE TO FIND 11, WHICH SHOULD NOT BE PRESENT");
            //            else
            //                Console.WriteLine("Test Passed: Unable to find nonexistent value 11!");
            //            Console.WriteLine("\n*******************\n");
        }
    }
}

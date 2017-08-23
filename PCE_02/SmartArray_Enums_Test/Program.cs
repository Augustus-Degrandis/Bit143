using System;

namespace SmartArray_Test
{

    enum ErrorCode { noError, overFlow, underFlow };


    class SmartArray
    {
        int[] rgNums;

        //// Running time for this method: O(1)
        //// Explanation (Why did you choose that running time?):
        /// Setting up an array is a 1 time function of 5 since were putting in 5 slots
        /// every time so its the same everytime you do it
        public SmartArray()
        {
            rgNums = new int[5];
        }
        //// Running time for this method: O(N)
		//// Explanation (Why did you choose that running time?):
        /// beacuse we are using X the running time of the function would
        /// depend on what the value of x is increasing or decreasing linearly
        /// as x changes making the run time O(N)
		public SmartArray(int x)
        {
            rgNums = new int[x];
        }

        //// Running time for this method:
        //// Explanation (Why did you choose that running time?):
        public ErrorCode SetAtIndex(int idx, int val)
        {
            if (idx < 0)
                return ErrorCode.underFlow;
            else if (idx > rgNums.Length - 1)
                return ErrorCode.overFlow;
            else
            {
                rgNums[idx] = val;
                return ErrorCode.noError;
            }
        }

        //// Running time for this method: O(1) Constant time 
        //// Explanation (Why did you choose that running time?): 3 if / else statments and 
        /// comparisons the worst run time would be the time it makes to do all 3 comparisons
        /// which would make thie contstant time
        public ErrorCode GetAtIndex(int idx, out int val)
        {
            if (idx < 0)
            {
                val = Int32.MinValue;
                return ErrorCode.underFlow;
            }
            else if (idx > rgNums.Length - 1)
            {
                val = Int32.MinValue;
                return ErrorCode.overFlow;
            }
            else
            {
                val = rgNums[idx];
                return ErrorCode.noError;
            }
        }

        //// Running time for this method: O(N)
        //// Explanation (Why did you choose that running time?):
        /// the for loop linearly goes through every slot of the array to print them out
        /// the ammount of prints is equal to the number of slots in the array
        public void PrintAllElements()
        {
            for (int i = 0; i < rgNums.Length - 1; i++)
            {
                Console.WriteLine(rgNums[i]);
            }
        }
        //// Running time for this method: O(N)
        //// Explanation (Why did you choose that running time?):
        /// this method is a linear search of an array which is almost the definitions
        /// of a linear run time 
        public bool Find(int val)
        {
            for (int i = 0; i < rgNums.Length - 1; i++)
            {
                if (rgNums[i] == val)
                    return true;
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
                        SmartArray sa = new SmartArray();
                        const int SMART_ARRAY_SIZE = 5;
                        bool testPassed = false;
                        ErrorCode ec;

                        Console.WriteLine("CHECK THIS: SmartArray starts with all zeros");
                        sa.PrintAllElements();
                        Console.WriteLine("\n*******************\n");


                        Console.WriteLine("================= SetAtIndex =================");
                        Console.WriteLine("AutoChecked: Can add at slot 0?");
                        if ( (ec = sa.SetAtIndex(0, 10))!= ErrorCode.noError)
                            Console.WriteLine("TEST FAILED: UNABLE TO SET ELEMENT 0! (ErrorCode: {0})", ec);
                        else
                            Console.WriteLine("Test Passed: Able to set element 0!");
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Can add at slots 0-4?");
                        testPassed = true;
                        for (int i = 0; i < SMART_ARRAY_SIZE; i++)
                        {
                            if ((ec = sa.SetAtIndex(i, 10 * i)) != ErrorCode.noError)
                            {
                                Console.WriteLine("TEST FAILED: UNABLE TO SET ELEMENT {0}! (ErrorCode: {1})", i, ec);
                                testPassed = false;
                                break; // out of the loop
                            }
                        }
                        if(testPassed)
                            Console.WriteLine("Test Passed: Able to set all elements!");
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Should NOT be able to add at slot {0}?", SMART_ARRAY_SIZE);

                        if ((ec = sa.SetAtIndex(SMART_ARRAY_SIZE, 10)) != ErrorCode.overFlow)
                            Console.WriteLine("TEST FAILED: SET ELEMENT {0} DIDN'T OVERFLOW (ErrorCode: {1})", SMART_ARRAY_SIZE, ec);
                        else
                            Console.WriteLine("Test Passed: Unable to set element {0}!", SMART_ARRAY_SIZE);
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Should NOT be able to add at slot {0}?", SMART_ARRAY_SIZE+10);
                        if ((ec = sa.SetAtIndex(SMART_ARRAY_SIZE+10, 10)) != ErrorCode.overFlow)
                            Console.WriteLine("TEST FAILED: SET ELEMENT {0} DIDN'T OVERFLOW (ErrorCode: {1})", SMART_ARRAY_SIZE+10, ec); 
                        else
                            Console.WriteLine("Test Passed: Unable to set element {0}!", SMART_ARRAY_SIZE + 10);
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Should NOT be able to add at slot -1?");
                        if ((ec = sa.SetAtIndex(-1, 10)) != ErrorCode.underFlow)
                            Console.WriteLine("TEST FAILED: SET ELEMENT -1 DIDN'T UNDERFLOW! ErrorCode: {0})", ec);
                        else
                            Console.WriteLine("Test Passed: Unable to set element -1!");
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Should NOT be able to add at slot -10?");
                        if ((ec = sa.SetAtIndex(-10, 10)) != ErrorCode.underFlow)
                            Console.WriteLine("TEST FAILED: SET ELEMENT -10 DIDN'T UNDERFLOW! ErrorCode: {0})", ec);
                        else
                            Console.WriteLine("Test Passed: Unable to set element -1!");
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("CHECK THIS: Should see 0, 10, 20, 30, 40");
                        sa.PrintAllElements();
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("================= GetAtIndex =================");
                        int valueGotten;
                        Console.WriteLine("AutoChecked: Can get from slot 0?");
                        ec = sa.GetAtIndex(0, out valueGotten);
                        if (ec != ErrorCode.noError)
                        {
                            Console.WriteLine("TEST FAILED: UNABLE TO GET FROM SLOT 0 (ErrorCode: {0})", ec);
                        }
                        else if (valueGotten != 0)
                        {
                            Console.WriteLine("TEST FAILED: UNEXPECTED VALUE FROM SLOT 0: (EXPECTED 0, GOT {0})", valueGotten);
                        }
                        else
                            Console.WriteLine("Test Passed: Able to get expected value from slot 0!");
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Can get from slots 0-4?");
                        testPassed = true;
                        for (int i = 0; i < SMART_ARRAY_SIZE; i++)
                        {
                            ec = sa.GetAtIndex(i, out valueGotten);
                            if (ec != ErrorCode.noError)
                            {
                                Console.WriteLine("TEST FAILED: UNABLE TO GET FROM SLOT {0} (ErrorCode: {1})", i, ec);
                            }
                            else if (valueGotten != 10 * i)
                            {
                                Console.WriteLine("TEST FAILED:  UNEXPECTED VALUE AT SLOT {0} (EXPECTED {1}, GOT {2})", i, i*10, valueGotten);
                                testPassed = false;
                                break; // out of the loop
                            }
                        }
                        if (testPassed)
                            Console.WriteLine("Test Passed: Able to get expected values!");
                        Console.WriteLine("\n*******************\n");


                        Console.WriteLine("AutoChecked: Should NOT be able to get from slot {0}?", SMART_ARRAY_SIZE);
                        if ( (ec = sa.GetAtIndex(SMART_ARRAY_SIZE, out valueGotten)) != ErrorCode.overFlow)
                            Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T OVERFLOW (ErrorCode: {1})?", SMART_ARRAY_SIZE, ec);
                        else if (valueGotten != Int32.MinValue)
                            Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T PRODUCE Int32.MinValue", SMART_ARRAY_SIZE);
                        else
                            Console.WriteLine("Test Passed: Unable to get from slot {0}!", SMART_ARRAY_SIZE);
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Should NOT be able to get from slot {0}?", SMART_ARRAY_SIZE+10);
                        if ((ec = sa.GetAtIndex(SMART_ARRAY_SIZE+10, out valueGotten)) != ErrorCode.overFlow)
                            Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T OVERFLOW (ErrorCode: {1})?", SMART_ARRAY_SIZE+10, ec);
                        else if (valueGotten != Int32.MinValue)
                            Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T PRODUCE Int32.MinValue", SMART_ARRAY_SIZE+10);
                        else
                            Console.WriteLine("Test Passed: Unable to get from slot {0}!", SMART_ARRAY_SIZE+10);
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Should NOT be able to get from slot -1?");
                        if ((ec = sa.GetAtIndex(-1, out valueGotten)) != ErrorCode.underFlow)
                            Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T UNDERFLOW(ErrorCode: {1})", -1, ec);
                        else if (valueGotten != Int32.MinValue)
                            Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T PRODUCE Int32.MinValue", -1);
                        else
                            Console.WriteLine("Test Passed: Unable to get from slot {0}!", SMART_ARRAY_SIZE); 

                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Should NOT be able to get from slot -10?");
                        if ((ec = sa.GetAtIndex(-10, out valueGotten)) != ErrorCode.underFlow)
                            Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T UNDERFLOW(ErrorCode:{1})", -10, ec);
                        else if (valueGotten != Int32.MinValue)
                            Console.WriteLine("TEST FAILED: GET FROM ELEMENT {0} DIDN'T PRODUCE Int32.MinValue", -10);
                        else
                            Console.WriteLine("Test Passed: Unable to get from slot {0}!", SMART_ARRAY_SIZE);
                        Console.WriteLine("\n*******************\n");


                        Console.WriteLine("================= Find =================");
                        Console.WriteLine("AutoChecked: Can find 0?");
                        if (! sa.Find(0))
                            Console.WriteLine("TEST FAILED: UNABLE TO FIND VALUE 0!");
                        else
                            Console.WriteLine("Test Passed: Able to find value 0!");
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Can find the values in slots 0-4?");
                        testPassed = true;
                        for (int i = 0; i < SMART_ARRAY_SIZE; i++)
                        {
                            ec = sa.GetAtIndex(i, out valueGotten);
                            if (ec != ErrorCode.noError)
                            {
                                Console.WriteLine("TEST FAILED:UNABLE TO GET ELEMENT AT SLOT {0} (ErrorCode: {1})!", i, ec);
                                testPassed = false;
                                break;
                            }  // technically don't need the 'else'....
                            else if (!sa.Find(valueGotten)) // test by getting from array
                            {
                                Console.WriteLine("TEST FAILED: UNABLE TO FIND {0}!", valueGotten);
                                testPassed = false;
                                break; // out of the loop
                            }
                        }
                        if (testPassed)
                            Console.WriteLine("Test Passed: Able to find values that are already in the array!");
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Can find the values calculated to be in slots 0-4?");
                        testPassed = true;
                        for (int i = 0; i < SMART_ARRAY_SIZE; i++)
                        {
                            if (!sa.Find(i * 10)) // test by re-calculating the result
                            {
                                Console.WriteLine("TEST FAILED: UNABLE TO FIND {0}!", i * 10);
                                testPassed = false;
                                break; // out of the loop
                            }
                        }
                        if (testPassed)
                            Console.WriteLine("Test Passed: Able to find values calculated to be in the array!");
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Should NOT be able to find -1?");
                        if (sa.Find(-1))
                            Console.WriteLine("TEST FAILED: ABLE TO FIND -1, WHICH SHOULD NOT BE PRESENT");
                        else
                            Console.WriteLine("Test Passed: Unable to find nonexistent value -1!");
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Should NOT be able to find -10?");
                        if (sa.Find(-10))
                            Console.WriteLine("TEST FAILED: ABLE TO FIND -10, WHICH SHOULD NOT BE PRESENT");
                        else
                            Console.WriteLine("Test Passed: Unable to find nonexistent value -10!");
                        Console.WriteLine("\n*******************\n");

                        Console.WriteLine("AutoChecked: Should NOT be able to find 11?");
                        if (sa.Find(11))
                            Console.WriteLine("TEST FAILED: ABLE TO FIND 11, WHICH SHOULD NOT BE PRESENT");
                        else
                            Console.WriteLine("Test Passed: Unable to find nonexistent value 11!");
                        Console.WriteLine("\n*******************\n");
        }
    }
}

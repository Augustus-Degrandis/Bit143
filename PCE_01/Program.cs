using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code is used by the first exercise
            // It is left here, uncommented, so that it's easy for you to run
            // Once you complete it, feel free to comment these lines out
            // That way, you won't have every single exercise being run, each and
            // every time :)
            //IO_Operators ioo = new IO_Operators();
            //ioo.RunExercise();

            //Fibonnaci_With_Array fwa = new Fibonnaci_With_Array();
            //fwa.RunExercise();

            //Scope_Of_Variables sov = new Scope_Of_Variables();
            //sov.RunExercise();

            Array_Of_Ints aoi = new Array_Of_Ints();
            aoi.RunExercise();
            //Object_Composition_Circle OOC = new Object_Composition_Circle();
            //OOC.RunExercise();
                
        }
    }

    class IO_Operators
    {
        public void RunExercise()
        {
            Console.Write("First Number: ");
            int x;
            if (Int32.TryParse(Console.ReadLine(), out x) == false)
            {
                Console.WriteLine("IT didnt work");
            }

            Console.Write("\nSecond Number: ");
            int y = Int32.Parse(Console.ReadLine());
            int result = x - y;
            result = Math.Abs(result);
            if (result <= 5)
                Console.WriteLine("{0} and {1} are within 5 units", x, y);
            else
                Console.WriteLine("{0} and {1} are NOT within 5 units", x, y);
        }

    }

    class Fibonnaci_With_Array
    {
        public void RunExercise()
        {
            int[] fibArray = new int[20];
            fibArray[0] = 0;
            fibArray[1] = 1;

            for (int i = 2; i < fibArray.Length; i++)
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
            foreach (int n in fibArray)
                Console.WriteLine(fibArray[n]);
        }
    }

    class Scope_Of_Variables
    {
        // Put your comment here:
        // Instance variables are saved on the heap and are usually saved to a specific class 
        // in this class the instance variables are the private int's low and high
        // They are created when a new instance of the class is made and
        // They continue to exist as long as the program is running

        // Local variables and Parameters are put into the stack and cease to exist
        // once that certant function finishes 
        // An example of a local variable is one that is created inside of a method or function
        // such as a for loop for(int i=0 ; i<length; i++)
        // in this example the local variable i ceases to exist once the for loop finishes

        //Parameters are created when a method or funciton is called they are neccesary and required for
        //certant functions that accept parameters ecample methods that use parameters are the SetHighest and SetLowest
        // they need a parameter to work and that parameter ceases to exist one the method is complete

        public void RunExercise()
        {
            NumberPrinter np = new NumberPrinter();
            np.SetLowest(3.14159);
            np.SetHighest(12);
            np.Print(true);
            np.SetHighest(17.1);
            np.Print(false);
        }


        class NumberPrinter
        {
            private int low;
            private int high;
            public NumberPrinter()
            {
                low = 0;
                high = 0;
            }
            public void SetHighest(double h)
            {
                high = (int)h;
            }
            public void SetLowest(double l)
            {
                low = (int)Math.Ceiling(l);
            }
            public void Print(bool b)
            {
                if (b)
                {
                    for (int i = low; i <= high; i++)
                    {
                        if (i % 2 == 0)
                            Console.WriteLine(i);
                    }
                }
                else
                {
                    for (int i = low; i <= high; i++)
                        Console.WriteLine(i);
                }

            }
        }
    }


    class Object_Composition_Circle
    {
		class Point
		{
			private int x;
			private int y;
			public Point(int x, int y)
			{
				this.x = x;
				this.y = y;
			}
			public void setX(int xint)
			{
				x = xint;
			}
			public void setY(int yint)
			{
				y = yint;
			}
			public int getX()
			{
				return x;
			}
			public int getY()
			{
				return y;
			}
			public void Print()
			{
				Console.WriteLine("({0},({1})", x, y);
			}

		}
		class Circle
		{
			private Point center;
			private double radius;

			public Circle(int x, int y, double r)
			{
				center = new Point(x, y);
				radius = r;
			}
			public void Print()
			{
				Console.WriteLine("This Circle is at the point {0},{1} with a radius: {2}", center.getX(), center.getY(), radius);
			}
			public void setY(int ychange)
			{
				center.setY(ychange);
			}
			public void setX(int xchange)
			{
				center.setX(xchange);
			}
            public void setRadius(double r)
            {
                radius = r;
            }
            public double getRadius()
            {
                return radius;
            }
            public int getY()
            {
                return center.getY();
            }
            public int getX()
            {
                return center.getX();
            }
		}
        public void RunExercise()
        {
            // Note that even though c1 & c2 are using Point         // objects to store the location, we're still passing         // in the x & y values separately          Circle c1 = new Circle(10, 20, 3);         // c1 is located at (10,20), with radius = 3         Circle c2 = new Circle(0, 0, 4);         // c2 is at the origin, radius is 4          c1.Print(); // Prints out something like (10, 20) radius=3         c2.Print(); // Prints out something like (0, 0) radius=4         c1.setX(-10);         c1.Print(); // Now prints out (-10, 20) radius=3         c2.setY(10);         c2.setRadius(10);         c2.Print(); // Prints out something like (0, 10) radius=10         Console.WriteLine("c1 is at {0} and {1}, with radius of {2}",             c1.getX(), c1.getY(), c1.getRadius());         // prints out c1 is at -10 and 20, with radius of 3
        }
    }


    // this is a good place to put your Point and Circle classes


    class Array_Of_Ints
    {
        public void RunExercise()
        {
            int[] intArray = new int[10];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = (i * 2) + 1;
            }
            int input = 0;
            while (input != 1000)
            {
                Console.Write("Array slot:");
                while (Int32.TryParse(Console.ReadLine(), out input) == false)
                {
                    Console.WriteLine("Please type a Intiger");
                }
                if (input < 0 || input > 9)
                    Console.WriteLine("Please type a Int between 0 and 9 or 1000 to quit");
                else
                    Console.WriteLine("Array slot: {0} is {1}",input,intArray[input]);
            }
            Console.WriteLine("Have a good day!");
        }
    }
}
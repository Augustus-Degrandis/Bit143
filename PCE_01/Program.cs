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
            IO_Operators ioo = new IO_Operators();
            ioo.RunExercise();

            // Fibonnaci_With_Array fwa = new Fibonnaci_With_Array();
            // fwa.RunExercise();

            // Scope_Of_Variables sov = new Scope_Of_Variables();
            // sov.RunExercise();

            Array_Of_Ints aoi = new Array_Of_Ints();
            aoi.RunExercise();
        }
    }

    class IO_Operators 
    {
        public void RunExercise()
        {
        }
    }

    class Fibonnaci_With_Array 
    {
        public void RunExercise()
        {
        }
    }

    class Scope_Of_Variables 
    {
        // Put your comment here:

        public void RunExercise()
        {
        }
    }

    class Object_Composition_Circle 
    {
        public void RunExercise()
        {
            //// Quick test for your Point class:
            //Point pt1 = new Point(10, 20);
            //// Pt1 is located at (10,20)
            //Point pt2 = new Point(0, 0);
            //// Pt2 is at the origin

            //pt1.Print(); // Prints out something like (10, 20)
            //pt2.Print(); // Prints out something like (0, 0)
            //pt1.setX(-10);
            //pt1.Print(); // Now prints out (-10, 20)
            //pt2.setY(10);
            //pt2.Print(); // Prints out something like (0, 10)
            //Console.WriteLine("pt1 is at {0} and {1}", pt1.getX(), pt1.getY());
            //// prints out: pt1 is at -10 and 20

            //// Note that even though c1 & c2 are using Point
            //// objects to store the location, we're still passing
            //// in the x & y values separately 
            //Circle c1 = new Circle(10, 20, 3);
            //// c1 is located at (10,20), with radius = 3
            //Circle c2 = new Circle(0, 0, 4);
            //// c2 is at the origin, radius is 4

            //c1.Print(); // Prints out something like (10, 20) radius=3
            //c2.Print(); // Prints out something like (0, 0) radius=4
            //c1.setX(-10);
            //c1.Print(); // Now prints out (-10, 20) radius=3
            //c2.setY(10);
            //c2.setRadius(10);
            //c2.Print(); // Prints out something like (0, 10) radius=10
            //Console.WriteLine("c1 is at {0} and {1}, with radius of {2}",
            //    c1.getX(), c1.getY(), c1.getRadius());
            //// prints out c1 is at -10 and 20, with radius of 3
        }
    }
    // this is a good place to put your Point and Circle classes


    class Array_Of_Ints
    {
        public void RunExercise()
        {
        }
    }

}
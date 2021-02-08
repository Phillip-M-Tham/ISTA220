using System;

namespace Classes
{
    class Point
    {
        //THESE ARE PRIVATE INSTANCE FIELDS INSTANCE FIELDS HAVE EACH POINT HAS THESE VARIABLES SET TO SOMETHING
        private int _x = 0;
        private int _y = 0;
        private int _z = 0;
        private int serialnum;
        //PRIVATE CLASS FIELD EACH OBJECT HAS ACCESS TO THIS VARIABLE
        private static int objectcount = 0;
        
        //THIS IS A CLASS METHOD
        public static int ObjectCount()
        {
            return objectcount;
        }
        public Point()// THIS IS A DEFUALT CONSTRUCTOR
        {
            _x = -1;
            _y = -1;
            objectcount++;
            serialnum = objectcount;
            Console.WriteLine($"Default constructor called, point number is {serialnum}");

        }
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
            objectcount++;
            serialnum = objectcount;
            Console.WriteLine($"x is {x}, y is {y}, point number is {serialnum}");
        }
        public Point(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
            objectcount++;
            serialnum = objectcount;
            Console.WriteLine($"x={_x}, y={_y}, z={_z}, point number is {serialnum}");
        }
        public double DistanceTo(Point other)//THIS IS AN INSTANCE METHOD
        {
            int xDiff = _x - other._x;
            int yDiff = _y - other._y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }

        public double DistanceToTriple(Point other2)
        {
            int xDiff = _x - other2._x;
            int yDiff = _y - other2._y;
            int zDiff = _z - other2._z;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff) + (zDiff * zDiff));
            return distance;
        }
       
       
    }
}

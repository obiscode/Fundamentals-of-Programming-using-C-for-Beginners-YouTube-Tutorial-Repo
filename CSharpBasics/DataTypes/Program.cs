using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int minimumInt = int.MinValue;
            //int maximumInt = int.MaxValue;

            //Console.WriteLine("The minimum value for int is: " + minimumInt
            //    + " and the maximum vaue of int is: " + maximumInt);
            //Type type = typeof(int);
            //Console.WriteLine(type.FullName);

            //long secondsMakeTenYears = 31560000000L;
            //long minimumLong = long.MinValue;
            //long maximumLong = long.MaxValue;

            //Console.WriteLine("The minimum value for long is: " + minimumLong
            //    + " and the maximum vaue of long is: " + maximumLong);
            //Type type = typeof(long);
            //Console.WriteLine(type.FullName);

            //Float datatype

            //float myFloat = 4.67f;

            //float minimumFloat = float.MinValue;
            //float maximumFloat = float.MaxValue;

            //Console.WriteLine("The minimum value for float is: " + minimumFloat
            //    + " and the maximum vaue of int is: " + maximumFloat);
            //Type type = typeof(float);          
            //    Console.WriteLine(type.FullName);

            //Double datatype

            //double myDouble = 34.456D;

            //double minimumDouble = double.MinValue;
            //double maximumDouble = double.MaxValue;

            //Console.WriteLine("The minimum value for double is: " + minimumDouble
            //    + " and the maximum value double is: " + maximumDouble);
            //Type type = typeof(double);
            //Console.WriteLine(type.FullName);

            //Scientific Notation
            //e or E

            //double d = 0.12e2;//0.12 x 10^2 = 12
            //Console.WriteLine(d);

            ////default number for all number type is 0
            //int i = default;// outputs 0
            //float f = default;// 0

            //Booleans
            bool isDataTypeUseful = true;
            bool isProgammingNotEasy = false;//outpus false
            //Console.WriteLine(isDataTypeUseful);
            ////default value is false.
            //bool isBool = default; //outputs false

            ////Characters : char 
            //char passGrade = 'C';
            //Console.WriteLine(passGrade);
            ////the default value is '\0'
            //char dF = default;//'\0'

            ////Strings

            //string greeting = "Hello World";
            //Console.WriteLine(greeting);

            //string ch = "S";
            //string word = "string";
            //string text = "This is a string";

            //Type Conversion - Type casting
            //int myInt = 25;
            //double myDouble = myInt; //Automatic

            //Console.WriteLine(myInt);
            //Console.WriteLine(myDouble);
            //char -> int -> long -> float -> double

            //double myDouble = 5.34;
            //int myInt = (int)myDouble;

            //Console.WriteLine(myDouble);
            //Console.WriteLine(myInt);

            //double -> float -> long -> int -> char
            //Convert.ToBoolean
            //Convert.ToDouble
            //Convert.ToString
            //Convert.ToInt32 (int)
            //ConvertToInt64 (long)

            string myString = "true";
            char myChar = 'a';
            double myDouble = 3.5;

            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myChar));
            Console.WriteLine(Convert.ToBoolean(myString));
        }
    }
}

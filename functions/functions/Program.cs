﻿using System;

namespace function
{
    class Program
    {
    
        /* return Value with ref */
        public static int AddMulWithRef(int a, int b, ref int add, ref int mul)
        {
            Console.WriteLine("Return parameter using ref");
            mul = a * b;
            return  add = a + b;
        }

        /* return Value with out */
        public static void AddMulWithOut(int a, int b, out int add, out int mul)
        {
            Console.WriteLine("Return parameter using out");
            add = a + b;
            mul = a * b;
            Console.WriteLine("Addition " + add);
            Console.WriteLine("Multiplication " + mul);
        }

        /* return Value with tuple */
        public static Tuple<int,int> AddMulWithTuple(int a, int b)
        {
            Console.WriteLine("Return parameter using Tuple");
            int addition, multiplication;
            addition = a + b;
            multiplication = a * b;
           
            /* return Tuple.Create(addition, multiplication);*/
            return new Tuple<int,int>(addition, multiplication);
        }

        static void Main(string[] args)
        {
            int a = 5, b = 2, add = 0, mul = 0;
       
            AddMulWithRef(a, b, ref add, ref mul);
            Console.WriteLine("Addition " + add);
            Console.WriteLine("Multiplication " + mul);
            Console.WriteLine();
            AddMulWithOut(a, b, out add, out mul);
            Console.WriteLine();
            var Tuple = AddMulWithTuple(a, b);
            Console.WriteLine("Addition " + Tuple.Item1);
            Console.WriteLine("Multiplication " + Tuple.Item2);


            Console.ReadKey();
        }
    }
}
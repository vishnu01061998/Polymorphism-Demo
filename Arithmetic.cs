using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Demo    // Over loading program 
{
    internal class Arithmetic
    {
        public void Add() 
        {
            Console.WriteLine("method with 0 arugument");
        }
        public void Add(int num1)
        {
            Console.WriteLine("Methos with 1 parameter");
        }
        public void Add (int num1, int num2)
        {
            int result = num1+ num2;
            Console.WriteLine("Addition of two integers types value="+ result);
        }
        public void Add (float num1, float num2) 
        {
            float  result = num1 + num2;
            Console.WriteLine("Addition of two float types value=" + result);
        }
        public void Add (float num1, int num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Addition of one float  and one integer types value=" + result);
        }
        public void Add(int num1, float num2)
        {
            float result = num1 + num2;
            Console.WriteLine("Addition of one integer and one float types value=" + result);
        }
    }
}

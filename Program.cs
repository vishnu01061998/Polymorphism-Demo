using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor= new Doctor();
            doctor.Operations("Heart Surgery");

            Arithmetic arithmetic= new Arithmetic();
            arithmetic.Add();
            arithmetic.Add(10);
            arithmetic.Add(10.5f,20);
            arithmetic.Add(10.5f,20.10f);
            arithmetic.Add(10, 20);
            arithmetic.Add(20.5f, 10);
            arithmetic.Add(10, 10.5f);
        }
    }
}

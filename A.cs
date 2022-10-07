using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Oop.anastasiabutevich.task2
{
    public class A {

        private B b1;
        private B b2;
        private B b3;

        public A(B b1, B b2, B b3)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
        }

        public void printNumber(int number)
        {
            Console.WriteLine(b1.returnNumber(number));
            Console.WriteLine(b2.returnNumber(number));
            Console.WriteLine(b3.returnNumber(number));
        }
    }
}

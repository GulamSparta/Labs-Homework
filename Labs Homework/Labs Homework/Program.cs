using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            labTaskOne taskOne = new labTaskOne(); //Creates the object, which we can call from now
            int addedNumbers;
            int multipledNumbers = taskOne.Product(5, 10, 15, out addedNumbers); //Output is 750
            Console.WriteLine("All the added numbers: " + addedNumbers);
            Console.WriteLine("all the numbers multiplied: " + multipledNumbers);
        }

      
    }

    class labTaskOne
    {
        public int Product(int num1, int num2, int num3, out int labNumbers)
        {
            labNumbers = num1 + num2 + num3;
            return num1 * num2 * num3;
        }
    }

    class Cat
    {
        private string name;
        private int age;
        public int Cat(int age, string name)
        {
            this.name = name;
            this.age = age;

        }


    }
}

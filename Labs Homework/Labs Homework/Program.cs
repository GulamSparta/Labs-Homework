using System;
using System.Web.Script.Serialization; //Adds this libary from the references section

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


            Cat TibbyTheCat = new Cat(2, "Tibby"); //instance of cat with name and age
            Cat.AgeOfCat(TibbyTheCat);
            Cat.AgeOfCat(TibbyTheCat);

            var json = new JavaScriptSerializer().Serialize(TibbyTheCat);
            Console.WriteLine(json.ToString());


            Console.Read();
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
        /* Explains this function down here
         * This is a constructor, when I created it
         * it had to be the same name as the class.
         * 
         * So when I instantiate a class/object it forces me to give
         * it a input
         * 
         * In this case when I make a new cat you always have to give it
         * a name and age
         */

        private string name;
        private int age;

        public Cat(int age, string name)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public static object AgeOfCat(Cat cat)
        {
            cat.age = cat.age + 5;

            return cat;
        }

    }
}

using System;

namespace BasicOOPTask
{
    

    class Program
    {
        static void Main(string[] args)
        {

            //Create  class with static and non-static class members
            Console.WriteLine("Static class");
            StaticC.a = 3;
            StaticC.b = 2;
            StaticC.Alert();

            //Show difference between class and instance of class.
            Console.WriteLine("\nNon Static class");
            NonStaticC person = new NonStaticC();
            person.Name = "Vova";
            person.Age = 29;
            person.Occupation = "QA";
            person.Height = 175.5;
            person.Introduce();

            //Contructor method. Constructor arguments
            Console.WriteLine("\nContructor method. Constructor arguments");
            Constructor Apple = new Constructor("MacBook");
            Console.WriteLine(Apple.device);

            //Encapsulation. Demonstrate with different class attributes: methods and fields. Access modifiers.

            Console.WriteLine("\nEncapsulation. Demonstrate with different class attributes: methods and fields. Access modifiers.");
            Encapsulation character = new Encapsulation();
            character.Age = 22;
            character.Name = "Vova";
            character.Intro();


            //Inheritance. Make class which inheres the parent and demonstrate the inheritance

            Console.WriteLine("\nInheritance. Make class which inheres the parent and demonstrate the inheritance");

            Employee employee = new Employee { FirstName = "Vlad", LastName = "Koros" };
            employee.PrintName();
            employee.Hello();

            //Inheritance. Create Class A with a constructor that accepts 2 parameters and saves them to variables.
            //( A(String name, int age) ). Create class B that extends class A and has a constructor with no parameters.
            //(B()) - make code to compile successfully. Print instance of B

            Console.WriteLine("\nInheritance. Create Class A with a constructor that accepts 2 parameters and saves " +
                "them to variables.( A(String name, int age) ). Create class B that extends class " +
                "A and has a constructor with no parameters. (B()) - make code to compile successfully. " +
                "Print instance of B");

            InhTask2Constr2 billioner = new InhTask2Constr2("Elon", 48);
            billioner.WhoIsHe();
            

        }
    }
}

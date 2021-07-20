using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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


            //Methods: new, virtual override
            Console.WriteLine("\nMethods: new, virtual override");

            SportCar car = new SportCar();
            car.CarBrand = "BMW";
            car.CarModel = "X5";
            car.Drive();
            car.DriveCar();
            RetroCar oldCar = new RetroCar();
            oldCar.DriveCar();

            //Polymorphism. Demonstrate its applying (at least 3 classes are needed)
            Console.WriteLine("\nPolymorphism. Demonstrate its applying (at least 3 classes are needed)");

            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            //Interfaces
            Console.WriteLine("\nInterfaces");

            Console.WriteLine(IVehicle.MaxSpeed);
            IVehicle.MaxSpeed = 250;
            Console.WriteLine(IVehicle.MaxSpeed);
            double time = IVehicle.GetTime(200, 20);
            Console.WriteLine(time);

            //Abstract classes. Difference between class, abstract class, interface
            Console.WriteLine("\nAbstract classes. Difference between class, abstract class, interface");

            Student student = new Student();
            student.FullName = "Oleg Coal";
            student.Greetings();
            student.MyNameIs();

            //Create Interface IDriver...
            Console.WriteLine("\nCreate Interface IDriver...");

            GetText findText = new GetText();
            ClickOn click = new ClickOn();
            click.ClickOnButton(click.Link);
            click.ClickOnButton(click.Button);
            findText.GetTextOfElement(findText.Text);




            //Add general buisness object class which involve page object inside basing on Dependency  injection principle
            Console.WriteLine("\nAdd general buisness object class which involve page object inside basing on " +
                "Dependency  injection principle");
            ButtonLogin buttonLogin = new ButtonLogin(); // B is constructed here instead
            PageObjects ButtonOne = new PageObjects(buttonLogin);
            ButtonOne.Login();
            ResetPassword resetPassword = new ResetPassword(); // B is constructed here instead
            PageObjects ButtonTwo = new PageObjects(resetPassword);
            ButtonOne.Login();
            ButtonTwo.ResetPassword();

            //Create class and serialize it; print result; deserialize it; print result
            Console.WriteLine("\nCreate class and serialize it; print result; deserialize it; print result");

            JsonSerializeTask user = new JsonSerializeTask();
            user.NameJ = "Vlad";
            user.Age = 29;
            user.Hobbies = new List<string> { "Travelling", "Partying", "Hiking" };

            string output = JsonConvert.SerializeObject(user);
            Console.WriteLine(output);
            JsonSerializeTask deserializedOutput = JsonConvert.DeserializeObject<JsonSerializeTask>(output);
            Console.WriteLine(deserializedOutput);

            Console.WriteLine("\nCreate string that contains JSON ..." +
                "parse this string into JSON object and print it's name and age.");

            CreateJSONTask personJSON = new CreateJSONTask();
            personJSON.Name = "John";
            personJSON.Age = 30;
            personJSON.Car = null;
            string outputJSON = JsonConvert.SerializeObject(personJSON);
            dynamic data = JObject.Parse(outputJSON);
            Console.WriteLine(data.Name);
            Console.WriteLine(data.Age);


        }
    }
}

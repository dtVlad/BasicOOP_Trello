using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPTask
{
    class Car
    {
        //Car
        public string CarBrand;
        public virtual void Drive()
        {
            Console.WriteLine($"I drive a {CarBrand}");
        }

        public  void DriveCar()
        {
            Console.WriteLine("I drive a new car");
        }
    }

    class SportCar : Car
    {

        public string CarModel;
        public override void Drive()
        {
            Console.WriteLine($"I drive a {CarBrand} {CarModel}");
        }
    }

    class RetroCar : Car
    {

        public new void DriveCar()
        {
            Console.WriteLine("I drive an old car");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Models.builder
{
    public interface ICar
    {
        public int SeatNo { get; set; }
        public string  Engine{ get; set; }

    }

    public class Car : ICar
    {
        public int SeatNo { get; set; }
        public string Engine { get; set; }
        public void Display()
        {
            Console.WriteLine($"{SeatNo} : {Engine}");
        }
    }
    public class ManualDOcCar : ICar
    {
        public int SeatNo { get; set; }
        public string Engine { get; set; }
        public void Display()
        {
            Console.WriteLine($"{SeatNo} : {Engine}");
        }
    }
    public interface CarbuilderInterface
    {
        void Reset();
        void SetSeatNo(int a);
        void SetEngine(string a);

    }
    public class Carbuilder : CarbuilderInterface
    {
        private Car car;
        public void Reset()
        {
            car = new Car();
        }

        public void SetEngine(string a)
        {
            car.Engine = a;
        }

        public void SetSeatNo(int a)
        {
            car.SeatNo = a;
        }

        public Car getCar()
        {
            return car;
        }
    }
    public class ManualBuilder : CarbuilderInterface
    {
        ManualDOcCar manual;
        public void Reset()
        {
            manual = new ManualDOcCar();
        }

        public void SetEngine(string a)
        {
            manual.Engine = a;
        }

        public void SetSeatNo(int a)
        {
            manual.SeatNo = a;
        }
        public ManualDOcCar getCarmanual()
        {
            return manual;
        }
    }

    public class Director
    {
        public void ConstructNormalCar(CarbuilderInterface carbuilderInterface)
        {
            carbuilderInterface.Reset(); 
            carbuilderInterface.SetEngine("Sme Eng");
            carbuilderInterface.SetSeatNo(5);
        }
        public void ConstructNormalTruck(CarbuilderInterface carbuilderInterface)
        {
            carbuilderInterface.Reset(); 
            carbuilderInterface.SetEngine("Truck Sme Eng");
            carbuilderInterface.SetSeatNo(7);
        }
        public void BuildManual(ManualBuilder manualBuilder)
        {
            manualBuilder.Reset();
            manualBuilder.SetEngine("Truck Sme Eng");
            manualBuilder.SetSeatNo(50);
        }
    }


}

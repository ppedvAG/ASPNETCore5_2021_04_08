using System;

namespace DI_BasicSample
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        ICarService carService = new CarService();
    //        ICarService mockService = new MockCarService();

    //        carService.RepairCar(new Car());

    //        ICar car = CarFacotry.CreateInstance("orginal");
    //        ICar mockCar = CarFacotry.CreateInstance("mock");
    //    }
    //}


    #region Bad CarSample

    //Programmierer A: Benötigt 5 Tage
    public class BadCar
    {
        public string Brand { get; set; }    
        public string Model { get; set; }
        public DateTime ConstructYear { get; set; }
    }


    //Programmierer B: Muss 5 Tage warten, bis er mit fertiger Car-Klasse arbeiten, bzw als Parameter verwenden kann 
    public class BadCarService
    {
        public void CarRepair(BadCar car)
        {
            //Mach etwas mit dem Auto 
        }
    }
    #endregion

    #region Cood CarSample

    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }
        DateTime ConstructYear { get; set; }
    }

    public interface ICarService
    {
        void RepairCar(ICar car);
    }


    //Programmierer 2 Tage
    public class Car : ICar
    {
        public string Brand //Auto-Properties
        {
            get; 
            set;
        }
        public string Model 
        { 
            get; 
            set; 
        }
        public DateTime ConstructYear 
        { 
            get; 
            set; 
        }
    }

    //Programmierer B: 3 Tage
    public class CarService : ICarService
    {
        public void RepairCar(ICar car)
        {
           //Mach was
        }
    }

    public class MockCarService : ICarService
    {
        public void RepairCar(ICar car)
        {
            //Mock-Implementierung
        }
    }

    public class MockCar : ICar
    {
        public string Brand { get; set; } = "BMW";
        public string Model{ get; set;} = "Z8";
        public DateTime ConstructYear { get; set; } = DateTime.Now;
    }


    public class CarFacotry
    {
        public static ICar CreateInstance(string carType)
        {
            if (carType == "orginal")
                return new Car();

            else if (carType == "mock")
                return new MockCar();
            else 
                throw new Exception("Type not supported");
        }
    }
    #endregion
}

using DesignPattern.DesignPattern;
using Models.builder;
using System.ComponentModel.DataAnnotations;


var stopnow = false;
do
{
    #region useless
    Console.WriteLine("Please Enter your selected value");
    Console.WriteLine("y for html");
    var selectedOption = Console.ReadKey().KeyChar;
    Console.WriteLine("");
    #endregion

    var director = new Director();
    var normalCarBuilder = new Carbuilder();
    var truckBuilder = new Carbuilder();
    var manual = new ManualBuilder();

    director.ConstructNormalCar(normalCarBuilder);
    director.ConstructNormalTruck(truckBuilder);
    director.BuildManual(manual);

    var prod1 = normalCarBuilder.getCar();
    var prod2 = truckBuilder.getCar();
    var prod3 = manual.getCarmanual();

    Console.WriteLine($"{prod1.SeatNo} : {prod1.Engine}");
    Console.WriteLine($"{prod2.SeatNo} : {prod2.Engine}");
    Console.WriteLine($"{prod3.SeatNo} : {prod3.Engine}");
    #region useless
    Console.WriteLine("n to stop");
    Console.WriteLine("");
    var isstop = Console.ReadKey().KeyChar;
    stopnow = isstop == 'n';
    #endregion
} while (!stopnow);

using DesignPattern.DesignPattern;
using Models.builder;
using Models.PrototypeDesignPattern;
using System.ComponentModel.DataAnnotations;


var stopnow = false;
//do
//{
//    #region useless
//    Console.WriteLine("Please Enter your selected value");
//    Console.WriteLine("y for html");
//    var selectedOption = Console.ReadKey().KeyChar;
//    Console.WriteLine("");
//    #endregion



//    #region useless
//    Console.WriteLine("n to stop");
//    Console.WriteLine("");
//    var isstop = Console.ReadKey().KeyChar;
//    stopnow = isstop == 'n';
//    #endregion


//} while (!stopnow);

ConstructorCirclePrototype constructorCircle = new ConstructorCirclePrototype(1, 5);
constructorCircle.Draw();
ConstructorCirclePrototype constructorCircleCopyContructor = constructorCircle.CloneCircleCopyConst() as ConstructorCirclePrototype;

constructorCircleCopyContructor.Draw();
constructorCircleCopyContructor.Radius = 5555;


constructorCircleCopyContructor.Draw();

var cc2 = constructorCircle.CloneCircleCopy();
cc2.Draw();
using DesignPattern.DesignPattern;
using Models;
using Models.Adapter;
using Models.builder;
using Models.CompositeDesignPattern;
using Models.DecoratorDesignPatterb;
using Models.Facade;
using Models.FlyWeight;
using Models.PrototypeDesignPattern;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;


//var stopnow = false;
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

//ConstructorCirclePrototype constructorCircle = new ConstructorCirclePrototype(1, 5);
//constructorCircle.Draw();
//ConstructorCirclePrototype constructorCircleCopyContructor = constructorCircle.CloneCircleCopyConst() as ConstructorCirclePrototype;

//constructorCircleCopyContructor.Draw();
//constructorCircleCopyContructor.Radius = 5555;


//constructorCircleCopyContructor.Draw();

//var cc2 = constructorCircle.CloneCircleCopy();
//cc2.Draw();


//adapter Design Pattern 
//RoundHole keyHole = new RoundHole(5);
//RoundKey key = new RoundKey(5);
//RoundKey key1 = new RoundKey(6);

//var isFit = keyHole.FitsInsideKey(key.getRadius);
//Console.WriteLine(isFit);
//isFit = keyHole.FitsInsideKey(key1.getRadius);
//Console.WriteLine(isFit);

//SquareKey sk = new SquareKey("5");
//SquareKey sk1 = new SquareKey("15");



//SquareToKeyObjectAdapter adp1 = new SquareToKeyObjectAdapter(0, sk);
//SquareToKeyObjectAdapter adp2 = new SquareToKeyObjectAdapter(0, sk1);

//isFit = keyHole.FitsInsideKey(adp1.getRadius);
//Console.WriteLine(isFit);

//isFit = keyHole.FitsInsideKey(adp2.getRadius);
//Console.WriteLine(isFit);


//SquareToKeyClassAdapter clapt = new SquareToKeyClassAdapter("5");
//isFit = keyHole.FitsInsideKey(clapt.getRadius);
//Console.WriteLine(isFit);

//SquareToKeyClassAdapter clapt1 = new SquareToKeyClassAdapter("15");
//isFit = keyHole.FitsInsideKey(clapt1.getRadius);
//Console.WriteLine(isFit);

//IDevice tv = new Tv();
//RemoteControl remote = new RemoteControl(tv);
//remote.TogglePower();

//IDevice radio = new Radio();
//AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(radio);
//advancedRemote.Mute();

//Product book = new Product("Book", 10);
//Product pen = new Product("Pen", 2);
//Items item = new Items("Book", 10);
//Items i2 = new Items("Pen", 2);

//Box smallBox = new Box();
//smallBox.AddItem(book);
//smallBox.AddItem(pen);


//Box biggerBox = new Box();
//biggerBox.AddItem(smallBox);
//biggerBox.AddItem(item);
//biggerBox.AddItem(i2);

//Console.WriteLine($"Total price of bigBox: {biggerBox.GetPrice()}");

//string salaryRecords = "Employee Salary Records";
//DecoratorPatternExample source = new FileDataSource("somefile.dat");
//source.WriteData(salaryRecords);
//Console.WriteLine();

//var source2 = new CompressionDecorator(source);
//source2.WriteData(salaryRecords);
//Console.WriteLine();

//var source3 = new EncryptionDecorator(source2);

//source3.WriteData(salaryRecords);
//Console.WriteLine();
//Subsystem1 subsystem1 = new Subsystem1();
//Subsystem2 subsystem2 = new Subsystem2();
//Facade facade = new Facade(subsystem1, subsystem2);
//facade.Operate();
Forest forest = new();
forest.PlantTree(10, 20, "Oak", "Green", "Rough");
forest.PlantTree(15, 25, "Pine", "Dark Green", "Smooth");
forest.PlantTree(10, 20, "Oak", "Green", "Rough"); // Uses the existing flyweight

forest.Draw("Canvas");
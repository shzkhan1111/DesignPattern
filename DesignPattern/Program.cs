using DesignPattern.DesignPattern;


var stopnow = false;
do
{
    Console.WriteLine("Please Enter your selected value");
    Console.WriteLine("y for html");
   

    var selectedOption = Console.ReadKey().KeyChar;

    Console.WriteLine("");
    var isHtml = selectedOption == 'y';
    var fact = FactoryMethod.CreateButtonFactory(isHtml);

    fact.Render();
    fact.onClick();

    Console.WriteLine("n to stop");
    Console.WriteLine("");
    var isstop = Console.ReadKey().KeyChar;
    stopnow = isstop == 'n';

} while (!stopnow);

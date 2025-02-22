using DesignPattern.DesignPattern;


var stopnow = false;
do
{
    #region useless
    Console.WriteLine("Please Enter your selected value");
    Console.WriteLine("y for html");
    var selectedOption = Console.ReadKey().KeyChar;
    Console.WriteLine("");
    #endregion

    var isHtml = selectedOption == 'y';
    var fact = FactoryMethod.AbstractCreateFactoryForButtonAndCheckboxes(isHtml);

    var b = fact.createButton();
    var c = fact.createcheckbox();

    b.Render();
    b.onClick();

    c.onCheck();

    #region useless
    Console.WriteLine("n to stop");
    Console.WriteLine("");
    var isstop = Console.ReadKey().KeyChar;
    stopnow = isstop == 'n';
    #endregion
} while (!stopnow);

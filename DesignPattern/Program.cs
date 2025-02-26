using Models.StateDesignPattern;

DayOftheYear dayOftheYear = new DayOftheYear();
bool isMorning = false;
bool doContinue = true;



do{
    dayOftheYear.IsDay = isMorning;
    if (isMorning)
    {
        dayOftheYear.ChangeState(new MorningState());
    }
    else
    {
        dayOftheYear.ChangeState(new NightState());
    }
    dayOftheYear.start();
    var sel = Console.ReadKey().KeyChar;
    Console.WriteLine("Press Y to continue");
    doContinue = sel == 'y' || sel == 'Y';
    isMorning = !isMorning;

}while (isMorning);
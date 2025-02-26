using Models.StradagyDesignPatten;

for (int i = 0; i < 2; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Not Enough Memory");
        SortingMach sortingMach = new SortingMach(new BubbleSort());
        sortingMach.sortitout("", "");
    }
    else
    {
        Console.WriteLine("Enough Memory");
        SortingMach sortingMach = new SortingMach(new MergeSort());
        sortingMach.sortitout("", "");
    }
}
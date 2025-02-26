using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.StradagyDesignPatten
{
    public interface ISortingStrategy
    {
        List<string> Sort(string origin, string destination);
    }
    public class BubbleSort : ISortingStrategy
    {
        public List<string> Sort(string origin, string destination)
        {
            Console.WriteLine("Implementing bubble sort");
            return new List<string> { "abc", "abf"  , "ccc" , "ddd" , "eee"};
        }
    }
    public class MergeSort : ISortingStrategy
    {
        public List<string> Sort(string origin, string destination)
        {
            Console.WriteLine("Implementing Merge Sort");
            return new List<string> { "abc", "abf", "ccc", "ddd", "eee" };
        }
    }
    public class SortingMach
    {
        private ISortingStrategy _sortingStrategy;
        public SortingMach(ISortingStrategy sortingStrategy)
        {
             _sortingStrategy = sortingStrategy;
        }
        public List<string> sortitout(string origin, string destination) 
        {
            return _sortingStrategy.Sort(origin, destination);
        }

    }


}

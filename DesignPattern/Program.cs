using DesignPattern.DesignPattern;
using Models;
using Models.Adapter;
using Models.builder;
using Models.ChainOfResposibility;
using Models.CommandDesignPattern;
using Models.CompositeDesignPattern;
using Models.DecoratorDesignPatterb;
using Models.Enums;
using Models.Facade;
using Models.FlyWeight;
using Models.IteratorDEsignPattern;
using Models.PrototypeDesignPattern;
using Models.Proxy;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;



//int[] numbers = { 1, 2, 3, 4, 5 };
//NumberCollection collection = new NumberCollection(numbers);

//// Create an iterator for the collection
//IMyIterator iterator = collection.CreateIterator();

//// Use the iterator to traverse the collection
//Console.WriteLine("Iterating through the collection:");
//while (iterator.HasNext())
//{
//    Console.WriteLine(iterator.Next());
//}


string[] strings = { "shahz", "zain", "ahgned", "khan", "khh" };
StringCollection stringCollection = new StringCollection(strings);

IMystringIterator mystringIterator = stringCollection.createIteratorForStringCollection();
Console.WriteLine("Iterating through the collection:");
while (mystringIterator.HasNext())
{
    Console.WriteLine(mystringIterator.Next());
}

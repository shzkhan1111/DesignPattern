using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.IteratorDEsignPattern
{
    //iterator interface 
    public interface IMyIterator
    {
        bool HasNext();
        int Next();

    }
    public interface IMystringIterator
    {
        bool HasNext();
        string Next();

    }
    //collection Interface implement Iterator interface

    public interface IMycollection
    {
        //collection returns an iterator 
        IMyIterator CreateIterator();
    }
    //create collection\
    //collection injects itself into the iterator
    public class NumberCollection : IMycollection
    {
        private int[] _numbers;

        public NumberCollection(int[] numbers)
        {
            _numbers = numbers;
        }
        public IMyIterator CreateIterator()
        {
            return new NumberIterator(this);
        }

        public int Length
        {
            get { return _numbers.Length; }
        }
        public int GetElement(int index) => _numbers[index];

        //create Iterator 

        public class NumberIterator : IMyIterator
        {
            private NumberCollection _collection;
            private int _position = 0;

            public NumberIterator(NumberCollection collection)
            {
                _collection = collection;
            }
            public bool HasNext()
            {
                return _position < _collection.Length;
            }

            public int Next()
            {
                if (HasNext())
                {
                    return _collection.GetElement(_position++);
                }
                throw new InvalidOperationException("No more elements!");
            }
        }

    }

    public interface IStringCollection
    {
        IMystringIterator createIteratorForStringCollection();
    }
    public class StringCollection : IStringCollection
    {
        private string[] _colllectionofstrings;
        public StringCollection(string[] colllectionofstrings)
        {
             _colllectionofstrings = colllectionofstrings;
        }
        public IMystringIterator createIteratorForStringCollection()
        {
            return new StringCollectionIterator(this);
        }
        public int Length
        {
            get
            {
                return _colllectionofstrings.Length;
            }
        }
        public string getElementAtIndex(int index)
        {
            return _colllectionofstrings[index];
        }
    }
    public class StringCollectionIterator : IMystringIterator
    {
        private StringCollection _stringCollection;
        private int pos = 0;
        public StringCollectionIterator(StringCollection stringCollection)
        {
            _stringCollection = stringCollection;
        }

        public bool HasNext()
        {
            return _stringCollection.Length > pos;
        }

        public string Next()
        {
            if (HasNext())
            {
                return _stringCollection.getElementAtIndex(pos++);
            }
            throw new Exception("Out of bound");
            
        }
    }

}

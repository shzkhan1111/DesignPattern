using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DecoratorDesignPatterb
{
    public interface DecoratorPatternExample
    {
        void WriteData(string data);
        string ReadData();
    }
    //default 
    public class FileDataSource : DecoratorPatternExample
    {
        private string _filename;

        public FileDataSource(string filename)
        {
            _filename = filename;
        }
        public string ReadData()
        {
            string str = "Reading Data from FileDataSource";
            Console.WriteLine(str);
            return str;
        }

        public void WriteData(string data)
        {
            string str = "Writing Data to FileDataSource";
            Console.WriteLine(str);
        }
    }
    public class DataSourceDecorator : DecoratorPatternExample
    {
        protected DecoratorPatternExample _wrappee;

        public DataSourceDecorator(DecoratorPatternExample wrappee)
        {
            _wrappee = wrappee;
        }
        public string ReadData()
        {
            string str = "Reading Data to DataSourceDecorator";
            Console.WriteLine(str);
            _wrappee.ReadData();
            return str;
        }

        public void WriteData(string data)
        {
            string str = "Writing Data to DataSourceDecorator";
            Console.WriteLine(str);
            _wrappee.WriteData(str);
        }
    }

    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(DecoratorPatternExample wrappee) : base(wrappee)
        {

        }

        public new string ReadData()
        {
            string str = "Encryption Data to EncryptionDecorator";
            Console.WriteLine(str);
            _wrappee.ReadData();
            return str;
        }

        public new void WriteData(string data)
        {
            string str = "Encryption Data to EncryptionDecorator";
            Console.WriteLine(str);
            _wrappee.WriteData(str);
        }
    }

    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(DecoratorPatternExample wrappee) : base(wrappee)
        {
        }
        public new string ReadData() 
        {
            string str = "Compression Data to DataSourceDecorator";
            Console.WriteLine(str);
            _wrappee.ReadData();
            return str;
        }

        public new void WriteData(string data)
        {
            string str = "Compression Data to DataSourceDecorator";
            Console.WriteLine(str);
            _wrappee.WriteData(str);
        }
    }


}

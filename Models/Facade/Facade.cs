using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Facade
{
    public class Facade
    {
        protected Subsystem1 _subsystem1;

        protected Subsystem2 _subsystem2;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        public void Operate()
        {
            Console.WriteLine("Facade Action started");
            _subsystem1.operation1();
            _subsystem1.operation2();
            _subsystem2.operation1();
            _subsystem2.operation2();
            Console.WriteLine("Facade Action Completed");
        }
    }
    public class Subsystem1
    {
        public void operation1()
        {
            Console.WriteLine( "Subsystem1: Task 1!\n");

        }
        public void operation2() 
        {
            Console.WriteLine("Subsystem1: Task 2!\n");
        }
    }
    public class Subsystem2
    {
        public void operation1()
        {
            Console.WriteLine("Subsystem2: Task 1!\n");

        }
        public void operation2()
        {
            Console.WriteLine("Subsystem2: Task 2!\n");
        }
    }
}

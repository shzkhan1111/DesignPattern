using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.FactoryDPModel;

namespace DesignPattern.DesignPattern
{
    public class FactoryDesignPattern
    {
        
    }
    public class FactoryMethod
    {

        public static Ibutton CreateButtonFactory(bool isHtml)
        {
            if (isHtml)
            {
                Action action = () =>
                {
                    Console.WriteLine("Default wndows ");
                };
                return new HTMLButton(action);

            }
            else
            {
                Action action = () =>
                {
                    Console.WriteLine("you selected html");
                };
                return new WindowButton(action);
               

            }
        }
    }
}

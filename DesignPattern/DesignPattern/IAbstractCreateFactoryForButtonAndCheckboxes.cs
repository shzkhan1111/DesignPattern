using Models.FactoryDPModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPattern
{
    public interface implementAbstractFactory
    {

       /// <summary>
       /// for related family
       /// </summary>
       /// <returns></returns>
        Ibutton createButton();
        ICheckbox createcheckbox();
    }
    //fact to gove you the group of method
    public class implementWindowsGroupControl : implementAbstractFactory
    {
        public Ibutton createButton()
        {
            Action a = () => { Console.WriteLine("calling from abstract factory"); };
            return new WindowButton(a);
        }

        public ICheckbox createcheckbox()
        {
            return new WindowCheckBoxes();
        }
    }

    public class implementHTMLGroupControl : implementAbstractFactory
    {
        public Ibutton createButton()
        {
            Action a = () => { Console.WriteLine("calling from abstract factory"); };
            return new HTMLButton(a);
        }

        public ICheckbox createcheckbox()
        {
            return new HTMLCheckBoxes();
        }
    }



}

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

        public static implementAbstractFactory AbstractCreateFactoryForButtonAndCheckboxes(bool isHtml)
        {
            if (isHtml)
            {
                return new implementHTMLGroupControl();
            }
            else
            {
                return new implementWindowsGroupControl();
            }
        }
    }
}

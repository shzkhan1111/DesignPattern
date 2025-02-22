using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FactoryDPModel
{
    public class WindowCheckBoxes : ICheckbox
    {
        
        public void onCheck()
        {
            Console.WriteLine("Window radio has been checked");    
        }

        public void onUnChecked()
        {
            Console.WriteLine("Window radio has been unchecked");
        }
    }

    public class HTMLCheckBoxes : ICheckbox
    {

        public void onCheck()
        {
            Console.WriteLine("HTML radio has been checked");
        }

        public void onUnChecked()
        {
            Console.WriteLine("HTML radio has been unchecked");
        }
    }
}

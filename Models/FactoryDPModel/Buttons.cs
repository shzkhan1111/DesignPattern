using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FactoryDPModel
{
    //implement button
    public class WindowButton : Ibutton
    {
        private readonly Action action;

        public WindowButton(Action action)
        {
            this.action = action;
        }
        public void Render()
        {
            Console.WriteLine("Windows Render Button has been clicked");

        }
        public void onClick()
        {
            Console.WriteLine("Windows click Button Calling Action");
            action();
        }
    }

    public class HTMLButton : Ibutton
    {
        private readonly Action action;

        public HTMLButton(Action action)
        {
            this.action = action;
        }
        public void onClick()
        {
            Console.WriteLine("HTML click Button Calling Action");
            action?.Invoke();
        }

        public void Render()
        {
            Console.WriteLine("HTML Render Button has been clicked");
        }
    }
}

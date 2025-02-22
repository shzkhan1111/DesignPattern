using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FactoryDPModel
{
    //render
    //Click(Action)
    public interface Ibutton
    {
        void Render();
        void onClick();

    }

    public interface ICheckbox
    {
        void onCheck();
        void onUnChecked();
    }
}

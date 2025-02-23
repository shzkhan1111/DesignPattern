using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PrototypeDesignPattern
{

    
    
    public interface ICircle
    {
        ICircle CloneCircleCopyConst();
        ICircle CloneCircleCopy();
        void Draw();
    }

    public class ConstructorCirclePrototype : ICircle
    {
        public int Radius { get; set; }
        private int id;

        public ConstructorCirclePrototype(int r, int i)
        {
            Radius = r;
            id = i;
        }
        public ConstructorCirclePrototype()
        {
            
        }
        public ICircle CloneCircleCopyConst()
        {
            return new ConstructorCirclePrototype(Radius , id);
        }


        public void Draw()
        {
            Console.WriteLine($"Radius is {Radius}: id is {id}");
        }

        public ICircle CloneCircleCopy()
        {
            ConstructorCirclePrototype circle = new ConstructorCirclePrototype();
            circle.Radius = Radius;
            circle.id = id;
            return circle;
        }
    }

}

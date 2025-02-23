using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Adapter
{
    /// <summary>
    /// Object Adapter
    /// </summary>
    /// 
    public interface IRoundPeg
    {
        public int getRadius { get; }
    }
    public class RoundHole : IRoundPeg
    {
        //key hole 
        //has fit method 

        private int radius;

        public RoundHole(int r)
        {
            radius = r;
        }

        public int getRadius { get { return radius; } }

        public string FitsInsideKey(int r)
        {
            if(r == radius)
            {
                return "Key FIts";
            }
            return "Key doesnt FIt";
        }

    }

    public class RoundKey
    {
        private int radius;
        public RoundKey(int r)
        {
            radius = r;
        }
        public int getRadius { get { return radius; } }

    }
    public class SquareKey
    {
        public string Length { get; set; }
        public SquareKey(string le)
        {
            Length = le;
        }
    }

    public class SquareToKeyObjectAdapter : RoundKey
    {
        private SquareKey _squarekey;
        public SquareToKeyObjectAdapter(int r , SquareKey sk) : base(r)
        {
            _squarekey = sk;
        }
        public new int getRadius {
            get {
                int val = int.Parse(_squarekey.Length);
                return val;
            }
        }
    }

    public class SquareToKeyClassAdapter : SquareKey, IRoundPeg
    {
        public SquareToKeyClassAdapter(string le) : base(le)
        {
        }   

        public int getRadius
        {
            //provide functionality for IRoundPeg
            //reusing SquareKey
            get
            {
                int val = int.Parse(this.Length);
                return val;
            }
        }
    }

}

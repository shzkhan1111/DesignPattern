using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.FlyWeight
{
    public class Flyweight
    {

    }
    //store shared state
    public class TreeType
    {
        //only get as they cannot change
        public string Name { get; }
        public string Color { get; }
        public string Texture { get; }

        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
        }

        public void Draw(string canvas, int x, int y)
        {
            Console.WriteLine($"Drawing {Name} tree at ({x}, {y}) on {canvas} with color {Color} and texture {Texture}.");
        }

    }

    //fly weight factory 
    class TreeFactory
    {
        private static readonly List<TreeType> _treeTypes = new();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            //if exist in the tree
            var type = _treeTypes.Find(t => t.Name == name && t.Color == color && t.Texture == texture);
            //if nor add 
            if (type == null)
            {
                type = new TreeType(name, color, texture);
                _treeTypes.Add(type);
            }
            return type;

        }

    }

    // Context: Stores unique data (position)

    public class Tree
    {
        //x and y are state that will change constantly
        public int X { get; }
        public int Y { get; }
        private readonly TreeType _type;

        public Tree(int x, int y, TreeType type)
        {
            X = x;
            Y = y;
            _type = type;
        }

        public void Draw(string canvas)
        {
            _type.Draw(canvas, X, Y);
        }
    }


    // Client: Uses the flyweight and context
    //forest for collection of trees

    public class Forest
    {
        private readonly List<Tree> _trees = new();
        //plant tree will add to the collection of trees 
        //multiple object share  the same state
        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            TreeType type = TreeFactory.GetTreeType(name, color, texture);
            Tree tree = new(x, y, type);
            _trees.Add(tree);
        }
        //draw will draw all trees 
        public void Draw(string canvas)
        {
            foreach (var tree in _trees)
            {
                tree.Draw(canvas);
            }
        }


    }

}

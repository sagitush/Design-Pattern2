using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern1._3._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite(6);
            Component number1 = new Leaf(8);
            Component number2 = new Leaf(8);
            root.AddChild(number1);
            root.AddChild(number2);

            Component container1 = new Composite(5);
            Component number3 = new Leaf(8);
            Component number4 = new Leaf(2);
            container1.AddChild(number3);
            container1.AddChild(number4);

            root.AddChild(container1);

            Component container2 = new Composite(6);
            Component t1 = new Leaf(4);
            Component t2 = new Leaf(2);
            container2.AddChild(t1);
            container2.AddChild(t2);

            root.AddChild(container2);

            Console.WriteLine(root.Sum(0));
            if(Duplicate(root)==true)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }

        static bool Duplicate(Component c)
        {
            if (c.GetNumber() % 2 != 0)
            {
                return false;
            }
            if (c.GetChilds() == null)
                return true;

            foreach (Component child in c.GetChilds())
            {
                if (Duplicate(child) == false)
                {
                    return false;
                }
            }
            return true;
        }
    }

   
}


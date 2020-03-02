using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern1._3._20
{
   public abstract class Component
    {
        
        protected int number;

        public Component(int number)
        {
            this.number = number;
        }

        public abstract void AddChild(Component c);

        public abstract void RemoveChild(Component c);

        public abstract IList<Component> GetChilds();

        public abstract int Sum(int number);

       
        public int GetNumber()
        {
            return this.number;
        }
    }
}

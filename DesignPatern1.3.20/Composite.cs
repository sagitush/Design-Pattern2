using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern1._3._20
{
    public class Composite : Component
    {

        private IList<Component> childs = new List<Component>();

        public Composite(int number) : base(number)
        {
        }

        public override void AddChild(Component c)
        {
            childs.Add(c);
        }

        public override IList<Component> GetChilds()
        {
            return childs;
        }

        public override void RemoveChild(Component c)
        {
            childs.Remove(c);
        }      

        public override int Sum(int sum)
        {
            sum = sum + this.number;
            foreach (Component c in childs)
            {
               sum=sum+c.Sum(0);
            }
            return sum;
        }

       

    }
}

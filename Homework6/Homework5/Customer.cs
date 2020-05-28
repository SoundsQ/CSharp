using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    [Serializable]
    public class Customer
    {
        public string name;
        public string Name { get { return name; } }

        public Customer() { }
        public Customer(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return Name;
        }
        public override bool Equals(object obj)
        {
            Customer m = obj as Customer;
            return m.Name == Name;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

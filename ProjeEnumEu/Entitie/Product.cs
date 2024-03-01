using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeEnumEu.Entitie
{
    internal class Product
    {
        public string Name { get; set; }
        public double Prince { get; set; }

        public Product()
        { }

        public Product(string name, double prince)
        {
            Name = name;
            Prince = prince;
        }
    }
}

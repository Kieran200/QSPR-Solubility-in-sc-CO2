using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_for_BD
{
    internal class SubstanceView
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

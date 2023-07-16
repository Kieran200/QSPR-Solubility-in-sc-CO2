using Interface_for_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_for_BD
{
    class Individual
    {
        public List<double> chromosomes;
        public double survival_rate;
        public double survival_percent;
        public Individual(List<double> chrom, double rate)
        {
            chromosomes = chrom;
            survival_rate = rate;
        }
    }
}

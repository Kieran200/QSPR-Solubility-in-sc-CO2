using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_for_BD
{
    class Average_Eq
    {
        public void Average_Equations(List<List<double>> eqList, out List<double> FinalCoefList, double pow)
        {
            FinalCoefList = new List<double>(eqList[0].Count);
            for (int i = 0; i < eqList[0].Count; i++)
            {
                FinalCoefList.Insert(i, 0);
                for (int j = 0; j < eqList.Count; j++)
                {         
                    FinalCoefList[i] += Math.Pow(eqList[j][i], pow);
                }
                FinalCoefList[i] = Math.Pow(FinalCoefList[i] / eqList.Count, (1/pow));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_for_BD
{
    class Average_Eq
    {
        public void Average_Equations(List<List<double>> eqList, List<double> solubList, out List<double> FinalCoefList)
        {
            FinalCoefList = new List<double>(eqList[0].Count);
            for (int i = 0; i < eqList[0].Count; i++)
            {
                FinalCoefList.Insert(i, 0);
                for (int j = 0; j < eqList.Count; j++)
                {         
                    FinalCoefList[i] += eqList[j][i];
                }
                FinalCoefList[i] = FinalCoefList[i] / eqList.Count;
            }
        }
    }
}

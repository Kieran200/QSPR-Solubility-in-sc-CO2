using Interface_for_BD;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Interface_for_BD
{
    class GA
    {
        public void Genetic_Algorithm(List<double> variablesList, double survival_rate, out List <double> coefList)
        {   
            List<double> none = new List<double>();
            coefList = none;

            int gen_scale = 40;
            Random rnd = new Random();
            List<Individual> gensList = new List<Individual>();  //переменные нескольких уравнений
            List<List<Individual>> parentsList = new List<List<Individual>>();
            double precision = 0.0000001;

            for (int i = 0; i < gen_scale; i++)
            {
                List<double> first_chrom_List = new List<double>();    //переменные для 1го уравнения
                for (int j = 0; j < variablesList.Count; j++)
                {
                    double r = rnd.NextDouble();
                    first_chrom_List.Add(rnd.Next(0, Convert.ToInt32(survival_rate)) +r);
                }
                Individual individ = new Individual(first_chrom_List, survival_rate);
                gensList.Add(individ);
            }

            Distance_Calc calc = new Distance_Calc();
            bool stop = true;
            double sum_of_reciprocals = 0;
            int count = 0;

            while (stop)
            {
                count++;
                //рассчитываем коэффициенты выживаемости
                foreach (Individual individ in gensList)
                {
                    individ.survival_rate = calc.Distance(variablesList, individ.chromosomes, survival_rate);
                    if (individ.survival_rate > precision)
                        sum_of_reciprocals = sum_of_reciprocals + (1 / Convert.ToDouble(individ.survival_rate));
                    else break;
                }

                foreach (Individual individ in gensList)
                {
                    if (individ.survival_rate > precision)
                        individ.survival_percent = 100.0 * ((1 / Convert.ToDouble(individ.survival_rate)) / sum_of_reciprocals);
                    else break;
                }
                foreach (Individual individ in gensList)
                {
                    if (individ.survival_rate < precision || count > 10000000)
                    {
                        for (int i = 0; i < individ.chromosomes.Count; i++)
                        {
                            coefList.Add(individ.chromosomes[i]);
                        }
                        stop = false;
                        break;
                    }
                }
               
                //ранжирование списка популяции
                Individual number; //локальная переменная 

                for (int i = 0; i < gensList.Count - 1; i++)
                {
                    if (gensList[i].survival_percent < gensList[i + 1].survival_percent)
                    {
                        number = gensList[i];
                        gensList[i] = gensList[i + 1];
                        gensList[i + 1] = number;
                        i = -1;
                    }
                }
                //список родителей
                parentsList.Clear();
                for (int i = 0; i < gen_scale; i++)
                {
                    parentsList.Add(new List<Individual> { gensList[rnd.Next(0, Convert.ToInt32(gen_scale / 4))], gensList[rnd.Next(0, gen_scale/2)] });
                }

                //новое поколение
                gensList.Clear();
                foreach (List<Individual> parents in parentsList)
                {
                    List<double> chroms = new List<double>();
                    for (int i = 0; i < parents[0].chromosomes.Count; i++)
                    {
                        chroms.Add(parents[rnd.Next(0, 2)].chromosomes[i]);
                    }
                    Individual individ = new Individual(chroms, survival_rate);
                    gensList.Add(individ);
                }
                //мутация        
                int mutation_coef = rnd.Next(0, 6);
                if (mutation_coef == 5)
                {
                    gensList[rnd.Next(0, 10)].chromosomes[rnd.Next(0, variablesList.Count)] = rnd.Next(0, Convert.ToInt32(survival_rate)) + rnd.NextDouble();
                }
                sum_of_reciprocals = 0;
            }
        }
    }
}

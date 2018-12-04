using Lab2.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.action
{
    public class PolinomialActions
    {
       
        public PolinomialActions()
        {
        }
        
        public static Polinomial calculatePolinomialSum(List<Polinomial> polinomials)
        {
            Polinomial result = new Polinomial();
            int maxPower = 0;
            foreach (Polinomial polinomial in polinomials)
            {
               if(polinomial.Power > maxPower)
                {
                    maxPower = polinomial.Power;
                }
            }
            result.Power = maxPower;
            result.Coefficients = new List<double>(new double[maxPower + 1]);

            foreach (Polinomial polinomial in polinomials)
            {
                for(int i = 0; i <= polinomial.Power; i++)
                {
                    result.Coefficients[i] += polinomial.Coefficients[i];
                }
            }
           
            return result;
        }
    }
}

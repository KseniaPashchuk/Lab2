using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2.model
{
    public class Polinomial
    {
        private int power;
        private List<double> coefficients;

        public Polinomial()
        {
        }

        public Polinomial(int power, List<double> coefficients)
        {
            Power = power;
            Coefficients = coefficients;
        }

        public int Power { get => power; set => power = value; }
        public List<double> Coefficients { get => coefficients; set => coefficients = value; }

        public double GetCoefficient(int power)
        {
            if (power >= Coefficients.Count)
            {
                throw new InvalidOperationException("Can not get coefficient because actual polinomial power is less than requested");
            }
            return Coefficients[power];
        }

        public override bool Equals(object obj)
        {
            var polinomial = obj as Polinomial;
            return polinomial != null &&
                   Power == polinomial.Power &&
                   Coefficients.SequenceEqual(polinomial.Coefficients);
        }

        public override int GetHashCode()
        {
            var hashCode = 552058985;
            hashCode = hashCode * -1521134295 + Power.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<double>>.Default.GetHashCode(Coefficients);
            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for(int p = power; p >= 0; p--)
            {
                if (Coefficients[power] == 0)
                {
                    continue;
                }
                if (p == power || Coefficients[power] < 0)
                {
                    str.Append(Coefficients[power] + "*x^" + power);
                }
                else if (Coefficients[power] > 0)
                {
                    str.Append(" + " + Coefficients[power] + "*x^" + power);
                }

            }
            return base.ToString();
        }
    }
}

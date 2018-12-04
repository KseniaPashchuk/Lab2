using Lab2.model;
using Lab2.action;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        private List<Polinomial> polinomials;

        [SetUp]
        public void Setup()
        {
            polinomials = new List<Polinomial>();
            polinomials.Add(new Polinomial(2, new List<double>() {1, 2, 3}));
            polinomials.Add(new Polinomial(4, new List<double>() {1, 2, 3, 4, 5}));
            polinomials.Add(new Polinomial(1, new List<double>() {1, 2}));
        }

        [Test]
        public void test_calculatePolinomialSum()
        {
            Polinomial expectedResult = new Polinomial(4, new List<double>() {3, 6, 6, 4, 5 });
            Polinomial actualResult = PolinomialActions.calculatePolinomialSum(polinomials);            
            
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
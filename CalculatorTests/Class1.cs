using NUnit.Framework;
using Practices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTests
{

    public class Class1
    {
        [Test]
        public void AdditionalShouldReturn()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(100, 50) == 150);
        }

        [Test]
        public void SubtractionShouldReturn()
        {
            Calculator calculator=new Calculator();
            Assert.That(calculator.Subtraction(100, 50) == 50);
        }

        [Test]
        public void MultiplicationShouldReturn()
        {
            Calculator claculator=new Calculator();
            Assert.That(claculator.Multiplication(100, 5) == 500);
        }

        [Test]
        public void DivisionShouldReturn()
        {
            Calculator calculator=new Calculator();
            Assert.That(calculator.Division(100, 5) == 20);
        }

        [Test]
        public void DivisionNotZero()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}

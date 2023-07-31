using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calc = new();

            //Act
            int result = calc.AddNumbers(10, 20);

            //Assert
            Assert.AreEqual(30, result);
        }

        [Test]
        [TestCase(11)] //PARA EJECUTAR EL MÉTODO CON MÚLTIPLES PARÁMETROS
        [TestCase(13)]
        public void IsOddNumber_InputOddNumber_GetTrue(int num)
        {
            //Arrange
            Calculator calc = new();

            //Act
            bool result = calc.IsOddNumber(num);

            //Assert
            //OTRAS FORMAS
            //Assert.IsTrue(result);

            //CONSTRAINT ASSERTION MODEL
            //Assert.That(result, Is.True);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void IsOddNumber_InputEvenNumber_GetFalse()
        {
            //Arrange
            Calculator calc = new();

            //Act
            bool result = calc.IsOddNumber(4);

            //Assert
            Assert.IsFalse(result);
        }

        //Haciendo uso de ExpectedResult y retornando se podrían combinar los dos métodos anteriores
        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddNumber_InputNumber_ReturnTrueIfOdd(int num)
        {
            //Arrange
            Calculator calc = new();

            //Act
            return calc.IsOddNumber(num);
        }

        [Test]
        [TestCase(5.4, 10.5)]
        [TestCase(5.43, 10.53)]
        [TestCase(5.49, 10.59)]
        public void AddNumbersDouble_InputTwoDoubles_GetCorrectAddition(double num1, double num2)
        {
            //Arrange
            Calculator calc = new();

            //Act
            double result = calc.AddNumbersDouble(num1, num2);

            //Assert
            //SE USA EL DELTA QUE ES LA DIFERENCIA PERMITIDA, TODOS NUESTOS INPUTS TIENEN COMO RESULTADO UN
            //NÚMERO EN ESE RANGO
            Assert.AreEqual(15.9, result, 1);
        }
    }
}
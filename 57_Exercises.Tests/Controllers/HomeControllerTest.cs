using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _57_Exercises.Controllers;
using Newtonsoft.Json;
using _57_Exercises.Models;

namespace _57_Exercises.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void _1_WhenGivenAName_ShouldReturnGreeting()
        {
            //Arrange
            var controller = new HomeController();
            var name = "Peraxel";
            var expected = $"Hello, {name}, nice to meet you!";
            
            // Act
            var actual = controller._1(name).Content;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _2_WhenGivenAString_ShouldReturnStringAndStringLength()
        {
            //Arrange
            var controller = new HomeController();
            var name = " Peraxel ";
            var length = name.Trim().Length;
            var expected = $"\"{name}\" contains {length} characters.";
            // Act
            var actual = controller._2(name).Content;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _3_WhenEnteringAQuote_SholuReturnTheQouteWithQoutationMarks()
        {
            // Arrange
            HomeController controller = new HomeController();
            var qoute = "Kilroy was here";
            var expected = $"The qoute is \"{qoute}\".";

            // Act
            var actual = controller._3(qoute).Content;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _4_WhenEnteringAQuote_SholuReturnTheQouteWithQoutationMarks()
        {
            // Arrange
            HomeController controller = new HomeController();
            string[] words = {"dog", "walk", "blue", "quickly"};
            var expected = $"Do you {words[1]} your {words[2]} {words[0]} {words[3]}. That is hilarious!";

            // Act
            var actual = controller._4(JsonConvert.SerializeObject(words)).Content;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _5_WhenEnteringTwoNumbers_SholudReturnSumDiffProduktAndRatio()
        {
            // Arrange
            string[] expected = {"5 + 2 = 7", "5 - 2 = 3", "5 * 2 = 10", "5 / 2 = 2,5"};

            // Act
            List<string> actual = Helpers.Helper57._5_DoTheMath(5, 2).ToList();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _6_WhenEnteringTwoNumbers_SholudReturnCorrectAnswer()
        {
            // Arrange
            HomeController controller = new HomeController();
            int age = 50;
            int retirementAge = 65;
            var currentYear = DateTime.Now.Year;

            IEnumerable<string> expected = new List<string>()
            {
                $"You have {retirementAge - age} years left until you can retire.",
                $"It is {currentYear} so you can retire in {retirementAge - age + currentYear}."
            };

            // Act
            IEnumerable<string> actual = Helpers.Helper57._6_DoTheMath(age, retirementAge);

            // Assert
            CollectionAssert.AreEqual(expected.ToList(), actual.ToList());
        }

        [TestMethod]
        public void _7_WhenEnteringTwoNumbersInFeet_SholudReturnAreaInSquareFeet()
        {
            // Arrange
            double length = 10;
            double width = 65;
            double expected = length * width;

            // Act
            double actual = new Ex7(length, width, "sqFeet").GetAreaInSquareFeet();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] public void _7_WhenEnteringTwoNumbersInMeter_SholudReturnAreaInSquareFeet()
        {
            double length = 10;
            double width = 65;
            double expected = length * width / Ex7.ConversionFactor;
            // Act
            double actual = new Ex7(length, width, "sqMeter").GetAreaInSquareFeet();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _8_When1Pizza7People8Slices_SholudReturn1SlicePerPersonAnd1Leftover()
        {
            int people = 7;
            int pizza = 1;
            int slices = 8;
            int expectedSlicePerPerson = 1;
            int expectedLeftOvers = 1;
            // Act
            Ex8 ex = new Ex8(people, pizza, slices);
            int actualSlicesPerPerson = ex.GetSlicesPerPerson();
            int actualLeftOvers = ex.GetLeftOvers();

            // Assert
            Assert.AreEqual(expectedSlicePerPerson, actualSlicesPerPerson);
            Assert.AreEqual(expectedLeftOvers, actualLeftOvers);
        }

        [TestMethod]
        public void _8_When4Pizza5People8Slices_SholudReturn6SlicePerPersonAnd2Leftover()
        {
            int people = 5;
            int pizza = 4;
            int slices = 8;
            int expectedSlicePerPerson = 6;
            int expectedLeftOvers = 2;
            // Act
            Ex8 ex = new Ex8(people, pizza, slices);
            int actualSlicesPerPerson = ex.GetSlicesPerPerson();
            int actualLeftOvers = ex.GetLeftOvers();

            // Assert
            Assert.AreEqual(expectedSlicePerPerson, actualSlicesPerPerson);
            Assert.AreEqual(expectedLeftOvers, actualLeftOvers);
        }

        [TestMethod]
        public void _9_WhenEnteringWidth4AndLength5_SholudReturn6Liters()
        {
            int width = 5;
            int length = 4;
            int expected = 6;
            // Act
            Ex9 ex = new Ex9(width, length);
            int actual = ex.GetPaintNeeded();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _10_WhenInputIsX_SholudReturnCorrectAnswer()
        {
            IList<KeyValuePair<int, int>> items = new List<KeyValuePair<int, int>>();

            items.Add(new KeyValuePair<int, int>(2, 25));
            items.Add(new KeyValuePair<int, int>(1, 10));
            items.Add(new KeyValuePair<int, int>(1, 4));

            float expectedSubTotal = 64.0F;
            float expectedTax = 3.52F;  
            float expectedTotal = 67.52F;
            // Act
            Ex10 ex = new Ex10(items);
            float actualSubTotal = ex.GetSubTotal();
            float actualTax = ex.GetTax();
            float actualTotal = ex.GetTotal();

            // Assert
            Assert.AreEqual(expectedSubTotal, actualSubTotal);
            Assert.AreEqual(expectedTax, actualTax);
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void _12_WhenGivenPrinipalRateAndYears_SholudReturnCorrectAmount()
        {
            // Arrange
            decimal principal = 1500m;
            float rate = 4.3F;
            int years = 4;
            Ex12 ex = new Ex12(principal, rate, years);
            decimal expected = 1758m;
            
            // Act
            decimal actual = ex.CalculateInterest();
            
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _14_WhenStateIsWI_SholudReturnThreeStrings()
        {
            // Arrange
            string state = "wi";
            decimal amount = 15.5m;
            int expected = 3;
            Ex14 ex = new Ex14(state, amount);

            // Act
            string[] actual = ex.GetResult();
            // Assert
            Assert.AreEqual(expected, actual.Length);
        }

        [TestMethod]
        public void _14_WhenStateIsNotWI_SholudReturnOneString()
        {
            // Arrange
            string state = "aa";
            decimal amount = 15.5m;
            int expected = 1;
            Ex14 ex = new Ex14(state, amount);

            // Act
            string[] actual = ex.GetResult();
            // Assert
            Assert.AreEqual(expected, actual.Length);
        }

        [TestMethod]
        public void _15_WhenEnteringCorrectCredentials_SholudTrue()
        {
            // Arrange
            string userName = "aaa";
            string password = "123@Bob";
            //bool expected = true;
            Ex15 ex = new Ex15(userName, password);

            // Act
            bool actual = ex.IsValid();
            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void _15_WhenEnteringWrongCredentials_SholudFalse()
        {
            // Arrange
            string userName = "wrong";
            string password = "123@Bob";
            //bool expected = true;
            Ex15 ex = new Ex15(userName, password);

            // Act
            bool actual = ex.IsValid();
            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void _18_WhenEntering32Farenheight_SholudReturn0Celcius()
        {
            // Arrange
            int temp = 32;
            TemeratureScale tempScale = TemeratureScale.Farenheit;
            float expected = 0;
            Ex18 ex = new Ex18(temp, tempScale);

            // Act
            float actual = ex.GetTempInCelcius();
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _18_WhenEntering0Celcius_SholudReturn32Farenheight()
        {
            // Arrange
            int temp = 0;
            TemeratureScale tempScale = TemeratureScale.Celsius;
            float expected = 32;
            Ex18 ex = new Ex18(temp, tempScale);

            // Act
            float actual = ex.GetTempInFarenheight();
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

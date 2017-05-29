using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _57_Exercises.Models;

namespace _57_Exercises.Tests.Controllers
{
    [TestClass]
    public class Chapter5ControllerTests
    {
        [TestMethod]
        public void _24_WhenGivenTwoAnagrams_SholudReturnTrue()
        {
            // Arrange
            string s1 = "tone";
            string s2 = "note";
            Ex24 ex = new Ex24(s1, s2);
            
            // Act
            bool actual = ex.IsAnagram;

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void _24_WhenGivenTwoNoneAnagrams_SholudReturnFalse()
        {
            // Arrange
            string s1 = "bob";
            string s2 = "note";
            Ex24 ex = new Ex24(s1, s2);

            // Act
            bool actual = ex.IsAnagram;

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void _25_WhenGivenAWeakPassword_SholudReturnWeak()
        {
            // Arrange
            string pw = "ABC";
            PasswordStrength expected = PasswordStrength.Weak;
            
            // Act
            PasswordStrength actual = Ex25.ValidatePassword(pw);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _25_WhenGivenAVeryStrongPassword_SholudReturnVeryStrong()
        {
            // Arrange
            string pw = "ABCD1234&";
            PasswordStrength expected = PasswordStrength.VeryStrong;

            // Act
            PasswordStrength actual = Ex25.ValidatePassword(pw);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

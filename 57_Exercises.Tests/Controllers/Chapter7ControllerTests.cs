using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _57_Exercises.Models;

namespace _57_Exercises.Tests.Controllers
{
    [TestClass]
    public class Chapter7ControllerTests
    {
        [TestMethod]
        public void _34_WhenRemovingOnName_SholudReturnListWithCorrectNumberOfNames()
        {
            // Arrange
            IEnumerable<string> names = Ex34.GetNames();
            int before = names.Count();

            // Act
            Ex34.RemoveName(names.First());
            int after = Ex34.GetNames().Count();

            // Assert
            Assert.AreEqual(before-1, after);
        }
    }
}

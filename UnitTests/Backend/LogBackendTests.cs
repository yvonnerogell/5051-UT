using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Backend;
using HW1c.Models;

namespace UnitTests.Backend
{
    [TestClass]
    public class LogBackendTests
    {
        [TestMethod]
        public void LogBackend_Default_Instance_Should_Pass()
        {
            // Arrange
            // Can't instantiate a singleton pattern

            // Act
            var result = LogBackend.Instance;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LogBackend_Index_Default_Should_Pass()
        {
            // Arrange
            // Can't instantiate a singleton pattern

            // Act
            LogViewModel myData = LogBackend.Instance.Index();

            // Assert
            // Should have 4 rows
            Assert.AreEqual(4, myData.LogList.Count);
        }
    }
}

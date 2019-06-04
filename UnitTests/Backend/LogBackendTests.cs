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

        [TestMethod]
        public void LogBackend_Create_Default_Should_Pass()
        {
            // Arrange
            LogModel myModel = new LogModel();
            myModel.PhoneID = "TestingPhone";

            // Act
            LogModel myData = LogBackend.Instance.Create(myModel);

            // Assert
            Assert.AreEqual("TestingPhone", myData.PhoneID);
        }

        [TestMethod]
        public void LogBackend_Delete_First_Should_Pass()
        {
            // Arrange
            LogViewModel myList = LogBackend.Instance.Index();
            int countBeforeDelete = myList.LogList.Count;

            // Get ID of first item in list
            string myId = myList.LogList[0].ID;

            // Act
            // Delete ID
            LogBackend.Instance.Delete(myId);
            // Get id of list that's now first in the list
            string firstID = myList.LogList[0].ID;

            // Assert
            Assert.AreNotEqual(firstID, myId);
            Assert.AreNotEqual(countBeforeDelete, myList.LogList.Count);

        }

        [TestMethod]
        public void LogBackend_Read_First_Should_Pass()
        {
            // Arrange
            LogViewModel myList = LogBackend.Instance.Index();
            LogModel myModel = myList.LogList[0];
            string myID = myModel.ID;

            // Act
            // Get ID of first item in list via LogBackend Read method
            LogModel myModel2 = LogBackend.Instance.Read(myID);

            // Assert
            // Assert both IDs are equal.
            Assert.AreEqual(myID, myModel2.ID);



        }


    }
}

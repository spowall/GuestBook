using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuestBook.Domain;

namespace GuestBook.Tests.Domain
{
    [TestClass]
    public class EventManagerTest
    {
        [TestMethod]
        public void ListEventReturnsEvents()
        {
            //Arrange
            var eventManager = new EventManager();

            //Act
            var events = eventManager.ListEvents();

            //Assert
            Assert.IsNotNull(events, "Events should not be null");
            Assert.IsTrue(events.Length > 0, "Events should not be empty");
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mock;
using Moq;
using FluentAssertions;
using System.Collections.Generic;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MethodTest()
        {
           var listOfBands = new List<Band>();
            listOfBands.Add(new Band
            {
                Name = "Insync Maniacs",
                song = "Fir Kabhi",
                genre = "emotional"
            });

            Mock<IRepository> mockRepository = new Mock<IRepository>();
            mockRepository.Setup(x => x.GetBands()).Returns(listOfBands);
            var bandController = new BandController(mockRepository.Object);
            bandController.Method();
            bandController.Should().NotBeNull();
        }
    }
}

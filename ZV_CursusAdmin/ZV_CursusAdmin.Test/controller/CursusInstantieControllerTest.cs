using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ZV_CursusAdmin.App.Controllers;
using ZV_CursusAdmin.App.Entities;
using ZV_CursusAdmin.App.Repositories;

namespace ZV_CursusAdmin.Test
{
    [TestClass]
    public class CursusInstantieControllerTest
    {
        [TestMethod]
        public void CursusInstatnieController_GetCursusInstantie_NotNull()
        {
            //Arrange
            var mockRepository = new Mock<ICursusInstantieRepository>();
            var controller = new CursusInstantieController(mockRepository.Object);

            //Act
            var result = controller.GetAllCursusInstanties();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CursusInstatnieController_GetCursusInstantie_TypeOfIEnumerable()
        {
            //Arrange
            var mockRepository = new Mock<ICursusInstantieRepository>();
            var controller = new CursusInstantieController(mockRepository.Object);

            //Act
            var result = controller.GetAllCursusInstanties();

            //Assert
            Assert.IsInstanceOfType(result, typeof(IEnumerable<CursusInstantie>));
        }
    }
}

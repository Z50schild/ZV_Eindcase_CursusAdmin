using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ZV_CursusAdmin.App.Context;
using ZV_CursusAdmin.App.Entities;
using ZV_CursusAdmin.App.Repositories;

namespace ZV_CursusAdmin.Test.repository
{
    [TestClass]
    public class CursusInstantieRepositoryTest
    {
        private List<CursusInstantie> TestData()
        {
            var date1 = new DateTime(2020, 2, 2);
            var date2 = new DateTime(2020, 4, 4);
            var date3 = new DateTime(2020, 3, 5);
            var cursus1 = new Cursus() { Id = 1, Titel = "unittest", Duur = 5 };
            var cursus2 = new Cursus() { Id = 2, Titel = "mvc", Duur = 5 };
            var testObject1 = new CursusInstantie() { Id = 1, StartDatum = date1, Cursus = cursus1 };
            var testObject2 = new CursusInstantie() { Id = 2, StartDatum = date2, Cursus = cursus2 };
            var testObject3 = new CursusInstantie() { Id = 3, StartDatum = date3, Cursus = cursus2 };
            var testList = new List<CursusInstantie>() { testObject1, testObject2, testObject3 };
            return testList;
        }

       

        [TestMethod]
        public void CursusInstantieRepository_GetCursusInstantie_returnsAll()
        {
            //Arrange
            var testList = TestData();
            var dbSetMock = new Mock<DbSet<CursusInstantie>>();
            dbSetMock.As<IQueryable<CursusInstantie>>().Setup(s => s.Provider).Returns(testList.AsQueryable().Provider);
            dbSetMock.As<IQueryable<CursusInstantie>>().Setup(s => s.Expression).Returns(testList.AsQueryable().Expression);
            dbSetMock.As<IQueryable<CursusInstantie>>().Setup(s => s.ElementType).Returns(testList.AsQueryable().ElementType);
            dbSetMock.As<IQueryable<CursusInstantie>>().Setup(s => s.GetEnumerator()).Returns(testList.AsQueryable().GetEnumerator());


            var context = new Mock<CursusAdminContext>();
            context.Setup(s => s.Set<CursusInstantie>()).Returns(dbSetMock.Object);


            //Act
            var repository = new CursusInstantieRepository(context.Object);
            var result = repository.GetAllCursusInstanties();

            //Assert
            CollectionAssert.AreEqual(testList, result.ToList());
        }
    }
}


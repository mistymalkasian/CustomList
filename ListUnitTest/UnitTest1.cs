using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListUnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Add_Numbers_AddsNumberToList()
        {
            //Arrange
            MyList<int> newList = new MyList<int>();
            int result = 5;


            //Act
            newList.Add(result);


            //Assert
            Assert.AreEqual<int>(result, newList[0]);

        }
    }
}

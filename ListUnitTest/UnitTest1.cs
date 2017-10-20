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

        public void Add_String_AddsStringToList()
        {
            //Arrange
            MyList<string> newList = new MyList<string>();
            string result = "unicorn";

            //Act
            newList.Add(result);

            //Assert
            Assert.AreEqual<string>(result, newList[0]);
  
                
        }

        public void Add_Bool_AddsBoolToList()
        {
            //Arrange
            MyList<bool> newList = new MyList<bool>();
            bool result = true;

            //Act
            newList.Add(result);

            //Assert
            Assert.AreEqual<bool>(result, newList[0]);


        }

        public void Add_NewClass_AddsNewClassToList()
        {
            //Arrange
            MyList<Poop> newList = new MyList<Poop>();
            Poop Poop = new Poop();

            //Act
            newList.Add(Poop);

            //Assert
            Assert.AreEqual<string>(Poop, newList[0]);


        }

        public void Add_TwoStrings_AddsTwoStringsToList()
        {
            //Arrange
            MyList<string> newList = new MyList<string>();
            string string1 = "Misty";
            string string2 = "Malkasian";

            //Act
            newList.Add(string1);
            newList.Add(string2);

            //Assert
            Assert.AreEqual<string>(string1, newList[0]);
            Assert.AreEqual<string>(string2, newList[1]);


        }

        public void Add_TwoObjects_AddsTwoObjectsToList()
        {
            //Arrange
            MyList<Meme> newList = new MyList<Meme>();
            Meme Trollface = new Meme();
            Meme Doge = new Meme();

            //Act
            newList.Add(Trollface);
            newList.Add(Doge);

            //Assert
            Assert.AreEqual<string>(Trollface, newList[0]);
            Assert.AreEqual<string>(Doge, newList[1]);


        }
    }
}

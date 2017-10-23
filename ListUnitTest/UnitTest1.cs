using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace ListUnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Add_Number_AddsNumberToList()
        {
            //Arrange
            MyList<int> newList = new MyList<int>();
            int result = 5;

            //Act
            newList.Add(result);

            //Assert
            Assert.AreEqual<int>(result, newList[0]);
        }

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
        public void Add_Object_AddsObjectToList()
        {
            //Arrange
            MyList<Poop> newList = new MyList<Poop>();
            Poop Poop = new Poop();

            //Act
            newList.Add(Poop);

            //Assert
            Assert.AreEqual<string>(Poop, newList[0]);
        }

        [TestMethod]
        public void Add_TwoNumbers_AddsTwoNumbersToList()
        {
            //Arrange
            MyList<int> newList = new MyList<int>();
            int num1 = 1;
            int num2 = 2;

            //Act
            newList.Add(num1);
            newList.Add(num2);

            //Assert
            Assert.AreEqual<string>(newList.Count, 2);
        }

        [TestMethod]
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
            Assert.AreEqual<string>(newList.Count, 2);
        }

        [TestMethod]
        public void Add_TwoBools_AddsTwoBoolsToList()
        {
            //Arrange
            MyList<bool> newList = new MyList<bool>();
            bool bool1 = true;
            bool bool2 = false;

            //Act
            newList.Add(bool1);
            newList.Add(bool2);

            //Assert
            Assert.AreEqual<string>(newList.Count, 2);
        }

        [TestMethod]
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
            Assert.AreEqual<string>(newList.Count, 2);
        }

        [TestMethod]
        public void Add_MyList_AddsMyListToList()
        {
            //Arrange
            MyList<MyList<int>> newList1 = new MyList<MyList<int>>();
            MyList<MyList<int>> newList2 = new MyList<MyList<int>>();

            //Act
            newList1.Add(1);
            newList2.Add(newList1);

            //Assert
            Assert.AreEqual<int>(newList2[0], newList1);
        }

        [TestMethod]
        public void Add_LongerMyList_AddsLongerMyListToList()
        {
            //Arrange
            MyList<MyList<int>> newList1 = new MyList<MyList<int>>(1, 2, 3, 4, 5);
            MyList<MyList<int>> newList2 = new MyList<MyList<int>>();

            //Act
            newList1.Add(1);
            newList2.Add(newList1);

            //Assert
            Assert.AreEqual<string>(newList2[5], newList1);
        }

        [TestMethod]
        public void Add_TwoMyLists_AddsTwoMyListsToList()
        {
            //Arrange
            MyList<MyList<int>> newList1 = new MyList<MyList<int>>(1);
            MyList<MyList<int>> newList2 = new MyList<MyList<int>>();
            MyList<MyList<int>> newList3 = new MyList<MyList<int>>();

            //Act
            newList2.Add(newList1);
            newList3.Add(newList1);
            newList3.Add(newList2);

            //Assert
            Assert.AreEqual<string>(newList2[0], newList1);
        }

        [TestMethod]
        public void Remove_Number_RemovesNumberFromList()
        {
            //Arrange
            MyList<int> newList = new MyList<int>(5);

            //Act
            newList.Remove(5);

            //Assert
            Assert.AreEqual<int>(newList.Count, 0);
        }

        [TestMethod]
        public void Remove_String_RemovesStringFromList()
        {
            //Arrange
            MyList<string> newList = new MyList<string>("hello");

            //Act
            newList.Remove("hello");

            //Assert
            Assert.AreEqual<string>(newList.Count, 0);
        }

        [TestMethod]
        public void Remove_Bool_RemovesBoolFromList()
        {
            //Arrange
            MyList<bool> newList = new MyList<bool>(true);

            //Act
            newList.Remove(true);

            //Assert
            Assert.AreEqual<bool>(newList.Count, 0);
        }

        [TestMethod]
        public void Remove_Object_RemovesObjectFromList()
        {
            //Arrange
            Poop SteamingPoop = new Poop();
            MyList<Poop> newList = new MyList<Poop>(SteamingPoop);

            //Act
            newList.Remove(SteamingPoop);

            //Assert
            Assert.AreEqual<Poop>(newList.Count, 0);
        }

        [TestMethod]
        public void Remove_TwoNumbers_RemovesTwoNumbersFromList()
        {
            //Arrange
            MyList<int> newList = new MyList<int>(5, 3);

            //Act
            newList.Remove(5);
            newList.Remove(3);

            //Assert
            Assert.AreEqual<int>(newList.Count, 0);
        }

        [TestMethod]
        public void Remove_TwoStrings_RemovesTwoStringsFromList()
        {
            //Arrange
            MyList<string> newList = new MyList<string>("hello", "world");

            //Act
            newList.Remove("hello");
            newList.Remove("world");

            //Assert
            Assert.AreEqual<string>(newList.Count, 0);
        }

        [TestMethod]
        public void Remove_TwoBools_RemovesTwoBoolsFromList()
        {
            //Arrange
            MyList<bool> newList = new MyList<bool>(true, false);

            //Act
            newList.Remove(true);
            newList.Remove(false);

            //Assert
            Assert.AreEqual<bool>(newList.Count, 0);
        }

        [TestMethod]
        public void Remove_TwoObjects_RemovesTwoObjectsFromList()
        {
            //Arrange
            Meme BadLuckBrian = new Meme();
            Meme DatBoi = new Meme();
            MyList<Meme> newList = new MyList<Meme>(BadLuckBrian, DatBoi);

            //Act
            newList.Remove(BadLuckBrian);
            newList.Remove(DatBoi);

            //Assert
            Assert.AreEqual<Meme>(newList.Count, 0);
        }



    }
}

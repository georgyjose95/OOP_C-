using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonCL;

namespace CommonCL.Test
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void ValidInsertSpaceTest()
        {
            //Arrange
            string source = "FootballBoots";
            string expected = "Football Boots";

            //Act
            //string actual = StringHandler.InsertSpace(source);
            string actual = source.InsertSpace();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertSpaceTestWithExistingSpace()
        {
            //Arrange
            string source = "Football Boots";
            string expected = "Football Boots";

            //Act
            string actual = source.InsertSpace();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NullStringTest()
        {
            //Arrange
            string source = "";
            string expected = "";

            //Act
            string actual = source.InsertSpace();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SingleStringTest()
        {
            //Arrange
            string source = "Football";
            string expected = "Football";

            //Act
            string actual = source.InsertSpace();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

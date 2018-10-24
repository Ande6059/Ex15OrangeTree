﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex15OrangeTree;

namespace Ex15OrangeTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        private OrangeTree orangeTree;

        [TestInitialize]
        public void SetupForTest()
        {
            // Start an orange tree
            int age = 0;
            int height = 6;
            orangeTree = new OrangeTree(age, height);
        }

        [TestMethod]
        public void ShouldIncrementTheTreesAgeWithEachPassingYear()
        {
            //Act
            orangeTree.OneYearPasses();

            //Assert
            Assert.AreEqual(1, orangeTree.Age);
        }
        [TestMethod]
        public void ShouldIncrementTheTreesHeightByTwoWithEachPassingYear()
        {
            //Act
            orangeTree.OneYearPasses();

            //Assert
            Assert.AreEqual(8, orangeTree.Height);
        }
        [TestMethod]
        public void ShouldDieAfter80Years()
        {
            //Act
            for (int i = 1; i <= 80; i++)
            {
                orangeTree.OneYearPasses();
            }

            //Assert
            Assert.AreEqual(false, orangeTree.TreeAlive);
        }

        [TestMethod]
        public void ShouldProduceFruitAfter2Years()
        {
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.NumOranges);

            orangeTree.OneYearPasses();
            Assert.AreEqual(5, orangeTree.NumOranges);

        }
        [TestMethod]
        public void ShouldIncreaseFruitProductionBy5PiecesEachYearAfterMaturity()
        {
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            Assert.AreEqual(5, orangeTree.NumOranges);

            orangeTree.OneYearPasses();
            Assert.AreEqual(10, orangeTree.NumOranges);

        }
        [TestMethod]

        public void ShouldCountNumberOfOrangesEatenThisYear()
        {
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            orangeTree.EatOrange(1);

            Assert.AreEqual(1, orangeTree.OrangesEaten);

            orangeTree.EatOrange(3);
            Assert.AreEqual(4, orangeTree.OrangesEaten);

            Assert.AreEqual(5, orangeTree.NumOranges);
        }
        [TestMethod]
        public void OrangesEatenOneYearPasses()
        {
            //Act
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            orangeTree.EatOrange(1);
            orangeTree.EatOrange(3);
            orangeTree.OneYearPasses();
            //Assert
            Assert.AreEqual(0, orangeTree.OrangesEaten);
            Assert.AreEqual(10, orangeTree.NumOranges);
        }

        [TestMethod]
        public void DeadTreeDoNotGrowAndProduceFruit()
        {
            //Act
            for (int i = 1; i <= 80; i++)
            {
                orangeTree.OneYearPasses();
            }

            //Assert
            Assert.AreEqual(false, orangeTree.TreeAlive);
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.NumOranges);
            Assert.AreEqual(164, orangeTree.Height);
            Assert.AreEqual(81, orangeTree.Age);
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.NumOranges);
            Assert.AreEqual(164, orangeTree.Height);
            Assert.AreEqual(82, orangeTree.Age);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException), "You can't eat an orange that isn't there!  There are 0 oranges available to eat")]
        public void ShouldNotLetYouPickFruitThatIsNotThere()
        {
            orangeTree.EatOrange(1);
        }


    }

}
using System;
using GameOfLife.Models;
using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace Tests
{
    public class UniverseTest
    {

        Universe _universe;

        [SetUp]
        public void Setup()
        {
            _universe = new Universe();
        }

        [Test]
        public void GetAliveCellsCountShouldReturnZeroWhenCreated()
        {
            Assert.AreEqual(0, _universe.GetAliveCellsCount());
        }

        [Test]
        public void GetAliveCellsCountShouldReturnTwoWhenInitializedWithTwoAliveCells()
        {
            _universe.AddCell(0, 0);
            _universe.AddCell(0, 0);
            Assert.AreEqual(2, _universe.GetAliveCellsCount());
        }

        [Test]
        public void AddCellShouldThrowExceptionIfCellIsInInvalidLocation()
        {
            _universe.SetDimensions(1, 1);
            Assert.Throws<InvalidCellLocationException>(() => _universe.AddCell(3, 3));

        }



    }

    
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RankingPokerHands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RankingPokerHands.Tests
{
    [TestClass()]
    public class CheckHandTests
    {
        [TestMethod()]
        public void IsRoyalFlushTrueTest()
        {
            Assert.IsTrue(CheckHand.IsRoyalFlush(new int[] { 9, 10, 11, 12, 13 }, new char[] { 'C', 'C', 'C', 'C', 'C' }));
            Assert.IsTrue(CheckHand.IsRoyalFlush(new int[] { 9, 10, 11, 12, 13 }, new char[] { 'S', 'S', 'S', 'S', 'S' }));

        }

        [TestMethod()]
        public void IsRoyalFlushFalseTest()
        {
            Assert.IsFalse(CheckHand.IsRoyalFlush(new int[] { 4, 8, 9, 11, 12 }, new char[] { 'S', 'S', 'S', 'S', 'S' }));
            Assert.IsFalse(CheckHand.IsRoyalFlush(new int[] { 9, 10, 11, 12, 13 }, new char[] { 'S', 'S', 'C', 'S', 'S' }));
        }

        [TestMethod()]
        public void IsStraightFlushTrueTest()
        {
            Assert.IsTrue(CheckHand.IsStraightFlush(new int[] { 2, 3, 4, 5, 6 }, new char[] { 'C', 'C', 'C', 'C', 'C' }));
            Assert.IsTrue(CheckHand.IsStraightFlush(new int[] { 7, 8, 9, 10, 11 }, new char[] { 'S', 'S', 'S', 'S', 'S' }));
        }

        [TestMethod()]
        public void IsStraightFlushFalseTest()
        {
            Assert.IsFalse(CheckHand.IsStraightFlush(new int[] { 2, 4, 5, 6, 7 }, new char[] { 'S', 'S', 'S', 'S', 'S' }));
            Assert.IsFalse(CheckHand.IsStraightFlush(new int[] { 6, 7, 8, 9, 10 }, new char[] { 'S', 'S', 'C', 'S', 'S' }));
        }

        [TestMethod()]
        public void IsFourKindTrueTest()
        {
            Assert.IsTrue(CheckHand.IsFourKind(new int[] { 4, 5, 4, 4, 4 }));
            Assert.IsTrue(CheckHand.IsFourKind(new int[] { 8, 8, 8, 8, 4 }));
        }

        [TestMethod()]
        public void IsFourKindFalseTest()
        {
            Assert.IsFalse(CheckHand.IsFourKind(new int[] { 4, 5, 4, 4, 3 }));
            Assert.IsFalse(CheckHand.IsFourKind(new int[] { 2, 8, 4, 8, 8 }));
        }

        [TestMethod()]
        public void IsFullHouseTrueTest()
        {
            Assert.IsTrue(CheckHand.IsFullHouse(new int[] { 4, 4, 4, 6, 6 }));
            Assert.IsTrue(CheckHand.IsFullHouse(new int[] { 10, 11, 10, 10, 11 }));
        }

        [TestMethod()]
        public void IsFullHouseFalseTest()
        {
            Assert.IsFalse(CheckHand.IsFullHouse(new int[] { 3, 4, 4, 6, 6 }));
            Assert.IsFalse(CheckHand.IsFullHouse(new int[] { 4, 4, 5, 6, 6 })); 
        }
    }
}
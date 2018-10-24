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

        [TestMethod()]
        public void IsFlushTrueTest()
        {
            Assert.IsTrue(CheckHand.IsFlush(new char[] { 'S', 'S', 'S', 'S', 'S' }));
            Assert.IsTrue(CheckHand.IsFlush(new char[] { 'C', 'C', 'C', 'C', 'C' }));
        }

        [TestMethod()]
        public void IsFlushFalseTest()
        {
            Assert.IsFalse(CheckHand.IsFlush(new char[] { 'C', 'H', 'C', 'C', 'C' }));
            Assert.IsFalse(CheckHand.IsFlush(new char[] { 'H', 'D', 'C', 'S', 'C' }));
        }

        [TestMethod()]
        public void IsStraightTrueTest()
        {
            Assert.IsTrue(CheckHand.IsStraight(new int[] { 3, 4, 5, 6, 7 }));
            Assert.IsTrue(CheckHand.IsStraight(new int[] { 9, 10, 11, 12, 13 }));
        }

        [TestMethod()]
        public void IsStraightFalseTest()
        {
            Assert.IsFalse(CheckHand.IsStraight(new int[] { 3, 9, 4, 5, 6 }));
            Assert.IsFalse(CheckHand.IsStraight(new int[] { 10, 2, 4, 7, 8 }));
        }

        [TestMethod()]
        public void IsThreeKindTrueTest()
        {
            Assert.IsTrue(CheckHand.IsThreeKind(new int[] { 3, 4, 5, 3, 3 }));
            Assert.IsTrue(CheckHand.IsThreeKind(new int[] { 9, 10, 6, 6, 6 }));
        }

        [TestMethod()]
        public void IsThreeKindFalseTest()
        {
            Assert.IsFalse(CheckHand.IsThreeKind(new int[] { 3, 3, 4, 5, 6 }));
            Assert.IsFalse(CheckHand.IsThreeKind(new int[] { 9, 2, 9, 7, 8 }));
        }

        [TestMethod()]
        public void IsTwoPairTrueTest()
        {
            Assert.IsTrue(CheckHand.IsTwoPair(new int[] { 3, 3, 5, 6, 6 }));
            Assert.IsTrue(CheckHand.IsTwoPair(new int[] { 4, 4, 5, 5, 6 }));
        }

        [TestMethod()]
        public void IsTwoPairFalseTest()
        {
            Assert.IsFalse(CheckHand.IsTwoPair(new int[] { 3, 3, 4, 5, 6 }));
            Assert.IsFalse(CheckHand.IsTwoPair(new int[] { 9, 2, 9, 7, 8 }));
        }

        [TestMethod()]
        public void IsPairTrueTest()
        {
            Assert.IsTrue(CheckHand.IsPair(new int[] { 3, 3, 5, 11, 10 }));
            Assert.IsTrue(CheckHand.IsPair(new int[] { 4, 10, 5, 4, 6 }));
        }

        [TestMethod()]
        public void IsPairFalseTest()
        {
            Assert.IsFalse(CheckHand.IsPair(new int[] { 2, 3, 5, 6, 11 }));
            Assert.IsFalse(CheckHand.IsPair(new int[] { 5, 4, 13, 2, 6 }));
        }

        [TestMethod()]
        public void HighCardTest()
        {
            Assert.AreEqual(12, CheckHand.HighCard(new int[] { 5, 4, 12, 2, 6 }));
            Assert.AreEqual(7, CheckHand.HighCard(new int[] { 5, 7, 3, 2, 6 }));
            Assert.AreEqual(13, CheckHand.HighCard(new int[] { 1, 2, 13, 8, 11 }));
            Assert.AreEqual(6, CheckHand.HighCard(new int[] { 1, 2, 3, 4, 6 }));
        }
    }
}
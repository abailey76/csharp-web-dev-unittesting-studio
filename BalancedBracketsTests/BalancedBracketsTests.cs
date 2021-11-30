using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue() 
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void OnlyRightBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]
        public void OnlyLeftBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void NoBracketReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(" "));
        }

        [TestMethod]
        public void TextLeftTextRight()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Java[Script]"));
        }

        [TestMethod]
        public void MismatchedBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void DoubleRightBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]"));
        }

        [TestMethod]
        public void DoubleLeftBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"));
        }

        [TestMethod]
        public void DoubleLeftBracketsWithText()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[unbroken]"));
        }

        [TestMethod]
        public void DoubleRightBracketsWithText()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("unbroken]]"));
        }

        [TestMethod]
        public void SomeKindOfTextWithSomeBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("unit]testing[sucks"));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp71Demo.Tests
{
    [TestClass]
    public class ParsingTests
    {
        [TestMethod]
        public void YuckTest()
        {
            var res = "1".TryParse<int>();
            Assert.IsTrue(res.IsSuccess);
            Assert.AreEqual(1, res.Value);

            res = "".TryParse<int>();
            Assert.IsFalse(res.IsSuccess);
            Assert.AreEqual(default, res.Value);

            var resB = "true".TryParse<bool>();
            Assert.IsTrue(resB.IsSuccess);
            Assert.IsTrue(resB.Value);

            resB = "false".TryParse<bool>();
            Assert.IsTrue(resB.IsSuccess);
            Assert.IsFalse(resB.Value);

            var resC = "7.1".TryParse<double>();
            Assert.IsTrue(resC.IsSuccess);
            Assert.AreEqual(7.1d, resC.Value);
        }
    }
}

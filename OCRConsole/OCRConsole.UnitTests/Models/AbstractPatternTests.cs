using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCRConsole.Models;

namespace OCRConsole.UnitTests
{
    [TestClass]
    public class AbstractPatternTests
    {
        private IAbstractPattern abstractPattern;

        [TestInitialize]
        public void RunBeforeEachTest()
        {
            int[] pattern = new int[]
            {
                0, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                1, 1, 1, 1, 1,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
            };

            this.abstractPattern = new AbstractPattern(pattern);
        }

        [TestMethod]
        public void AbstractPattern_ShouldGetCorrectLayerWeights()
        {
            this.abstractPattern.GetLayerWeight(0).Should().Be(0);
            this.abstractPattern.GetLayerWeight(1).Should().Be(1);
        }
    }
}

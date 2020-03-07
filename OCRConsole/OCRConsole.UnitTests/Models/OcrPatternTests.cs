using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OCRConsole.Models;

namespace OCRConsole.UnitTests
{
    [TestClass]
    public class OcrPatternTests
    {
        private IOcrPattern ocrPattern;

        [TestInitialize]
        public void RunBeforeEachTest()
        {
            int[] sequence = new int[]
            {
                0, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                1, 1, 1, 1, 1,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
            };

            this.ocrPattern = new OcrPattern(sequence);
        }

        [TestMethod]
        public void OcrPattern_ShouldGetCorrectLayerWeights()
        {
            this.ocrPattern.GetLayerWeight(0).Should().Be(0);
            this.ocrPattern.GetLayerWeight(1).Should().Be(1);
        }
    }
}

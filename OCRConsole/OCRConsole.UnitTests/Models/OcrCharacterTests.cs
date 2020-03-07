using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using OCRConsole.Models;

namespace OCRConsole.UnitTests.Models
{
    [TestClass]
    public class OcrCharacterTests
    {
        [TestMethod]
        public void OcrCharacter_CanBeConstructed()
        {
            // arrange
            var ocrPattern = Substitute.For<IOcrPattern>();

            // act
            var ocrCharacter = new OcrCharacter('A', ocrPattern);

            // assert
            ocrCharacter.Should().NotBeNull();
        }
    }
}

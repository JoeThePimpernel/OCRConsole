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
            var abstractRepresentation = Substitute.For<IAbstractPattern>();

            // act
            var ocrCharacter = new OcrCharacter('A', abstractRepresentation);

            // assert
            ocrCharacter.Should().NotBeNull();
        }
    }
}

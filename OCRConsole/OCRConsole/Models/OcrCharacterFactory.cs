using System;
using System.Collections.Generic;
using System.Text;

namespace OCRConsole.Models
{
    public class OcrCharacterFactory
    {
        private readonly ICanvasFactory canvasFactory;

        public OcrCharacterFactory(ICanvasFactory canvasFactory)
        {
            this.canvasFactory = canvasFactory;
        }

        public OcrCharacter Create(char characterValue, int[][] characterMatrix)
        {
            return new OcrCharacter(this.canvasFactory, characterValue, characterMatrix);
        }
    }
}

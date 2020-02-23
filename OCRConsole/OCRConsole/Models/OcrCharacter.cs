using System;
using System.Collections.Generic;
using System.Text;

namespace OCRConsole.Models
{
    public class OcrCharacter
    {
        private readonly char ocrCharacter;
        private readonly Canvas canvas;

        public OcrCharacter(ICanvasFactory canvasFactory, char characterValue, int[][] characterMatrix)
        {
            this.ocrCharacter = characterValue;
            this.canvas = canvasFactory.Create(characterMatrix);
        }
    }
}

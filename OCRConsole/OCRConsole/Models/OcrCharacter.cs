// Copyright (c) JoeThePimpernel. All Rights Reserved.

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

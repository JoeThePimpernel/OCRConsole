// Copyright (c) JoeThePimpernel. All Rights Reserved.

namespace OCRConsole.Models
{
    using System;

    public class OcrCharacterFactory
    {
        private readonly ICanvasFactory canvasFactory;

        public OcrCharacterFactory(ICanvasFactory canvasFactory)
        {
            this.canvasFactory = canvasFactory;
        }

        public OcrCharacter Create(char characterValue, int[][] characterMatrix)
        {
            throw new NotImplementedException();
            ////return new OcrCharacter(this.canvasFactory, characterValue, characterMatrix);
        }
    }
}

// Copyright (c) JoeThePimpernel. All Rights Reserved.

namespace OCRConsole.Models
{
    using System;
    using OCRConsole.Renderers;

    public class Canvas
    {
        private readonly IOcrRenderer ocrRenderer;

        public Canvas(IOcrRenderer ocrRenderer)
        {
            this.ocrRenderer = ocrRenderer;
        }

        public void Render(OcrCharacter ocrCharacter)
        {
            throw new NotImplementedException();
            ////this.ocrRenderer.Render(ocrCharacter);
        }
    }
}

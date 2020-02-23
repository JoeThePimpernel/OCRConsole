// Copyright (c) JoeThePimpernel. All Rights Reserved.

namespace OCRConsole.Models
{
    using System;
    using OCRConsole.Renderers;

    public class CanvasFactory
    {
        private readonly IOcrRenderer ocrRenderer;

        public CanvasFactory(IOcrRenderer ocrRenderer)
        {
            this.ocrRenderer = ocrRenderer;
        }

        public Canvas Create(int[] characterMatrix)
        {
            throw new NotImplementedException();
            ////return new Canvas(this.ocrRenderer, characterMatrix);
        }
    }
}

// Copyright (c) JoeThePimpernel. All Rights Reserved.

namespace OCRConsole.Models
{
    using System;
    using OCRConsole.Renderers;

    public class Canvas
    {
        private readonly int[][] canvas;

        public Canvas(IOcrRenderer ocrRenderer, int[][] characterMatrix)
        {
            this.canvas = characterMatrix;
        }

        public void Render()
        {
            throw new NotImplementedException();
        }
    }
}

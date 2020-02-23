using System;
using System.Collections.Generic;
using System.Text;
using OCRConsole.Renderers;

namespace OCRConsole.Models
{
    public class CanvasFactory
    {
        private readonly IOcrRenderer ocrRenderer;

        public CanvasFactory(IOcrRenderer ocrRenderer)
        {
            this.ocrRenderer = ocrRenderer;
        }

        public Canvas Create(int[][] characterMatrix)
        {
            return new Canvas(this.ocrRenderer, characterMatrix);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;
using OCRConsole.Renderers;

namespace OCRConsole.Models
{
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

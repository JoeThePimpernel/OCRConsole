using System;
using System.Collections.Generic;
using System.Text;

namespace OCRConsole.Models
{
    public interface ICanvasFactory
    {
        Canvas Create(int[][] characterMatrix);
    }
}

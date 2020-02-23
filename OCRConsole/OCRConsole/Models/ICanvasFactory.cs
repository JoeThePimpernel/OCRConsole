// Copyright (c) JoeThePimpernel. All Rights Reserved.

namespace OCRConsole.Models
{
    public interface ICanvasFactory
    {
        Canvas Create(int[][] characterMatrix);
    }
}

// Copyright (c) JoeThePimpernel. All Rights Reserved.

namespace OCRConsole.Models
{
    public class OcrCharacter
    {
        public OcrCharacter(char characterValue, IOcrPattern ocrPattern)
        {
            this.Character = characterValue;
            this.OcrPattern = ocrPattern;
        }

        public char Character { get; }

        public IOcrPattern OcrPattern { get; }
    }
}

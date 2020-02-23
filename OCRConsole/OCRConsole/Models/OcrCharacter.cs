// Copyright (c) JoeThePimpernel. All Rights Reserved.

namespace OCRConsole.Models
{
    public class OcrCharacter
    {
        private readonly IAbstractPattern abstractRepresentation;

        public OcrCharacter(char characterValue, IAbstractPattern abstractRepresentation)
        {
            this.Character = characterValue;
            this.abstractRepresentation = abstractRepresentation;
        }

        public char Character { get; }

        public IAbstractPattern GetAbstractRepresentation()
        {
            return this.abstractRepresentation;
        }
    }
}

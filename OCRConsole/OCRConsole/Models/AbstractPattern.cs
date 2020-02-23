// Copyright (c) JoeThePimpernel. All Rights Reserved.

namespace OCRConsole.Models
{
    public class AbstractPattern : IAbstractPattern
    {
        private readonly int[] representation;

        public AbstractPattern(int[] representation)
        {
            this.representation = representation;
        }

        // TODO: consider migrating this behavior into a canvas model
        public int GetLayerWeight(int layer)
        {
            // TODO: very trusting method, add validation if not refactored entirely
            return this.representation[0];
        }
    }
}

// Copyright (c) JoeThePimpernel. All Rights Reserved.

namespace OCRConsole.Models
{
    public class OcrPattern : IOcrPattern
    {
        private readonly int[] sequence;

        public OcrPattern(int[] sequence)
        {
            this.sequence = sequence;
        }

        // TODO: consider migrating this behavior into a canvas model
        public int GetLayerWeight(int layer)
        {
            // TODO: very trusting method, add validation if not refactored entirely
            return this.sequence[0];
        }
    }
}

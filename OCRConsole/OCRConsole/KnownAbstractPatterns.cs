// Copyright (c) JoeThePimpernel. All Rights Reserved.

namespace OCRConsole
{
    using OCRConsole.Models;

    public static class KnownAbstractPatterns
    {
        public static AbstractPattern UpperAlphaA => new AbstractPattern(new int[]
            {
                0, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                1, 1, 1, 1, 1,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
            });

        public static AbstractPattern UpperAlphaB => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                1, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                1, 1, 1, 1, 0,
            });

        public static AbstractPattern UpperAlphaC => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 1,
                1, 0, 0, 0, 0,
                1, 0, 0, 0, 0,
                1, 0, 0, 0, 0,
                1, 1, 1, 1, 1,
            });

        public static AbstractPattern UpperAlphaD => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                1, 1, 1, 1, 0,
            });

        public static AbstractPattern UpperAlphaE => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 1,
                1, 0, 0, 0, 0,
                1, 1, 1, 0, 0,
                1, 0, 0, 0, 0,
                1, 1, 1, 1, 1,
            });

        public static AbstractPattern UpperAlphaF => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 1,
                1, 0, 0, 0, 0,
                1, 1, 1, 0, 0,
                1, 0, 0, 0, 0,
                1, 0, 0, 0, 0,
            });

        public static AbstractPattern UpperAlphaG => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 1,
                1, 0, 0, 0, 0,
                1, 0, 1, 1, 1,
                1, 0, 0, 0, 1,
                1, 1, 1, 1, 1,
            });

        public static AbstractPattern UpperAlphaH => new AbstractPattern(new int[]
            {
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                1, 1, 1, 1, 1,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
            });

        public static AbstractPattern UpperAlphaI => new AbstractPattern(new int[]
            {
                0, 1, 1, 1, 0,
                0, 0, 1, 0, 0,
                0, 0, 1, 0, 0,
                0, 0, 1, 0, 0,
                0, 1, 1, 1, 0,
            });

        public static AbstractPattern UpperAlphaJ => new AbstractPattern(new int[]
            {
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 0, 0, 1, 0,
                0, 1, 0, 1, 0,
                0, 1, 1, 1, 0,
            });

        public static AbstractPattern UpperAlphaK => new AbstractPattern(new int[]
            {
                1, 0, 0, 0, 1,
                1, 0, 0, 1, 0,
                1, 1, 1, 0, 0,
                1, 0, 0, 1, 0,
                1, 0, 0, 0, 1,
            });

        public static AbstractPattern UpperAlphaL => new AbstractPattern(new int[]
            {
                1, 0, 0, 0, 0,
                1, 0, 0, 0, 0,
                1, 0, 0, 0, 0,
                1, 0, 0, 0, 0,
                1, 1, 1, 1, 1,
            });

        public static AbstractPattern UpperAlphaM => new AbstractPattern(new int[]
            {
                1, 0, 0, 0, 1,
                1, 1, 0, 1, 1,
                1, 0, 1, 0, 1,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
            });

        public static AbstractPattern UpperAlphaN => new AbstractPattern(new int[]
            {
                1, 0, 0, 0, 1,
                1, 1, 0, 0, 1,
                1, 0, 1, 0, 1,
                1, 0, 0, 1, 1,
                1, 0, 0, 0, 1,
            });

        public static AbstractPattern UpperAlphaO => new AbstractPattern(new int[]
            {
                0, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                0, 1, 1, 1, 0,
            });

        public static AbstractPattern UpperAlphaP => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                1, 1, 1, 1, 0,
                1, 0, 0, 0, 0,
                1, 0, 0, 0, 0,
            });

        public static AbstractPattern UpperAlphaQ => new AbstractPattern(new int[]
            {
                0, 1, 1, 0, 0,
                1, 0, 0, 1, 0,
                1, 0, 0, 1, 0,
                1, 0, 0, 1, 0,
                0, 1, 1, 0, 1,
            });

        public static AbstractPattern UpperAlphaR => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                1, 1, 1, 1, 0,
                1, 0, 0, 1, 0,
                1, 0, 0, 0, 1,
            });

        public static AbstractPattern UpperAlphaS => new AbstractPattern(new int[]
            {
                0, 1, 1, 1, 1,
                1, 0, 0, 0, 0,
                0, 1, 1, 1, 0,
                0, 0, 0, 0, 1,
                1, 1, 1, 1, 0,
            });

        public static AbstractPattern UpperAlphaT => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 1,
                0, 0, 1, 0, 0,
                0, 0, 1, 0, 0,
                0, 0, 1, 0, 0,
                0, 0, 1, 0, 0,
            });

        public static AbstractPattern UpperAlphaU => new AbstractPattern(new int[]
            {
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                0, 1, 1, 1, 0,
            });

        public static AbstractPattern UpperAlphaV => new AbstractPattern(new int[]
            {
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                0, 1, 0, 1, 0,
                0, 0, 1, 0, 0,
            });

        public static AbstractPattern UpperAlphaW => new AbstractPattern(new int[]
            {
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                1, 0, 1, 0, 1,
                1, 1, 0, 1, 1,
                1, 0, 0, 0, 1,
            });

        public static AbstractPattern UpperAlphaX => new AbstractPattern(new int[]
            {
                1, 0, 0, 0, 1,
                0, 1, 0, 1, 0,
                0, 0, 1, 0, 0,
                0, 1, 0, 1, 0,
                1, 0, 0, 0, 1,
            });

        public static AbstractPattern UpperAlphaY => new AbstractPattern(new int[]
            {
                1, 0, 0, 0, 1,
                0, 1, 0, 1, 0,
                0, 0, 1, 0, 0,
                0, 0, 1, 0, 0,
                0, 0, 1, 0, 0,
            });

        public static AbstractPattern UpperAlphaZ => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 1,
                0, 0, 0, 1, 0,
                0, 0, 1, 0, 0,
                0, 1, 0, 0, 0,
                1, 1, 1, 1, 1,
            });

        public static AbstractPattern Numeric0 => new AbstractPattern(new int[]
            {
                0, 1, 1, 1, 0,
                1, 0, 0, 1, 1,
                1, 0, 1, 0, 1,
                1, 1, 0, 0, 1,
                0, 1, 1, 1, 0,
            });

        public static AbstractPattern Numeric1 => new AbstractPattern(new int[]
            {
                0, 1, 1, 0, 0,
                0, 0, 1, 0, 0,
                0, 0, 1, 0, 0,
                0, 0, 1, 0, 0,
                0, 0, 1, 0, 0,
            });

        public static AbstractPattern Numeric2 => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 0,
                0, 0, 0, 0, 1,
                0, 1, 1, 1, 0,
                1, 0, 0, 0, 0,
                1, 1, 1, 1, 1,
            });

        public static AbstractPattern Numeric3 => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 0,
                0, 0, 0, 0, 1,
                0, 1, 1, 1, 0,
                0, 0, 0, 0, 1,
                1, 1, 1, 1, 0,
            });

        public static AbstractPattern Numeric4 => new AbstractPattern(new int[]
            {
                1, 0, 0, 0, 1,
                1, 0, 0, 0, 1,
                1, 1, 1, 1, 1,
                0, 0, 0, 0, 1,
                0, 0, 0, 0, 1,
            });

        public static AbstractPattern Numeric5 => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 1,
                1, 0, 0, 0, 0,
                1, 1, 1, 1, 0,
                0, 0, 0, 0, 1,
                1, 1, 1, 1, 0,
            });

        public static AbstractPattern Numeric6 => new AbstractPattern(new int[]
            {
                1, 0, 0, 0, 0,
                1, 0, 0, 0, 0,
                1, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                0, 1, 1, 1, 0,
            });

        public static AbstractPattern Numeric7 => new AbstractPattern(new int[]
            {
                1, 1, 1, 1, 1,
                0, 0, 0, 0, 1,
                0, 0, 0, 1, 0,
                0, 0, 1, 0, 0,
                0, 0, 1, 0, 0,
            });

        public static AbstractPattern Numeric8 => new AbstractPattern(new int[]
            {
                0, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                0, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                0, 1, 1, 1, 0,
            });

        public static AbstractPattern Numeric9 => new AbstractPattern(new int[]
            {
                0, 1, 1, 1, 0,
                1, 0, 0, 0, 1,
                0, 1, 1, 1, 1,
                0, 0, 0, 0, 1,
                0, 0, 0, 0, 1,
            });
    }
}

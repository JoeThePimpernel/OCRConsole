// Copyright (c) JoeThePimpernel. All Rights Reserved.

namespace OCRConsole
{
    using System;
    using System.Collections.Generic;
    using OCRConsole.Models;

    public class Program
    {
        public static void Main(string[] args)
        {
            //// int patterns = 36;
            //// int input_values = 25;
            //// int output_target_values = 36;

            var characters = new List<OcrCharacter>
            {
                new OcrCharacter('A', OcrPatternObjectMother.UpperAlphaA),
                new OcrCharacter('B', OcrPatternObjectMother.UpperAlphaB),
                new OcrCharacter('C', OcrPatternObjectMother.UpperAlphaC),
                new OcrCharacter('D', OcrPatternObjectMother.UpperAlphaD),
                new OcrCharacter('E', OcrPatternObjectMother.UpperAlphaE),
                new OcrCharacter('F', OcrPatternObjectMother.UpperAlphaF),
                new OcrCharacter('G', OcrPatternObjectMother.UpperAlphaG),
                new OcrCharacter('H', OcrPatternObjectMother.UpperAlphaH),
                new OcrCharacter('I', OcrPatternObjectMother.UpperAlphaI),
                new OcrCharacter('J', OcrPatternObjectMother.UpperAlphaJ),
                new OcrCharacter('K', OcrPatternObjectMother.UpperAlphaK),
                new OcrCharacter('L', OcrPatternObjectMother.UpperAlphaL),
                new OcrCharacter('M', OcrPatternObjectMother.UpperAlphaM),
                new OcrCharacter('N', OcrPatternObjectMother.UpperAlphaN),
                new OcrCharacter('O', OcrPatternObjectMother.UpperAlphaO),
                new OcrCharacter('P', OcrPatternObjectMother.UpperAlphaP),
                new OcrCharacter('Q', OcrPatternObjectMother.UpperAlphaQ),
                new OcrCharacter('R', OcrPatternObjectMother.UpperAlphaR),
                new OcrCharacter('S', OcrPatternObjectMother.UpperAlphaS),
                new OcrCharacter('T', OcrPatternObjectMother.UpperAlphaT),
                new OcrCharacter('U', OcrPatternObjectMother.UpperAlphaU),
                new OcrCharacter('V', OcrPatternObjectMother.UpperAlphaV),
                new OcrCharacter('W', OcrPatternObjectMother.UpperAlphaW),
                new OcrCharacter('X', OcrPatternObjectMother.UpperAlphaX),
                new OcrCharacter('Y', OcrPatternObjectMother.UpperAlphaY),
                new OcrCharacter('Z', OcrPatternObjectMother.UpperAlphaZ),
                new OcrCharacter('0', OcrPatternObjectMother.Numeric0),
                new OcrCharacter('1', OcrPatternObjectMother.Numeric1),
                new OcrCharacter('2', OcrPatternObjectMother.Numeric2),
                new OcrCharacter('3', OcrPatternObjectMother.Numeric3),
                new OcrCharacter('4', OcrPatternObjectMother.Numeric4),
                new OcrCharacter('5', OcrPatternObjectMother.Numeric5),
                new OcrCharacter('6', OcrPatternObjectMother.Numeric6),
                new OcrCharacter('7', OcrPatternObjectMother.Numeric7),
                new OcrCharacter('8', OcrPatternObjectMother.Numeric8),
                new OcrCharacter('9', OcrPatternObjectMother.Numeric9),
            };

            var trainingPatterns = new List<OcrPattern>
            {
                OcrPatternObjectMother.UpperAlphaA,
                OcrPatternObjectMother.UpperAlphaB,
                OcrPatternObjectMother.UpperAlphaC,
                OcrPatternObjectMother.UpperAlphaD,
                OcrPatternObjectMother.UpperAlphaE,
                OcrPatternObjectMother.UpperAlphaF,
                OcrPatternObjectMother.UpperAlphaG,
                OcrPatternObjectMother.UpperAlphaH,
                OcrPatternObjectMother.UpperAlphaI,
                OcrPatternObjectMother.UpperAlphaJ,
                OcrPatternObjectMother.UpperAlphaK,
                OcrPatternObjectMother.UpperAlphaL,
                OcrPatternObjectMother.UpperAlphaM,
                OcrPatternObjectMother.UpperAlphaN,
                OcrPatternObjectMother.UpperAlphaO,
                OcrPatternObjectMother.UpperAlphaP,
                OcrPatternObjectMother.UpperAlphaQ,
                OcrPatternObjectMother.UpperAlphaR,
                OcrPatternObjectMother.UpperAlphaS,
                OcrPatternObjectMother.UpperAlphaT,
                OcrPatternObjectMother.UpperAlphaU,
                OcrPatternObjectMother.UpperAlphaV,
                OcrPatternObjectMother.UpperAlphaW,
                OcrPatternObjectMother.UpperAlphaX,
                OcrPatternObjectMother.UpperAlphaY,
                OcrPatternObjectMother.UpperAlphaZ,
                OcrPatternObjectMother.Numeric0,
                OcrPatternObjectMother.Numeric1,
                OcrPatternObjectMother.Numeric2,
                OcrPatternObjectMother.Numeric3,
                OcrPatternObjectMother.Numeric4,
                OcrPatternObjectMother.Numeric5,
                OcrPatternObjectMother.Numeric6,
                OcrPatternObjectMother.Numeric7,
                OcrPatternObjectMother.Numeric8,
                OcrPatternObjectMother.Numeric9,
            };

            int[,] output_target_value = new int[,]
            {
             //// A  B  C  D  E  F  G  H  I  J  K  L  M  N  O  P  Q  R  S  T  U  V  W  X  Y  Z  0  1  2  3  4  5  6  7  8  9
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            };

            // CREATE VARIABLES
            int patterns = characters.Count;
            int input_values = trainingPatterns.Count / patterns;
            int output_target_values = output_target_value.Length / patterns;

            int input_neuron_count = input_values + 1;
            int output_neuron_count = output_target_values;
            int middle_neuron_count = ((input_values + output_target_values) / 2) + 1;

            decimal[] middle_neuron_sum = new decimal[middle_neuron_count];
            decimal[] output_neuron_sum = new decimal[output_neuron_count];

            decimal[] input_neuron_value = new decimal[input_neuron_count];
            decimal[] middle_neuron_value = new decimal[middle_neuron_count];
            decimal[] output_neuron_value = new decimal[output_neuron_count];

            decimal[] output_neuron_error = new decimal[output_neuron_count];

            decimal[,] inwt = new decimal[input_neuron_count, middle_neuron_count];
            decimal[,] outwt = new decimal[middle_neuron_count, output_neuron_count];

            // CREATE RANDOM NUMBER GENERATOR
            Random randomNumbers = new Random(); // random number generator

            // SET CONNECTION WEIGHTS RANDOMLY BETWEEN -1 and +1 FOR INPUT LAYER CONNECTION WEIGHTS
            for (int i = 0; i < input_neuron_count; i++)
            {
                for (int j = 0; j < middle_neuron_count; j++)
                {
                    inwt[i, j] = Convert.ToDecimal(randomNumbers.Next(0, 20000000) - 10000000) / 10000000;
                }
            }

            // SET CONNECTION WEIGHTS RANDOMLY BETWEEN -1 and +1 FOR OUTPUT LAYER CONNECTION WEIGHTS
            for (int i = 0; i < middle_neuron_count; i++)
            {
                for (int j = 0; j < output_neuron_count; j++)
                {
                    outwt[i, j] = Convert.ToDecimal(randomNumbers.Next(0, 20000000) - 10000000) / 10000000;
                }
            }

            // SET BIAS NEURON VALUES TO 1
            input_neuron_value[input_neuron_count - 1] = 1;
            middle_neuron_value[middle_neuron_count - 1] = 1;

            // CREATE CYCLE STATISTIC VARIABLES
            DateTime date1 = DateTime.Now;

            var limit = 0.1M;
            var max_cycle_error = 1.00000000000M;
            var max_last_cycle_error = 1.00000000000M;
            int h = -1;

            var outputWeightCount = 0;
            decimal absouluteValueOutputWeightSum = 0;
            decimal averageAbsoluteValueOutputWeight;
            decimal maxAbsoluteValueOutputWeight = 0;

            // LOOP THROUGH TRAINING PATTERNS

            // STOP TRAINING WHEN CYCLE ERROR <= LIMIT
            while (Math.Abs(max_cycle_error) > limit)
            {
                h += 1; // CYCLE INDEX

                // PATTERN INDEX
                for (int i = 0; i < patterns; i++)
                {
                    //// BEGIN FEED-FORWARD

                    // RESET CYCLE ERROR ACCUMULATORS TO ZERO
                    if (i == 0)
                    {
                        max_last_cycle_error = max_cycle_error;
                        max_cycle_error = 0;
                    }

                    // RESET MIDDLE NEURON SUMS TO ZERO
                    for (int k = 0; k < middle_neuron_count - 1; k++)
                    {
                        middle_neuron_sum[k] = 0;
                    }

                    // ACCUMULATE SUM OF INPUT NEURON ACTIVATION VALUE x INPUT LAYER WEIGHT FOR EACH MIDDLE NEURON
                    for (int j = 0; j < input_neuron_count - 1; j++)
                    {
                        for (int k = 0; k < middle_neuron_count - 1; k++)
                        {
                            middle_neuron_sum[k] += trainingPatterns[i].GetLayerWeight(j) * inwt[j, k];
                            //// (TODO: remove before PR) middle_neuron_sum[k] += input_value[i, j] * inwt[j, k];
                        }
                    }

                    // CALCULATE MIDDLE NEURON ACTIVATION VALUES
                    for (int j = 0; j < middle_neuron_count - 1; j++)
                    {
                        double sum = Convert.ToDouble(middle_neuron_sum[j]);
                        middle_neuron_value[j] = Convert.ToDecimal(1 / (1 + Math.Exp(-sum)));
                    }

                    // RESET OUTPUT NEURON SUMS TO ZERO
                    for (int k = 0; k < output_neuron_count; k++)
                    {
                        output_neuron_sum[k] = 0;
                    }

                    // ACCUMULATE SUM OF MIDDLE NEURON ACTIVATION VALUE x OUTPUT LAYER WEIGHT FOR EACH OUTPUT NEURON
                    for (int j = 0; j < middle_neuron_count - 1; j++)
                    {
                        for (int k = 0; k < output_neuron_count; k++)
                        {
                            output_neuron_sum[k] += middle_neuron_value[j] * outwt[j, k];
                        }
                    }

                    // CALCULATE OUTPUT NEURON ACTIVATION VALUES
                    for (int j = 0; j < output_neuron_count; j++)
                    {
                        double sum = Convert.ToDouble(output_neuron_sum[j]);
                        output_neuron_value[j] = Convert.ToDecimal(1 / (1 + Math.Exp(-sum)));
                    }

                    //// END FEED-FORWARD

                    // BACK-PROPAGATE ERROR CORRECTION
                    for (int j = 0; j < middle_neuron_count - 1; j++)
                    {
                        for (int k = 0; k < output_neuron_count; k++)
                        {
                            outwt[j, k] += 4 * middle_neuron_value[j] * output_neuron_value[k] * (1 - output_neuron_value[k]) * (output_target_value[i, k] - output_neuron_value[k]);
                        }
                    }

                    // CALCULATE ABSOLUTE VALUE OUTPUT WEIGHT AVERAGE AND MAXIMUM FOR PATTERN
                    outputWeightCount = 0;
                    absouluteValueOutputWeightSum = 0;
                    maxAbsoluteValueOutputWeight = 0;

                    for (int x = 0; x < middle_neuron_count; x++)
                    {
                        for (int y = 0; y < output_neuron_count; y++)
                        {
                            // outwt[i, j] = Convert.ToDecimal((randomNumbers.Next(0, 20000000) - 10000000)) / 10000000;
                            outputWeightCount += 1;
                            absouluteValueOutputWeightSum += Math.Abs(outwt[x, y]);

                            if (outwt[x, y] > maxAbsoluteValueOutputWeight)
                            {
                                maxAbsoluteValueOutputWeight = Math.Abs(outwt[x, y]);
                            }
                        }
                    }

                    averageAbsoluteValueOutputWeight = absouluteValueOutputWeightSum / outputWeightCount;

                    // PRINT CYCLE DATA TO CONSOLE
                    Console.WriteLine("        Pat-   Output  Mapped                                                    Max Abs Error   Target Max Abs   Avg Output Wt   Max Output Wt  Output Wt[0,0]");
                    Console.WriteLine("Cycle   tern   Neuron Character  Target Value    Output Value        Error       Previous Cycle   Cycle Error     This Pattern    This Pattern     This Cyle");
                    Console.WriteLine();

                    for (int l = 0; l < output_neuron_count; l++)
                    {
                        output_neuron_error[l] = output_target_value[i, l] - output_neuron_value[l];
                        if (Math.Abs(max_cycle_error) < Math.Abs(output_neuron_error[l]))
                        {
                            max_cycle_error = output_neuron_error[l];
                        }

                        Console.WriteLine("[" + h.ToString("00") + "]\t[" + i.ToString("00") + "]\t[" + l.ToString("00") + "]\t[" + characters[l].Character + "]\t[" + output_target_value[i, l].ToString("0.0000000000") + "]  [" + (output_neuron_value[l] + 0).ToString("0.0000000000") + "]  [" + (output_neuron_error[l] + 0).ToString("0.0000000000").PadLeft(13, ' ') + "]  [" + max_last_cycle_error.ToString("0.0000000000") + "]  [" + limit.ToString("0.0000000000") + "]  [" + averageAbsoluteValueOutputWeight.ToString("0.0000000000") + "]  [" + maxAbsoluteValueOutputWeight.ToString("0.0000000000") + "]  [" + outwt[0, 0].ToString("0.0000000000") + "]");
                    }

                    Console.WriteLine();
                }

                // PRINT CYCLE STATISTICS TO CONSOLE
                Console.WriteLine("[max_abs_cycle_error] [" + max_cycle_error.ToString("0.0000000000") + "]");
                Console.WriteLine();
                Console.WriteLine("[target_max_abs_cycle_error] [" + limit.ToString("0.0000000000") + "]");
                Console.WriteLine();
            }

            // PRINT EXECUTION DURATION TO CONSOLE
            DateTime date2 = DateTime.Now;
            TimeSpan interval = date2 - date1;
            Console.WriteLine("{0} - {1} = {2}", date2, date1, $"{interval:hh\\:mm\\:ss}");
            Console.ReadLine();
        }
    }
}

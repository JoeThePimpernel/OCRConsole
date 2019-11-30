using System;

namespace OCRConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //int patterns = 36;
            //int input_values = 25;
            //int output_target_values = 36;

            char[] character = new char[]
            {
                'A',
                'B',
                'C',
                'D',
                'E',
                'F',
                'G',
                'H',
                'I',
                'J',
                'K',
                'L',
                'M',
                'N',
                'O',
                'P',
                'Q',
                'R',
                'S',
                'T',
                'U',
                'V',
                'W',
                'X',
                'Y',
                'Z',
                '0',
                '1',
                '2',
                '3',
                '4',
                '5',
                '6',
                '7',
                '8',
                '9',
            };

            int[,] input_value = new int[,]
            {
                {0,1,1,1,0,
                 1,0,0,0,1,
                 1,1,1,1,1,
                 1,0,0,0,1,
                 1,0,0,0,1},
                {1,1,1,1,0,
                 1,0,0,0,1,
                 1,1,1,1,0,
                 1,0,0,0,1,
                 1,1,1,1,0},
                {1,1,1,1,1,
                 1,0,0,0,0,
                 1,0,0,0,0,
                 1,0,0,0,0,
                 1,1,1,1,1},
                {1,1,1,1,0,
                 1,0,0,0,1,
                 1,0,0,0,1,
                 1,0,0,0,1,
                 1,1,1,1,0},
                {1,1,1,1,1,
                 1,0,0,0,0,
                 1,1,1,0,0,
                 1,0,0,0,0,
                 1,1,1,1,1},
                {1,1,1,1,1,
                 1,0,0,0,0,
                 1,1,1,0,0,
                 1,0,0,0,0,
                 1,0,0,0,0},
                {1,1,1,1,1,
                 1,0,0,0,0,
                 1,0,1,1,1,
                 1,0,0,0,1,
                 1,1,1,1,1},
                {1,0,0,0,1,
                 1,0,0,0,1,
                 1,1,1,1,1,
                 1,0,0,0,1,
                 1,0,0,0,1},
                {0,1,1,1,0,
                 0,0,1,0,0,
                 0,0,1,0,0,
                 0,0,1,0,0,
                 0,1,1,1,0},
                {0,0,0,1,0,
                 0,0,0,1,0,
                 0,0,0,1,0,
                 0,1,0,1,0,
                 0,1,1,1,0},
                {1,0,0,0,1,
                 1,0,0,1,0,
                 1,1,1,0,0,
                 1,0,0,1,0,
                 1,0,0,0,1},
                {1,0,0,0,0,
                 1,0,0,0,0,
                 1,0,0,0,0,
                 1,0,0,0,0,
                 1,1,1,1,1},
                {1,0,0,0,1,
                 1,1,0,1,1,
                 1,0,1,0,1,
                 1,0,0,0,1,
                 1,0,0,0,1},
                {1,0,0,0,1,
                 1,1,0,0,1,
                 1,0,1,0,1,
                 1,0,0,1,1,
                 1,0,0,0,1},
                {0,1,1,1,0,
                 1,0,0,0,1,
                 1,0,0,0,1,
                 1,0,0,0,1,
                 0,1,1,1,0},
                {1,1,1,1,0,
                 1,0,0,0,1,
                 1,1,1,1,0,
                 1,0,0,0,0,
                 1,0,0,0,0},
                {0,1,1,0,0,
                 1,0,0,1,0,
                 1,0,0,1,0,
                 1,0,0,1,0,
                 0,1,1,0,1},
                {1,1,1,1,0,
                 1,0,0,0,1,
                 1,1,1,1,0,
                 1,0,0,1,0,
                 1,0,0,0,1},
                {0,1,1,1,1,
                 1,0,0,0,0,
                 0,1,1,1,0,
                 0,0,0,0,1,
                 1,1,1,1,0},
                {1,1,1,1,1,
                 0,0,1,0,0,
                 0,0,1,0,0,
                 0,0,1,0,0,
                 0,0,1,0,0},
                {1,0,0,0,1,
                 1,0,0,0,1,
                 1,0,0,0,1,
                 1,0,0,0,1,
                 0,1,1,1,0},
                {1,0,0,0,1,
                 1,0,0,0,1,
                 1,0,0,0,1,
                 0,1,0,1,0,
                 0,0,1,0,0},
                {1,0,0,0,1,
                 1,0,0,0,1,
                 1,0,1,0,1,
                 1,1,0,1,1,
                 1,0,0,0,1},
                {1,0,0,0,1,
                 0,1,0,1,0,
                 0,0,1,0,0,
                 0,1,0,1,0,
                 1,0,0,0,1},
                {1,0,0,0,1,
                 0,1,0,1,0,
                 0,0,1,0,0,
                 0,0,1,0,0,
                 0,0,1,0,0},
                {1,1,1,1,1,
                 0,0,0,1,0,
                 0,0,1,0,0,
                 0,1,0,0,0,
                 1,1,1,1,1},
                {0,1,1,1,0,
                 1,0,0,1,1,
                 1,0,1,0,1,
                 1,1,0,0,1,
                 0,1,1,1,0},
                {0,1,1,0,0,
                 0,0,1,0,0,
                 0,0,1,0,0,
                 0,0,1,0,0,
                 0,0,1,0,0},
                {1,1,1,1,0,
                 0,0,0,0,1,
                 0,1,1,1,0,
                 1,0,0,0,0,
                 1,1,1,1,1},
                {1,1,1,1,0,
                 0,0,0,0,1,
                 0,1,1,1,0,
                 0,0,0,0,1,
                 1,1,1,1,0},
                {1,0,0,0,1,
                 1,0,0,0,1,
                 1,1,1,1,1,
                 0,0,0,0,1,
                 0,0,0,0,1},
                {1,1,1,1,1,
                 1,0,0,0,0,
                 1,1,1,1,0,
                 0,0,0,0,1,
                 1,1,1,1,0},
                {1,0,0,0,0,
                 1,0,0,0,0,
                 1,1,1,1,0,
                 1,0,0,0,1,
                 0,1,1,1,0},
                {1,1,1,1,1,
                 0,0,0,0,1,
                 0,0,0,1,0,
                 0,0,1,0,0,
                 0,0,1,0,0},
                {0,1,1,1,0,
                 1,0,0,0,1,
                 0,1,1,1,0,
                 1,0,0,0,1,
                 0,1,1,1,0},
                {0,1,1,1,0,
                 1,0,0,0,1,
                 0,1,1,1,1,
                 0,0,0,0,1,
                 0,0,0,0,1}
            };

            int[,] output_target_value = new int[,]
            {
            //   A B C D E F G H I J K L M N O P Q R S T U V W X Y Z 0 1 2 3 4 5 6 7 8 9
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1}
            };

            //CREATE VARIABLES

            int patterns = character.Length;
            int input_values = input_value.Length / patterns;
            int output_target_values = output_target_value.Length / patterns;

            int input_neuron_count = input_values + 1;
            int output_neuron_count = output_target_values;
            int middle_neuron_count = (input_values + output_target_values) / 2 + 1;

            decimal[] middle_neuron_sum = new decimal[middle_neuron_count];
            decimal[] output_neuron_sum = new decimal[output_neuron_count];

            decimal[] input_neuron_value = new decimal[input_neuron_count];
            decimal[] middle_neuron_value = new decimal[middle_neuron_count];
            decimal[] output_neuron_value = new decimal[output_neuron_count];

            decimal[] output_neuron_error = new decimal[output_neuron_count];

            decimal[,] inwt = new decimal[input_neuron_count, middle_neuron_count];
            decimal[,] outwt = new decimal[middle_neuron_count, output_neuron_count];

            //CREATE RANDOM NUMBER GENERATOR

            Random randomNumbers = new Random(); // random number generator

            //SET CONNECTION WEIGHTS RANDOMLY BETWEEN -1 and +1 FOR INPUT LAYER CONNECTION WEIGHTS

            for (int i = 0; i < input_neuron_count; i++)
            {
                for (int j = 0; j < middle_neuron_count; j++)
                {
                    inwt[i, j] = Convert.ToDecimal((randomNumbers.Next(0, 20000000) - 10000000)) / 10000000;
                }
            }

            //SET CONNECTION WEIGHTS RANDOMLY BETWEEN -1 and +1 FOR OUTPUT LAYER CONNECTION WEIGHTS

            for (int i = 0; i < middle_neuron_count; i++)
            {
                for (int j = 0; j < output_neuron_count; j++)
                {
                    outwt[i, j] = Convert.ToDecimal((randomNumbers.Next(0, 20000000) - 10000000)) / 10000000;
                }
            }

            //SET BIAS NEURON VALUES TO 1

            input_neuron_value[input_neuron_count - 1] = 1;
            middle_neuron_value[middle_neuron_count - 1] = 1;

            //CREATE CYCLE STATISTIC VARIABLES

            DateTime date1 = new DateTime();
            date1 = DateTime.Now;

            Decimal limit = 0.01M;
            Decimal max_cycle_error = 1.00000000000M;
            Decimal max_last_cycle_error = 1.00000000000M;
            int h = -1;

            int OutputWeightCount = 0;
            decimal AbsouluteValueOutputWeightSum = 0;
            decimal AverageAbsoluteValueOutputWeight;
            decimal MaxAbsoluteValueOutputWeight = 0;

            //LOOP THROUGH TRAINING PATTERNS

            while (Math.Abs(max_cycle_error) > limit) //STOP TRAINING WHEN CYCLE ERROR <= LIMIT
            {
                h += 1; //CYCLE INDEX

                for (int i = 0; i < patterns; i++) //PATTERN INDEX
                {
                    //BEGIN FEED-FORWARD 

                    //RESET CYCLE ERROR ACCUMULATORS TO ZERO

                    if (i == 0)
                    {
                        max_last_cycle_error = max_cycle_error;
                        max_cycle_error = 0;
                    }

                    //RESET MIDDLE NEURON SUMS TO ZERO

                    for (int k = 0; k < middle_neuron_count - 1; k++)
                    {
                        middle_neuron_sum[k] = 0;
                    }

                    //ACCUMULATE SUM OF INPUT NEURON ACTIVATION VALUE x INPUT LAYER WEIGHT FOR EACH MIDDLE NEURON

                    for (int j = 0; j < input_neuron_count - 1; j++)
                    {
                        for (int k = 0; k < middle_neuron_count - 1; k++)
                        {
                            middle_neuron_sum[k] += input_value[i, j] * inwt[j, k];
                        }
                    }

                    //CALCULATE MIDDLE NEURON ACTIVATION VALUES

                    for (int j = 0; j < middle_neuron_count - 1; j++)
                    {
                        double sum = Convert.ToDouble(middle_neuron_sum[j]);
                        middle_neuron_value[j] = Convert.ToDecimal(1 / (1 + Math.Exp(-sum)));
                    }

                    //RESET OUTPUT NEURON SUMS TO ZERO

                    for (int k = 0; k < output_neuron_count; k++)
                    {
                        output_neuron_sum[k] = 0;
                    }

                    //ACCUMULATE SUM OF MIDDLE NEURON ACTIVATION VALUE x OUTPUT LAYER WEIGHT FOR EACH OUTPUT NEURON

                    for (int j = 0; j < middle_neuron_count - 1; j++)
                    {
                        for (int k = 0; k < output_neuron_count; k++)
                        {
                            output_neuron_sum[k] += middle_neuron_value[j] * outwt[j, k];
                        }
                    }

                    //CALCULATE OUTPUT NEURON ACTIVATION VALUES

                    for (int j = 0; j < output_neuron_count; j++)
                    {
                        double sum = Convert.ToDouble(output_neuron_sum[j]);
                        output_neuron_value[j] = Convert.ToDecimal(1 / (1 + Math.Exp(-sum)));
                    }

                    //END FEED-FORWARD

                    //BACK-PROPAGATE ERROR CORRECTION

                    for (int j = 0; j < middle_neuron_count - 1; j++)
                    {
                        for (int k = 0; k < output_neuron_count; k++)
                        {
                            outwt[j, k] += 4 * middle_neuron_value[j] * output_neuron_value[k] * (1 - output_neuron_value[k]) * (output_target_value[i, k] - output_neuron_value[k]);
                        }
                    }

                    //CALCULATE ABSOLUTE VALUE OUTPUT WEIGHT AVERAGE AND MAXIMUM FOR PATTERN

                    OutputWeightCount = 0;
                    AbsouluteValueOutputWeightSum = 0;
                    MaxAbsoluteValueOutputWeight = 0;

                    for (int x = 0; x < middle_neuron_count; x++)
                    {
                        for (int y = 0; y < output_neuron_count; y++)
                        {
                            //outwt[i, j] = Convert.ToDecimal((randomNumbers.Next(0, 20000000) - 10000000)) / 10000000;
                            OutputWeightCount += 1;
                            AbsouluteValueOutputWeightSum += Math.Abs(outwt[x, y]);
                            if (outwt[x, y] > MaxAbsoluteValueOutputWeight) { MaxAbsoluteValueOutputWeight = Math.Abs(outwt[x, y]); }
                        }
                    }

                    AverageAbsoluteValueOutputWeight = AbsouluteValueOutputWeightSum / OutputWeightCount;

                    //PRINT CYCLE DATA TO CONSOLE

                    Console.WriteLine("        Pat-   Output  Mapped                                                    Max Abs Error   Target Max Abs   Avg Output Wt   Max Output Wt   Output Wt[0,0]");
                    Console.WriteLine("Cycle   tern   Neuron Character  Target Value    Output Value        Error       Previous Cycle   Cycle Error     This Pattern    This Pattern      This Cyle");
                    Console.WriteLine();

                    for (int l = 0; l < output_neuron_count; l++)
                    {
                        output_neuron_error[l] = output_target_value[i, l] - output_neuron_value[l];
                        if (Math.Abs(max_cycle_error) < Math.Abs(output_neuron_error[l]))
                        {
                            max_cycle_error = output_neuron_error[l];
                        }

                        Console.WriteLine("[" + h.ToString("00") + "]\t[" + i.ToString("00") + "]\t[" + l.ToString("00") + "]\t[" + character[l] + "]\t[" + output_target_value[i, l].ToString("0.0000000000") + "]  [" + (output_neuron_value[l] + 0).ToString("0.0000000000") + "]  [" + (output_neuron_error[l] + 0).ToString("0.0000000000").PadLeft(13, ' ') + "]  [" + max_last_cycle_error.ToString("0.0000000000") + "]  [" + limit.ToString("0.0000000000") + "]  [" + AverageAbsoluteValueOutputWeight.ToString("0.0000000000") + "]  [" + MaxAbsoluteValueOutputWeight.ToString("0.0000000000") + "]  [" + outwt[0, 0].ToString("0.0000000000") + "]");
                    }

                    Console.WriteLine();
                }

                //PRINT CYCLE STATISTICS TO CONSOLE

                Console.WriteLine("[max_abs_cycle_error] [" + max_cycle_error.ToString("0.0000000000") + "]");
                Console.WriteLine();
                Console.WriteLine("[target_max_abs_cycle_error] [" + limit.ToString("0.0000000000") + "]");
                Console.WriteLine();
            }

            //PRINT EXECUTION DURATION TO CONSOLE

            DateTime date2 = new DateTime();
            date2 = DateTime.Now;
            TimeSpan interval = date2 - date1;
            Console.WriteLine("{0} - {1} = {2}", date2, date1, interval.ToString("00:00:00"));
            Console.ReadLine();
        }
    }
}

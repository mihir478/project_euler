using System;
// using System.Diagnostics;

namespace P14
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            long[] inputs = new long[t];
            long maxN = 0;
            for (int a0 = 0; a0 < t; a0++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                inputs[a0] = n;
                if (n > maxN)
                {
                    maxN = n;
                }
            }
            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();

            int LIMIT = 200000;
            int[] chains = new int[LIMIT + 1];

            int maxCL = 0;
            long nWithMaxCL = 1;
            long[] outputs = new long[inputs.Length];

            for (long i = 2; i <= maxN; i++)
            {
                int cL = 0;
                long n = i;
                long[] chain = new long[685]; // less than 10 million is 8,400,511, which has 685 steps - Wikipedia
                do
                {
                    chain[cL++] = n;
                    if (n % 2 == 0)
                        n = n >> 1;
                    else
                        n = (n << 1) + n + 1;
                } while (n > i && n > 1 && (n > LIMIT || chains[n] == 0));

                for (int c = 0; c < cL; ++c) {
                    if (chain[c] >= i && chain[c] <= LIMIT && chains[chain[c]] == 0)
                        chains[chain[c]] = chains[n] + cL - c;
                }

                if (chains[i] >= maxCL)
                {
                    maxCL = chains[i];
                    nWithMaxCL = i;
                }
                
                for (int s = 0; s < inputs.Length; ++s) {
                    if (inputs[s] == i) {
                        outputs[s] = nWithMaxCL;
                    }
                }
            }

            for (int o = 0; o < outputs.Length; ++o)
            {
                Console.WriteLine(outputs[o]);
            }

            //stopWatch.Stop();
            //// Get the elapsed time as a TimeSpan value.
            //TimeSpan ts = stopWatch.Elapsed;

            //// Format and display the TimeSpan value.
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            //Console.WriteLine("RunTime " + elapsedTime);
            Console.Read();
        }
    }
}

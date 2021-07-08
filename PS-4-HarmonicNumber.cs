using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PS_4_HarmonicNumber
    {
        public void harmonicSeries()
        {
            int i, N;
            double s = 0.0;

            Console.Write("Calculate the harmonic series and their sum:\n ");
            Console.Write("Input the number of terms : ");
            N = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= N; i++)
            {
                Console.Write("1/" +i+ "+");
                s += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto " +N+ "terms : "+s+"\n");
        }
    }
}

static void Main(string[] args)
        {
            PS_4_HarmonicNumber obj4 = new PS_4_HarmonicNumber();
            obj4.harmonicSeries();
        }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    /// <summary>
    ///  Addytywny Opóźniony Generator Fibonacciego
    /// </summary>

    public class Generator
    {
        private const int k = 10;
        private const int j = 7;
        private const int m = 32000;
        private const int a = 5184;
       

        private static int[] x = new int[k];
        private static int i; 

        public static void Init(int seed)
        {
           x[0]= seed; 
           for(int n=1; n<k; n++)
            {
                x[n] = (a* x[n - 1]) % m;

                 i= 0; 
            }
        }

        public static int LFG()
        {
            int result;

            x[i] = (x[(k + i - j) % k] + x[i]) % m;
            result = x[i];
            i = (i + 1) % k;

            return result;

        }

    }
}

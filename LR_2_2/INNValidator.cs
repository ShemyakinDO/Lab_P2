using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2_2
{
    public class INNValidator
    {
        public bool check10DigitInn(int[] inn)
        {
            return inn[9] == computeInnControlSum(inn, 0) % 11 % 10;
        }

        public bool check12DigitInn(int[] inn)
        {
            int controlSum1 = ((inn[0] * 7 + computeInnControlSum(inn, 1)) % 11) % 10;
            int controlSum2 = ((inn[0] * 3 + inn[1] * 7 + computeInnControlSum(inn, 2)) % 11) % 10;
            return inn[10] == controlSum1 && inn[11] == controlSum2;
        }

        private int computeInnControlSum(int[] inn, int index)
        {
            int[] coefficients = { 2, 4, 10, 3, 5, 9, 4, 6, 8 };
            int controlSum = 0;
            for (int i = 0; i < 9; i++)
                controlSum += coefficients[i] * inn[i + index];
            return controlSum;
        }

    }
}

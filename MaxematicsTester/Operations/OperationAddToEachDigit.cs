using System;
using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationAddToEachDigit : Operation {
        int amount;
        public OperationAddToEachDigit(int amount) {
            this.amount = amount;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            int digits = (int)Math.Floor(Math.Log10(num) + 1);
            string s = num.ToString();
            int output = 0;
            for (int i = 0; i < s.Length; i++) {
                int digit = '0' - s[s.Length - i - 1];
                digit = (digit + amount) % 10;
                output += digit * (int)Math.Pow(10, i);
            }
            List<int> list = new List<int>();
            list.Add(output);
            return list;
        }
    }
}
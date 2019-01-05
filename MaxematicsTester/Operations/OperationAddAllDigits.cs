using System;
using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationAddAllDigits : Operation {
        public OperationAddAllDigits() {
        }

        public override List<int> Modify(int num, int position, int handSize) {
            int b = num;
            num = Math.Abs(num);
            HashSet<int> output = new HashSet<int>();
            while (num > 0) {
                b += num % 10;
                num /= 10;
            }
            output.Add(b);
            return new List<int>(output);
        }
    }
}
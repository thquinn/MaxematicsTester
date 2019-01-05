using System;
using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationAddAnyDigit : Operation {
        public OperationAddAnyDigit() {
        }

        public override List<int> Modify(int num, int position, int handSize) {
            if (num == 0) {
                return new List<int>(new int[] { num });
            }
            int b = num;
            num = Math.Abs(num);
            HashSet<int> output = new HashSet<int>();
            while (num > 0) {
                output.Add(b + (num % 10));
                num /= 10;
            }
            return new List<int>(output);
        }
    }
}
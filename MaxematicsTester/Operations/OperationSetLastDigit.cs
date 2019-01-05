using System;
using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationSetLastDigit : Operation {
        int digit;
        public OperationSetLastDigit(int digit) {
            this.digit = digit;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            int delta = 9 - Math.Abs(num % 10);
            if (num < 0) {
                delta *= -1;
            }
            List<int> output = new List<int>();
            output.Add(num + delta);
            return output;
        }
    }
}
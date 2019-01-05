using System;
using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationMultiply : Operation {
        float multiplier;
        public OperationMultiply(float multiplier) {
            this.multiplier = multiplier;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            List<int> output = new List<int>();
            output.Add((int)Math.Floor(num * multiplier));
            return output;
        }
    }
}
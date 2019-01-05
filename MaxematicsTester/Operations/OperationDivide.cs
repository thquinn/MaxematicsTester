using System;
using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationDivide : Operation {
        float divisor;
        public OperationDivide(float divisor) {
            this.divisor = divisor;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            List<int> output = new List<int>();
            output.Add((int)Math.Floor(num / divisor));
            return output;
        }
    }
}
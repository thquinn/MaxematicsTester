using System;
using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationExponent : Operation {
        float exponent;
        public OperationExponent(float exponent) {
            this.exponent = exponent;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            List<int> output = new List<int>();
            output.Add((int)Math.Floor(Math.Pow(num, exponent)));
            return output;
        }
    }
}
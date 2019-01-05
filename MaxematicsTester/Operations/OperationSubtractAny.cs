using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationSubtractAny : Operation {
        public OperationSubtractAny() {
        }

        public override List<int> Modify(int num, int position, int handSize) {
            // Doesn't go down into negatives, but whatever.
            List<int> output = new List<int>();
            output.Add(num);
            for (int i = 1; i <= num; i++) {
                output.Add(num - i);
            }
            return output;
        }
    }
}
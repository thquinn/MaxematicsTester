using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationAddForEachBefore : Operation {
        int value;
        public OperationAddForEachBefore(int value) {
            this.value = value;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            List<int> output = new List<int>();
            output.Add(num + value * position);
            return output;
        }
    }
}
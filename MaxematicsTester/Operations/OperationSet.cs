using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationSet : Operation {
        int constant;
        public OperationSet(int constant) {
            this.constant = constant;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            List<int> output = new List<int>();
            output.Add(constant);
            return output;
        }
    }
}
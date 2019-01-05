using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationAdd : Operation {
        int constant;
        public OperationAdd(int constant) {
            this.constant = constant;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            List<int> output = new List<int>();
            output.Add(num + constant);
            return output;
        }
    }
}
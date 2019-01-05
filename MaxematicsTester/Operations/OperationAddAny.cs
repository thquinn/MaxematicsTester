using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationAddAny : Operation {
        int[] constants;
        public OperationAddAny(int[] constants) {
            this.constants = constants;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            List<int> output = new List<int>();
            foreach (int constant in constants) {
                output.Add(num + constant);
            }
            return output;
        }
    }
}
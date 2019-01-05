using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationIfThreshold : Operation {
        int threshold;
        Operation trueOperation, falseOperation;

        public OperationIfThreshold(int threshold, Operation trueOperation, Operation falseOperation) {
            this.threshold = threshold;
            this.trueOperation = trueOperation;
            this.falseOperation = falseOperation;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            if (num >= threshold) {
                return trueOperation.Modify(num, position, handSize);
            }
            return falseOperation.Modify(num, position, handSize);
        }
    }
}
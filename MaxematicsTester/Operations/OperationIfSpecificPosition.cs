using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationIfSpecificPosition : Operation {
        int specificPosition;
        bool fromFront;
        Operation trueOperation, falseOperation;

        public OperationIfSpecificPosition(int specificPosition, bool fromFront, Operation trueOperation, Operation falseOperation) {
            this.specificPosition = specificPosition;
            this.fromFront = fromFront;
            this.trueOperation = trueOperation;
            this.falseOperation = falseOperation;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            bool inPosition;
            if (fromFront) {
                inPosition = position == specificPosition;
            } else {
                inPosition = (handSize - position - 1) == specificPosition;
            }

            if (inPosition) {
                return trueOperation.Modify(num, position, handSize);
            }
            return falseOperation.Modify(num, position, handSize);
        }
    }
}
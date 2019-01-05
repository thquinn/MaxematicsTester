using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationFlip : Operation {
        public OperationFlip() {
        }

        public override List<int> Modify(int num, int position, int handSize) {
            int output = 0;
            while (num != 0) {
                output *= 10;
                output += num % 10;
                num /= 10;
            }
            List<int> list = new List<int>();
            list.Add(output);
            return list;
        }
    }
}
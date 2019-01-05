using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationAll : Operation {
        Operation[] operations;
        public OperationAll(Operation[] operations) {
            this.operations = operations;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            List<int> output = new List<int>();
            output.Add(num);
            HashSet<int> temp = new HashSet<int>();
            foreach (Operation operation in operations) {
                foreach (int n in output) {
                    temp.UnionWith(operation.Modify(n, position, handSize));
                }
                output.Clear();
                output.AddRange(temp);
                temp.Clear();
            }
            return output;
        }
    }
}
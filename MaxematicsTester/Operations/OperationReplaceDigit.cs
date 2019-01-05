using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationReplaceDigit : Operation {
        char before, after;
        public OperationReplaceDigit(int before, int after) {
            this.before = (char)((int)'0' + before);
            this.after = (char)((int)'0' + after);
        }

        public override List<int> Modify(int num, int position, int handSize) {
            List<int> output = new List<int>();
            output.Add(int.Parse(num.ToString().Replace(before, after)));
            return output;
        }
    }
}
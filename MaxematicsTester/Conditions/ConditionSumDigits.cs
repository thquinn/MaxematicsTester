using System;
using System.Linq;

namespace MaxematicsTester {
    class ConditionSumDigits : Condition {
        int sum;
        public ConditionSumDigits(int sum) {
            this.sum = sum;
        }

        public override bool Meets(int num) {
            return Array.ConvertAll(num.ToString().ToArray(), x => (int)x - 48).Sum() == sum;
        }
    }
}

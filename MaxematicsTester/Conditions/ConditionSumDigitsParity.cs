using System;
using System.Linq;

namespace MaxematicsTester {
    class ConditionSumDigitsParity : Condition {
        bool even;
        public ConditionSumDigitsParity(bool even) {
            this.even = even;
        }

        public override bool Meets(int num) {
            return (Array.ConvertAll(num.ToString().ToArray(), x => (int)x - 48).Sum() % 2 == 0) == even;
        }
    }
}

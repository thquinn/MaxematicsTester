using System;
using System.Linq;

namespace MaxematicsTester {
    class ConditionDigitsWithinRange : Condition {
        int min, max;
        public ConditionDigitsWithinRange(int min, int max) {
            this.min = min;
            this.max = max;
        }

        public override bool Meets(int num) {
            int[] digits = Array.ConvertAll(num.ToString().ToArray(), x => (int)x - 48);
            foreach (int digit in digits) {
                if (digit < min || digit > max) {
                    return false;
                }
            }
            return true;
        }
    }
}

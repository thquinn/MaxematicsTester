using System;
using System.Linq;

namespace MaxematicsTester {
    class ConditionMonotonic : Condition {
        bool ascending, orEqualsTo;
        public ConditionMonotonic(bool ascending, bool orEqualsTo) {
            this.ascending = ascending;
            this.orEqualsTo = orEqualsTo;
        }

        public override bool Meets(int num) {
            int[] digits = Array.ConvertAll(num.ToString().ToArray(), x => (int)x - 48);
            for (int i = 1; i < digits.Length; i++) {
                if (ascending) {
                    if (orEqualsTo && digits[i] < digits[i - 1]) {
                        return false;
                    }
                    if (!orEqualsTo && digits[i] <= digits[i - 1]) {
                        return false;
                    }
                } else {
                    if (orEqualsTo && digits[i] > digits[i - 1]) {
                        return false;
                    }
                    if (!orEqualsTo && digits[i] >= digits[i - 1]) {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

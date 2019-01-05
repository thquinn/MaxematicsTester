using System;
using System.Linq;

namespace MaxematicsTester {
    class ConditionDigitsInARow : Condition {
        int n;
        public ConditionDigitsInARow(int n) {
            this.n = n;
        }

        public override bool Meets(int num) {
            string s = num.ToString();
            for (int i = 1; i < s.Length; i++) {
                if (s[i - 1] == s[i]) {
                    return true;
                }
            }
            return false;
        }
    }
}

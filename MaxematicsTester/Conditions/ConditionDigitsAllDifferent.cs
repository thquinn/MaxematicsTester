using System;

namespace MaxematicsTester {
    class ConditionDigitsAllDifferent : Condition {
        public ConditionDigitsAllDifferent() {
        }

        public override bool Meets(int num) {
            num = Math.Abs(num);
            bool[] seen = new bool[10];
            foreach (char c in num.ToString()) {
                int i = (int)c - (int)'0';
                if (seen[i]) {
                    return false;
                }
                seen[i] = true;
            }
            return true;
        }
    }
}

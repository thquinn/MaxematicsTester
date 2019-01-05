using System;

namespace MaxematicsTester {
    class ConditionPalindrome : Condition {
        public ConditionPalindrome() {
        }

        public override bool Meets(int num) {
            string s = num.ToString();
            char[] ca = s.ToCharArray();
            Array.Reverse(ca);
            return s == new string(ca);
        }
    }
}

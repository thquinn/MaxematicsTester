namespace MaxematicsTester {
    class ConditionDigitsAllSame : Condition {
        public ConditionDigitsAllSame() {
        }

        public override bool Meets(int num) {
            string s = num.ToString();
            for (int i = 1; i < s.Length; i++) {
                if (s[i] != s[0]) {
                    return false;
                }
            }
            return true;
        }
    }
}

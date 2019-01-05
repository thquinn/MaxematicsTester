namespace MaxematicsTester {
    class ConditionContainsDigit : Condition {
        char digit;
        int minAppearances, maxAppearances;
        public ConditionContainsDigit(int digit, int minAppearances, int maxAppearances) {
            this.digit = digit.ToString()[0];
            this.minAppearances = minAppearances;
            this.maxAppearances = maxAppearances;
        }

        public override bool Meets(int num) {
            int count = 0;
            foreach (char c in num.ToString()) {
                if (c == digit) {
                    count++;
                }
            }
            return count >= minAppearances && count <= maxAppearances;
        }
    }
}

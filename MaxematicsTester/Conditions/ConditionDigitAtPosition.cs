namespace MaxematicsTester {
    class ConditionDigitAtPosition : Condition {
        char digit;
        int position;
        public ConditionDigitAtPosition(int digit, int position) {
            this.digit = digit.ToString()[0];
            this.position = position;
        }

        public override bool Meets(int num) {
            string s = num.ToString();
            if (s.Length <= position) {
                return false;
            }
            return s[position] == digit;
        }
    }
}

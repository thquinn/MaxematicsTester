namespace MaxematicsTester {
    class ConditionDigitParity : Condition {
        bool even;
        public ConditionDigitParity(bool even) {
            this.even = even;
        }

        public override bool Meets(int num) {
            while (true) {
                if ((num % 2 == 0) != even) {
                    return false;
                }
                num /= 10;
                if (num == 0) {
                    return true;
                }
            }
        }
    }
}

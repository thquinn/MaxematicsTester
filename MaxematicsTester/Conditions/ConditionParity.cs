namespace MaxematicsTester {
    class ConditionParity : Condition {
        bool even;
        public ConditionParity(bool even) {
            this.even = even;
        }

        public override bool Meets(int num) {
            return (num % 2 == 0) == even;
        }
    }
}

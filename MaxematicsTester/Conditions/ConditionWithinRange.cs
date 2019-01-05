namespace MaxematicsTester {
    class ConditionWithinRange : Condition {
        int min, max;
        public ConditionWithinRange(int min, int max) {
            this.min = min;
            this.max = max;
        }

        public override bool Meets(int num) {
            return num >= min && num <= max;
        }
    }
}

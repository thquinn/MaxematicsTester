namespace MaxematicsTester {
    class ConditionMod : Condition {
        int mod, remainder;
        public ConditionMod(int mod, int remainder) {
            this.mod = mod;
            this.remainder = remainder;
        }

        public override bool Meets(int num) {
            return num % mod == remainder;
        }
    }
}

using System;
using System.Linq;

namespace MaxematicsTester {
    class ConditionStartsWith : Condition {
        string substring;
        public ConditionStartsWith(string substring) {
            this.substring = substring;
        }

        public override bool Meets(int num) {
            return Math.Abs(num).ToString().StartsWith(substring);
        }
    }
}

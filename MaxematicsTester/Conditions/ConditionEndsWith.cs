using System;
using System.Linq;

namespace MaxematicsTester {
    class ConditionEndsWith : Condition {
        string substring;
        public ConditionEndsWith(string substring) {
            this.substring = substring;
        }

        public override bool Meets(int num) {
            return num.ToString().EndsWith(substring);
        }
    }
}

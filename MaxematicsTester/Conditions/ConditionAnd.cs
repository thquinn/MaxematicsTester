using System;
using System.Linq;

namespace MaxematicsTester {
    class ConditionAnd : Condition {
        Condition[] conditions;
        public ConditionAnd(Condition[] conditions) {
            this.conditions = conditions;
        }

        public override bool Meets(int num) {
            foreach (Condition condition in conditions) {
                if (!condition.Meets(num)) {
                    return false;
                }
            }
            return true;
        }
    }
}

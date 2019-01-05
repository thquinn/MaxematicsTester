using System;
using System.Linq;

namespace MaxematicsTester {
    class ConditionOr : Condition {
        Condition[] conditions;
        public ConditionOr(Condition[] conditions) {
            this.conditions = conditions;
        }

        public override bool Meets(int num) {
            foreach (Condition condition in conditions) {
                if (condition.Meets(num)) {
                    return true;
                }
            }
            return false;
        }
    }
}

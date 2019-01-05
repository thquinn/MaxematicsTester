using System;
using System.Linq;

namespace MaxematicsTester {
    class ConditionNot : Condition {
        Condition condition;
        public ConditionNot(Condition condition) {
            this.condition = condition;
        }

        public override bool Meets(int num) {
            return !condition.Meets(num);
        }
    }
}

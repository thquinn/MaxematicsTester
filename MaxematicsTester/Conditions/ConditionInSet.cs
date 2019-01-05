using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxematicsTester {
    class ConditionInSet : Condition {
        HashSet<int> set;
        public ConditionInSet(HashSet<int> set) {
            this.set = set;
        }

        public override bool Meets(int num) {
            return set.Contains(num);
        }
    }
}

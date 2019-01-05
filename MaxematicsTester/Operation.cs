using System.Collections.Generic;

namespace MaxematicsTester {
    abstract class Operation {
        public abstract List<int> Modify(int num, int position, int handSize);
    }
}

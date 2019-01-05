using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxematicsTester {
    class ConditionInSeries : Condition {
        InfiniteSeries series;
        public ConditionInSeries(InfiniteSeries series) {
            this.series = series;
        }

        public override bool Meets(int num) {
            return series.Contains(num);
        }
    }
}

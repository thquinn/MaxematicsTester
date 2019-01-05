using System.Collections.Generic;

namespace MaxematicsTester {
    class OperationNextSeriesMember : Operation {
        InfiniteSeries series;

        public OperationNextSeriesMember(InfiniteSeries series) {
            this.series = series;
        }

        public override List<int> Modify(int num, int position, int handSize) {
            List<int> output = new List<int>();
            output.Add(series.GetNext(num));
            return output;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxematicsTester {
    abstract class InfiniteSeries {
        protected List<int> series;

        public bool Contains(int value) {
            while (value > series.Last()) {
                AddNext();
            }
            return series.BinarySearch(value) >= 0;
        }
        public int GetNext(int value) {
            while (value >= series.Last()) {
                AddNext();
            }
            int index = series.BinarySearch(value);
            if (index < 0) {
                index = ~index;
            }
            else {
                index++;
            }
            return series[index];
        }
        protected abstract void AddNext();
    }

    class AdditiveSeries : InfiniteSeries {
        int factor;
        public AdditiveSeries(int factor) {
            this.factor = factor;
            series = new List<int>();
            series.Add(0);
        }
        protected override void AddNext() {
            series.Add(series.Count * factor);
        }
    }
    class SquareSeries : InfiniteSeries {
        public SquareSeries() {
            series = new List<int>();
            series.Add(0);
        }
        protected override void AddNext() {
            series.Add(series.Count * series.Count);
        }
    }
    class PowerSeries : InfiniteSeries {
        int b;
        public PowerSeries(int b) {
            this.b = b;
            series = new List<int>();
            series.Add(1);
        }
        protected override void AddNext() {
            series.Add((int)Math.Pow(b, series.Count));
        }
    }
    class PrimeSeries : InfiniteSeries {
        public PrimeSeries() {
            series = new List<int>();
            series.Add(2);
        }
        protected override void AddNext() {
            int candidate = series[series.Count - 1] + 1;
            while (true) {
                double sqrt = Math.Sqrt(candidate);
                bool good = true;
                foreach (int prime in series) {
                    if (prime > sqrt) {
                        break;
                    }
                    if (candidate % prime == 0) {
                        good = false;
                        break;
                    }
                }
                if (good) {
                    series.Add(candidate);
                    return;
                }
                candidate++;
            }
        }
    }
    class FiniteSeries : InfiniteSeries {
        public FiniteSeries(int[] arr) {
            series = new List<int>(arr);
        }
        protected override void AddNext() {
            throw new NotImplementedException();
        }
    }
}

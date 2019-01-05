using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxematicsTester {
    class OperationRearrange : Operation {
        public OperationRearrange() {
        }

        public override List<int> Modify(int num, int position, int handSize) {
            HashSet<int> output = new HashSet<int>();
            int[] digits = Array.ConvertAll(num.ToString().ToArray(), x => (int)x - 48);
            foreach (int[] permutation in digits.GetPermutations<int>()) {
                int total = 0;
                for (int i = 0; i < permutation.Length; i++) {
                    total += permutation[permutation.Length - i - 1] * (int)Math.Pow(10, i);
                }
                output.Add(total);
            }
            return output.ToList();
        }
    }
}
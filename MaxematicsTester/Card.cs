using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxematicsTester {
    class Card {
        public Condition condition;
        public Operation operation;

        int selfIndex;
        int trials;
        int totalScore;
        int timesUsed;
        int totalNumUsed;
        int[] pairTrials;
        int[] pairTotalScore;

        public Card(Condition condition, Operation operation) {
            this.condition = condition;
            this.operation = operation;

            selfIndex = -1;
            trials = 0;
            totalScore = 0;
            timesUsed = 0;
            totalNumUsed = 0;
        }

        public void Trial(int score, int totalUsed, HashSet<int> cards) {
            if (selfIndex == -1) {
                pairTrials = new int[Constants.CARDS.Length];
                pairTotalScore = new int[Constants.CARDS.Length];
                selfIndex = Array.IndexOf(Constants.CARDS, this);
            }

            trials++;
            // Prevent super-high scores from overweighting averages.
            totalScore += Math.Min(250, score);
            if (cards.Contains(selfIndex)) {
                timesUsed++;
            }
            totalNumUsed += totalUsed;
            foreach (int card in cards) {
                if (card == selfIndex) {
                    continue;
                }
                pairTrials[card]++;
                pairTotalScore[card] += score;
            }
        }

        public override string ToString() {
            int maxIndex = -1;
            float maxAvg = 0;
            for (int i = 0; i < pairTrials.Length; i++) {
                if (pairTrials[i] == 0) {
                    continue;
                }
                float avg = (float)pairTotalScore[i] / pairTrials[i];
                if (avg > maxAvg) {
                    maxIndex = i;
                    maxAvg = avg;
                }
            }
            string percentString = trials > 0 ? (timesUsed * 100f / trials).ToString() : "none";
            return string.Format("Card #{0}: avgscore {1:0.##}, used in {2:0.#}% of {3} trials. Works best with card #{4}.", selfIndex + 1, (double)totalScore / trials, percentString, trials, maxIndex + 1);
        }
    }
}

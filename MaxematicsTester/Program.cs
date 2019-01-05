using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxematicsTester {
    class Program {
        static void Main(string[] args) {
            // Create random hands of cards, find the best possible score for each, track per-card stats:
            //      - Chance to be used when present
            //      - Average score when present
            //      - Average number of cards used when present
            //      - Other card that combines most/least effectively
            // And also lowest/highest overall score, overall all-card chance.

            Console.WriteLine("Loaded " + Constants.CARDS.Length + " cards.");
            int numTrials = 50000;
            List<int> indices = new List<int>(SomeExtensions.CreateRange(0, Constants.CARDS.Length - 1));
            Random random = new Random();
            for (int i = 0; i < numTrials; i++) {
                int[] hand = indices.OrderBy(x => random.Next()).Take(Constants.HAND_SIZE).OrderBy(x => x).ToArray();
                RunHand(hand);
                if (i % 100 == 99) {
                    Console.WriteLine((i + 1) + "/" + numTrials + " trials complete.");
                }
            }
            foreach (Card card in Constants.CARDS) {
                Console.WriteLine(card.ToString());
            }
            Console.ReadLine();
        }

        static void RunHand(int[] indices) {
            int bestScore = 1;
            HashSet<int> bestCards = new HashSet<int>();
            int bestNumUsed = 0;
            foreach (int[] order in indices.GetPermutations<int>()) {
                if (Constants.CARDS[order[0]].condition == null) {
                    continue;
                }
                if (Constants.CARDS[order[0]].operation == null) {
                    continue;
                }
                for (int subOrderLength = order.Length; subOrderLength >= 1; subOrderLength--) {
                    HashSet<int> current = new HashSet<int>();
                    current.Add(1);
                    HashSet<int> next = new HashSet<int>();
                    for (int i = 0; i < subOrderLength; i++) {
                        Condition condition = null;
                        for (int j = i; j >= 0; j--) {
                            if (Constants.CARDS[order[j]].condition != null) {
                                condition = Constants.CARDS[order[j]].condition;
                                break;
                            }
                        }
                        Operation operation = null;
                        for (int j = i; j >= 0; j--) {
                            if (Constants.CARDS[order[j]].operation != null) {
                                operation = Constants.CARDS[order[j]].operation;
                                break;
                            }
                        }
                        foreach (int n in current) {
                            if (!condition.Meets(n)) {
                                continue;
                            }
                            List<int> modified = operation.Modify(n, i, subOrderLength);
                            int max = modified.Max();
                            if (max > bestScore) {
                                bestScore = max;
                                bestCards.Clear();
                                bestNumUsed = 0;
                            }
                            if (max == bestScore) {
                                bestCards.UnionWith(order.Take(i + 1));
                                bestNumUsed = Math.Max(bestNumUsed, i + 1);
                            }
                            next.UnionWith(modified);
                        }
                        if (next.Count == 0) {
                            break;
                        }
                        current.Clear();
                        current.UnionWith(next);
                        next.Clear();
                    }
                }
            }
            foreach (int card in indices) {
                Constants.CARDS[card].Trial(bestScore, bestNumUsed, bestCards);
            }
            Console.WriteLine(bestScore);
        }
    }
}

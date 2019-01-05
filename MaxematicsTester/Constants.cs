using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxematicsTester {
    class Constants {
        public static int HAND_SIZE = 8;
        public static int BONUS_POINTS = 20;

        public static PrimeSeries PRIME_SERIES = new PrimeSeries();
        public static PowerSeries POWER_SERIES = new PowerSeries(2);
        public static SquareSeries SQUARE_SERIES = new SquareSeries();
        public static AdditiveSeries MULTIPLE_OF_15_SERIES = new AdditiveSeries(15);
        public static AdditiveSeries MULTIPLE_OF_100_SERIES = new AdditiveSeries(100);
        public static FiniteSeries FACTORS_OF_100_SERIES = new FiniteSeries(new int[] { 1, 2, 4, 5, 10, 20, 25, 50, 100 });
        public static Card[] CARDS = new Card[] {
            new Card(new ConditionDigitParity(true), new OperationAll(new Operation[]{ new OperationAdd(-12), new OperationFlip() })),
            new Card(new ConditionDigitsAllSame(), null),
            new Card(new ConditionAnything(), new OperationAddAny(new int[]{ 1, 2, 3 })),
            new Card(new ConditionAnything(), new OperationAddAny(SomeExtensions.CreateRange(-6, -1))),
            new Card(new ConditionAnything(), new OperationAdd(4)),
            new Card(new ConditionAnything(), new OperationAdd(5)),
            new Card(new ConditionAnything(), new OperationAddAnyDigit()),
            new Card(new ConditionAnything(), new OperationAddAny(SomeExtensions.CreateRange(-12, -3))),
            new Card(new ConditionAnything(), new OperationNextSeriesMember(SQUARE_SERIES)),
            new Card(new ConditionAnything(), new OperationIfSpecificPosition(2, true, new OperationAddAny(SomeExtensions.CreateRange(6, 9)), new OperationAddForEachBefore(2))),
            new Card(new ConditionWithinRange(10, 22), new OperationMultiply(2)),
            new Card(new ConditionWithinRange(26, 33), new OperationMultiply(2)),
            new Card(new ConditionContainsDigit(1, 1, int.MaxValue), new OperationAddAny(new int[]{ -6, -5, -4, -3, -2, -1, 1, 2, 3 })),
            new Card(new ConditionContainsDigit(7, 1, int.MaxValue), new OperationAddAny(new int[]{ 2, 3, 5, 7, 11, 13, 17, 19, 23 })), // all primes less than 25
            new Card(new ConditionContainsDigit(9, 1, int.MaxValue), new OperationAddAny(SomeExtensions.CreateRange(1, 11))),
            new Card(new ConditionContainsDigit(3, 1, int.MaxValue), new OperationReplaceDigit(3, 6)),
            new Card(null, null),
            new Card(null, new OperationAddAny(SomeExtensions.CreateRange(11, 12))),
            new Card(new ConditionDigitsAllDifferent(), new OperationAdd(8)),
            new Card(new ConditionAnd(new Condition[]{ new ConditionWithinRange(10, int.MaxValue), new ConditionMonotonic(false, false) }), new OperationNextSeriesMember(POWER_SERIES)),
            new Card(new ConditionAnd(new Condition[]{ new ConditionWithinRange(10, int.MaxValue), new ConditionMonotonic(true, false) }), new OperationMultiply(1.5f)),
            new Card(new ConditionSumDigits(12), new OperationSet(99)),
            new Card(new ConditionSumDigits(8), new OperationAddAny(new int[]{ 17, 26, 30 })),
            new Card(new ConditionEndsWith("41"), new OperationNextSeriesMember(MULTIPLE_OF_100_SERIES)),
            new Card(new ConditionOr(new Condition[]{ new ConditionEndsWith("7"), new ConditionEndsWith("8"), new ConditionEndsWith("9") }), new OperationAddAny(new int[]{ 1, 10, 11 })),
            new Card(new ConditionParity(true), new OperationAdd(9)),
            new Card(new ConditionParity(true), new OperationAll(new Operation[]{ new OperationDivide(2), new OperationAdd(22) })),
            new Card(new ConditionParity(true), new OperationAddAny(new int[]{ 2, 4, 5, 7, 9 })),
            new Card(new ConditionParity(true), new OperationAddAny(new int[]{ 1, 3, 6, 8 })),
            new Card(new ConditionWithinRange(1, 1), new OperationAddAny(SomeExtensions.CreateRange(1, 7))),
            new Card(new ConditionWithinRange(76, 83), new OperationAddAny(SomeExtensions.CreateRange(1, 52))),
            new Card(new ConditionInSet(new HashSet<int>(){ 1, 2, 4, 5, 10, 20, 25, 50 }), new OperationNextSeriesMember(FACTORS_OF_100_SERIES)),
            new Card(new ConditionWithinRange(85, int.MaxValue), new OperationIfSpecificPosition(1, false, new OperationAddAny(SomeExtensions.CreateRange(35, 55)), new OperationAdd(-1))),
            new Card(new ConditionWithinRange(65, int.MaxValue), new OperationAdd(40)),
            new Card(new ConditionWithinRange(int.MinValue, 99), new OperationAddAny(SomeExtensions.CreateRange(-8, -1))),
            new Card(new ConditionWithinRange(int.MinValue, 99), new OperationReplaceDigit(1, 3)),
            new Card(new ConditionWithinRange(int.MinValue, 19), new OperationAdd(11)),
            new Card(new ConditionWithinRange(int.MinValue, 22), new OperationMultiply(2)),
            new Card(new ConditionWithinRange(int.MinValue, 49), new OperationAddAny(SomeExtensions.CreateRange(4, 6))),
            new Card(new ConditionAnd(new Condition[]{ new ConditionMod(11, 0), new ConditionWithinRange(23, int.MaxValue) }), new OperationAddAny(new int[]{ 5, 10, 15, 20, 25, 30 })),
            new Card(new ConditionMod(25, 0), new OperationAddAny(new int[]{ 24, 25, 26, -3 })),
            new Card(new ConditionMod(16, 0), new OperationAddAny(new int[]{ -12, -11, -10, -9, -8, -7, -6, -5, -4, -3, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 })),
            new Card(new ConditionMod(7, 0), new OperationAddAny(SomeExtensions.CreateRange(2, 10))),
            new Card(new ConditionMod(9, 0), new OperationAdd(19)),
            new Card(new ConditionDigitsWithinRange(0, 3), new OperationIfSpecificPosition(0, false, new OperationAddToEachDigit(1), new OperationAdd(14))),
            new Card(new ConditionDigitsWithinRange(5, 9), new OperationIfThreshold(86, new OperationAdd(42), new OperationAdd(25))),
            new Card(new ConditionNot(new ConditionInSeries(PRIME_SERIES)), new OperationAddAny(new int[]{ 2, 1, -1, -2 })),
            new Card(new ConditionParity(false), new OperationAddAny(new int[]{ 3, 5 })),
            new Card(new ConditionParity(false), new OperationAddForEachBefore(4)),
            new Card(new ConditionParity(false), new OperationAdd(13)),
            new Card(new ConditionParity(false), new OperationNextSeriesMember(MULTIPLE_OF_15_SERIES)),
            new Card(new ConditionAnd(new Condition[]{ new ConditionParity(false), new ConditionSumDigitsParity(true) }), new OperationAdd(21)),
            new Card(new ConditionInSeries(SQUARE_SERIES), new OperationAll(new Operation[]{ new OperationNextSeriesMember(SQUARE_SERIES), new OperationNextSeriesMember(SQUARE_SERIES) })),
            new Card(new ConditionInSeries(SQUARE_SERIES), new OperationAddAny(SomeExtensions.CreateRange(8, 10))),
            new Card(new ConditionInSeries(POWER_SERIES), new OperationMultiply(2)),
            new Card(new ConditionInSeries(POWER_SERIES), new OperationAddAny(SomeExtensions.CreateRange(6, 8))),
            new Card(new ConditionInSeries(PRIME_SERIES), new OperationIfThreshold(50, new OperationAdd(39), new OperationAdd(12))),
            new Card(new ConditionInSeries(PRIME_SERIES), new OperationMultiply(2)),
            new Card(new ConditionAnything(), new OperationSubtractAny()),
            new Card(new ConditionMod(12, 1), new OperationAddAny(new int[]{ 11, 12 })),
            new Card(new ConditionMod(6, 5), new OperationAddAny(new int[]{ 13, 14, 15, -6, -7, -8 })),
            new Card(new ConditionDigitAtPosition(4, 1), new OperationMultiply(1.5f)),
            new Card(new ConditionDigitsInARow(2), new OperationAdd(26)),
            new Card(new ConditionAnd(new Condition[]{ new ConditionWithinRange(10, int.MaxValue), new ConditionDigitParity(false) }), new OperationAddAny(new int[]{ 5, 6, 7, 8, 9, 11 })),
            new Card(new ConditionAnything(), new OperationAll(new Operation[]{ new OperationAdd(-16), new OperationMultiply(-1) })),
            new Card(new ConditionWithinRange(2, 7), new OperationAddAny(SomeExtensions.CreateRange(5, 14))),
            new Card(new ConditionWithinRange(int.MinValue, 29), null),
            new Card(new ConditionWithinRange(int.MinValue, 114), new OperationAddAllDigits()),
            new Card(null, new OperationMultiply(1.5f)),
            new Card(new ConditionStartsWith("4"), new OperationAll(new Operation[]{ new OperationMultiply(2), new OperationAdd(-7) })),
            new Card(new ConditionWithinRange(15, 50), new OperationAddAny(new int[]{ 3, 6, 7, 19 })),
            new Card(new ConditionAnything(), new OperationSetLastDigit(9)),
        };
    }
}

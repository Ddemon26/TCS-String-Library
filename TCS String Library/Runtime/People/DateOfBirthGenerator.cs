using System;

namespace TC.StringLibrary.People {
    public static class DateOfBirthGenerator {
        static readonly Random Random = new();

        public static DateTime GenerateRandomDateOfBirth(int minYear, int maxYear) {
            int year = Random.Next(minYear, maxYear + 1);
            int month = Random.Next(1, 13);
            int day = Random.Next(1, DateTime.DaysInMonth(year, month) + 1);
            return new DateTime(year, month, day);
        }
    }
}
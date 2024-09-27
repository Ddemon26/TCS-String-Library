using System;
using System.Collections.Generic;

namespace TC.StringLibrary.People {
    public static class SocialSecurityNumberGenerator {
        static readonly HashSet<int> GeneratedNumbers = new();
        static readonly Random Random = new();

        public static int GenerateUniqueNumber() {
            int newNumber;
            do {
                newNumber = Random.Next(100000000, 999999999); // Generate a 9-digit number
            } while (!GeneratedNumbers.Add(newNumber)); // Add returns false if the number is already present

            return newNumber;
        }
    }
}
using JetBrains.Annotations;
using UnityEngine;
namespace TC.StringLibrary {
    public static class StringLibrary {
        [UsedImplicitly]
        class UniqueStrings {
            public string[] Strings;
        }

        static UniqueStrings s_uniqueNames;
        static UniqueStrings s_uniqueSurnames;
        static UniqueStrings s_uniqueCountries;
        static UniqueStrings s_uniqueAnimals;
        static UniqueStrings s_uniqueOccupations;
        static UniqueStrings s_randomDialogue;
        static UniqueStrings s_lookForDrugsDialogue;
        static UniqueStrings s_apologies;
        static UniqueStrings s_complaints;
        static UniqueStrings s_excuses;
        static UniqueStrings s_farewells;
        static UniqueStrings s_flirty;
        static UniqueStrings s_greetings;
        static UniqueStrings s_jokes;
        static UniqueStrings s_questions;
        static UniqueStrings s_smallTalk;
        static UniqueStrings s_threats;
        static UniqueStrings s_warnings;

        //Class Methods
        static UniqueStrings InitializeCollection(string jsonPath) {
            var json = Resources.Load<TextAsset>(jsonPath);
            if (!json) {
                Debug.LogError($"Failed to load JSON file at path: {jsonPath}");
                return null;
            }

            var collection = JsonUtility.FromJson<UniqueStrings>(json.text);
            if (collection?.Strings == null) {
                Debug.LogError($"Failed to deserialize JSON file at path: {jsonPath}");
            }

            return collection;
        }

        static string GetRandomString(ref UniqueStrings collection, string jsonPath) {
            if (collection != null) return collection.Strings[Random.Range(0, collection.Strings.Length)];
            collection = InitializeCollection(jsonPath);
            if (collection?.Strings != null) return collection.Strings[Random.Range(0, collection.Strings.Length)];
            Debug.LogError($"Failed to initialize collection from JSON file at path: {jsonPath}");
            return null;
        }

        //public API
        public static string GetRandomName() => GetRandomString(ref s_uniqueNames, "Json/Names");
        public static string GetRandomSurname() => GetRandomString(ref s_uniqueSurnames, "Json/Surnames");
        public static string GetRandomCountry() => GetRandomString(ref s_uniqueCountries, "Json/Countries");
        public static string GetRandomAnimal() => GetRandomString(ref s_uniqueAnimals, "Json/Animals");
        public static string GetRandomOccupation() => GetRandomString(ref s_uniqueOccupations, "Json/Occupations"); 
        public static string GetRandomDialogue() => GetRandomString(ref s_randomDialogue, "Json/RandomDialogue");
        public static string GetLookForDrugsDialogue() => GetRandomString(ref s_lookForDrugsDialogue, "Json/LookForDrugsDialogue");
        public static string GetRandomApology() => GetRandomString(ref s_apologies, "Json/Apologies");
        public static string GetRandomComplaint() => GetRandomString(ref s_complaints, "Json/Complaints");
        public static string GetRandomExcuse() => GetRandomString(ref s_excuses, "Json/Excuses");
        public static string GetRandomFarewell() => GetRandomString(ref s_farewells, "Json/Farewells");
        public static string GetRandomFlirty() => GetRandomString(ref s_flirty, "Json/Flirty");
        public static string GetRandomGreeting() => GetRandomString(ref s_greetings, "Json/Greetings");
        public static string GetRandomJoke() => GetRandomString(ref s_jokes, "Json/Jokes");
        public static string GetRandomQuestion() => GetRandomString(ref s_questions, "Json/Questions");
        public static string GetRandomSmallTalk() => GetRandomString(ref s_smallTalk, "Json/SmallTalk");
        public static string GetRandomThreat() => GetRandomString(ref s_threats, "Json/Threats");
        public static string GetRandomWarning() => GetRandomString(ref s_warnings, "Json/Warnings");
    }
}
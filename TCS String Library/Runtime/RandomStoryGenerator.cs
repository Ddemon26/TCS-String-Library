using System;
namespace TC.StringLibrary {
    public static class RandomStoryGenerator {
        static readonly Random Random = new();
        public static string GetRandomStory(this string _) {
            string protagonist = "".GetRandomName().RichBold().RichColor("cyan");
            string surname = "".GetRandomSurname().RichBold().RichColor("magenta");
            string location = "".GetRandomCountry().RichBold().RichColor("green");
            string animalCompanion = "".GetRandomAnimal().RichBold().RichColor("orange");
            string occupation = "".GetRandomOccupation().RichBold().RichColor("purple");
            string dialogue = "".GetRandomDialogue().RichBold().RichColor("yellow");
            string helpRequest = "".GetLookForDrugsDialogue().RichBold().RichColor("cyan");
            string excuse = "".GetRandomExcuse().RichBold().RichColor("magenta");
            string threat = "".GetRandomThreat().RichBold().RichColor("red");
            string joke = "".GetRandomJoke().RichBold().RichColor("yellow");
            string warning = "".GetRandomWarning().RichBold().RichColor("red");
            string apology = "".GetRandomApology().RichBold().RichColor("cyan");
            string complaint = "".GetRandomComplaint().RichBold().RichColor("green");
            string farewell = "".GetRandomFarewell().RichBold().RichColor("purple");
            string flirty = "".GetRandomFlirty().RichBold().RichColor("orange");
            string greeting = "".GetRandomGreeting().RichBold().RichColor("cyan");
            string question = "".GetRandomQuestion().RichBold().RichColor("magenta");
            string smallTalk = "".GetRandomSmallTalk().RichBold().RichColor("red");

            // Story branching variables
            bool foundTreasure = GetRandomBoolean();
            bool meetsVillain = GetRandomBoolean();
            bool helpsStranger = GetRandomBoolean();
            bool badEnding = GetRandomBoolean();
            bool strangeEncounter = GetRandomBoolean();
            int storyStart = Random.Next(5); // Increase the story starts to 5

            string story = GetStoryStart(storyStart, protagonist, surname, occupation, location, warning, greeting, animalCompanion, dialogue);

            // Encounter with a stranger
            story += HandleStrangerEncounter(protagonist, dialogue, question, helpsStranger, smallTalk, helpRequest, excuse);

            // Optional strange encounter
            if (strangeEncounter) {
                story += HandleStrangeEncounter(protagonist);
            }

            // Decision: treasure or trouble?
            story += foundTreasure
                ? $"{protagonist} followed the clues on the map and found a hidden treasure in an abandoned warehouse.\n\n"
                : $"{protagonist} found nothing but frustration, complaining aloud, '{complaint}'.\n\n";

            // Adding an animal encounter
            story += $"{protagonist} noticed that their {animalCompanion} was acting strangely. It sniffed the air and started leading {protagonist} toward a narrow alleyway. Curious, they followed.\n\n";

            // Decision based on the animal's behavior
            bool followAnimal = GetRandomBoolean();
            story += followAnimal
                ? $"{protagonist} decided to trust their {animalCompanion}, allowing it to lead them to a mysterious, old bookstore hidden in the alley. The shopkeeper greeted them with a peculiar look and whispered, '{greeting}'. {protagonist} felt a strange sense of destiny unfolding.\n\n"
                : $"{protagonist} hesitated, choosing instead to continue down the main road. The {animalCompanion} looked back with a hint of disappointment, but {protagonist} decided not to pursue the alleyway adventure.\n\n";

            // If they follow the animal
            if (followAnimal) {
                story += $"Inside the bookstore, the shopkeeper pulled out an ancient-looking tome. \"This book contains stories of great power,\" the shopkeeper said cryptically. \"But beware...\" {protagonist} felt a shiver as the warning, '{warning}', echoed in their mind. They had to make a choice.\n\n";

                bool takeTheBook = GetRandomBoolean();
                story += takeTheBook
                    ? $"{protagonist} took the book, feeling its weight in their hands. It felt oddly warm, almost alive. They knew this decision could change everything.\n\n"
                    : $"{protagonist} declined, not wanting to get involved with ancient magic. \"Thanks, but I'll pass,\" they said, giving a quick '{excuse}' before leaving the shop.\n\n";
            }

            // Decision: meeting a villain
            if (meetsVillain) {
                string villainName = "".GetRandomName().RichBold().RichColor("red");
                story += HandleVillainEncounter(protagonist, animalCompanion, villainName, threat, apology, flirty);
            }
            else {
                story += $"The day passed without further incident, though {protagonist} couldn't shake the feeling of being watched.\n\n";
            }

            // Adding a surprise old friend encounter
            if (followAnimal || foundTreasure) {
                story += $"As {protagonist} left the bookstore, they encountered someone they didn't expect—an old friend from the past, looking for answers. \"{question},\" the friend asked, eyes searching for truth. {protagonist} couldn't help but wonder if this was fate or mere coincidence.\n\n";

                bool helpFriend = GetRandomBoolean();
                story += helpFriend
                    ? $"{protagonist} agreed to help, knowing it might take them deeper into the mystery. The duo set off on a new journey, with {protagonist}'s {animalCompanion} leading the way once again.\n\n"
                    : $"{protagonist} apologized, '{apology}', and walked away. Some mysteries, they decided, were better left unsolved.\n\n";
            }

            // Final decision: good or bad ending?
            story += badEnding
                ? GetBadEnding(protagonist, location, warning)
                : GetGoodEnding(protagonist, animalCompanion, joke, farewell, location);

            return story;
        }

        static bool GetRandomBoolean() => Random.Next(2) == 0;

        static string GetStoryStart(int storyStart, string protagonist, string surname, string occupation, string location, string warning, string greeting, string animalCompanion, string dialogue) {
            return storyStart switch {
                0 => $"One Monday morning, {protagonist} {surname}, a {occupation} in {location}, woke up to find a mysterious letter at their doorstep. " +
                     $"The letter contained only the words '{warning}'. After a quick exchange of '{greeting}' with their neighbor, {protagonist} decided to investigate.\n\n",
                1 => $"It was a rainy evening in {location} when {protagonist} {surname}, a {occupation}, received an urgent phone call. " +
                     $"The voice on the other end whispered, '{dialogue}', before the line went dead. Grabbing their {animalCompanion}, they rushed out into the night.\n\n",
                2 => $"{protagonist} {surname}, a {occupation}, was spending a lazy afternoon with their {animalCompanion} at a café in {location}, " +
                     $"when they overheard a conversation at the next table. Someone was saying, '{dialogue}'. Curiosity piqued, {protagonist} decided to eavesdrop more closely.\n\n",
                3 => $"A loud knock at {protagonist} {surname}'s door woke them up. Outside stood a stranger, warning them about a strange event happening in {location}. " +
                     $"'{warning}', the stranger said, before disappearing into the night. {protagonist} couldn't shake the feeling that this was no ordinary day.\n\n",
                4 => $"On a calm afternoon, {protagonist} {surname} was enjoying a walk in the park with their {animalCompanion} when they stumbled upon an odd-looking device. " +
                     $"It beeped and displayed a cryptic message: '{warning}'. Confused, they decided to investigate further.\n\n",
                _ => string.Empty,
            };
        }

        static string HandleStrangerEncounter(string protagonist, string dialogue, string question, bool helpsStranger, string smallTalk, string helpRequest, string excuse) {
            string story = $"As they made their way through the city, they encountered a stranger muttering '{dialogue}'. " +
                           $"The stranger asked '{question}', catching {protagonist}'s attention. Should they engage?\n\n";

            if (helpsStranger) {
                story += $"{protagonist} approached the stranger, who engaged in small talk: '{smallTalk}', eventually revealing they needed help: '{helpRequest}'.\n\n";
            }
            else {
                story += $"{protagonist} ignored the stranger, offering a quick '{excuse}' before continuing on their way.\n\n";
            }

            return story;
        }

        static string HandleStrangeEncounter(string protagonist) {
            var story = $"As they continued, someone bumped into {protagonist} and dropped a package. Should {protagonist} open it?\n\n";
            bool openPackage = GetRandomBoolean();
            story += openPackage
                ? $"{protagonist} opened the package to find an old treasure map.\n\n"
                : $"{protagonist} left the package untouched, feeling safer but curious.\n\n";
            return story;
        }

        static string HandleVillainEncounter(string protagonist, string animalCompanion, string villainName, string threat, string apology, string flirty) {
            var story = $"{protagonist} and their {animalCompanion} were confronted by the notorious {villainName}, who hissed '{threat}'.\n\n";
            bool fightVillain = GetRandomBoolean();
            story += fightVillain
                ? $"{protagonist} outwitted {villainName}, sarcastically apologizing: '{apology}', before escaping.\n\n"
                : $"Trying to avoid conflict, {protagonist} gave a flirty response: '{flirty}', distracting the villain just long enough to slip away.\n\n";
            return story;
        }

        static string GetBadEnding(string protagonist, string location, string warning) {
            return $"Later that night, there was a knock on {protagonist}'s door. The warning came to mind: '{warning}'. The next day, {protagonist} was nowhere to be found in {location}.\n\n";
        }

        static string GetGoodEnding(string protagonist, string animalCompanion, string joke, string farewell, string location) {
            return $"{protagonist} and their {animalCompanion} returned home safe, joking, '{joke}', and bid farewell to the city: '{farewell}'.\n\n";
        }
    }
}
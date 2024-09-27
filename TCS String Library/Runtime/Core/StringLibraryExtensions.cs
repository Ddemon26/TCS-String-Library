namespace TC.StringLibrary {
    public static class StringLibraryExtensions {
        public static string GetRandomName(this string _) => StringLibrary.GetRandomName();
        public static string GetRandomSurname(this string _) => StringLibrary.GetRandomSurname();
        public static string GetRandomCountry(this string _) => StringLibrary.GetRandomCountry();
        public static string GetRandomAnimal(this string _) => StringLibrary.GetRandomAnimal();
        public static string GetRandomOccupation(this string _) => StringLibrary.GetRandomOccupation();
        public static string GetRandomDialogue(this string _) => StringLibrary.GetRandomDialogue();
        public static string GetLookForDrugsDialogue(this string _) => StringLibrary.GetLookForDrugsDialogue();
        public static string GetRandomApology(this string _) => StringLibrary.GetRandomApology();
        public static string GetRandomComplaint(this string _) => StringLibrary.GetRandomComplaint();
        public static string GetRandomExcuse(this string _) => StringLibrary.GetRandomExcuse();
        public static string GetRandomFarewell(this string _) => StringLibrary.GetRandomFarewell();
        public static string GetRandomFlirty(this string _) => StringLibrary.GetRandomFlirty();
        public static string GetRandomGreeting(this string _) => StringLibrary.GetRandomGreeting();
        public static string GetRandomJoke(this string _) => StringLibrary.GetRandomJoke();
        public static string GetRandomQuestion(this string _) => StringLibrary.GetRandomQuestion();
        public static string GetRandomSmallTalk(this string _) => StringLibrary.GetRandomSmallTalk();
        public static string GetRandomThreat(this string _) => StringLibrary.GetRandomThreat();
        public static string GetRandomWarning(this string _) => StringLibrary.GetRandomWarning();
        
        // Rich text formatting, for Unity UI elements that support rich text.
        public static string RichColor(this string text, string color) => $"<color={color}>{text}</color>";
        public static string RichSize(this string text, int size) => $"<size={size}>{text}</size>";
        public static string RichBold(this string text) => $"<b>{text}</b>";
        public static string RichItalic(this string text) => $"<i>{text}</i>";
        public static string RichUnderline(this string text) => $"<u>{text}</u>";
        public static string RichStrikethrough(this string text) => $"<s>{text}</s>";
        public static string RichFont(this string text, string font) => $"<font={font}>{text}</font>";
        public static string RichAlign(this string text, string align) => $"<align={align}>{text}</align>";
        public static string RichGradient(this string text, string color1, string color2) => $"<gradient={color1},{color2}>{text}</gradient>";
        public static string RichRotation(this string text, float angle) => $"<rotate={angle}>{text}</rotate>";
        public static string RichSpace(this string text, float space) => $"<space={space}>{text}</space>";
    }
}
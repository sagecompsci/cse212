public static class MysteryStack1 {
    public static string Run(string text) {
        var stack = new Stack<char>();
        foreach (var letter in text)
        {
            Console.WriteLine(letter);
            stack.Push(letter);
        }

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result;
    }
}
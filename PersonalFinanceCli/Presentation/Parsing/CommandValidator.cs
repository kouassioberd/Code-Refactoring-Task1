using System;

namespace PersonalFinanceCli.Presentation.Parsing;

public static class CommandValidator
{
    public static void EnsureNotEmpty(IReadOnlyList<string> tokens)
    {
        if (tokens.Count == 0)
        {
            throw new InvalidOperationException("Command is empty.");
        }
    }

    public static void EnsureMinimumArguments(
        IReadOnlyList<string> tokens,
        int minimum,
        string message)
    {
        if (tokens.Count < minimum)
        {
            throw new InvalidOperationException(message);
        }
    }
}
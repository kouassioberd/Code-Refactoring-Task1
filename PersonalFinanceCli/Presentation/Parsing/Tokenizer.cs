using System.Text;

namespace PersonalFinanceCli.Presentation.Parsing;

public static class Tokenizer
{
    public static IReadOnlyList<string> Tokenize(string commandLine)
    {
        var result = new List<string>();
        if (string.IsNullOrWhiteSpace(commandLine))
        {
            return result;
        }

        var stringBuilder = new StringBuilder();
        var inQuotes = false;

        foreach (var ch in commandLine)
        {
            if (ch == '"')
            {
                inQuotes = !inQuotes;
                continue;
            }

            if (char.IsWhiteSpace(ch) && !inQuotes)
            {
                if (stringBuilder.Length > 0)
                {
                    result.Add(stringBuilder.ToString());
                    stringBuilder.Clear();
                }
            }
            else
            {
                stringBuilder.Append(ch);
            }
        }

        if (stringBuilder.Length > 0)
        {
            result.Add(stringBuilder.ToString());
        }

        return result;
    }
}

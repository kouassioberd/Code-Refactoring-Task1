using System;

namespace PersonalFinanceCli.Presentation.Rendering;

public sealed class ConfirmationPrompt
{
    private readonly IConsole _console;

    public ConfirmationPrompt(IConsole console)
    {
        _console = console;
    }

    public bool AskYesNo(string prompt)
    {
        while (true)
        {
            _console.Write($"{prompt} ");
            var raw = _console.ReadLine();

            if (raw == null)
            {
                return false;
            }

            var value = raw.Trim();

            if (value.Equals("y", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (value.Equals("n", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            _console.WriteLine("Error: Please answer y/n.");
        }
    }

    public bool AskYesNoDefaultYes(string prompt)
    {
        while (true)
        {
            _console.Write($"{prompt} ");
            var raw = _console.ReadLine();

            if (raw == null)
            {
                return false;
            }

            var value = raw.Trim();

            if (value.Length == 0)
            {
                return true;
            }

            if (value.Equals("y", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (value.Equals("n", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            _console.WriteLine("Error: Please answer y/n.");
        }
    }

    public bool AskYesNoDefaultNo(string prompt)
    {
        while (true)
        {
            _console.Write($"{prompt} ");
            var raw = _console.ReadLine();

            if (raw == null)
            {
                return false;
            }

            var value = raw.Trim();

            if (value.Length == 0)
            {
                return false;
            }

            if (value.Equals("y", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (value.Equals("n", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            _console.WriteLine("Error: Please answer y/n.");
        }
    }

    public bool AskYesNoWithCancel(string prompt, out bool canceled)
    {
        canceled = false;

        while (true)
        {
            _console.Write($"{prompt} ");
            var raw = _console.ReadLine();

            if (raw == null)
            {
                return false;
            }

            var value = raw.Trim();

            if (value.Equals("cancel", StringComparison.OrdinalIgnoreCase))
            {
                canceled = true;
                return false;
            }

            if (value.Length == 0)
            {
                return false;
            }

            if (value.Equals("y", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (value.Equals("n", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            _console.WriteLine("Error: Please answer y/n.");
        }
    }
}
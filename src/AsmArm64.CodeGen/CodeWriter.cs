// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.CodeGen;

internal class CodeWriter : IDisposable
{
    private readonly bool _autoDispose;
    private const int IndentSize = 4;
    private int _indentLevel;
    private bool _hasNewLine;
    private readonly List<string> _prefixes;

    public CodeWriter(TextWriter writer, bool autoDispose = true)
    {
        _autoDispose = autoDispose;
        CurrentWriter = writer;
        _prefixes = new List<string>();
        _hasNewLine = true;
    }

    public TextWriter CurrentWriter { get; }

    public void Indent()
    {
        _indentLevel++;
    }

    public void PushPrefix(string prefix)
    {
        if (prefix == null) throw new ArgumentNullException(nameof(prefix));
        _prefixes.Add(prefix);
    }

    public void PopPrefix()
    {
        if (_prefixes.Count == 0) throw new InvalidOperationException("Cannot pop prefix more than push prefix");
        _prefixes.RemoveAt(_prefixes.Count - 1);
    }

    public void UnIndent()
    {
        if (_indentLevel == 0) throw new InvalidOperationException("Cannot un-indent more than indent");
        _indentLevel--;
    }

    public void OpenBraceBlock()
    {
        WriteLine("{");
        Indent();
    }

    public void CloseBraceBlock()
    {
        UnIndent();
        WriteLine("}");
    }

    public CodeWriter Write(string text)
    {
        if (text == null) throw new ArgumentNullException(nameof(text));

        var currentWriter = CurrentWriter;
        var firstEndOfLine = text.IndexOf('\n');
        var lastEndOfLine = text.LastIndexOf('\n');
        var hasTrailingEndOfLine = text.EndsWith("\n");
        var hasMultiLine = firstEndOfLine != lastEndOfLine || (firstEndOfLine >= 0 && !hasTrailingEndOfLine);

        if (hasMultiLine)
        {
            var startIndex = 0;
            var isNextNewLine = true;
            var nextStartIndex = firstEndOfLine < 0 ? text.Length : firstEndOfLine + 1;

            while (true)
            {
                if (_hasNewLine)
                {
                    WriteIndentAndPrefix();
                    _hasNewLine = false;
                }
                _hasNewLine = isNextNewLine;

                var subText = NormalizeLine(text.Substring(startIndex, nextStartIndex - startIndex));

                currentWriter.Write(subText);
                startIndex = nextStartIndex;

                if (startIndex >= text.Length)
                {
                    break;
                }

                nextStartIndex = text.IndexOf('\n', startIndex);
                if (nextStartIndex < 0)
                {
                    isNextNewLine = false;
                    nextStartIndex = text.Length;
                }
                else
                {
                    isNextNewLine = true;
                    nextStartIndex += 1;
                }
            }
        }
        else
        {
            var normalizedLineText = NormalizeLine(text);

            if (_hasNewLine)
            {
                WriteIndentAndPrefix();
                _hasNewLine = false;
            }

            currentWriter.Write(normalizedLineText);
        }

        _hasNewLine = hasTrailingEndOfLine;
        return this;
    }

    private string NormalizeLine(string text)
    {
        // Make sure that we are only using our NewLine and not the one provided
        if (text.EndsWith("\n"))
        {
            text = text.TrimEnd('\r', '\n');
            return $"{text}{Environment.NewLine}";
        }

        return text;
    }

    private void WriteIndentAndPrefix()
    {
        WriteIndent();
        WritePrefix();
    }

    private void WriteIndent()
    {
        var currentWriter = CurrentWriter;
        if (currentWriter == null)
        {
            throw new InvalidOperationException($"The {nameof(CurrentWriter)} of this instance cannot be null");
        }

        var indentSize = IndentSize;

        for (int i = 0; i < _indentLevel; i++)
        {
            for (int j = 0; j < indentSize; j++)
            {
                currentWriter.Write(" ");
            }
        }
    }

    private void WritePrefix()
    {
        var currentWriter = CurrentWriter;

        if (currentWriter == null)
        {
            throw new InvalidOperationException($"The {nameof(CurrentWriter)} of this instance cannot be null");
        }

        // Print all prefixes after indent
        foreach (var prefix in _prefixes)
        {
            currentWriter.Write(prefix);
        }
    }

    public void WriteSummary(string summary, bool compact = false)
    {
        if (compact)
        {
            WriteDoc($"<summary>{summary}</summary>");
        }
        else
        {
            WriteDoc("<summary>", summary, "</summary>");
        }
    }

    public void WriteDoc(params string[] lines)
    {
        PushPrefix("/// ");
        foreach (var line in lines)
        {
            WriteLine(line);
        }
        PopPrefix();
    }

    public CodeWriter WriteLine(string text)
    {
        Write(text);
        WriteLine();
        return this;
    }

    public CodeWriter WriteLine()
    {
        Write(Environment.NewLine);
        return this;
    }

    /// <inheritdoc />
    public override string? ToString()
    {
        return CurrentWriter.ToString();
    }

    public void Dispose()
    {
        if (_autoDispose)
        {
            CurrentWriter.Dispose();
        }
    }
}
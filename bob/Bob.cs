using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Statement
{
    public string statement;

    public Statement(string statement)
    {
        this.statement = statement;
    }

    public bool isQuestion()
    {
        string cleanString = this.statement.Replace(" ", "");
        return cleanString[cleanString.Length - 1] == '?';
    }

    public bool isNothing()
    {
        return string.IsNullOrEmpty(this.statement) || string.IsNullOrWhiteSpace(this.statement);
    }

    public bool isYell()
    {
        bool letterCheck = this.statement.Any(x => char.IsLetter(x));
        return (letterCheck && this.statement.ToUpper() == this.statement);
    }
}

public static class Bob
{
    public static string Response(string statement)
    {
        Statement declaration = new Statement(statement);
        string response = "Whatever.";

        if (declaration.isNothing())
            {
                response = "Fine. Be that way!";
            }
        else
        {
            if (declaration.isYell())
            {
                response = "Whoa, chill out!";
                if (declaration.isQuestion())
                {
                    response = "Calm down, I know what I'm doing!";
                }

            } else {
                if (declaration.isQuestion())
                {
                    response = "Sure.";
                }
            }
        }

        return response;
    }
}
using System;

public class Statement
{
    public string statement;

    public Statement(string statement)
    {
        this.statement = statement;
    }

    public bool isQuestion()
    {
        return this.statement[this.statement.Length - 1] == '?';
    }

    public bool isNothing()
    {
        return (this.statement.Length == 0);
    }

    public bool isYell()
    {
        return (this.statement.ToUpper() == this.statement);
    }
}

public static class Bob
{
    public static string Response(string statement)
    {
        Statement declaration = new Statement(statement);
        string response = "Whatever.";

        if (declaration.isYell())
        {
            if (declaration.isQuestion())
            {
                response = "Calm down, I know what I'm doing!";
                return response;
            }

            response = "Whoa, chill out!";
            return response;
        }

        if (declaration.isQuestion())
        {
            response = "Sure.";
            return response;
        }

        if (declaration.isNothing())
        {
            response = "Fine. Be that way!";
            return response;
        }

        return response;
    }
}
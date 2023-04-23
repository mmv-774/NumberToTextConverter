using NumberToTextConverter.Enums;

namespace NumberToTextConverter.Helpers;

public class PrepositionalHelper : CaseHelper
{
    public override string Zero => "ноле";

    protected override string One(Gender gender)
    {
        return gender switch
        {
            Gender.Male => "одном",
            Gender.Female => "одной",
            Gender.Neuter => "одном",
            _ => throw new NotImplementedException(),
        };
    }

    protected override string Two(Gender gender)
    {
        return gender switch
        {
            Gender.Male => "двух",
            Gender.Female => "двух",
            Gender.Neuter => "двух",
            _ => throw new NotImplementedException(),
        };
    }

    protected override Dictionary<long, string> Units => new()
    {
        { 3, "трех" },
        { 4, "четырех" },
        { 5, "пяти" },
        { 6, "шести" },
        { 7, "семи" },
        { 8, "восьми" },
        { 9, "девяти" },
        { 10, "десяти" },
        { 11, "одиннадцати" },
        { 12, "двенадцати" },
        { 13, "тринадцати" },
        { 14, "четырнадцати" },
        { 15, "пятнадцати" },
        { 16, "шестнадцати" },
        { 17, "семнадцати" },
        { 18, "восемнадцати" },
        { 19, "девятнадцати" },
    };

    protected override Dictionary<long, string> Tens => new()
    {
        { 1, "десяти" },
        { 2, "двадцати" },
        { 3, "тридцати" },
        { 4, "сорока" },
        { 5, "пятьдесяти" },
        { 6, "шестьдесяти" },
        { 7, "семьдесяти" },
        { 8, "восемьдесяти" },
        { 9, "девяноста" },
    };

    protected override Dictionary<long, string> Hundreds => new()
    {
        { 1, "ста" },
        { 2, "двухстах" },
        { 3, "трехстах" },
        { 4, "четырехстах" },
        { 5, "пятистах" },
        { 6, "шестистах" },
        { 7, "семистах" },
        { 8, "восьмистах" },
        { 9, "девятистах" },
    };

    public override string PrefixOfThousands(long number)
    {
        return number == 1 ? "тысяче" : "тысячах";
    }

    public override string PrefixOfMillion(long number)
    {
        return number == 1 ? "миллионе" : "миллионах";
    }

    public override string PrefixOfBillion(long number)
    {
        return number == 1 ? "миллиарде" : "миллиардах";
    }
}
using NumberToTextConverter.Enums;

namespace NumberToTextConverter.Helpers;

public class CreativeHelper : CaseHelper
{
    public override string Zero => "нолем";

    protected override string One(Gender gender)
    {
        return gender switch
        {
            Gender.Male => "одним",
            Gender.Female => "одной",
            Gender.Neuter => "одними",
            _ => throw new NotImplementedException(),
        };
    }

    protected override string Two(Gender gender)
    {
        return gender switch
        {
            Gender.Male => "двумя",
            Gender.Female => "двумя",
            Gender.Neuter => "двумя",
            _ => throw new NotImplementedException(),
        };
    }

    protected override Dictionary<long, string> Units => new()
    {
        { 3, "тремя" },
        { 4, "четырьмя" },
        { 5, "пятью" },
        { 6, "шестью" },
        { 7, "семью" },
        { 8, "восьмью" },
        { 9, "девятью" },
        { 10, "десятью" },
        { 11, "одиннадцатью" },
        { 12, "двенадцатью" },
        { 13, "тринадцатью" },
        { 14, "четырнадцатью" },
        { 15, "пятнадцатью" },
        { 16, "шестнадцатью" },
        { 17, "семнадцатью" },
        { 18, "восемнадцатью" },
        { 19, "девятнадцатью" },
    };

    protected override Dictionary<long, string> Tens => new()
    {
        { 1, "десятью" },
        { 2, "двадцатью" },
        { 3, "тридцатью" },
        { 4, "сорока" },
        { 5, "пятьюдесятью" },
        { 6, "шестьюдесятью" },
        { 7, "семьюдесятью" },
        { 8, "восьмьюдесятью" },
        { 9, "девяноста" },
    };

    protected override Dictionary<long, string> Hundreds => new()
    {
        { 1, "ста" },
        { 2, "двумястами" },
        { 3, "тремястами" },
        { 4, "четырьмястами" },
        { 5, "пятьюстами" },
        { 6, "шестьюстами" },
        { 7, "семьюстами" },
        { 8, "восемьюстами" },
        { 9, "девятьюстами" },
    };

    public override string PrefixOfThousands(long number)
    {
        return number == 1 ? "тысячей" : "тысячами";
    }

    public override string PrefixOfMillion(long number)
    {
        return number == 1 ? "миллионом" : "миллионами";
    }

    public override string PrefixOfBillion(long number)
    {
        return number == 1 ? "миллиардом" : "миллиардами";
    }
}
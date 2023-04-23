using NumberToTextConverter.Enums;

namespace NumberToTextConverter.Helpers;

public class AccusativeHelper : CaseHelper
{
    public override string Zero => "ноль";

    protected override string One(Gender gender)
    {
        return gender switch
        {
            Gender.Male => "один",
            Gender.Female => "одну",
            Gender.Neuter => "одно",
            _ => throw new NotImplementedException(),
        };
    }

    protected override string Two(Gender gender)
        {
            return gender switch
            {
                Gender.Male => "два",
                Gender.Female => "две",
                Gender.Neuter => "два",
                _ => throw new NotImplementedException(),
            };
        }

        protected override Dictionary<long, string> Units => new()
        {
            {3, "три" },
            {4, "четыре" },
            {5, "пять" },
            {6, "шесть" },
            {7, "семь" },
            {8, "восемь" },
            {9, "девять" },
            {10, "десять" },
            {11, "одинадцать" },
            {12, "двенадцать" },
            {13, "тринадцать" },
            {14, "четырнадцать" },
            {15, "пятнадцать" },
            {16, "шестнадцать" },
            {17, "семнадцать" },
            {18, "восемнадцать" },
            {19, "девятнадцать" },
        };

        protected override Dictionary<long, string> Tens => new()
        {
            { 1, "десять" },
            { 2, "двадцать" },
            { 3, "тридцать"},
            { 4, "сорок"},
            { 5, "пятьдесят"},
            { 6, "шестьдесят"},
            { 7, "семьдесят"},
            { 8, "восемьдесят"},
            { 9, "девяносто"},
        };

        protected override Dictionary<long, string> Hundreds => new()
        {
            { 1, "сто"},
            { 2, "двести"},
            { 3, "триста"},
            { 4, "четыреста"},
            { 5, "пятьсот"},
            { 6, "шестьсот"},
            { 7, "семьсот"},
            { 8, "восемьсот"},
            { 9, "девятьсот"},
        };

        public override string PrefixOfThousands(long number)
        {
            return number switch
            {
                1 => "тысячу",
                > 1 and < 5 => "тысячи",
                _ => "тысяч"
            };
        }

        public override string PrefixOfMillion(long number)
        {
            return number switch
            {
                1 => "миллион",
                > 1 and < 5 => "миллиона",
                _ => "миллионов"
            };
        }

        public override string PrefixOfBillion(long number)
        {
            return number switch
            {
                1 => "миллиард",
                > 1 and < 5 => "миллиарда",
                _ => "миллиардов"
            };
        }
}
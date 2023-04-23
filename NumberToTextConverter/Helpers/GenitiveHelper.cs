using NumberToTextConverter.Enums;

namespace NumberToTextConverter.Helpers
{
    public class GenitiveHelper : CaseHelper
    {
        public override string Zero => "ноля";
        
        protected override string One(Gender gender)
        {
            return gender switch
            {
                Gender.Male => "одного",
                Gender.Female => "одной",
                Gender.Neuter => "одного",
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
            {3, "трех" },
            {4, "четырех" },
            {5, "пяти" },
            {6, "шести" },
            {7, "семи" },
            {8, "восьми" },
            {9, "девяти" },
            {10, "десяти" },
            {11, "одиннадцати" },
            {12, "двенадцати" },
            {13, "тринадцати" },
            {14, "четырнадцати" },
            {15, "пятнадцати" },
            {16, "шестнадцати" },
            {17, "семнадцати" },
            {18, "восемнадцати" },
            {19, "девятнадцати" },
        };

        protected override Dictionary<long, string> Tens => new()
        {
            { 1, "десяти" },
            { 2, "двадцати" },
            { 3, "тридцати"},
            { 4, "сорока"},
            { 5, "пятьдесяти"},
            { 6, "шестьдесяти"},
            { 7, "семьдесяти"},
            { 8, "восемьдесяти"},
            { 9, "девяноста"},
        };

        protected override Dictionary<long, string> Hundreds => new()
        {
            { 1, "ста"},
            { 2, "двухсот"},
            { 3, "трехсот"},
            { 4, "четырехсот"},
            { 5, "пятисот"},
            { 6, "шестисот"},
            { 7, "семисот"},
            { 8, "восьмисот"},
            { 9, "девятисот"},
        };

        public override string PrefixOfThousands(long number)
        {
            return number == 1 ? "тысячи" : "тысяч";
        }

        public override string PrefixOfMillion(long number)
        {
            return number == 1 ? "миллиона" : "миллионов";
        }

        public override string PrefixOfBillion(long number)
        {
            return number == 1 ? "миллиарда" : "миллиардов";
        }
    }
}

using NumberToTextConverter.Enums;

namespace NumberToTextConverter.Helpers
{
    public class DativeHelper : CaseHelper
    {
        public override string Zero => "нолю";
        
        protected override string One(Gender gender)
        {
            return gender switch
            {
                Gender.Male => "одному",
                Gender.Female => "одной",
                Gender.Neuter => "одному",
                _ => throw new NotImplementedException(),
            };
        }

        protected override string Two(Gender gender)
        {
            return gender switch
            {
                Gender.Male => "двум",
                Gender.Female => "двум",
                Gender.Neuter => "двум",
                _ => throw new NotImplementedException(),
            };
        }

        protected override Dictionary<long, string> Units => new()
        {
            {3, "трем" },
            {4, "четырем" },
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
            { 2, "двумстам"},
            { 3, "тремстам"},
            { 4, "четыремстам"},
            { 5, "пятистам"},
            { 6, "шестистам"},
            { 7, "семистам"},
            { 8, "восьмистам"},
            { 9, "девятистам"},
        };

        public override string PrefixOfThousands(long number)
        {
            return number == 1 ? "тысяче" : "тысячам";
        }

        public override string PrefixOfMillion(long number)
        {
            return number == 1 ? "миллиону" : "миллионам";
        }

        public override string PrefixOfBillion(long number)
        {
            return number == 1 ? "миллиарду" : "миллиардам";
        }
    }
}

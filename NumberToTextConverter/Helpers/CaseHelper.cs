using NumberToTextConverter.Enums;

namespace NumberToTextConverter.Helpers
{
    public abstract class CaseHelper
    {
        public string GetUnit(long key, Gender gender)
        {
            if (Units.TryGetValue(key, out var value))
            {
                return value;
            }

            return key switch
            {
                1 => One(gender),
                2 => Two(gender),
                _ => string.Empty
            };
        }

        public string GetTen(long key)
        {
            return Tens.TryGetValue(key, out var value) ? value : string.Empty;
        }

        public string GetHundred(long key)
        {
            return Hundreds.TryGetValue(key, out var value) ? value : string.Empty;
        }

        public abstract string Zero { get; }
        protected abstract string One(Gender gender);
        protected abstract string Two(Gender gender);
        protected abstract Dictionary<long, string> Units { get; }
        protected abstract Dictionary<long, string> Tens { get; }
        protected abstract Dictionary<long, string> Hundreds { get; }
        public abstract string PrefixOfThousands(long number);
        public abstract string PrefixOfMillion(long number);
        public abstract string PrefixOfBillion(long number);
    }
}

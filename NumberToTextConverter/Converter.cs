using NumberToTextConverter.Enums;
using NumberToTextConverter.Factories;
using NumberToTextConverter.Helpers;

namespace NumberToTextConverter
{
    public static class Converter
    {
        public static string NumberToText(long number, Gender gender, Case caseType)
        {
            var result = Convert(number, gender, caseType);
            return result.JoinToString();
        }

        private static List<string> Convert(long number, Gender gender, Case caseType)
        {
            var words = new List<string>();
            var helper = CaseHelperFactory.GetHelper(caseType);
            
            if (number == 0)
            {
                words.Add(helper.Zero);
                return words;
            }

            if (number < 0)
            {
                words.Add("минус");
                number = Math.Abs(number);
            }

            var digit = number / 1_000_000_000;
            if (digit > 0)
            {
                words.AddRange(Convert(digit, Gender.Male, caseType));
                words.Add(helper.PrefixOfBillion(digit % 10));
                number %= 1_000_000_000;
            }

            digit = number / 1_000_000;
            if (digit > 0)
            {
                words.AddRange(Convert(digit, Gender.Male, caseType));
                words.Add(helper.PrefixOfMillion(digit % 10));
                number %= 1_000_000;
            }

            digit = number / 1000;
            if (digit > 0)
            {
                words.AddRange(Convert(digit, Gender.Female, caseType));
                words.Add(helper.PrefixOfThousands(digit % 10));
                number %= 1000;
            }

            digit = number / 100;
            if (digit > 0)
            {
                var hundred = helper.GetHundred(digit);
                words.Add(hundred);
                number %= 100;
            }

            if (number <= 0) return words;
            var unit = helper.GetUnit(number, gender);
            if (!string.IsNullOrEmpty(unit))
            {
                words.Add(unit);
                return words;
            }

            digit = number / 10;
            if (digit > 0)
            {
                var ten = helper.GetTen(digit);
                words.Add(ten);
                number %= 10;
            }

            if (number <= 0) return words;
            unit = helper.GetUnit(number, gender);
            if (string.IsNullOrEmpty(unit)) return words;
            words.Add(unit);
            return words;
        }

        private static string JoinToString(this IEnumerable<string> list)
        {
            return string.Join(" ", list);
        }
    }
}

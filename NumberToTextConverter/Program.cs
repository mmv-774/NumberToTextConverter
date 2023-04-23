using NumberToTextConverter.Enums;

namespace NumberToTextConverter
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Converter.NumberToText(999_999_999_999, Gender.Male, Case.Nominative));
            Console.WriteLine(Converter.NumberToText(999_999_999_999, Gender.Male, Case.Genitive));
            Console.WriteLine(Converter.NumberToText(999_999_999_999, Gender.Male, Case.Dative));
            Console.WriteLine(Converter.NumberToText(999_999_999_999, Gender.Male, Case.Accusative));
            Console.WriteLine(Converter.NumberToText(999_999_999_999, Gender.Male, Case.Creative));
            Console.WriteLine(Converter.NumberToText(999_999_999_999, Gender.Male, Case.Prepositional));
        }
    }
}
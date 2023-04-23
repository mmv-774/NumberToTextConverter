using NumberToTextConverter.Enums;
using NumberToTextConverter.Helpers;

namespace NumberToTextConverter.Factories
{
    public static class CaseHelperFactory
    {
        public static CaseHelper GetHelper(Case caseType)
        {
            return caseType switch
            {
                Case.Nominative => new NominativeHelper(),
                Case.Genitive => new GenitiveHelper(),
                Case.Dative => new DativeHelper(),
                Case.Accusative => new AccusativeHelper(),
                Case.Creative => new CreativeHelper(),
                Case.Prepositional => new PrepositionalHelper(),
                _ => throw new NotSupportedException(),
            };
        }
    }
}

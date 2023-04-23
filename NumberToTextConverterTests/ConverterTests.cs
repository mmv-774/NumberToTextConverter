using NumberToTextConverter;
using NumberToTextConverter.Enums;

namespace NumberToTextConverterTests;

[TestFixture]
public class ConverterTests
{
    [TestCaseSource(nameof(RightResultTestCases))]
    public void NumberToText_WhenCalled_ReturnRightResult((long number, Gender gender, Case caseType, string result) testCase)
    {
        //Arrange
        var number = testCase.number;
        var gender = testCase.gender;
        var caseType = testCase.caseType;
        var rightResult = testCase.result;
        
        //Act
        var result = Converter.NumberToText(number, gender, caseType);
        
        //Assert
        Assert.That(result, Is.EqualTo(rightResult));
    }

    private static IEnumerable<(long, Gender, Case, string)> RightResultTestCases()
    {
        const long number1 = 31;
        const Gender gender1 = Gender.Male;
        const Case caseType1 = Case.Genitive;
        const string result1 = "тридцати одного";
        
        const long number2 = 22;
        const Gender gender2 = Gender.Neuter;
        const Case caseType2 = Case.Creative;
        const string result2 = "двадцатью двумя";
        
        const long number3 = 154323;
        const Gender gender3 = Gender.Male;
        const Case caseType3 = Case.Nominative;
        const string result3 = "сто пятьдесят четыре тысячи триста двадцать три";
        
        const long number4 = 154323;
        const Gender gender4 = Gender.Male;
        const Case caseType4 = Case.Creative;
        const string result4 = "ста пятьюдесятью четырьмя тысячами тремястами двадцатью тремя";
        
        yield return (number1, gender1, caseType1, result1);
        yield return (number2, gender2, caseType2, result2);
        yield return (number3, gender3, caseType3, result3);
        yield return (number4, gender4, caseType4, result4);
    }
}
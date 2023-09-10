namespace MyWebAppTests;
using NumericWordsConversion; // Adjust the namespace as needed

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class CurrencyWordsConverterTests
{
    [TestMethod]
    public void ConvertToWords_ValidInput()
    {
        // Arrange
        var converter = new CurrencyWordsConverter(new CurrencyWordsConversionOptions()
        {
            Culture = Culture.International,
            OutputFormat = OutputFormat.English,
            CurrencyUnitSeparator = "and",
            CurrencyUnit = "dollars",
            SubCurrencyUnit = "cents",
            EndOfWordsMarker = ""
        });

        // Act
        string result = converter.ToWords(123.45M);

        // Assert
        Assert.AreEqual("One hundred twenty three dollars and forty five cents", result);
    }

    [TestMethod]
    public void ConvertToWords_ZeroCents()
    {
        // Arrange
        var converter = new CurrencyWordsConverter(new CurrencyWordsConversionOptions()
        {
            Culture = Culture.International,
            OutputFormat = OutputFormat.English,
            CurrencyUnitSeparator = "and",
            CurrencyUnit = "dollars",
            SubCurrencyUnit = "cents",
            EndOfWordsMarker = ""
        });

        // Act
        string result = converter.ToWords(123.00M);

        // Assert
        Assert.AreEqual("One hundred twenty three dollars", result);
    }

}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NumericWordsConversion;
using System.Text.RegularExpressions;

namespace MyWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync(string inputNumber)
        {
            try
            {
                // Get the input from the request body with the key inputNumber
                var input = inputNumber;
                CurrencyWordsConverter converter = new CurrencyWordsConverter(new CurrencyWordsConversionOptions()
                {
                    Culture = Culture.International,
                    OutputFormat = OutputFormat.English,
                    CurrencyUnitSeparator = "and",
                    CurrencyUnit = "dollars",
                    SubCurrencyUnit = "cents",
                    EndOfWordsMarker = ""
                });
                string words = await Task.Run(() => converter.ToWords(Decimal.Parse(input)));

                string output = words;



                if (output.Contains("trillion") && !output.Contains("trillion dollars"))
                {
                    output = output.Replace("trillion", "trillion and");
                }
                else if (output.Contains("billion") && !output.Contains("billion dollars"))
                {
                    output = output.Replace("billion", "billion and");
                }
                else if (output.Contains("million") && !output.Contains("million dollars"))
                {
                    output = output.Replace("million", "million and");
                }
                else if (output.Contains("thousand") && !output.Contains("thousand dollars"))
                {
                    output = output.Replace("thousand", "thousand and");
                }
                else if (output.Contains("hundred") && !output.Contains("hundred dollars"))
                {
                    output = output.Replace("hundred", "hundred and");
                }

                // add code here

                Console.WriteLine($"Input: {input}");
                Console.WriteLine($"Output: {output}");

                // Return the output as JSON
                return new JsonResult(new { output });
            }
            catch (System.Exception)
            {
                return new JsonResult(new { output = "Something went Wrong" });
            }

        }
    }
}

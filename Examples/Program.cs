using GoogleTranslator;
using System;
//using System.Threading.Tasks;

namespace Examples
{
  class Program
  {
    static  void Main(string[] args)
    {
      TranslateExamle2();

      Console.ReadKey();
    }

    static async void TranslateExamle()
    {
      Console.WriteLine("Translate: Hello World!");

      //Dịch văn bản "Hello Work" sang tiếng việt
      var result = await TranslateService.TranslateAsync(sourceText: "Hello world", languageSourceCode: "en", languageDestinationCode: "vi");

      //In kết quả
      Console.WriteLine($"Result: {result.Sentences[0].Translated}");

      Console.ReadKey();
    }


    static void TranslateExamle2()
    {
      Console.WriteLine("Translate: Hello World!");

      //Dịch văn bản "Hello Work" sang tiếng việt
      var result = TranslateService.Translate(sourceText: "Hello world", languageSourceCode: "en", languageDestinationCode: "vi");

      //In kết quả
      Console.WriteLine($"Result: {result.Sentences[0].Translated}");

      Console.ReadKey();
    }
  }
}

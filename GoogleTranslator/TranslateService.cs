using System;
using System.Threading.Tasks;
using System.Web;
using RestSharp;

namespace GoogleTranslator
{
  public class TranslateService
  {

    //private const string RequestUserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:91.0) Gecko/20100101 Firefox/91.0";
    private const string RequestGoogleTranslatorUrl = "https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&hl=en&dt=t&dt=bd&dj=1&source=icon&tk=467103.467103&q={2}";

    static string CreateApiUrl(string sourceText, string languageSourceCode, string languageDestinationCode)
    {
      sourceText = HttpUtility.UrlEncode(sourceText);
      return string.Format(RequestGoogleTranslatorUrl, languageSourceCode, languageDestinationCode, sourceText);
    }

    /// <summary>
    /// Dịch văn bản (sourceText). Yêu cầu kết nối internet.
    /// </summary>
    /// <param name="sourceText">Văn bản cần dịch</param>
    /// <param name="languageSourceCode">Mã ngôn ngữ của văn bản cần dịch. Nếu đặt là auto thì sẽ tự động phát hiện ngôn ngữ.</param>
    /// <param name="languageDestinationCode">Mã ngôn ngữ cần dịch sang.</param>
    /// <returns></returns>
    public static TranslateResult Translate(string sourceText, string languageSourceCode, string languageDestinationCode)
    {
      var url = CreateApiUrl(sourceText, languageSourceCode, languageDestinationCode);
      var client = new RestClient(url);
      var request = new RestRequest(Method.GET);
      var response = client.Get(request);
      return TranslateResult.FromJson(response.Content);
    }

    /// <summary>
    /// Dịch văn bản (sourceText). Yêu cầu kết nối internet.
    /// </summary>
    /// <param name="sourceText">Văn bản cần dịch</param>
    /// <param name="languageSourceCode">Mã ngôn ngữ của văn bản cần dịch. Nếu đặt là auto thì sẽ tự động phát hiện ngôn ngữ. Vd: auto hoặc vi = vietnam, en = english </param>
    /// <param name="languageDestinationCode">Mã ngôn ngữ cần dịch sang. vd: vi (vietnamese), en = (english).</param>
    /// <returns></returns>
    public static Task<TranslateResult> TranslateAsync(string sourceText, string languageSourceCode, string languageDestinationCode)
    {
      var url = CreateApiUrl(sourceText, languageSourceCode, languageDestinationCode);
      var client = new RestClient(url);
      var request = new RestRequest(Method.GET);
      var _res = client.GetAsync<string>(request);
      return client.GetAsync<TranslateResult>(request);
    }
  }

}


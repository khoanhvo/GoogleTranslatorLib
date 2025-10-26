using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleTranslator
{
  using System;
  using System.Collections.Generic;

  using System.Globalization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  public partial class TranslateResult
  {
    [JsonProperty("sentences")]
    public List<Sentence> Sentences { get; set; }

    [JsonProperty("src")]
    public string Source { get; set; }

    [JsonProperty("confidence")]
    public double Confidence { get; set; }

    //[JsonProperty("spell")]
    //public Spell Spell { get; set; }

    [JsonProperty("ld_result")]
    public LdResult LdResult { get; set; }
  }

  public partial class LdResult
  {
    [JsonProperty("srclangs")]
    public List<string> Srclangs { get; set; }

    [JsonProperty("srclangs_confidences")]
    public List<double> SrclangsConfidences { get; set; }

    [JsonProperty("extended_srclangs")]
    public List<string> ExtendedSrclangs { get; set; }
  }

  public partial class Sentence
  {
    [JsonProperty("trans")]
    public string Translated { get; set; }

    [JsonProperty("orig")]
    public string Origin { get; set; }

    //[JsonProperty("backend")]
    //public long Backend { get; set; }
  }

  //public partial class Spell
  //{
  //}

  public partial class TranslateResult
  {
    public static TranslateResult FromJson(string json) => JsonConvert.DeserializeObject<TranslateResult>(json, Converter.Settings);
  }

  public static class Serialize
  {
    public static string ToJson(this TranslateResult self) => JsonConvert.SerializeObject(self, Converter.Settings);
  }

  internal static class Converter
  {
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
      MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
      DateParseHandling = DateParseHandling.None,
      Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
    };
  }
}

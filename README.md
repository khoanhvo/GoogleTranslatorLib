# Google Translator Library

[![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)

> **A free text translation library using Google Translate API**

A simple and efficient .NET library for translating text using Google Translate's free API. Supports automatic language detection and translation between hundreds of different languages.

## ✨ Features

- 🔍 **Automatic Language Detection** - Automatically detects the language of input text
- 🌐 **Multi-language Translation** - Supports translation between hundreds of languages
- ⚡ **Sync & Async** - Supports both synchronous and asynchronous methods
- 📝 **Long Text Translation** - Can translate words, phrases, and long text passages
- 🆓 **Free** - Uses Google Translate's free API

## 📦 Installation

### Add Reference to Project

1. Download or clone this repository
2. Add project reference to your solution:

```xml
<ProjectReference Include="path\to\GoogleTranslator\GoogleTranslator.csproj" />
```

### Build from Source

```bash
git clone https://github.com/yourusername/GoogleTranslator.git
cd GoogleTranslator
dotnet build
```

## 🚀 Usage

### Synchronous Translation

```csharp
using GoogleTranslator;

Console.WriteLine("Translate: Hello World!");

// Translate "Hello world!" to Vietnamese
var result = TranslateService.Translate(
    sourceText: "Hello world!",
    languageSourceCode: "auto", // Auto-detect language
    languageDestinationCode: "vi" // Translate to Vietnamese
);

// Print result
Console.WriteLine($"Result: {result.Sentences[0].Translated}");
// Output: Result: Xin chào thế giới!
```

### Asynchronous Translation

```csharp
using GoogleTranslator;

Console.WriteLine("Translate: Hello World!");

// Translate "Hello world!" to Vietnamese (async)
var result = await TranslateService.TranslateAsync(
    sourceText: "Hello world!",
    languageSourceCode: "auto",
    languageDestinationCode: "vi"
);

// Print result
Console.WriteLine($"Result: {result.Sentences[0].Translated}");
```

### Advanced Example

```csharp
using GoogleTranslator;

// Translate from English to Japanese
var result = await TranslateService.TranslateAsync(
    sourceText: "The quick brown fox jumps over the lazy dog",
    languageSourceCode: "en",
    languageDestinationCode: "ja"
);

Console.WriteLine($"Source text: {result.SourceText}");
Console.WriteLine($"Detected language: {result.SourceLanguage}");
Console.WriteLine($"Translation: {result.Sentences[0].Translated}");
```

## 🌍 Supported Language Codes

| Language    | Code   |
| ----------- | ------ |
| Vietnamese  | `vi`   |
| English     | `en`   |
| Chinese     | `zh`   |
| Japanese    | `ja`   |
| Korean      | `ko`   |
| French      | `fr`   |
| German      | `de`   |
| Spanish     | `es`   |
| Auto-detect | `auto` |

_And many more languages..._

## 📋 System Requirements

- .NET Standard 2.1+
- .NET Core 3.1+
- .NET 5.0+
- .NET Framework 4.7.2+

## 🤝 Contributing

We welcome all contributions! Please read the [contributing guidelines](CONTRIBUTING.md) for more details.

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

```
MIT License

Copyright (c) 2025 Google Translator Library

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

## ⚠️ Important Notes

- This library uses Google Translate's free API and may have request limitations
- Should not be used for large-scale commercial purposes without complying with Google's terms of service
- Translation results may not be 100% perfect, especially for specialized or technical texts
- Consider implementing rate limiting and error handling for production use

## 📞 Contact

- **Issues**: [GitHub Issues](https://github.com/yourusername/GoogleTranslator/issues)
- **Discussions**: [GitHub Discussions](https://github.com/yourusername/GoogleTranslator/discussions)

---

⭐ If this project is helpful, please give us a star on GitHub!

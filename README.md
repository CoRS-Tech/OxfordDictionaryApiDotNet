 # OxfordDictionariesDotNet
An unofficial .NET package that wraps up the Oxford Languages API.

# Setup

1) First, obtain your App ID and App Key from https://developer.oxforddictionaries.com/.

Note: On Novemeber 20th, Oxford Dictionaries announced that starting April 1st, 2024, all plans except the Business plan will be discontinued.

2) Install the package:
   
Nuget: ```NuGet\Install-Package OxfordDictionaryApiDotNet```

Project: ```<PackageReference Include="OxfordDictionaryApiDotNet"/>```

.NET CLI: ```dotnet add package OxfordDictionaryApiDotNet```

Or simply download this repository from the 'Code' dropdown menu.

# Usage

It takes just 3 lines of code to retrieve a definition:

1) Use the Entries client to fetch information about a word:

```csharp
var entries = new EntriesClient("appId", "appKey");
var entry = await entries.FindEntryAsync("entanglement");
```

2) There are many things a word can return, but you can always use a helper method for convenience:

```csharp
var definition = entry.FindFirstDefinition();
```
The above simplifies the following process:

```csharp
var result = entry?.Results?.FirstOrDefault();
var lexEntry = result?.LexicalEntries?.FirstOrDefault();
var innerEntry = lexEntry?.Entries?.FirstOrDefault();
var sense = innerEntry?.Senses?.FirstOrDefault();
var definition = sense?.Definitions?.FirstOrDefault();
```

3) You can also define a main client that houses both the Entries and Lemmas clients:

```csharp
var config = new OxfordDictionaryClientConfig
  {
    AppId = "yourAppId",
    AppKey = "yourAppKey"
  };

var client = new OxfordDictionaryClient(config);
var entriesClient = client.EntriesClient;
var lemmasClient = client.LemmasClient;
```

# Understanding the Oxford Dictionaries API
Please note that this is not a straightforward, one-size-fits-all dictionary. A single entry can provide lots of details, most of which you won't even need.
While I have tried to provide some guidance in my XML comments, for a more in-depth understanding of how the Oxford Dictionaries API works, and their data structure,
please visit their official documentation webpage: https://developer.oxforddictionaries.com/documentation.

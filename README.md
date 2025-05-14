 # OxfordDictionariesDotNet
An unofficial .NET package that wraps up the Oxford Languages API.

# Setup

1) First, obtain your App ID and App Key from https://developer.oxforddictionaries.com/.

Note: On the 1st of April, 2024, all plans except the Business plan were discontinued.

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
To put it simply, the Oxford Languages API is complicated and very branched. It is best if your consult their official documentation to understand the structure behind their entries. Although I've also tried to use XML comments to help out a bit.

# OxfordDictionariesDotNet
An unofficial .NET wrapper for the Oxford Languages API

It only takes a few lines of code to retrieve a definition:

1) First, obtain your App Key and App Token from https://developer.oxforddictionaries.com/.
   
2) Install the package:
   
Nuget: ```NuGet\Install-Package OxfordDictionaryApiDotNet```

Project: ```<PackageReference Include="OxfordDictionaryApiDotNet"/>```

.NET CLI: ```dotnet add package OxfordDictionaryApiDotNet```

3) Initialise the main client:

```csharp
var config = new OxfordDictionaryClientConfig
  {
    AppKey = "yourAppKey",
    AppToken = "yourAppToken"
  };

var client = new OxfordDictionaryClient(config);
```
4) Use the Entries client to fetch information about a word:

```csharp
var entry = await client.EntriesClient.FindEntryAsync("entanglement");
```

5) There are many things a word can return, but you can always use a helper method for convenience:

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

# Understanding the Oxford Dictionaries API
Please note that this is not a straightforward, one-size-fits-all dictionary. A single entry can provide a wealth of data, which may initially seem confusing.
While I have tried to provide some guidance in my XML comments, for a more in-depth understanding of how the Oxford Dictionaries API works,
I recommend visiting their official documentation: https://developer.oxforddictionaries.com/documentation.

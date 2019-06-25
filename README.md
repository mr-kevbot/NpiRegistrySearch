# NpiRegistrySearch
C# Library for Querying the [NPPES NPI Registry API](https://npiregistry.cms.hhs.gov) for medical organizations and providers

**Search for Individual Provider by NPI Number**
```csharp
NpiSearch.GetIndividualByNumber(string npiNumber)
```

#

**Search for Organization Provider by NPI Number**
```csharp
NpiSearch.GetOrganizationByNumber(string npiNumber)
```

#

**Search Individual by Properties**
```csharp
NpiSearch.SearchIndividuals(string npiNumber = "", string taxonomyDescription = "", bool useFirstNameAlias = false, string firstName = "", string lastName = "", string addressPurpose = "LOCATION", string city = "", string state = "", string postalCode = "", string countryCode = "US", int limit = 200, int skip = 0)

// Example
var records = new Search().SearchIndividuals(city: "Dallas", state: "TX", taxonomyDescription: "cardiology");
```

#

**Search Individual by Properties**
```csharp
NpiSearch.SearchOrganizations(string npiNumber = "", string taxonomyDescription = "", string organizationName = "", string addressPurpose = "LOCATION", string city = "", string state = "", string postalCode = "", string countryCode = "US", int limit = 200, int skip = 0)

// Example
var records = new Search().SearchOrganizations(city: "Dallas", state: "TX", taxonomyDescription: "cardiology");
```

**Handling Search Errors**
```csharp
try
{
	var failedOrgRecords = NpiSearch.SearchOrganizations(state: "TX");
}
catch (AggregateException ex)
{
	foreach (ArgumentException exception in ex.InnerExceptions)
	{
		Console.WriteLine(exception.Message);
	}
}
```

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NpiRegistrySearch.Dtos;
using NpiRegistrySearch.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace NpiRegistrySearch
{
    public class Search
    {
        /// <summary>
        /// Retrieves a single organization NPI from the NPI number
        /// </summary>
        /// <param name="npiNumber">Exactly 10 digits</param>
        public IndividualNpiRecord GetIndividualByNumber(string npiNumber)
        {
            IEnumerable<IndividualNpiRecordDto> recordDtos = GetApiCallList<IndividualNpiRecordDto>($"https://npiregistry.cms.hhs.gov/api/?version=2.1&number={npiNumber}&enumeration_type={EnumerationType.Individual.ToString()}");

            return recordDtos.FirstOrDefault()?.ToIndividualNpiRecord();
        }

        /// <summary>
        /// Retrieves a single organization NPI from the NPI number
        /// </summary>
        /// <param name="npiNumber">Exactly 10 digits</param>
        public OrganizationNpiRecord GetOrganizationByNumber(string npiNumber)
        {
            IEnumerable<OrganizationNpiRecordDto> recordDtos = GetApiCallList<OrganizationNpiRecordDto>($"https://npiregistry.cms.hhs.gov/api/?version=2.1&number={npiNumber}&enumeration_type={EnumerationType.Organization.ToString()}");

            return recordDtos.FirstOrDefault()?.ToOrganizationNpiRecord();
        }

        /// <summary>
        /// Search the NPI API for individual providers
        /// </summary>
        /// <param name="npiNumber">Exactly 10 digits</param>
        /// <param name="taxonomyDescription">Exact Description or Exact Specialty or wildcard * after 2 characters</param>
        /// <param name="useFirstNameAlias">True or False (Other criteria required)</param>
        /// <param name="firstName">Exact name, or wildcard * after 2 characters</param>
        /// <param name="lastName">Exact name, or wildcard * after 2 characters</param>
        /// <param name="addressPurpose">LOCATION, MAILING, PRIMARY or SECONDARY. (Other criteria required)</param>
        /// <param name="city">Exact city, or wildcard * after 2 characters</param>
        /// <param name="state">2 Characters (Other criteria required)</param>
        /// <param name="postalCode">Exact Postal Code (5 digits will also return 9 digit zip + 4), or wildcard * after 2 characters</param>
        /// <param name="countryCode">Exactly 2 characters (if "US", other criteria required)</param>
        /// <param name="limit">Limit results, default = 10, max = 200</param>
        /// <param name="skip">Skip first N results, max = 1000</param>
        /// <returns></returns>
        public IEnumerable<IndividualNpiRecord> SearchIndividuals(string npiNumber = "", string taxonomyDescription = "", bool useFirstNameAlias = false, string firstName = "", string lastName = "", string addressPurpose = "LOCATION", string city = "", string state = "", string postalCode = "", string countryCode = "US", int limit = 200, int skip = 0)
        {
            string apiUrl = $"https://npiregistry.cms.hhs.gov/api/?version=2.1&number={npiNumber}&enumeration_type={EnumerationType.Individual.ToString()}&taxonomy_description={taxonomyDescription}&first_name={firstName}&use_first_name_alias={useFirstNameAlias}&last_name={lastName}&address_purpose={addressPurpose.ToString()}&city={city}&state={state}&postal_code={postalCode}&country_code={countryCode}&limit={limit}&skip={skip}";
            IEnumerable<IndividualNpiRecordDto> recordDtos = GetApiCallList<IndividualNpiRecordDto>(apiUrl);

            IEnumerable<IndividualNpiRecord> records = recordDtos.Select(x => ((IndividualNpiRecordDto)x).ToIndividualNpiRecord());

            return records;
        }

        /// <summary>
        /// Search the NPI API for organizations
        /// </summary>
        /// <param name="npiNumber">Exactly 10 digits</param>
        /// <param name="taxonomyDescription">Exact Description or Exact Specialty or wildcard * after 2 characters</param>
        /// <param name="organizationName">Exact name, or wildcard * after 2 characters</param>
        /// <param name="addressPurpose">LOCATION, MAILING, PRIMARY or SECONDARY. (Other criteria required)</param>
        /// <param name="city">Exact city, or wildcard * after 2 characters</param>
        /// <param name="state">2 Characters (Other criteria required)</param>
        /// <param name="postalCode">Exact Postal Code (5 digits will also return 9 digit zip + 4), or wildcard * after 2 characters</param>
        /// <param name="countryCode">Exactly 2 characters (if "US", other criteria required)</param>
        /// <param name="limit">Limit results, default = 10, max = 200</param>
        /// <param name="skip">Skip first N results, max = 1000</param>
        /// <returns></returns>
        public IEnumerable<OrganizationNpiRecord> SearchOrganizations(string npiNumber = "", string taxonomyDescription = "", string organizationName = "", string addressPurpose = "LOCATION", string city = "", string state = "", string postalCode = "", string countryCode = "US", int limit = 200, int skip = 0)
        {
            string apiUrl = $"https://npiregistry.cms.hhs.gov/api/?version=2.1&number={npiNumber}&enumeration_type={EnumerationType.Organization.ToString()}&taxonomy_description={taxonomyDescription}&organization_name={organizationName}&address_purpose={addressPurpose.ToString()}&city={city}&state={state}&postal_code={postalCode}&country_code={countryCode}&limit={limit}&skip={skip}";
            IEnumerable<OrganizationNpiRecordDto> recordDtos = GetApiCallList<OrganizationNpiRecordDto>(apiUrl);

            IEnumerable<OrganizationNpiRecord> records = recordDtos.Select(x => ((OrganizationNpiRecordDto)x).ToOrganizationNpiRecord());

            return records;
        }

        private T GetApiCall<T>(string apiUrl)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = client.GetAsync(apiUrl).Result)
                {
                    response.EnsureSuccessStatusCode();
                    string responseBody = response.Content.ReadAsStringAsync().Result;

                    var jsonString = JObject.Parse(responseBody).ToString();
                    return JsonConvert.DeserializeObject<T>(jsonString, serializerSettings);
                }
            }
        }


        private IEnumerable<T> GetApiCallList<T>(string apiUrl)
        {
            var returnVal = new List<T>();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = client.GetAsync(apiUrl).Result)
                {
                    response.EnsureSuccessStatusCode();
                    string responseBody = response.Content.ReadAsStringAsync().Result;

                    if (responseBody.StartsWith('['))
                        return JsonConvert.DeserializeObject<List<T>>(responseBody, serializerSettings);

                    var jsonObject = JObject.Parse(responseBody);
                    var jsonValues = jsonObject["results"];
                    foreach (var jsonValue in jsonValues)
                    {
                        var deserializedObject = JsonConvert.DeserializeObject<T>(jsonValue.ToString(), serializerSettings);
                        returnVal.Add(deserializedObject);
                    }

                }
            }

            return returnVal;
        }


        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };

    }
}

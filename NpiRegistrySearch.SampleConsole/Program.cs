using System;

namespace NpiRegistrySearch.SampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("- Search Organizations");
            Console.WriteLine("---------------------------------");
            var orgRecords = NpiSearch.SearchOrganizations(city: "Dallas", state: "TX", taxonomyDescription: "cardiology");
            foreach (var record in orgRecords)
            {
                Console.WriteLine(record.Number + ": " + record.Basic.Name);
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("- Search Individuals");
            Console.WriteLine("---------------------------------");
            var individualRecords = NpiSearch.SearchIndividuals(city: "Dallas", state: "TX", taxonomyDescription: "cardiology");
            foreach (var record in individualRecords)
            {
                Console.WriteLine(record.Number + ": " + record.Basic.FirstName + " " + record.Basic.LastName);
            }

            Console.WriteLine();
            Console.WriteLine("DONE!");
            Console.ReadKey();
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NpiRegistrySearch.Models
{
    public abstract class NpiRecord
    {
        /// <summary>
        /// NPI-1 is individual, NPI-2 is organization
        /// </summary>
        public EnumerationType EnumerationType { get; internal set; }

        /// <summary>
        /// The NPI Number
        /// </summary>
        public string Number { get; internal set; }

        /// <summary>
        /// The taxonomies (e.g. Cardiology, Hospitalist) associated with the NPI
        /// </summary>
        public IEnumerable<Taxonomy> Taxonomies { get; internal set; }

        /// <summary>
        /// last_updated_epoch convert to DateTime
        /// </summary>
        public DateTime LastUpdatedDate { get; internal set; }

        /// <summary>
        /// created_epochc converted to DateTime
        /// </summary>
        public DateTime CreatedDate { get; internal set; }


        public IEnumerable<Address> Addresses { get; internal set; }


    }
}

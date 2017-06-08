namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// </summary>
    [DataContract]
    public class GovernmentService : Service
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "GovernmentService";

        /// <summary>
        /// The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.
        /// </summary>
        [DataMember(Name = "serviceOperator")]
        public Organization ServiceOperator { get; set; }
    }
}
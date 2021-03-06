namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A hospital.
    /// </summary>
    [DataContract]
    public partial class Hospital : CivicStructureAndEmergencyServiceAndMedicalOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Hospital";

        /// <summary>
        /// A medical service available from this provider.
        /// </summary>
        [DataMember(Name = "availableService", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalProcedure, MedicalTest, MedicalTherapy>? AvailableService { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<MedicalSpecialty?>? MedicalSpecialty { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// </summary>
    [DataContract]
    public partial class MedicalProcedure : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalProcedure";

        /// <summary>
        /// Location in the body of the anatomical structure.
        /// </summary>
        [DataMember(Name = "bodyLocation", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BodyLocation { get; set; }

        /// <summary>
        /// Typical or recommended followup care after the procedure is performed.
        /// </summary>
        [DataMember(Name = "followup", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Followup { get; set; }

        /// <summary>
        /// How the procedure is performed.
        /// </summary>
        [DataMember(Name = "howPerformed", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? HowPerformed { get; set; }

        /// <summary>
        /// A factor that indicates use of this therapy for treatment and/or prevention of a condition, symptom, etc. For therapies such as drugs, indications can include both officially-approved indications as well as off-label uses. These can be distinguished by using the ApprovedIndication subtype of MedicalIndication.
        /// </summary>
        [DataMember(Name = "indication", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<MedicalIndication>? Indication { get; set; }

        /// <summary>
        /// Expected or actual outcomes of the study.
        /// </summary>
        [DataMember(Name = "outcome", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalEntity, string>? Outcome { get; set; }

        /// <summary>
        /// Typical preparation that a patient must undergo before having the procedure performed.
        /// </summary>
        [DataMember(Name = "preparation", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalEntity, string>? Preparation { get; set; }

        /// <summary>
        /// The type of procedure, for example Surgical, Noninvasive, or Percutaneous.
        /// </summary>
        [DataMember(Name = "procedureType", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MedicalProcedureType?>? ProcedureType { get; set; }

        /// <summary>
        /// The status of the study (enumerated).
        /// </summary>
        [DataMember(Name = "status", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<EventStatusType?, MedicalStudyStatus?, string>? Status { get; set; }
    }
}

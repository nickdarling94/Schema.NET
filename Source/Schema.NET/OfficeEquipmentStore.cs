namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An office equipment store.
    /// </summary>
    [DataContract]
    public class OfficeEquipmentStore : Store
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "OfficeEquipmentStore";
    }
}
namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// &lt;p&gt;The act of providing an object under an agreement that it will be returned at a later date. Reciprocal of BorrowAction.&lt;/p&gt;
    /// &lt;p&gt;Related actions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/BorrowAction"&gt;BorrowAction&lt;/a&gt;: Reciprocal of LendAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class LendAction : TransferAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LendAction";

        /// <summary>
        /// A sub property of participant. The person that borrows the object being lent.
        /// </summary>
        [DataMember(Name = "borrower", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Borrower { get; set; }
    }
}

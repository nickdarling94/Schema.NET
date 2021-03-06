namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
    [DataContract]
    public partial class Organization : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Organization";

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 106)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PostalAddress, string>? Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AggregateRating>? AggregateRating { get; set; }

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Person>? Alumni { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AdministrativeArea, GeoShape, Place, string>? AreaServed { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Brand, Organization>? Brand { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 112)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ContactPoint>? ContactPoint { get; set; }

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [DataMember(Name = "department", Order = 113)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? Department { get; set; }

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        [DataMember(Name = "dissolutionDate", Order = 114)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DissolutionDate { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 115)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 116)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Email { get; set; }

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        [DataMember(Name = "employee", Order = 117)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Employee { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 118)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? Event { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 119)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        [DataMember(Name = "founder", Order = 120)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Founder { get; set; }

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        [DataMember(Name = "foundingDate", Order = 121)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? FoundingDate { get; set; }

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        [DataMember(Name = "foundingLocation", Order = 122)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? FoundingLocation { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 123)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Funder { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 124)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 125)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OfferCatalog>? HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 126)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? HasPOS { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 127)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? IsicV4 { get; set; }

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        [DataMember(Name = "legalName", Order = 128)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? LegalName { get; set; }

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [DataMember(Name = "leiCode", Order = 129)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? LeiCode { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 130)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place, PostalAddress, string>? Location { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 131)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ImageObject, Uri>? Logo { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 132)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? MakesOffer { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 133)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Member { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 134)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, ProgramMembership>? MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 135)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Naics { get; set; }

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 136)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? NumberOfEmployees { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 137)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OwnershipInfo, Product>? Owns { get; set; }

        /// <summary>
        /// The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        [DataMember(Name = "parentOrganization", Order = 138)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? ParentOrganization { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 139)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Review>? Review { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 140)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Demand>? Seeks { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 141)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Sponsor { get; set; }

        /// <summary>
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        [DataMember(Name = "subOrganization", Order = 142)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? SubOrganization { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 143)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 144)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 145)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VatID { get; set; }
    }
}

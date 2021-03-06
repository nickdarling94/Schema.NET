namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// </summary>
    [DataContract]
    public partial class JobPosting : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "JobPosting";

        /// <summary>
        /// The title of the job.
        /// </summary>
        [DataMember(Name = "title", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Title { get; set; }

        /// <summary>
        /// The base salary of the job or of an employee in an EmployeeRole.
        /// </summary>
        [DataMember(Name = "baseSalary", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MonetaryAmount, decimal?, PriceSpecification>? BaseSalary { get; set; }

        /// <summary>
        /// Publication date for the job posting.
        /// </summary>
        [DataMember(Name = "datePosted", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DatePosted { get; set; }

        /// <summary>
        /// Educational background needed for the position.
        /// </summary>
        [DataMember(Name = "educationRequirements", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? EducationRequirements { get; set; }

        /// <summary>
        /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        /// </summary>
        [DataMember(Name = "employmentType", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? EmploymentType { get; set; }

        /// <summary>
        /// Description of skills and experience needed for the position.
        /// </summary>
        [DataMember(Name = "experienceRequirements", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ExperienceRequirements { get; set; }

        /// <summary>
        /// Organization offering the job position.
        /// </summary>
        [DataMember(Name = "hiringOrganization", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? HiringOrganization { get; set; }

        /// <summary>
        /// Description of bonus and commission compensation aspects of the job.
        /// </summary>
        [DataMember(Name = "incentiveCompensation", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? IncentiveCompensation { get; set; }

        /// <summary>
        /// The industry associated with the job position.
        /// </summary>
        [DataMember(Name = "industry", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Industry { get; set; }

        /// <summary>
        /// Description of benefits associated with the job.
        /// </summary>
        [DataMember(Name = "jobBenefits", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? JobBenefits { get; set; }

        /// <summary>
        /// A (typically single) geographic location associated with the job position.
        /// </summary>
        [DataMember(Name = "jobLocation", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? JobLocation { get; set; }

        /// <summary>
        /// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
        /// </summary>
        [DataMember(Name = "occupationalCategory", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? OccupationalCategory { get; set; }

        /// <summary>
        /// Specific qualifications required for this role.
        /// </summary>
        [DataMember(Name = "qualifications", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Qualifications { get; set; }

        /// <summary>
        /// Responsibilities associated with this role.
        /// </summary>
        [DataMember(Name = "responsibilities", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Responsibilities { get; set; }

        /// <summary>
        /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
        /// </summary>
        [DataMember(Name = "salaryCurrency", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? SalaryCurrency { get; set; }

        /// <summary>
        /// Skills required to fulfill this role.
        /// </summary>
        [DataMember(Name = "skills", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Skills { get; set; }

        /// <summary>
        /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        /// </summary>
        [DataMember(Name = "specialCommitments", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? SpecialCommitments { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? ValidThrough { get; set; }

        /// <summary>
        /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        /// </summary>
        [DataMember(Name = "workHours", Order = 224)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? WorkHours { get; set; }
    }
}

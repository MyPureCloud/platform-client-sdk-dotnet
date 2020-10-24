using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ExternalOrganization
    /// </summary>
    [DataContract]
    public partial class ExternalOrganization :  IEquatable<ExternalOrganization>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalOrganization" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalOrganization() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalOrganization" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Name">The name of the company. (required).</param>
        /// <param name="CompanyType">CompanyType.</param>
        /// <param name="Industry">Industry.</param>
        /// <param name="PrimaryContactId">PrimaryContactId.</param>
        /// <param name="Address">Address.</param>
        /// <param name="PhoneNumber">PhoneNumber.</param>
        /// <param name="FaxNumber">FaxNumber.</param>
        /// <param name="EmployeeCount">EmployeeCount.</param>
        /// <param name="Revenue">Revenue.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Websites">Websites.</param>
        /// <param name="Tickers">Tickers.</param>
        /// <param name="TwitterId">TwitterId.</param>
        /// <param name="ExternalSystemUrl">A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace..</param>
        /// <param name="ModifyDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CreateDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Trustor">Trustor.</param>
        /// <param name="Schema">The schema defining custom fields for this contact.</param>
        /// <param name="CustomFields">Custom fields defined in the schema referenced by schemaId and schemaVersion..</param>
        /// <param name="ExternalDataSources">Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param..</param>
        public ExternalOrganization(string Id = null, string Name = null, string CompanyType = null, string Industry = null, string PrimaryContactId = null, ContactAddress Address = null, PhoneNumber PhoneNumber = null, PhoneNumber FaxNumber = null, long? EmployeeCount = null, long? Revenue = null, List<string> Tags = null, List<string> Websites = null, List<Ticker> Tickers = null, TwitterId TwitterId = null, string ExternalSystemUrl = null, DateTime? ModifyDate = null, DateTime? CreateDate = null, Trustor Trustor = null, DataSchema Schema = null, Dictionary<string, Object> CustomFields = null, List<ExternalDataSource> ExternalDataSources = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.CompanyType = CompanyType;
            this.Industry = Industry;
            this.PrimaryContactId = PrimaryContactId;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.FaxNumber = FaxNumber;
            this.EmployeeCount = EmployeeCount;
            this.Revenue = Revenue;
            this.Tags = Tags;
            this.Websites = Websites;
            this.Tickers = Tickers;
            this.TwitterId = TwitterId;
            this.ExternalSystemUrl = ExternalSystemUrl;
            this.ModifyDate = ModifyDate;
            this.CreateDate = CreateDate;
            this.Trustor = Trustor;
            this.Schema = Schema;
            this.CustomFields = CustomFields;
            this.ExternalDataSources = ExternalDataSources;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// The name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CompanyType
        /// </summary>
        [DataMember(Name="companyType", EmitDefaultValue=false)]
        public string CompanyType { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name="industry", EmitDefaultValue=false)]
        public string Industry { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PrimaryContactId
        /// </summary>
        [DataMember(Name="primaryContactId", EmitDefaultValue=false)]
        public string PrimaryContactId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public ContactAddress Address { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public PhoneNumber PhoneNumber { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets FaxNumber
        /// </summary>
        [DataMember(Name="faxNumber", EmitDefaultValue=false)]
        public PhoneNumber FaxNumber { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets EmployeeCount
        /// </summary>
        [DataMember(Name="employeeCount", EmitDefaultValue=false)]
        public long? EmployeeCount { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name="revenue", EmitDefaultValue=false)]
        public long? Revenue { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Websites
        /// </summary>
        [DataMember(Name="websites", EmitDefaultValue=false)]
        public List<string> Websites { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Tickers
        /// </summary>
        [DataMember(Name="tickers", EmitDefaultValue=false)]
        public List<Ticker> Tickers { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets TwitterId
        /// </summary>
        [DataMember(Name="twitterId", EmitDefaultValue=false)]
        public TwitterId TwitterId { get; set; }
        
        
        
        /// <summary>
        /// A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.
        /// </summary>
        /// <value>A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.</value>
        [DataMember(Name="externalSystemUrl", EmitDefaultValue=false)]
        public string ExternalSystemUrl { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Trustor
        /// </summary>
        [DataMember(Name="trustor", EmitDefaultValue=false)]
        public Trustor Trustor { get; set; }
        
        
        
        /// <summary>
        /// The schema defining custom fields for this contact
        /// </summary>
        /// <value>The schema defining custom fields for this contact</value>
        [DataMember(Name="schema", EmitDefaultValue=false)]
        public DataSchema Schema { get; set; }
        
        
        
        /// <summary>
        /// Custom fields defined in the schema referenced by schemaId and schemaVersion.
        /// </summary>
        /// <value>Custom fields defined in the schema referenced by schemaId and schemaVersion.</value>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }
        
        
        
        /// <summary>
        /// Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.
        /// </summary>
        /// <value>Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.</value>
        [DataMember(Name="externalDataSources", EmitDefaultValue=false)]
        public List<ExternalDataSource> ExternalDataSources { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalOrganization {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CompanyType: ").Append(CompanyType).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  PrimaryContactId: ").Append(PrimaryContactId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  FaxNumber: ").Append(FaxNumber).Append("\n");
            sb.Append("  EmployeeCount: ").Append(EmployeeCount).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  Tickers: ").Append(Tickers).Append("\n");
            sb.Append("  TwitterId: ").Append(TwitterId).Append("\n");
            sb.Append("  ExternalSystemUrl: ").Append(ExternalSystemUrl).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  Trustor: ").Append(Trustor).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  ExternalDataSources: ").Append(ExternalDataSources).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ExternalOrganization);
        }

        /// <summary>
        /// Returns true if ExternalOrganization instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalOrganization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalOrganization other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.CompanyType == other.CompanyType ||
                    this.CompanyType != null &&
                    this.CompanyType.Equals(other.CompanyType)
                ) &&
                (
                    this.Industry == other.Industry ||
                    this.Industry != null &&
                    this.Industry.Equals(other.Industry)
                ) &&
                (
                    this.PrimaryContactId == other.PrimaryContactId ||
                    this.PrimaryContactId != null &&
                    this.PrimaryContactId.Equals(other.PrimaryContactId)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) &&
                (
                    this.FaxNumber == other.FaxNumber ||
                    this.FaxNumber != null &&
                    this.FaxNumber.Equals(other.FaxNumber)
                ) &&
                (
                    this.EmployeeCount == other.EmployeeCount ||
                    this.EmployeeCount != null &&
                    this.EmployeeCount.Equals(other.EmployeeCount)
                ) &&
                (
                    this.Revenue == other.Revenue ||
                    this.Revenue != null &&
                    this.Revenue.Equals(other.Revenue)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.Websites == other.Websites ||
                    this.Websites != null &&
                    this.Websites.SequenceEqual(other.Websites)
                ) &&
                (
                    this.Tickers == other.Tickers ||
                    this.Tickers != null &&
                    this.Tickers.SequenceEqual(other.Tickers)
                ) &&
                (
                    this.TwitterId == other.TwitterId ||
                    this.TwitterId != null &&
                    this.TwitterId.Equals(other.TwitterId)
                ) &&
                (
                    this.ExternalSystemUrl == other.ExternalSystemUrl ||
                    this.ExternalSystemUrl != null &&
                    this.ExternalSystemUrl.Equals(other.ExternalSystemUrl)
                ) &&
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
                ) &&
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) &&
                (
                    this.Trustor == other.Trustor ||
                    this.Trustor != null &&
                    this.Trustor.Equals(other.Trustor)
                ) &&
                (
                    this.Schema == other.Schema ||
                    this.Schema != null &&
                    this.Schema.Equals(other.Schema)
                ) &&
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                ) &&
                (
                    this.ExternalDataSources == other.ExternalDataSources ||
                    this.ExternalDataSources != null &&
                    this.ExternalDataSources.SequenceEqual(other.ExternalDataSources)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.CompanyType != null)
                    hash = hash * 59 + this.CompanyType.GetHashCode();
                
                if (this.Industry != null)
                    hash = hash * 59 + this.Industry.GetHashCode();
                
                if (this.PrimaryContactId != null)
                    hash = hash * 59 + this.PrimaryContactId.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.FaxNumber != null)
                    hash = hash * 59 + this.FaxNumber.GetHashCode();
                
                if (this.EmployeeCount != null)
                    hash = hash * 59 + this.EmployeeCount.GetHashCode();
                
                if (this.Revenue != null)
                    hash = hash * 59 + this.Revenue.GetHashCode();
                
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                
                if (this.Websites != null)
                    hash = hash * 59 + this.Websites.GetHashCode();
                
                if (this.Tickers != null)
                    hash = hash * 59 + this.Tickers.GetHashCode();
                
                if (this.TwitterId != null)
                    hash = hash * 59 + this.TwitterId.GetHashCode();
                
                if (this.ExternalSystemUrl != null)
                    hash = hash * 59 + this.ExternalSystemUrl.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.Trustor != null)
                    hash = hash * 59 + this.Trustor.GetHashCode();
                
                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                if (this.ExternalDataSources != null)
                    hash = hash * 59 + this.ExternalDataSources.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}

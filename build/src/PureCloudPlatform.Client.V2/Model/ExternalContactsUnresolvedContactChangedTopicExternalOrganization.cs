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
    /// ExternalContactsUnresolvedContactChangedTopicExternalOrganization
    /// </summary>
    [DataContract]
    public partial class ExternalContactsUnresolvedContactChangedTopicExternalOrganization :  IEquatable<ExternalContactsUnresolvedContactChangedTopicExternalOrganization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContactsUnresolvedContactChangedTopicExternalOrganization" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Division">Division.</param>
        /// <param name="Name">Name.</param>
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
        /// <param name="ExternalSystemUrl">ExternalSystemUrl.</param>
        /// <param name="CustomFields">CustomFields.</param>
        /// <param name="CreateDate">CreateDate.</param>
        /// <param name="ModifyDate">ModifyDate.</param>
        public ExternalContactsUnresolvedContactChangedTopicExternalOrganization(string Id = null, ExternalContactsUnresolvedContactChangedTopicDivision Division = null, string Name = null, string CompanyType = null, string Industry = null, string PrimaryContactId = null, ExternalContactsUnresolvedContactChangedTopicContactAddress Address = null, ExternalContactsUnresolvedContactChangedTopicPhoneNumber PhoneNumber = null, ExternalContactsUnresolvedContactChangedTopicPhoneNumber FaxNumber = null, int? EmployeeCount = null, int? Revenue = null, List<string> Tags = null, List<string> Websites = null, List<ExternalContactsUnresolvedContactChangedTopicTicker> Tickers = null, ExternalContactsUnresolvedContactChangedTopicTwitterId TwitterId = null, string ExternalSystemUrl = null, Dictionary<string, Object> CustomFields = null, DateTime? CreateDate = null, DateTime? ModifyDate = null)
        {
            this.Id = Id;
            this.Division = Division;
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
            this.CustomFields = CustomFields;
            this.CreateDate = CreateDate;
            this.ModifyDate = ModifyDate;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicDivision Division { get; set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
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
        public ExternalContactsUnresolvedContactChangedTopicContactAddress Address { get; set; }



        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicPhoneNumber PhoneNumber { get; set; }



        /// <summary>
        /// Gets or Sets FaxNumber
        /// </summary>
        [DataMember(Name="faxNumber", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicPhoneNumber FaxNumber { get; set; }



        /// <summary>
        /// Gets or Sets EmployeeCount
        /// </summary>
        [DataMember(Name="employeeCount", EmitDefaultValue=false)]
        public int? EmployeeCount { get; set; }



        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name="revenue", EmitDefaultValue=false)]
        public int? Revenue { get; set; }



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
        public List<ExternalContactsUnresolvedContactChangedTopicTicker> Tickers { get; set; }



        /// <summary>
        /// Gets or Sets TwitterId
        /// </summary>
        [DataMember(Name="twitterId", EmitDefaultValue=false)]
        public ExternalContactsUnresolvedContactChangedTopicTwitterId TwitterId { get; set; }



        /// <summary>
        /// Gets or Sets ExternalSystemUrl
        /// </summary>
        [DataMember(Name="externalSystemUrl", EmitDefaultValue=false)]
        public string ExternalSystemUrl { get; set; }



        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }



        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }



        /// <summary>
        /// Gets or Sets ModifyDate
        /// </summary>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalContactsUnresolvedContactChangedTopicExternalOrganization {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
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
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ExternalContactsUnresolvedContactChangedTopicExternalOrganization);
        }

        /// <summary>
        /// Returns true if ExternalContactsUnresolvedContactChangedTopicExternalOrganization instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalContactsUnresolvedContactChangedTopicExternalOrganization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalContactsUnresolvedContactChangedTopicExternalOrganization other)
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
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
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
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.SequenceEqual(other.CustomFields)
                ) &&
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) &&
                (
                    this.ModifyDate == other.ModifyDate ||
                    this.ModifyDate != null &&
                    this.ModifyDate.Equals(other.ModifyDate)
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

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

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

                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();

                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();

                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();

                return hash;
            }
        }
    }

}

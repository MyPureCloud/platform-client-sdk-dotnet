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
    /// ExternalContact
    /// </summary>
    [DataContract]
    public partial class ExternalContact :  IEquatable<ExternalContact>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalContact() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContact" /> class.
        /// </summary>
        
        
        
        
        /// <param name="FirstName">The first name of the contact. (required).</param>
        
        
        
        /// <param name="MiddleName">MiddleName.</param>
        
        
        
        /// <param name="LastName">The last name of the contact. (required).</param>
        
        
        
        /// <param name="Salutation">Salutation.</param>
        
        
        
        /// <param name="Title">Title.</param>
        
        
        
        /// <param name="WorkPhone">WorkPhone.</param>
        
        
        
        /// <param name="CellPhone">CellPhone.</param>
        
        
        
        /// <param name="HomePhone">HomePhone.</param>
        
        
        
        /// <param name="OtherPhone">OtherPhone.</param>
        
        
        
        /// <param name="WorkEmail">WorkEmail.</param>
        
        
        
        /// <param name="PersonalEmail">PersonalEmail.</param>
        
        
        
        /// <param name="OtherEmail">OtherEmail.</param>
        
        
        
        /// <param name="Address">Address.</param>
        
        
        
        /// <param name="TwitterId">TwitterId.</param>
        
        
        
        /// <param name="ModifyDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="CreateDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        
        
        
        /// <param name="ExternalOrganization">ExternalOrganization.</param>
        
        
        
        /// <param name="SurveyOptOut">SurveyOptOut.</param>
        
        
        
        /// <param name="ExternalSystemUrl">A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the HTTP protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace..</param>
        
        
        
        /// <param name="ExternalDataSources">Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param..</param>
        
        
        
        
        public ExternalContact(string FirstName = null, string MiddleName = null, string LastName = null, string Salutation = null, string Title = null, PhoneNumber WorkPhone = null, PhoneNumber CellPhone = null, PhoneNumber HomePhone = null, PhoneNumber OtherPhone = null, string WorkEmail = null, string PersonalEmail = null, string OtherEmail = null, ContactAddress Address = null, TwitterId TwitterId = null, DateTime? ModifyDate = null, DateTime? CreateDate = null, ExternalOrganization ExternalOrganization = null, bool? SurveyOptOut = null, string ExternalSystemUrl = null, List<ExternalDataSource> ExternalDataSources = null)
        {
            
            
            
            
            
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for ExternalContact and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            
            
            
            
            
            
            
            
            
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for ExternalContact and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.MiddleName = MiddleName;
            
            
            
            
            
            
            
            
            
            
            
            
this.Salutation = Salutation;
            
            
            
            
            
            
            
            
this.Title = Title;
            
            
            
            
            
            
            
            
this.WorkPhone = WorkPhone;
            
            
            
            
            
            
            
            
this.CellPhone = CellPhone;
            
            
            
            
            
            
            
            
this.HomePhone = HomePhone;
            
            
            
            
            
            
            
            
this.OtherPhone = OtherPhone;
            
            
            
            
            
            
            
            
this.WorkEmail = WorkEmail;
            
            
            
            
            
            
            
            
this.PersonalEmail = PersonalEmail;
            
            
            
            
            
            
            
            
this.OtherEmail = OtherEmail;
            
            
            
            
            
            
            
            
this.Address = Address;
            
            
            
            
            
            
            
            
this.TwitterId = TwitterId;
            
            
            
            
            
            
            
            
this.ModifyDate = ModifyDate;
            
            
            
            
            
            
            
            
this.CreateDate = CreateDate;
            
            
            
            
            
            
            
            
this.ExternalOrganization = ExternalOrganization;
            
            
            
            
            
            
            
            
this.SurveyOptOut = SurveyOptOut;
            
            
            
            
            
            
            
            
this.ExternalSystemUrl = ExternalSystemUrl;
            
            
            
            
            
            
            
            
this.ExternalDataSources = ExternalDataSources;
            
            
            
            
            
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The first name of the contact.
        /// </summary>
        /// <value>The first name of the contact.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }
        
        
        
        /// <summary>
        /// The last name of the contact.
        /// </summary>
        /// <value>The last name of the contact.</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Salutation
        /// </summary>
        [DataMember(Name="salutation", EmitDefaultValue=false)]
        public string Salutation { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets WorkPhone
        /// </summary>
        [DataMember(Name="workPhone", EmitDefaultValue=false)]
        public PhoneNumber WorkPhone { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CellPhone
        /// </summary>
        [DataMember(Name="cellPhone", EmitDefaultValue=false)]
        public PhoneNumber CellPhone { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets HomePhone
        /// </summary>
        [DataMember(Name="homePhone", EmitDefaultValue=false)]
        public PhoneNumber HomePhone { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OtherPhone
        /// </summary>
        [DataMember(Name="otherPhone", EmitDefaultValue=false)]
        public PhoneNumber OtherPhone { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets WorkEmail
        /// </summary>
        [DataMember(Name="workEmail", EmitDefaultValue=false)]
        public string WorkEmail { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PersonalEmail
        /// </summary>
        [DataMember(Name="personalEmail", EmitDefaultValue=false)]
        public string PersonalEmail { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets OtherEmail
        /// </summary>
        [DataMember(Name="otherEmail", EmitDefaultValue=false)]
        public string OtherEmail { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public ContactAddress Address { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets TwitterId
        /// </summary>
        [DataMember(Name="twitterId", EmitDefaultValue=false)]
        public TwitterId TwitterId { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="modifyDate", EmitDefaultValue=false)]
        public DateTime? ModifyDate { get; set; }
        
        
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ExternalOrganization
        /// </summary>
        [DataMember(Name="externalOrganization", EmitDefaultValue=false)]
        public ExternalOrganization ExternalOrganization { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SurveyOptOut
        /// </summary>
        [DataMember(Name="surveyOptOut", EmitDefaultValue=false)]
        public bool? SurveyOptOut { get; set; }
        
        
        
        /// <summary>
        /// A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the HTTP protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.
        /// </summary>
        /// <value>A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the HTTP protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.</value>
        [DataMember(Name="externalSystemUrl", EmitDefaultValue=false)]
        public string ExternalSystemUrl { get; set; }
        
        
        
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
            sb.Append("class ExternalContact {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
            
            sb.Append("  Title: ").Append(Title).Append("\n");
            
            sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
            
            sb.Append("  CellPhone: ").Append(CellPhone).Append("\n");
            
            sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
            
            sb.Append("  OtherPhone: ").Append(OtherPhone).Append("\n");
            
            sb.Append("  WorkEmail: ").Append(WorkEmail).Append("\n");
            
            sb.Append("  PersonalEmail: ").Append(PersonalEmail).Append("\n");
            
            sb.Append("  OtherEmail: ").Append(OtherEmail).Append("\n");
            
            sb.Append("  Address: ").Append(Address).Append("\n");
            
            sb.Append("  TwitterId: ").Append(TwitterId).Append("\n");
            
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            
            sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
            
            sb.Append("  SurveyOptOut: ").Append(SurveyOptOut).Append("\n");
            
            sb.Append("  ExternalSystemUrl: ").Append(ExternalSystemUrl).Append("\n");
            
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
            return this.Equals(obj as ExternalContact);
        }

        /// <summary>
        /// Returns true if ExternalContact instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalContact other)
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
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) &&
                (
                    this.MiddleName == other.MiddleName ||
                    this.MiddleName != null &&
                    this.MiddleName.Equals(other.MiddleName)
                ) &&
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) &&
                (
                    this.Salutation == other.Salutation ||
                    this.Salutation != null &&
                    this.Salutation.Equals(other.Salutation)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.WorkPhone == other.WorkPhone ||
                    this.WorkPhone != null &&
                    this.WorkPhone.Equals(other.WorkPhone)
                ) &&
                (
                    this.CellPhone == other.CellPhone ||
                    this.CellPhone != null &&
                    this.CellPhone.Equals(other.CellPhone)
                ) &&
                (
                    this.HomePhone == other.HomePhone ||
                    this.HomePhone != null &&
                    this.HomePhone.Equals(other.HomePhone)
                ) &&
                (
                    this.OtherPhone == other.OtherPhone ||
                    this.OtherPhone != null &&
                    this.OtherPhone.Equals(other.OtherPhone)
                ) &&
                (
                    this.WorkEmail == other.WorkEmail ||
                    this.WorkEmail != null &&
                    this.WorkEmail.Equals(other.WorkEmail)
                ) &&
                (
                    this.PersonalEmail == other.PersonalEmail ||
                    this.PersonalEmail != null &&
                    this.PersonalEmail.Equals(other.PersonalEmail)
                ) &&
                (
                    this.OtherEmail == other.OtherEmail ||
                    this.OtherEmail != null &&
                    this.OtherEmail.Equals(other.OtherEmail)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.TwitterId == other.TwitterId ||
                    this.TwitterId != null &&
                    this.TwitterId.Equals(other.TwitterId)
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
                    this.ExternalOrganization == other.ExternalOrganization ||
                    this.ExternalOrganization != null &&
                    this.ExternalOrganization.Equals(other.ExternalOrganization)
                ) &&
                (
                    this.SurveyOptOut == other.SurveyOptOut ||
                    this.SurveyOptOut != null &&
                    this.SurveyOptOut.Equals(other.SurveyOptOut)
                ) &&
                (
                    this.ExternalSystemUrl == other.ExternalSystemUrl ||
                    this.ExternalSystemUrl != null &&
                    this.ExternalSystemUrl.Equals(other.ExternalSystemUrl)
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
                
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                
                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();
                
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                
                if (this.Salutation != null)
                    hash = hash * 59 + this.Salutation.GetHashCode();
                
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                
                if (this.WorkPhone != null)
                    hash = hash * 59 + this.WorkPhone.GetHashCode();
                
                if (this.CellPhone != null)
                    hash = hash * 59 + this.CellPhone.GetHashCode();
                
                if (this.HomePhone != null)
                    hash = hash * 59 + this.HomePhone.GetHashCode();
                
                if (this.OtherPhone != null)
                    hash = hash * 59 + this.OtherPhone.GetHashCode();
                
                if (this.WorkEmail != null)
                    hash = hash * 59 + this.WorkEmail.GetHashCode();
                
                if (this.PersonalEmail != null)
                    hash = hash * 59 + this.PersonalEmail.GetHashCode();
                
                if (this.OtherEmail != null)
                    hash = hash * 59 + this.OtherEmail.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                if (this.TwitterId != null)
                    hash = hash * 59 + this.TwitterId.GetHashCode();
                
                if (this.ModifyDate != null)
                    hash = hash * 59 + this.ModifyDate.GetHashCode();
                
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                
                if (this.ExternalOrganization != null)
                    hash = hash * 59 + this.ExternalOrganization.GetHashCode();
                
                if (this.SurveyOptOut != null)
                    hash = hash * 59 + this.SurveyOptOut.GetHashCode();
                
                if (this.ExternalSystemUrl != null)
                    hash = hash * 59 + this.ExternalSystemUrl.GetHashCode();
                
                if (this.ExternalDataSources != null)
                    hash = hash * 59 + this.ExternalDataSources.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}

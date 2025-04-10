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
        /// The type of contact
        /// </summary>
        /// <value>The type of contact</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ephemeral for "Ephemeral"
            /// </summary>
            [EnumMember(Value = "Ephemeral")]
            Ephemeral,
            
            /// <summary>
            /// Enum Identified for "Identified"
            /// </summary>
            [EnumMember(Value = "Identified")]
            Identified,
            
            /// <summary>
            /// Enum Curated for "Curated"
            /// </summary>
            [EnumMember(Value = "Curated")]
            Curated
        }
        /// <summary>
        /// The type of contact
        /// </summary>
        /// <value>The type of contact</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalContact" /> class.
        /// </summary>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="FirstName">The first name of the contact..</param>
        /// <param name="MiddleName">MiddleName.</param>
        /// <param name="LastName">The last name of the contact..</param>
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
        /// <param name="LineId">LineId.</param>
        /// <param name="WhatsAppId">WhatsAppId.</param>
        /// <param name="FacebookId">FacebookId.</param>
        /// <param name="ExternalIds">A list of external identifiers that identify this contact in an external system.</param>
        /// <param name="Identifiers">Identifiers claimed by this contact.</param>
        /// <param name="ModifyDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="CreateDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ExternalOrganization">ExternalOrganization.</param>
        /// <param name="SurveyOptOut">SurveyOptOut.</param>
        /// <param name="ExternalSystemUrl">A string that identifies an external system-of-record resource that may have more detailed information on the contact. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace..</param>
        /// <param name="Schema">The schema defining custom fields for this contact.</param>
        /// <param name="CustomFields">Custom fields defined in the schema referenced by schemaId and schemaVersion..</param>
        public ExternalContact(string Id = null, WritableStarrableDivision Division = null, string FirstName = null, string MiddleName = null, string LastName = null, string Salutation = null, string Title = null, PhoneNumber WorkPhone = null, PhoneNumber CellPhone = null, PhoneNumber HomePhone = null, PhoneNumber OtherPhone = null, string WorkEmail = null, string PersonalEmail = null, string OtherEmail = null, ContactAddress Address = null, TwitterId TwitterId = null, LineId LineId = null, WhatsAppId WhatsAppId = null, FacebookId FacebookId = null, List<ExternalId> ExternalIds = null, List<ContactIdentifier> Identifiers = null, DateTime? ModifyDate = null, DateTime? CreateDate = null, ExternalOrganization ExternalOrganization = null, bool? SurveyOptOut = null, string ExternalSystemUrl = null, DataSchema Schema = null, Dictionary<string, Object> CustomFields = null)
        {
            this.Id = Id;
            this.Division = Division;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
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
            this.LineId = LineId;
            this.WhatsAppId = WhatsAppId;
            this.FacebookId = FacebookId;
            this.ExternalIds = ExternalIds;
            this.Identifiers = Identifiers;
            this.ModifyDate = ModifyDate;
            this.CreateDate = CreateDate;
            this.ExternalOrganization = ExternalOrganization;
            this.SurveyOptOut = SurveyOptOut;
            this.ExternalSystemUrl = ExternalSystemUrl;
            this.Schema = Schema;
            this.CustomFields = CustomFields;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public WritableStarrableDivision Division { get; set; }



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
        /// Gets or Sets LineId
        /// </summary>
        [DataMember(Name="lineId", EmitDefaultValue=false)]
        public LineId LineId { get; set; }



        /// <summary>
        /// Gets or Sets WhatsAppId
        /// </summary>
        [DataMember(Name="whatsAppId", EmitDefaultValue=false)]
        public WhatsAppId WhatsAppId { get; set; }



        /// <summary>
        /// Gets or Sets FacebookId
        /// </summary>
        [DataMember(Name="facebookId", EmitDefaultValue=false)]
        public FacebookId FacebookId { get; set; }



        /// <summary>
        /// A list of external identifiers that identify this contact in an external system
        /// </summary>
        /// <value>A list of external identifiers that identify this contact in an external system</value>
        [DataMember(Name="externalIds", EmitDefaultValue=false)]
        public List<ExternalId> ExternalIds { get; set; }



        /// <summary>
        /// Identifiers claimed by this contact
        /// </summary>
        /// <value>Identifiers claimed by this contact</value>
        [DataMember(Name="identifiers", EmitDefaultValue=false)]
        public List<ContactIdentifier> Identifiers { get; set; }



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
        /// A string that identifies an external system-of-record resource that may have more detailed information on the contact. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.
        /// </summary>
        /// <value>A string that identifies an external system-of-record resource that may have more detailed information on the contact. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.</value>
        [DataMember(Name="externalSystemUrl", EmitDefaultValue=false)]
        public string ExternalSystemUrl { get; set; }



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
        public List<ExternalDataSource> ExternalDataSources { get; private set; }





        /// <summary>
        /// The contact at the head of the merge tree. If null, this contact is not a part of any merge.
        /// </summary>
        /// <value>The contact at the head of the merge tree. If null, this contact is not a part of any merge.</value>
        [DataMember(Name="canonicalContact", EmitDefaultValue=false)]
        public ContactAddressableEntityRef CanonicalContact { get; private set; }



        /// <summary>
        /// The set of all contacts that are a part of the merge tree. If null, this contact is not a part of any merge.
        /// </summary>
        /// <value>The set of all contacts that are a part of the merge tree. If null, this contact is not a part of any merge.</value>
        [DataMember(Name="mergeSet", EmitDefaultValue=false)]
        public List<ContactAddressableEntityRef> MergeSet { get; private set; }



        /// <summary>
        /// Information about the merge history of this contact. If null, this contact is not a part of any merge.
        /// </summary>
        /// <value>Information about the merge history of this contact. If null, this contact is not a part of any merge.</value>
        [DataMember(Name="mergeOperation", EmitDefaultValue=false)]
        public MergeOperation MergeOperation { get; private set; }



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
            sb.Append("  Division: ").Append(Division).Append("\n");
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
            sb.Append("  LineId: ").Append(LineId).Append("\n");
            sb.Append("  WhatsAppId: ").Append(WhatsAppId).Append("\n");
            sb.Append("  FacebookId: ").Append(FacebookId).Append("\n");
            sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
            sb.Append("  SurveyOptOut: ").Append(SurveyOptOut).Append("\n");
            sb.Append("  ExternalSystemUrl: ").Append(ExternalSystemUrl).Append("\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  ExternalDataSources: ").Append(ExternalDataSources).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CanonicalContact: ").Append(CanonicalContact).Append("\n");
            sb.Append("  MergeSet: ").Append(MergeSet).Append("\n");
            sb.Append("  MergeOperation: ").Append(MergeOperation).Append("\n");
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
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
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
                    this.LineId == other.LineId ||
                    this.LineId != null &&
                    this.LineId.Equals(other.LineId)
                ) &&
                (
                    this.WhatsAppId == other.WhatsAppId ||
                    this.WhatsAppId != null &&
                    this.WhatsAppId.Equals(other.WhatsAppId)
                ) &&
                (
                    this.FacebookId == other.FacebookId ||
                    this.FacebookId != null &&
                    this.FacebookId.Equals(other.FacebookId)
                ) &&
                (
                    this.ExternalIds == other.ExternalIds ||
                    this.ExternalIds != null &&
                    this.ExternalIds.SequenceEqual(other.ExternalIds)
                ) &&
                (
                    this.Identifiers == other.Identifiers ||
                    this.Identifiers != null &&
                    this.Identifiers.SequenceEqual(other.Identifiers)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.CanonicalContact == other.CanonicalContact ||
                    this.CanonicalContact != null &&
                    this.CanonicalContact.Equals(other.CanonicalContact)
                ) &&
                (
                    this.MergeSet == other.MergeSet ||
                    this.MergeSet != null &&
                    this.MergeSet.SequenceEqual(other.MergeSet)
                ) &&
                (
                    this.MergeOperation == other.MergeOperation ||
                    this.MergeOperation != null &&
                    this.MergeOperation.Equals(other.MergeOperation)
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

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

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

                if (this.LineId != null)
                    hash = hash * 59 + this.LineId.GetHashCode();

                if (this.WhatsAppId != null)
                    hash = hash * 59 + this.WhatsAppId.GetHashCode();

                if (this.FacebookId != null)
                    hash = hash * 59 + this.FacebookId.GetHashCode();

                if (this.ExternalIds != null)
                    hash = hash * 59 + this.ExternalIds.GetHashCode();

                if (this.Identifiers != null)
                    hash = hash * 59 + this.Identifiers.GetHashCode();

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

                if (this.Schema != null)
                    hash = hash * 59 + this.Schema.GetHashCode();

                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();

                if (this.ExternalDataSources != null)
                    hash = hash * 59 + this.ExternalDataSources.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.CanonicalContact != null)
                    hash = hash * 59 + this.CanonicalContact.GetHashCode();

                if (this.MergeSet != null)
                    hash = hash * 59 + this.MergeSet.GetHashCode();

                if (this.MergeOperation != null)
                    hash = hash * 59 + this.MergeOperation.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}

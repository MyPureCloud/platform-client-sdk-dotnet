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
    /// CaseplanCreateResponse
    /// </summary>
    [DataContract]
    public partial class CaseplanCreateResponse :  IEquatable<CaseplanCreateResponse>
    {
        /// <summary>
        /// The version state of the Caseplan.
        /// </summary>
        /// <value>The version state of the Caseplan.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum VersionStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Copying for "Copying"
            /// </summary>
            [EnumMember(Value = "Copying")]
            Copying,
            
            /// <summary>
            /// Enum Draft for "Draft"
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft,
            
            /// <summary>
            /// Enum Published for "Published"
            /// </summary>
            [EnumMember(Value = "Published")]
            Published
        }
        /// <summary>
        /// The version state of the Caseplan.
        /// </summary>
        /// <value>The version state of the Caseplan.</value>
        [DataMember(Name="versionState", EmitDefaultValue=false)]
        public VersionStateEnum? VersionState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseplanCreateResponse" /> class.
        /// </summary>
        /// <param name="Name">The name of the Caseplan..</param>
        /// <param name="Division">The division to which this entity belongs..</param>
        /// <param name="Description">The description of the Caseplan..</param>
        /// <param name="ReferencePrefix">The prefix used when creating the reference for Cases from the Caseplan..</param>
        /// <param name="DefaultDueDurationInSeconds">The default due duration in seconds for Cases created from the Caseplan..</param>
        /// <param name="DefaultTtlSeconds">The default TTL in seconds for Cases created from the Caseplan..</param>
        /// <param name="DefaultCaseOwner">The default case owner for Cases created from the Caseplan..</param>
        /// <param name="Latest">The latest version of the Caseplan..</param>
        /// <param name="Published">The published version of the Caseplan..</param>
        /// <param name="DateCreated">The Caseplan creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DateModified">The Caseplan modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="DatePublished">The Caseplan publication date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="ModifiedBy">The id of the User who modified the Caseplan..</param>
        /// <param name="CustomerIntent">The customer intent for the Cases created from the caseplan..</param>
        /// <param name="VersionState">The version state of the Caseplan..</param>
        /// <param name="DataSchemas">The schemas that define all data for cases from this Caseplan..</param>
        /// <param name="IntakeSettings">The intake format when collecting data for a case from this caseplan..</param>
        public CaseplanCreateResponse(string Name = null, StarrableDivision Division = null, string Description = null, string ReferencePrefix = null, int? DefaultDueDurationInSeconds = null, int? DefaultTtlSeconds = null, UserReference DefaultCaseOwner = null, int? Latest = null, int? Published = null, DateTime? DateCreated = null, DateTime? DateModified = null, DateTime? DatePublished = null, UserReference ModifiedBy = null, CustomerIntentReference CustomerIntent = null, VersionStateEnum? VersionState = null, List<CaseplanDataSchema> DataSchemas = null, List<IntakeSetting> IntakeSettings = null)
        {
            this.Name = Name;
            this.Division = Division;
            this.Description = Description;
            this.ReferencePrefix = ReferencePrefix;
            this.DefaultDueDurationInSeconds = DefaultDueDurationInSeconds;
            this.DefaultTtlSeconds = DefaultTtlSeconds;
            this.DefaultCaseOwner = DefaultCaseOwner;
            this.Latest = Latest;
            this.Published = Published;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.DatePublished = DatePublished;
            this.ModifiedBy = ModifiedBy;
            this.CustomerIntent = CustomerIntent;
            this.VersionState = VersionState;
            this.DataSchemas = DataSchemas;
            this.IntakeSettings = IntakeSettings;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// The name of the Caseplan.
        /// </summary>
        /// <value>The name of the Caseplan.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The division to which this entity belongs.
        /// </summary>
        /// <value>The division to which this entity belongs.</value>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public StarrableDivision Division { get; set; }



        /// <summary>
        /// The description of the Caseplan.
        /// </summary>
        /// <value>The description of the Caseplan.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The prefix used when creating the reference for Cases from the Caseplan.
        /// </summary>
        /// <value>The prefix used when creating the reference for Cases from the Caseplan.</value>
        [DataMember(Name="referencePrefix", EmitDefaultValue=false)]
        public string ReferencePrefix { get; set; }



        /// <summary>
        /// The default due duration in seconds for Cases created from the Caseplan.
        /// </summary>
        /// <value>The default due duration in seconds for Cases created from the Caseplan.</value>
        [DataMember(Name="defaultDueDurationInSeconds", EmitDefaultValue=false)]
        public int? DefaultDueDurationInSeconds { get; set; }



        /// <summary>
        /// The default TTL in seconds for Cases created from the Caseplan.
        /// </summary>
        /// <value>The default TTL in seconds for Cases created from the Caseplan.</value>
        [DataMember(Name="defaultTtlSeconds", EmitDefaultValue=false)]
        public int? DefaultTtlSeconds { get; set; }



        /// <summary>
        /// The default case owner for Cases created from the Caseplan.
        /// </summary>
        /// <value>The default case owner for Cases created from the Caseplan.</value>
        [DataMember(Name="defaultCaseOwner", EmitDefaultValue=false)]
        public UserReference DefaultCaseOwner { get; set; }



        /// <summary>
        /// The latest version of the Caseplan.
        /// </summary>
        /// <value>The latest version of the Caseplan.</value>
        [DataMember(Name="latest", EmitDefaultValue=false)]
        public int? Latest { get; set; }



        /// <summary>
        /// The published version of the Caseplan.
        /// </summary>
        /// <value>The published version of the Caseplan.</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public int? Published { get; set; }



        /// <summary>
        /// The Caseplan creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The Caseplan creation date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// The Caseplan modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The Caseplan modification date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// The Caseplan publication date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The Caseplan publication date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="datePublished", EmitDefaultValue=false)]
        public DateTime? DatePublished { get; set; }



        /// <summary>
        /// The id of the User who modified the Caseplan.
        /// </summary>
        /// <value>The id of the User who modified the Caseplan.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public UserReference ModifiedBy { get; set; }



        /// <summary>
        /// The customer intent for the Cases created from the caseplan.
        /// </summary>
        /// <value>The customer intent for the Cases created from the caseplan.</value>
        [DataMember(Name="customerIntent", EmitDefaultValue=false)]
        public CustomerIntentReference CustomerIntent { get; set; }





        /// <summary>
        /// The schemas that define all data for cases from this Caseplan.
        /// </summary>
        /// <value>The schemas that define all data for cases from this Caseplan.</value>
        [DataMember(Name="dataSchemas", EmitDefaultValue=false)]
        public List<CaseplanDataSchema> DataSchemas { get; set; }



        /// <summary>
        /// The intake format when collecting data for a case from this caseplan.
        /// </summary>
        /// <value>The intake format when collecting data for a case from this caseplan.</value>
        [DataMember(Name="intakeSettings", EmitDefaultValue=false)]
        public List<IntakeSetting> IntakeSettings { get; set; }



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
            sb.Append("class CaseplanCreateResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ReferencePrefix: ").Append(ReferencePrefix).Append("\n");
            sb.Append("  DefaultDueDurationInSeconds: ").Append(DefaultDueDurationInSeconds).Append("\n");
            sb.Append("  DefaultTtlSeconds: ").Append(DefaultTtlSeconds).Append("\n");
            sb.Append("  DefaultCaseOwner: ").Append(DefaultCaseOwner).Append("\n");
            sb.Append("  Latest: ").Append(Latest).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CustomerIntent: ").Append(CustomerIntent).Append("\n");
            sb.Append("  VersionState: ").Append(VersionState).Append("\n");
            sb.Append("  DataSchemas: ").Append(DataSchemas).Append("\n");
            sb.Append("  IntakeSettings: ").Append(IntakeSettings).Append("\n");
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
            return this.Equals(obj as CaseplanCreateResponse);
        }

        /// <summary>
        /// Returns true if CaseplanCreateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CaseplanCreateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseplanCreateResponse other)
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
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.ReferencePrefix == other.ReferencePrefix ||
                    this.ReferencePrefix != null &&
                    this.ReferencePrefix.Equals(other.ReferencePrefix)
                ) &&
                (
                    this.DefaultDueDurationInSeconds == other.DefaultDueDurationInSeconds ||
                    this.DefaultDueDurationInSeconds != null &&
                    this.DefaultDueDurationInSeconds.Equals(other.DefaultDueDurationInSeconds)
                ) &&
                (
                    this.DefaultTtlSeconds == other.DefaultTtlSeconds ||
                    this.DefaultTtlSeconds != null &&
                    this.DefaultTtlSeconds.Equals(other.DefaultTtlSeconds)
                ) &&
                (
                    this.DefaultCaseOwner == other.DefaultCaseOwner ||
                    this.DefaultCaseOwner != null &&
                    this.DefaultCaseOwner.Equals(other.DefaultCaseOwner)
                ) &&
                (
                    this.Latest == other.Latest ||
                    this.Latest != null &&
                    this.Latest.Equals(other.Latest)
                ) &&
                (
                    this.Published == other.Published ||
                    this.Published != null &&
                    this.Published.Equals(other.Published)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.DatePublished == other.DatePublished ||
                    this.DatePublished != null &&
                    this.DatePublished.Equals(other.DatePublished)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.CustomerIntent == other.CustomerIntent ||
                    this.CustomerIntent != null &&
                    this.CustomerIntent.Equals(other.CustomerIntent)
                ) &&
                (
                    this.VersionState == other.VersionState ||
                    this.VersionState != null &&
                    this.VersionState.Equals(other.VersionState)
                ) &&
                (
                    this.DataSchemas == other.DataSchemas ||
                    this.DataSchemas != null &&
                    this.DataSchemas.SequenceEqual(other.DataSchemas)
                ) &&
                (
                    this.IntakeSettings == other.IntakeSettings ||
                    this.IntakeSettings != null &&
                    this.IntakeSettings.SequenceEqual(other.IntakeSettings)
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

                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();

                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();

                if (this.ReferencePrefix != null)
                    hash = hash * 59 + this.ReferencePrefix.GetHashCode();

                if (this.DefaultDueDurationInSeconds != null)
                    hash = hash * 59 + this.DefaultDueDurationInSeconds.GetHashCode();

                if (this.DefaultTtlSeconds != null)
                    hash = hash * 59 + this.DefaultTtlSeconds.GetHashCode();

                if (this.DefaultCaseOwner != null)
                    hash = hash * 59 + this.DefaultCaseOwner.GetHashCode();

                if (this.Latest != null)
                    hash = hash * 59 + this.Latest.GetHashCode();

                if (this.Published != null)
                    hash = hash * 59 + this.Published.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.DatePublished != null)
                    hash = hash * 59 + this.DatePublished.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.CustomerIntent != null)
                    hash = hash * 59 + this.CustomerIntent.GetHashCode();

                if (this.VersionState != null)
                    hash = hash * 59 + this.VersionState.GetHashCode();

                if (this.DataSchemas != null)
                    hash = hash * 59 + this.DataSchemas.GetHashCode();

                if (this.IntakeSettings != null)
                    hash = hash * 59 + this.IntakeSettings.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}

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
    /// AttemptLimits
    /// </summary>
    [DataContract]
    public partial class AttemptLimits :  IEquatable<AttemptLimits>
    {
        /// <summary>
        /// After how long the number of attempts will be set back to 0. Defaults to NEVER.
        /// </summary>
        /// <value>After how long the number of attempts will be set back to 0. Defaults to NEVER.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ResetPeriodEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Never for "NEVER"
            /// </summary>
            [EnumMember(Value = "NEVER")]
            Never,
            
            /// <summary>
            /// Enum Today for "TODAY"
            /// </summary>
            [EnumMember(Value = "TODAY")]
            Today,
            
            /// <summary>
            /// Enum Days2 for "DAYS_2"
            /// </summary>
            [EnumMember(Value = "DAYS_2")]
            Days2,
            
            /// <summary>
            /// Enum Days3 for "DAYS_3"
            /// </summary>
            [EnumMember(Value = "DAYS_3")]
            Days3,
            
            /// <summary>
            /// Enum Days4 for "DAYS_4"
            /// </summary>
            [EnumMember(Value = "DAYS_4")]
            Days4,
            
            /// <summary>
            /// Enum Days5 for "DAYS_5"
            /// </summary>
            [EnumMember(Value = "DAYS_5")]
            Days5,
            
            /// <summary>
            /// Enum Days6 for "DAYS_6"
            /// </summary>
            [EnumMember(Value = "DAYS_6")]
            Days6,
            
            /// <summary>
            /// Enum Days7 for "DAYS_7"
            /// </summary>
            [EnumMember(Value = "DAYS_7")]
            Days7,
            
            /// <summary>
            /// Enum Days8 for "DAYS_8"
            /// </summary>
            [EnumMember(Value = "DAYS_8")]
            Days8,
            
            /// <summary>
            /// Enum Days9 for "DAYS_9"
            /// </summary>
            [EnumMember(Value = "DAYS_9")]
            Days9,
            
            /// <summary>
            /// Enum Days10 for "DAYS_10"
            /// </summary>
            [EnumMember(Value = "DAYS_10")]
            Days10,
            
            /// <summary>
            /// Enum Days11 for "DAYS_11"
            /// </summary>
            [EnumMember(Value = "DAYS_11")]
            Days11,
            
            /// <summary>
            /// Enum Days12 for "DAYS_12"
            /// </summary>
            [EnumMember(Value = "DAYS_12")]
            Days12,
            
            /// <summary>
            /// Enum Days13 for "DAYS_13"
            /// </summary>
            [EnumMember(Value = "DAYS_13")]
            Days13,
            
            /// <summary>
            /// Enum Days14 for "DAYS_14"
            /// </summary>
            [EnumMember(Value = "DAYS_14")]
            Days14,
            
            /// <summary>
            /// Enum Days15 for "DAYS_15"
            /// </summary>
            [EnumMember(Value = "DAYS_15")]
            Days15,
            
            /// <summary>
            /// Enum Days16 for "DAYS_16"
            /// </summary>
            [EnumMember(Value = "DAYS_16")]
            Days16,
            
            /// <summary>
            /// Enum Days17 for "DAYS_17"
            /// </summary>
            [EnumMember(Value = "DAYS_17")]
            Days17,
            
            /// <summary>
            /// Enum Days18 for "DAYS_18"
            /// </summary>
            [EnumMember(Value = "DAYS_18")]
            Days18,
            
            /// <summary>
            /// Enum Days19 for "DAYS_19"
            /// </summary>
            [EnumMember(Value = "DAYS_19")]
            Days19,
            
            /// <summary>
            /// Enum Days20 for "DAYS_20"
            /// </summary>
            [EnumMember(Value = "DAYS_20")]
            Days20,
            
            /// <summary>
            /// Enum Days21 for "DAYS_21"
            /// </summary>
            [EnumMember(Value = "DAYS_21")]
            Days21,
            
            /// <summary>
            /// Enum Days22 for "DAYS_22"
            /// </summary>
            [EnumMember(Value = "DAYS_22")]
            Days22,
            
            /// <summary>
            /// Enum Days23 for "DAYS_23"
            /// </summary>
            [EnumMember(Value = "DAYS_23")]
            Days23,
            
            /// <summary>
            /// Enum Days24 for "DAYS_24"
            /// </summary>
            [EnumMember(Value = "DAYS_24")]
            Days24,
            
            /// <summary>
            /// Enum Days25 for "DAYS_25"
            /// </summary>
            [EnumMember(Value = "DAYS_25")]
            Days25,
            
            /// <summary>
            /// Enum Days26 for "DAYS_26"
            /// </summary>
            [EnumMember(Value = "DAYS_26")]
            Days26,
            
            /// <summary>
            /// Enum Days27 for "DAYS_27"
            /// </summary>
            [EnumMember(Value = "DAYS_27")]
            Days27,
            
            /// <summary>
            /// Enum Days28 for "DAYS_28"
            /// </summary>
            [EnumMember(Value = "DAYS_28")]
            Days28,
            
            /// <summary>
            /// Enum Days29 for "DAYS_29"
            /// </summary>
            [EnumMember(Value = "DAYS_29")]
            Days29,
            
            /// <summary>
            /// Enum Days30 for "DAYS_30"
            /// </summary>
            [EnumMember(Value = "DAYS_30")]
            Days30
        }
        /// <summary>
        /// After how long the number of attempts will be set back to 0. Defaults to NEVER.
        /// </summary>
        /// <value>After how long the number of attempts will be set back to 0. Defaults to NEVER.</value>
        [DataMember(Name="resetPeriod", EmitDefaultValue=false)]
        public ResetPeriodEnum? ResetPeriod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttemptLimits" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        /// <param name="MaxAttemptsPerContact">The maximum number of times a contact can be called within the resetPeriod. Required if maxAttemptsPerNumber is not defined..</param>
        /// <param name="MaxAttemptsPerNumber">The maximum number of times a phone number can be called within the resetPeriod. Required if maxAttemptsPerContact is not defined..</param>
        /// <param name="TimeZoneId">If the resetPeriod is TODAY, this specifies the timezone in which TODAY occurs. Required if the resetPeriod is TODAY..</param>
        /// <param name="ResetPeriod">After how long the number of attempts will be set back to 0. Defaults to NEVER..</param>
        /// <param name="RecallEntries">Configuration for recall attempts..</param>
        public AttemptLimits(string Name = null, int? Version = null, int? MaxAttemptsPerContact = null, int? MaxAttemptsPerNumber = null, string TimeZoneId = null, ResetPeriodEnum? ResetPeriod = null, Dictionary<string, RecallEntry> RecallEntries = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.MaxAttemptsPerContact = MaxAttemptsPerContact;
            this.MaxAttemptsPerNumber = MaxAttemptsPerNumber;
            this.TimeZoneId = TimeZoneId;
            this.ResetPeriod = ResetPeriod;
            this.RecallEntries = RecallEntries;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// The maximum number of times a contact can be called within the resetPeriod. Required if maxAttemptsPerNumber is not defined.
        /// </summary>
        /// <value>The maximum number of times a contact can be called within the resetPeriod. Required if maxAttemptsPerNumber is not defined.</value>
        [DataMember(Name="maxAttemptsPerContact", EmitDefaultValue=false)]
        public int? MaxAttemptsPerContact { get; set; }



        /// <summary>
        /// The maximum number of times a phone number can be called within the resetPeriod. Required if maxAttemptsPerContact is not defined.
        /// </summary>
        /// <value>The maximum number of times a phone number can be called within the resetPeriod. Required if maxAttemptsPerContact is not defined.</value>
        [DataMember(Name="maxAttemptsPerNumber", EmitDefaultValue=false)]
        public int? MaxAttemptsPerNumber { get; set; }



        /// <summary>
        /// If the resetPeriod is TODAY, this specifies the timezone in which TODAY occurs. Required if the resetPeriod is TODAY.
        /// </summary>
        /// <value>If the resetPeriod is TODAY, this specifies the timezone in which TODAY occurs. Required if the resetPeriod is TODAY.</value>
        [DataMember(Name="timeZoneId", EmitDefaultValue=false)]
        public string TimeZoneId { get; set; }





        /// <summary>
        /// Configuration for recall attempts.
        /// </summary>
        /// <value>Configuration for recall attempts.</value>
        [DataMember(Name="recallEntries", EmitDefaultValue=false)]
        public Dictionary<string, RecallEntry> RecallEntries { get; set; }



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
            sb.Append("class AttemptLimits {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  MaxAttemptsPerContact: ").Append(MaxAttemptsPerContact).Append("\n");
            sb.Append("  MaxAttemptsPerNumber: ").Append(MaxAttemptsPerNumber).Append("\n");
            sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
            sb.Append("  ResetPeriod: ").Append(ResetPeriod).Append("\n");
            sb.Append("  RecallEntries: ").Append(RecallEntries).Append("\n");
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
            return this.Equals(obj as AttemptLimits);
        }

        /// <summary>
        /// Returns true if AttemptLimits instances are equal
        /// </summary>
        /// <param name="other">Instance of AttemptLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttemptLimits other)
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
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.MaxAttemptsPerContact == other.MaxAttemptsPerContact ||
                    this.MaxAttemptsPerContact != null &&
                    this.MaxAttemptsPerContact.Equals(other.MaxAttemptsPerContact)
                ) &&
                (
                    this.MaxAttemptsPerNumber == other.MaxAttemptsPerNumber ||
                    this.MaxAttemptsPerNumber != null &&
                    this.MaxAttemptsPerNumber.Equals(other.MaxAttemptsPerNumber)
                ) &&
                (
                    this.TimeZoneId == other.TimeZoneId ||
                    this.TimeZoneId != null &&
                    this.TimeZoneId.Equals(other.TimeZoneId)
                ) &&
                (
                    this.ResetPeriod == other.ResetPeriod ||
                    this.ResetPeriod != null &&
                    this.ResetPeriod.Equals(other.ResetPeriod)
                ) &&
                (
                    this.RecallEntries == other.RecallEntries ||
                    this.RecallEntries != null &&
                    this.RecallEntries.SequenceEqual(other.RecallEntries)
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

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.MaxAttemptsPerContact != null)
                    hash = hash * 59 + this.MaxAttemptsPerContact.GetHashCode();

                if (this.MaxAttemptsPerNumber != null)
                    hash = hash * 59 + this.MaxAttemptsPerNumber.GetHashCode();

                if (this.TimeZoneId != null)
                    hash = hash * 59 + this.TimeZoneId.GetHashCode();

                if (this.ResetPeriod != null)
                    hash = hash * 59 + this.ResetPeriod.GetHashCode();

                if (this.RecallEntries != null)
                    hash = hash * 59 + this.RecallEntries.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}

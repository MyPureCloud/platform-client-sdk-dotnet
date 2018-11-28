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
    /// DialerAttemptLimitsConfigChangeAttemptLimits
    /// </summary>
    [DataContract]
    public partial class DialerAttemptLimitsConfigChangeAttemptLimits :  IEquatable<DialerAttemptLimitsConfigChangeAttemptLimits>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ResetPeriod
        /// </summary>
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
            Today
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ResetPeriod
        /// </summary>
        [DataMember(Name="resetPeriod", EmitDefaultValue=false)]
        public ResetPeriodEnum? ResetPeriod { get; set; }
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerAttemptLimitsConfigChangeAttemptLimits" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="Version">Version.</param>
        /// <param name="MaxAttemptsPerContact">MaxAttemptsPerContact.</param>
        /// <param name="MaxAttemptsPerNumber">MaxAttemptsPerNumber.</param>
        /// <param name="TimeZoneId">TimeZoneId.</param>
        /// <param name="ResetPeriod">ResetPeriod.</param>
        /// <param name="RecallEntries">RecallEntries.</param>
        /// <param name="BreadthFirstRecalls">BreadthFirstRecalls.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        public DialerAttemptLimitsConfigChangeAttemptLimits(string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null, int? MaxAttemptsPerContact = null, int? MaxAttemptsPerNumber = null, string TimeZoneId = null, ResetPeriodEnum? ResetPeriod = null, Dictionary<string, DialerAttemptLimitsConfigChangeRecallEntry> RecallEntries = null, bool? BreadthFirstRecalls = null, Object AdditionalProperties = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            this.MaxAttemptsPerContact = MaxAttemptsPerContact;
            this.MaxAttemptsPerNumber = MaxAttemptsPerNumber;
            this.TimeZoneId = TimeZoneId;
            this.ResetPeriod = ResetPeriod;
            this.RecallEntries = RecallEntries;
            this.BreadthFirstRecalls = BreadthFirstRecalls;
            this.AdditionalProperties = AdditionalProperties;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MaxAttemptsPerContact
        /// </summary>
        [DataMember(Name="maxAttemptsPerContact", EmitDefaultValue=false)]
        public int? MaxAttemptsPerContact { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MaxAttemptsPerNumber
        /// </summary>
        [DataMember(Name="maxAttemptsPerNumber", EmitDefaultValue=false)]
        public int? MaxAttemptsPerNumber { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets TimeZoneId
        /// </summary>
        [DataMember(Name="timeZoneId", EmitDefaultValue=false)]
        public string TimeZoneId { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets RecallEntries
        /// </summary>
        [DataMember(Name="recallEntries", EmitDefaultValue=false)]
        public Dictionary<string, DialerAttemptLimitsConfigChangeRecallEntry> RecallEntries { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets BreadthFirstRecalls
        /// </summary>
        [DataMember(Name="breadthFirstRecalls", EmitDefaultValue=false)]
        public bool? BreadthFirstRecalls { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerAttemptLimitsConfigChangeAttemptLimits {\n");
            
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
            sb.Append("  BreadthFirstRecalls: ").Append(BreadthFirstRecalls).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
            return this.Equals(obj as DialerAttemptLimitsConfigChangeAttemptLimits);
        }

        /// <summary>
        /// Returns true if DialerAttemptLimitsConfigChangeAttemptLimits instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerAttemptLimitsConfigChangeAttemptLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerAttemptLimitsConfigChangeAttemptLimits other)
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
                    this.BreadthFirstRecalls == other.BreadthFirstRecalls ||
                    this.BreadthFirstRecalls != null &&
                    this.BreadthFirstRecalls.Equals(other.BreadthFirstRecalls)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                
                if (this.BreadthFirstRecalls != null)
                    hash = hash * 59 + this.BreadthFirstRecalls.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}

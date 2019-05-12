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
    /// DialerOutboundSettingsConfigChangeOutboundSettings
    /// </summary>
    [DataContract]
    public partial class DialerOutboundSettingsConfigChangeOutboundSettings :  IEquatable<DialerOutboundSettingsConfigChangeOutboundSettings>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ComplianceAbandonRateDenominator
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ComplianceAbandonRateDenominatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum AllCalls for "ALL_CALLS"
            /// </summary>
            [EnumMember(Value = "ALL_CALLS")]
            AllCalls,
            
            /// <summary>
            /// Enum CallsThatReachedQueue for "CALLS_THAT_REACHED_QUEUE"
            /// </summary>
            [EnumMember(Value = "CALLS_THAT_REACHED_QUEUE")]
            CallsThatReachedQueue
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets ComplianceAbandonRateDenominator
        /// </summary>
        [DataMember(Name="complianceAbandonRateDenominator", EmitDefaultValue=false)]
        public ComplianceAbandonRateDenominatorEnum? ComplianceAbandonRateDenominator { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerOutboundSettingsConfigChangeOutboundSettings" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="DateCreated">DateCreated.</param>
        /// <param name="DateModified">DateModified.</param>
        /// <param name="Version">Version.</param>
        /// <param name="MaxCallsPerAgent">MaxCallsPerAgent.</param>
        /// <param name="MaxLineUtilization">MaxLineUtilization.</param>
        /// <param name="AbandonSeconds">AbandonSeconds.</param>
        /// <param name="ComplianceAbandonRateDenominator">ComplianceAbandonRateDenominator.</param>
        /// <param name="AutomaticTimeZoneMapping">AutomaticTimeZoneMapping.</param>
        public DialerOutboundSettingsConfigChangeOutboundSettings(string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, int? Version = null, int? MaxCallsPerAgent = null, double? MaxLineUtilization = null, double? AbandonSeconds = null, ComplianceAbandonRateDenominatorEnum? ComplianceAbandonRateDenominator = null, DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings AutomaticTimeZoneMapping = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            this.MaxCallsPerAgent = MaxCallsPerAgent;
            this.MaxLineUtilization = MaxLineUtilization;
            this.AbandonSeconds = AbandonSeconds;
            this.ComplianceAbandonRateDenominator = ComplianceAbandonRateDenominator;
            this.AutomaticTimeZoneMapping = AutomaticTimeZoneMapping;
            
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
        /// Gets or Sets MaxCallsPerAgent
        /// </summary>
        [DataMember(Name="maxCallsPerAgent", EmitDefaultValue=false)]
        public int? MaxCallsPerAgent { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MaxLineUtilization
        /// </summary>
        [DataMember(Name="maxLineUtilization", EmitDefaultValue=false)]
        public double? MaxLineUtilization { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AbandonSeconds
        /// </summary>
        [DataMember(Name="abandonSeconds", EmitDefaultValue=false)]
        public double? AbandonSeconds { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets AutomaticTimeZoneMapping
        /// </summary>
        [DataMember(Name="automaticTimeZoneMapping", EmitDefaultValue=false)]
        public DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings AutomaticTimeZoneMapping { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerOutboundSettingsConfigChangeOutboundSettings {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  MaxCallsPerAgent: ").Append(MaxCallsPerAgent).Append("\n");
            sb.Append("  MaxLineUtilization: ").Append(MaxLineUtilization).Append("\n");
            sb.Append("  AbandonSeconds: ").Append(AbandonSeconds).Append("\n");
            sb.Append("  ComplianceAbandonRateDenominator: ").Append(ComplianceAbandonRateDenominator).Append("\n");
            sb.Append("  AutomaticTimeZoneMapping: ").Append(AutomaticTimeZoneMapping).Append("\n");
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
            return this.Equals(obj as DialerOutboundSettingsConfigChangeOutboundSettings);
        }

        /// <summary>
        /// Returns true if DialerOutboundSettingsConfigChangeOutboundSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerOutboundSettingsConfigChangeOutboundSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerOutboundSettingsConfigChangeOutboundSettings other)
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
                    this.MaxCallsPerAgent == other.MaxCallsPerAgent ||
                    this.MaxCallsPerAgent != null &&
                    this.MaxCallsPerAgent.Equals(other.MaxCallsPerAgent)
                ) &&
                (
                    this.MaxLineUtilization == other.MaxLineUtilization ||
                    this.MaxLineUtilization != null &&
                    this.MaxLineUtilization.Equals(other.MaxLineUtilization)
                ) &&
                (
                    this.AbandonSeconds == other.AbandonSeconds ||
                    this.AbandonSeconds != null &&
                    this.AbandonSeconds.Equals(other.AbandonSeconds)
                ) &&
                (
                    this.ComplianceAbandonRateDenominator == other.ComplianceAbandonRateDenominator ||
                    this.ComplianceAbandonRateDenominator != null &&
                    this.ComplianceAbandonRateDenominator.Equals(other.ComplianceAbandonRateDenominator)
                ) &&
                (
                    this.AutomaticTimeZoneMapping == other.AutomaticTimeZoneMapping ||
                    this.AutomaticTimeZoneMapping != null &&
                    this.AutomaticTimeZoneMapping.Equals(other.AutomaticTimeZoneMapping)
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
                
                if (this.MaxCallsPerAgent != null)
                    hash = hash * 59 + this.MaxCallsPerAgent.GetHashCode();
                
                if (this.MaxLineUtilization != null)
                    hash = hash * 59 + this.MaxLineUtilization.GetHashCode();
                
                if (this.AbandonSeconds != null)
                    hash = hash * 59 + this.AbandonSeconds.GetHashCode();
                
                if (this.ComplianceAbandonRateDenominator != null)
                    hash = hash * 59 + this.ComplianceAbandonRateDenominator.GetHashCode();
                
                if (this.AutomaticTimeZoneMapping != null)
                    hash = hash * 59 + this.AutomaticTimeZoneMapping.GetHashCode();
                
                return hash;
            }
        }
    }

}

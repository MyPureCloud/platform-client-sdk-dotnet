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
        /// The denominator to be used in determining the compliance abandon rate
        /// </summary>
        /// <value>The denominator to be used in determining the compliance abandon rate</value>
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
        /// The denominator to be used in determining the compliance abandon rate
        /// </summary>
        /// <value>The denominator to be used in determining the compliance abandon rate</value>
        [DataMember(Name="complianceAbandonRateDenominator", EmitDefaultValue=false)]
        public ComplianceAbandonRateDenominatorEnum? ComplianceAbandonRateDenominator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerOutboundSettingsConfigChangeOutboundSettings" /> class.
        /// </summary>
        /// <param name="MaxCallsPerAgent">The maximum number of calls that can be placed per agent on any campaign.</param>
        /// <param name="MaxLineUtilization">The maximum percentage of lines that should be used for Outbound, expressed as a decimal in the range [0.0, 1.0].</param>
        /// <param name="AbandonSeconds">The number of seconds used to determine if a call is abandoned.</param>
        /// <param name="ComplianceAbandonRateDenominator">The denominator to be used in determining the compliance abandon rate.</param>
        /// <param name="AutomaticTimeZoneMapping">AutomaticTimeZoneMapping.</param>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Name">The UI-visible name of the object.</param>
        /// <param name="DateCreated">Creation time of the entity.</param>
        /// <param name="DateModified">Last modified time of the entity.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        public DialerOutboundSettingsConfigChangeOutboundSettings(long? MaxCallsPerAgent = null, double? MaxLineUtilization = null, double? AbandonSeconds = null, ComplianceAbandonRateDenominatorEnum? ComplianceAbandonRateDenominator = null, DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings AutomaticTimeZoneMapping = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
        {
            this.MaxCallsPerAgent = MaxCallsPerAgent;
            this.MaxLineUtilization = MaxLineUtilization;
            this.AbandonSeconds = AbandonSeconds;
            this.ComplianceAbandonRateDenominator = ComplianceAbandonRateDenominator;
            this.AutomaticTimeZoneMapping = AutomaticTimeZoneMapping;
            this.Id = Id;
            this.Name = Name;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.Version = Version;
            
        }
        


        /// <summary>
        /// The maximum number of calls that can be placed per agent on any campaign
        /// </summary>
        /// <value>The maximum number of calls that can be placed per agent on any campaign</value>
        [DataMember(Name="maxCallsPerAgent", EmitDefaultValue=false)]
        public long? MaxCallsPerAgent { get; set; }



        /// <summary>
        /// The maximum percentage of lines that should be used for Outbound, expressed as a decimal in the range [0.0, 1.0]
        /// </summary>
        /// <value>The maximum percentage of lines that should be used for Outbound, expressed as a decimal in the range [0.0, 1.0]</value>
        [DataMember(Name="maxLineUtilization", EmitDefaultValue=false)]
        public double? MaxLineUtilization { get; set; }



        /// <summary>
        /// The number of seconds used to determine if a call is abandoned
        /// </summary>
        /// <value>The number of seconds used to determine if a call is abandoned</value>
        [DataMember(Name="abandonSeconds", EmitDefaultValue=false)]
        public double? AbandonSeconds { get; set; }





        /// <summary>
        /// Gets or Sets AutomaticTimeZoneMapping
        /// </summary>
        [DataMember(Name="automaticTimeZoneMapping", EmitDefaultValue=false)]
        public DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings AutomaticTimeZoneMapping { get; set; }



        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The UI-visible name of the object
        /// </summary>
        /// <value>The UI-visible name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Creation time of the entity
        /// </summary>
        /// <value>Creation time of the entity</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Last modified time of the entity
        /// </summary>
        /// <value>Last modified time of the entity</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerOutboundSettingsConfigChangeOutboundSettings {\n");

            sb.Append("  MaxCallsPerAgent: ").Append(MaxCallsPerAgent).Append("\n");
            sb.Append("  MaxLineUtilization: ").Append(MaxLineUtilization).Append("\n");
            sb.Append("  AbandonSeconds: ").Append(AbandonSeconds).Append("\n");
            sb.Append("  ComplianceAbandonRateDenominator: ").Append(ComplianceAbandonRateDenominator).Append("\n");
            sb.Append("  AutomaticTimeZoneMapping: ").Append(AutomaticTimeZoneMapping).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
                ) &&
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

                return hash;
            }
        }
    }

}

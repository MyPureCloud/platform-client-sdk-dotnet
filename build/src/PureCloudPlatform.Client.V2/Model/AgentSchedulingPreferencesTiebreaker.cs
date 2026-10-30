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
    /// AgentSchedulingPreferencesTiebreaker
    /// </summary>
    [DataContract]
    public partial class AgentSchedulingPreferencesTiebreaker :  IEquatable<AgentSchedulingPreferencesTiebreaker>
    {
        /// <summary>
        /// The primary ranking tiebreaker used when agents have equal preference scores
        /// </summary>
        /// <value>The primary ranking tiebreaker used when agents have equal preference scores</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PrimaryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom,
            
            /// <summary>
            /// Enum Hiredate for "HireDate"
            /// </summary>
            [EnumMember(Value = "HireDate")]
            Hiredate,
            
            /// <summary>
            /// Enum Performance for "Performance"
            /// </summary>
            [EnumMember(Value = "Performance")]
            Performance,
            
            /// <summary>
            /// Enum Randomlyassign for "RandomlyAssign"
            /// </summary>
            [EnumMember(Value = "RandomlyAssign")]
            Randomlyassign
        }
        /// <summary>
        /// The secondary ranking tiebreaker. Omit when primary is RandomlyAssign
        /// </summary>
        /// <value>The secondary ranking tiebreaker. Omit when primary is RandomlyAssign</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SecondaryEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom,
            
            /// <summary>
            /// Enum Hiredate for "HireDate"
            /// </summary>
            [EnumMember(Value = "HireDate")]
            Hiredate,
            
            /// <summary>
            /// Enum Performance for "Performance"
            /// </summary>
            [EnumMember(Value = "Performance")]
            Performance,
            
            /// <summary>
            /// Enum Randomlyassign for "RandomlyAssign"
            /// </summary>
            [EnumMember(Value = "RandomlyAssign")]
            Randomlyassign
        }
        /// <summary>
        /// The primary ranking tiebreaker used when agents have equal preference scores
        /// </summary>
        /// <value>The primary ranking tiebreaker used when agents have equal preference scores</value>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public PrimaryEnum? Primary { get; set; }
        /// <summary>
        /// The secondary ranking tiebreaker. Omit when primary is RandomlyAssign
        /// </summary>
        /// <value>The secondary ranking tiebreaker. Omit when primary is RandomlyAssign</value>
        [DataMember(Name="secondary", EmitDefaultValue=false)]
        public SecondaryEnum? Secondary { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSchedulingPreferencesTiebreaker" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AgentSchedulingPreferencesTiebreaker() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSchedulingPreferencesTiebreaker" /> class.
        /// </summary>
        /// <param name="Primary">The primary ranking tiebreaker used when agents have equal preference scores (required).</param>
        /// <param name="Secondary">The secondary ranking tiebreaker. Omit when primary is RandomlyAssign.</param>
        public AgentSchedulingPreferencesTiebreaker(PrimaryEnum? Primary = null, SecondaryEnum? Secondary = null)
        {
            this.Primary = Primary;
            this.Secondary = Secondary;
            
        }
        





        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentSchedulingPreferencesTiebreaker {\n");

            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Secondary: ").Append(Secondary).Append("\n");
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
            return this.Equals(obj as AgentSchedulingPreferencesTiebreaker);
        }

        /// <summary>
        /// Returns true if AgentSchedulingPreferencesTiebreaker instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentSchedulingPreferencesTiebreaker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentSchedulingPreferencesTiebreaker other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Primary == other.Primary ||
                    this.Primary != null &&
                    this.Primary.Equals(other.Primary)
                ) &&
                (
                    this.Secondary == other.Secondary ||
                    this.Secondary != null &&
                    this.Secondary.Equals(other.Secondary)
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
                if (this.Primary != null)
                    hash = hash * 59 + this.Primary.GetHashCode();

                if (this.Secondary != null)
                    hash = hash * 59 + this.Secondary.GetHashCode();

                return hash;
            }
        }
    }

}

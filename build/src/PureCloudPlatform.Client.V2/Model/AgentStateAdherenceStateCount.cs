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
    /// AgentStateAdherenceStateCount
    /// </summary>
    [DataContract]
    public partial class AgentStateAdherenceStateCount :  IEquatable<AgentStateAdherenceStateCount>
    {
        /// <summary>
        /// Adherence state
        /// </summary>
        /// <value>Adherence state</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum AdherenceStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inadherence for "InAdherence"
            /// </summary>
            [EnumMember(Value = "InAdherence")]
            Inadherence,
            
            /// <summary>
            /// Enum Outofadherence for "OutOfAdherence"
            /// </summary>
            [EnumMember(Value = "OutOfAdherence")]
            Outofadherence,
            
            /// <summary>
            /// Enum Unscheduled for "Unscheduled"
            /// </summary>
            [EnumMember(Value = "Unscheduled")]
            Unscheduled,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Ignored for "Ignored"
            /// </summary>
            [EnumMember(Value = "Ignored")]
            Ignored,
            
            /// <summary>
            /// Enum Explained for "Explained"
            /// </summary>
            [EnumMember(Value = "Explained")]
            Explained
        }
        /// <summary>
        /// Adherence state
        /// </summary>
        /// <value>Adherence state</value>
        [DataMember(Name="adherenceState", EmitDefaultValue=false)]
        public AdherenceStateEnum? AdherenceState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStateAdherenceStateCount" /> class.
        /// </summary>
        /// <param name="AdherenceState">Adherence state.</param>
        /// <param name="Count">Count of users with this adherence state.</param>
        public AgentStateAdherenceStateCount(AdherenceStateEnum? AdherenceState = null, int? Count = null)
        {
            this.AdherenceState = AdherenceState;
            this.Count = Count;
            
        }
        




        /// <summary>
        /// Count of users with this adherence state
        /// </summary>
        /// <value>Count of users with this adherence state</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentStateAdherenceStateCount {\n");

            sb.Append("  AdherenceState: ").Append(AdherenceState).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as AgentStateAdherenceStateCount);
        }

        /// <summary>
        /// Returns true if AgentStateAdherenceStateCount instances are equal
        /// </summary>
        /// <param name="other">Instance of AgentStateAdherenceStateCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgentStateAdherenceStateCount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.AdherenceState == other.AdherenceState ||
                    this.AdherenceState != null &&
                    this.AdherenceState.Equals(other.AdherenceState)
                ) &&
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.AdherenceState != null)
                    hash = hash * 59 + this.AdherenceState.GetHashCode();

                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();

                return hash;
            }
        }
    }

}

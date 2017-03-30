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
    /// AcwSettings
    /// </summary>
    [DataContract]
    public partial class AcwSettings :  IEquatable<AcwSettings>
    {
        /// <summary>
        /// This field controls how the UI prompts the agent for a wrapup.
        /// </summary>
        /// <value>This field controls how the UI prompts the agent for a wrapup.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum WrapupPromptEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Mandatory for "MANDATORY"
            /// </summary>
            [EnumMember(Value = "MANDATORY")]
            Mandatory,
            
            /// <summary>
            /// Enum Optional for "OPTIONAL"
            /// </summary>
            [EnumMember(Value = "OPTIONAL")]
            Optional,
            
            /// <summary>
            /// Enum MandatoryTimeout for "MANDATORY_TIMEOUT"
            /// </summary>
            [EnumMember(Value = "MANDATORY_TIMEOUT")]
            MandatoryTimeout,
            
            /// <summary>
            /// Enum MandatoryForcedTimeout for "MANDATORY_FORCED_TIMEOUT"
            /// </summary>
            [EnumMember(Value = "MANDATORY_FORCED_TIMEOUT")]
            MandatoryForcedTimeout
        }
        /// <summary>
        /// This field controls how the UI prompts the agent for a wrapup.
        /// </summary>
        /// <value>This field controls how the UI prompts the agent for a wrapup.</value>
        [DataMember(Name="wrapupPrompt", EmitDefaultValue=false)]
        public WrapupPromptEnum? WrapupPrompt { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AcwSettings" /> class.
        /// </summary>
        /// <param name="WrapupPrompt">This field controls how the UI prompts the agent for a wrapup..</param>
        /// <param name="TimeoutMs">The amount of time the agent can stay in ACW (Min: 1 sec, Max: 1 day).  Can only be used when ACW is MANDATORY_TIMEOUT or MANDATORY_FORCED_TIMEOUT..</param>
        public AcwSettings(WrapupPromptEnum? WrapupPrompt = null, int? TimeoutMs = null)
        {
            this.WrapupPrompt = WrapupPrompt;
            this.TimeoutMs = TimeoutMs;
        }
        
        /// <summary>
        /// The amount of time the agent can stay in ACW (Min: 1 sec, Max: 1 day).  Can only be used when ACW is MANDATORY_TIMEOUT or MANDATORY_FORCED_TIMEOUT.
        /// </summary>
        /// <value>The amount of time the agent can stay in ACW (Min: 1 sec, Max: 1 day).  Can only be used when ACW is MANDATORY_TIMEOUT or MANDATORY_FORCED_TIMEOUT.</value>
        [DataMember(Name="timeoutMs", EmitDefaultValue=false)]
        public int? TimeoutMs { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcwSettings {\n");
            sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
            sb.Append("  TimeoutMs: ").Append(TimeoutMs).Append("\n");
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
            return this.Equals(obj as AcwSettings);
        }

        /// <summary>
        /// Returns true if AcwSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of AcwSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcwSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.WrapupPrompt == other.WrapupPrompt ||
                    this.WrapupPrompt != null &&
                    this.WrapupPrompt.Equals(other.WrapupPrompt)
                ) &&
                (
                    this.TimeoutMs == other.TimeoutMs ||
                    this.TimeoutMs != null &&
                    this.TimeoutMs.Equals(other.TimeoutMs)
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
                if (this.WrapupPrompt != null)
                    hash = hash * 59 + this.WrapupPrompt.GetHashCode();
                if (this.TimeoutMs != null)
                    hash = hash * 59 + this.TimeoutMs.GetHashCode();
                return hash;
            }
        }
    }

}

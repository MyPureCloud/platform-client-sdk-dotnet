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
    /// CallSimulationResult
    /// </summary>
    [DataContract]
    public partial class CallSimulationResult :  IEquatable<CallSimulationResult>
    {
        /// <summary>
        /// The simulation level
        /// </summary>
        /// <value>The simulation level</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum LevelEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Ngn for "NGN"
            /// </summary>
            [EnumMember(Value = "NGN")]
            Ngn,
            
            /// <summary>
            /// Enum Blockprefixsupport for "BlockPrefixSupport"
            /// </summary>
            [EnumMember(Value = "BlockPrefixSupport")]
            Blockprefixsupport,
            
            /// <summary>
            /// Enum Allowprefix for "AllowPrefix"
            /// </summary>
            [EnumMember(Value = "AllowPrefix")]
            Allowprefix,
            
            /// <summary>
            /// Enum Blockprefix for "BlockPrefix"
            /// </summary>
            [EnumMember(Value = "BlockPrefix")]
            Blockprefix,
            
            /// <summary>
            /// Enum Highcost for "HighCost"
            /// </summary>
            [EnumMember(Value = "HighCost")]
            Highcost
        }
        /// <summary>
        /// The simulation level
        /// </summary>
        /// <value>The simulation level</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallSimulationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallSimulationResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CallSimulationResult" /> class.
        /// </summary>
        /// <param name="Allowed">Whether the call is allowed (required).</param>
        /// <param name="Level">The simulation level.</param>
        /// <param name="MatchedPrefix">The matched prefix.</param>
        public CallSimulationResult(bool? Allowed = null, LevelEnum? Level = null, string MatchedPrefix = null)
        {
            this.Allowed = Allowed;
            this.Level = Level;
            this.MatchedPrefix = MatchedPrefix;
            
        }
        


        /// <summary>
        /// Whether the call is allowed
        /// </summary>
        /// <value>Whether the call is allowed</value>
        [DataMember(Name="allowed", EmitDefaultValue=false)]
        public bool? Allowed { get; set; }





        /// <summary>
        /// The matched prefix
        /// </summary>
        /// <value>The matched prefix</value>
        [DataMember(Name="matchedPrefix", EmitDefaultValue=false)]
        public string MatchedPrefix { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallSimulationResult {\n");

            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  MatchedPrefix: ").Append(MatchedPrefix).Append("\n");
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
            return this.Equals(obj as CallSimulationResult);
        }

        /// <summary>
        /// Returns true if CallSimulationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of CallSimulationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallSimulationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Allowed == other.Allowed ||
                    this.Allowed != null &&
                    this.Allowed.Equals(other.Allowed)
                ) &&
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) &&
                (
                    this.MatchedPrefix == other.MatchedPrefix ||
                    this.MatchedPrefix != null &&
                    this.MatchedPrefix.Equals(other.MatchedPrefix)
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
                if (this.Allowed != null)
                    hash = hash * 59 + this.Allowed.GetHashCode();

                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();

                if (this.MatchedPrefix != null)
                    hash = hash * 59 + this.MatchedPrefix.GetHashCode();

                return hash;
            }
        }
    }

}

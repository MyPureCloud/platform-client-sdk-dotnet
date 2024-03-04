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
    /// Defines a characteristic that can be captured by data providers
    /// </summary>
    [DataContract]
    public partial class FlowLogLevelCharacteristicsDefinition :  IEquatable<FlowLogLevelCharacteristicsDefinition>
    {
        /// <summary>
        /// The minimum level required for this characteristic to be enabled.
        /// </summary>
        /// <value>The minimum level required for this characteristic to be enabled.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum MinimumLevelEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum Disabled for "Disabled"
            /// </summary>
            [EnumMember(Value = "Disabled")]
            Disabled,
            
            /// <summary>
            /// Enum Base for "Base"
            /// </summary>
            [EnumMember(Value = "Base")]
            Base,
            
            /// <summary>
            /// Enum Notes for "Notes"
            /// </summary>
            [EnumMember(Value = "Notes")]
            Notes,
            
            /// <summary>
            /// Enum Verbosenotes for "VerboseNotes"
            /// </summary>
            [EnumMember(Value = "VerboseNotes")]
            Verbosenotes,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All
        }
        /// <summary>
        /// The minimum level required for this characteristic to be enabled.
        /// </summary>
        /// <value>The minimum level required for this characteristic to be enabled.</value>
        [DataMember(Name="minimumLevel", EmitDefaultValue=false)]
        public MinimumLevelEnum? MinimumLevel { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowLogLevelCharacteristicsDefinition" /> class.
        /// </summary>
        public FlowLogLevelCharacteristicsDefinition()
        {
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }





        /// <summary>
        /// If set, this is the id of the characteristic that this one depends on and it must be enabled for this to be enabled.
        /// </summary>
        /// <value>If set, this is the id of the characteristic that this one depends on and it must be enabled for this to be enabled.</value>
        [DataMember(Name="dependsOn", EmitDefaultValue=false)]
        public FlowCharacteristics DependsOn { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowLogLevelCharacteristicsDefinition {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MinimumLevel: ").Append(MinimumLevel).Append("\n");
            sb.Append("  DependsOn: ").Append(DependsOn).Append("\n");
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
            return this.Equals(obj as FlowLogLevelCharacteristicsDefinition);
        }

        /// <summary>
        /// Returns true if FlowLogLevelCharacteristicsDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of FlowLogLevelCharacteristicsDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowLogLevelCharacteristicsDefinition other)
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
                    this.MinimumLevel == other.MinimumLevel ||
                    this.MinimumLevel != null &&
                    this.MinimumLevel.Equals(other.MinimumLevel)
                ) &&
                (
                    this.DependsOn == other.DependsOn ||
                    this.DependsOn != null &&
                    this.DependsOn.Equals(other.DependsOn)
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

                if (this.MinimumLevel != null)
                    hash = hash * 59 + this.MinimumLevel.GetHashCode();

                if (this.DependsOn != null)
                    hash = hash * 59 + this.DependsOn.GetHashCode();

                return hash;
            }
        }
    }

}

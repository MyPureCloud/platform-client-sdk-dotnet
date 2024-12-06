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
    /// EvaluationSettingsAssignee
    /// </summary>
    [DataContract]
    public partial class EvaluationSettingsAssignee :  IEquatable<EvaluationSettingsAssignee>
    {
        /// <summary>
        /// The assignee type. Valid values: Original, Individual, None
        /// </summary>
        /// <value>The assignee type. Valid values: Original, Individual, None</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Original for "Original"
            /// </summary>
            [EnumMember(Value = "Original")]
            Original,
            
            /// <summary>
            /// Enum Individual for "Individual"
            /// </summary>
            [EnumMember(Value = "Individual")]
            Individual,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None
        }
        /// <summary>
        /// The assignee type. Valid values: Original, Individual, None
        /// </summary>
        /// <value>The assignee type. Valid values: Original, Individual, None</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSettingsAssignee" /> class.
        /// </summary>
        /// <param name="User">The user the dispute should be assigned to.</param>
        /// <param name="Type">The assignee type. Valid values: Original, Individual, None.</param>
        public EvaluationSettingsAssignee(UserReferenceWithName User = null, TypeEnum? Type = null)
        {
            this.User = User;
            this.Type = Type;
            
        }
        


        /// <summary>
        /// The user the dispute should be assigned to
        /// </summary>
        /// <value>The user the dispute should be assigned to</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReferenceWithName User { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationSettingsAssignee {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as EvaluationSettingsAssignee);
        }

        /// <summary>
        /// Returns true if EvaluationSettingsAssignee instances are equal
        /// </summary>
        /// <param name="other">Instance of EvaluationSettingsAssignee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationSettingsAssignee other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                return hash;
            }
        }
    }

}

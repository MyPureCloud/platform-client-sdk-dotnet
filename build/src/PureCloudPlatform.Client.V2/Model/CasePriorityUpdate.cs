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
    /// CasePriorityUpdate
    /// </summary>
    [DataContract]
    public partial class CasePriorityUpdate :  IEquatable<CasePriorityUpdate>
    {
        /// <summary>
        /// The priority of the Case.
        /// </summary>
        /// <value>The priority of the Case.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PriorityEnum
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
            /// Enum Urgent for "Urgent"
            /// </summary>
            [EnumMember(Value = "Urgent")]
            Urgent,
            
            /// <summary>
            /// Enum High for "High"
            /// </summary>
            [EnumMember(Value = "High")]
            High,
            
            /// <summary>
            /// Enum Medium for "Medium"
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium,
            
            /// <summary>
            /// Enum Low for "Low"
            /// </summary>
            [EnumMember(Value = "Low")]
            Low
        }
        /// <summary>
        /// The priority of the Case.
        /// </summary>
        /// <value>The priority of the Case.</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public PriorityEnum? Priority { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CasePriorityUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CasePriorityUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CasePriorityUpdate" /> class.
        /// </summary>
        /// <param name="Priority">The priority of the Case. (required).</param>
        public CasePriorityUpdate(PriorityEnum? Priority = null)
        {
            this.Priority = Priority;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CasePriorityUpdate {\n");

            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(obj as CasePriorityUpdate);
        }

        /// <summary>
        /// Returns true if CasePriorityUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of CasePriorityUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CasePriorityUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
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
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();

                return hash;
            }
        }
    }

}

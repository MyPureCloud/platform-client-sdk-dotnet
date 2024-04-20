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
    /// SupportedEntityTypeStatus
    /// </summary>
    [DataContract]
    public partial class SupportedEntityTypeStatus :  IEquatable<SupportedEntityTypeStatus>
    {
        /// <summary>
        /// The configuration status of restricted lists
        /// </summary>
        /// <value>The configuration status of restricted lists</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ListSlotTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All,
            
            /// <summary>
            /// Enum Restricted for "Restricted"
            /// </summary>
            [EnumMember(Value = "Restricted")]
            Restricted,
            
            /// <summary>
            /// Enum Unrestricted for "Unrestricted"
            /// </summary>
            [EnumMember(Value = "Unrestricted")]
            Unrestricted
        }
        /// <summary>
        /// The configuration status of restricted lists
        /// </summary>
        /// <value>The configuration status of restricted lists</value>
        [DataMember(Name="listSlotType", EmitDefaultValue=false)]
        public ListSlotTypeEnum? ListSlotType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedEntityTypeStatus" /> class.
        /// </summary>
        /// <param name="ListSlotType">The configuration status of restricted lists.</param>
        public SupportedEntityTypeStatus(ListSlotTypeEnum? ListSlotType = null)
        {
            this.ListSlotType = ListSlotType;
            
        }
        



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportedEntityTypeStatus {\n");

            sb.Append("  ListSlotType: ").Append(ListSlotType).Append("\n");
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
            return this.Equals(obj as SupportedEntityTypeStatus);
        }

        /// <summary>
        /// Returns true if SupportedEntityTypeStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportedEntityTypeStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportedEntityTypeStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ListSlotType == other.ListSlotType ||
                    this.ListSlotType != null &&
                    this.ListSlotType.Equals(other.ListSlotType)
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
                if (this.ListSlotType != null)
                    hash = hash * 59 + this.ListSlotType.GetHashCode();

                return hash;
            }
        }
    }

}

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
    /// Defines a SCIM phone number.
    /// </summary>
    [DataContract]
    public partial class ScimPhoneNumber :  IEquatable<ScimPhoneNumber>
    {
        
        
        
        
        
        /// <summary>
        /// The type of phone number.
        /// </summary>
        /// <value>The type of phone number.</value>
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
            /// Enum Work for "work"
            /// </summary>
            [EnumMember(Value = "work")]
            Work,
            
            /// <summary>
            /// Enum Work2 for "work2"
            /// </summary>
            [EnumMember(Value = "work2")]
            Work2,
            
            /// <summary>
            /// Enum Work3 for "work3"
            /// </summary>
            [EnumMember(Value = "work3")]
            Work3,
            
            /// <summary>
            /// Enum Work4 for "work4"
            /// </summary>
            [EnumMember(Value = "work4")]
            Work4,
            
            /// <summary>
            /// Enum Home for "home"
            /// </summary>
            [EnumMember(Value = "home")]
            Home,
            
            /// <summary>
            /// Enum Mobile for "mobile"
            /// </summary>
            [EnumMember(Value = "mobile")]
            Mobile,
            
            /// <summary>
            /// Enum Other for "other"
            /// </summary>
            [EnumMember(Value = "other")]
            Other,
            
            /// <summary>
            /// Enum Microsoftteams for "microsoftteams"
            /// </summary>
            [EnumMember(Value = "microsoftteams")]
            Microsoftteams,
            
            /// <summary>
            /// Enum Zoomphone for "zoomphone"
            /// </summary>
            [EnumMember(Value = "zoomphone")]
            Zoomphone,
            
            /// <summary>
            /// Enum Ringcentral for "ringcentral"
            /// </summary>
            [EnumMember(Value = "ringcentral")]
            Ringcentral
        }
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of phone number.
        /// </summary>
        /// <value>The type of phone number.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimPhoneNumber" /> class.
        /// </summary>
        /// <param name="Value">The phone number in E.164 or tel URI format, for example, tel:+nnnnnnnn; ext=xxxxx..</param>
        /// <param name="Type">The type of phone number..</param>
        /// <param name="Primary">Indicates whether the phone number is the primary phone number..</param>
        public ScimPhoneNumber(string Value = null, TypeEnum? Type = null, bool? Primary = null)
        {
            this.Value = Value;
            this.Type = Type;
            this.Primary = Primary;
            
        }
        
        
        
        /// <summary>
        /// The phone number in E.164 or tel URI format, for example, tel:+nnnnnnnn; ext=xxxxx.
        /// </summary>
        /// <value>The phone number in E.164 or tel URI format, for example, tel:+nnnnnnnn; ext=xxxxx.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        
        
        
        
        
        /// <summary>
        /// Indicates whether the phone number is the primary phone number.
        /// </summary>
        /// <value>Indicates whether the phone number is the primary phone number.</value>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public bool? Primary { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimPhoneNumber {\n");
            
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
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
            return this.Equals(obj as ScimPhoneNumber);
        }

        /// <summary>
        /// Returns true if ScimPhoneNumber instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimPhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimPhoneNumber other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Primary == other.Primary ||
                    this.Primary != null &&
                    this.Primary.Equals(other.Primary)
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
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Primary != null)
                    hash = hash * 59 + this.Primary.GetHashCode();
                
                return hash;
            }
        }
    }

}

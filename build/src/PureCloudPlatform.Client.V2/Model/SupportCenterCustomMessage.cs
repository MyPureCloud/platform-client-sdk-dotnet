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
    /// SupportCenterCustomMessage
    /// </summary>
    [DataContract]
    public partial class SupportCenterCustomMessage :  IEquatable<SupportCenterCustomMessage>
    {
        
        
        
        
        
        /// <summary>
        /// Type of the message
        /// </summary>
        /// <value>Type of the message</value>
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
            /// Enum Welcome for "Welcome"
            /// </summary>
            [EnumMember(Value = "Welcome")]
            Welcome,
            
            /// <summary>
            /// Enum Fallback for "Fallback"
            /// </summary>
            [EnumMember(Value = "Fallback")]
            Fallback
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Type of the message
        /// </summary>
        /// <value>Type of the message</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportCenterCustomMessage" /> class.
        /// </summary>
        /// <param name="DefaultValue">Default value for the message.</param>
        /// <param name="Type">Type of the message.</param>
        public SupportCenterCustomMessage(string DefaultValue = null, TypeEnum? Type = null)
        {
            this.DefaultValue = DefaultValue;
            this.Type = Type;
            
        }
        
        
        
        /// <summary>
        /// Default value for the message
        /// </summary>
        /// <value>Default value for the message</value>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }
        
        
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportCenterCustomMessage {\n");
            
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
            return this.Equals(obj as SupportCenterCustomMessage);
        }

        /// <summary>
        /// Returns true if SupportCenterCustomMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of SupportCenterCustomMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupportCenterCustomMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DefaultValue == other.DefaultValue ||
                    this.DefaultValue != null &&
                    this.DefaultValue.Equals(other.DefaultValue)
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
                
                if (this.DefaultValue != null)
                    hash = hash * 59 + this.DefaultValue.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }
    }

}

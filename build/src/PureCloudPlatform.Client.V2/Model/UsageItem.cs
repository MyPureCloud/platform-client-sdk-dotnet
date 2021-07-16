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
    /// UsageItem
    /// </summary>
    [DataContract]
    public partial class UsageItem :  IEquatable<UsageItem>
    {
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
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
            /// Enum Recording for "RECORDING"
            /// </summary>
            [EnumMember(Value = "RECORDING")]
            Recording,
            
            /// <summary>
            /// Enum Fax for "FAX"
            /// </summary>
            [EnumMember(Value = "FAX")]
            Fax,
            
            /// <summary>
            /// Enum Document for "DOCUMENT"
            /// </summary>
            [EnumMember(Value = "DOCUMENT")]
            Document,
            
            /// <summary>
            /// Enum All for "ALL"
            /// </summary>
            [EnumMember(Value = "ALL")]
            All
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageItem" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="TotalDocumentByteCount">TotalDocumentByteCount.</param>
        /// <param name="TotalDocumentCount">TotalDocumentCount.</param>
        public UsageItem(TypeEnum? Type = null, long? TotalDocumentByteCount = null, long? TotalDocumentCount = null)
        {
            this.Type = Type;
            this.TotalDocumentByteCount = TotalDocumentByteCount;
            this.TotalDocumentCount = TotalDocumentCount;
            
        }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets TotalDocumentByteCount
        /// </summary>
        [DataMember(Name="totalDocumentByteCount", EmitDefaultValue=false)]
        public long? TotalDocumentByteCount { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets TotalDocumentCount
        /// </summary>
        [DataMember(Name="totalDocumentCount", EmitDefaultValue=false)]
        public long? TotalDocumentCount { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsageItem {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TotalDocumentByteCount: ").Append(TotalDocumentByteCount).Append("\n");
            sb.Append("  TotalDocumentCount: ").Append(TotalDocumentCount).Append("\n");
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
            return this.Equals(obj as UsageItem);
        }

        /// <summary>
        /// Returns true if UsageItem instances are equal
        /// </summary>
        /// <param name="other">Instance of UsageItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsageItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.TotalDocumentByteCount == other.TotalDocumentByteCount ||
                    this.TotalDocumentByteCount != null &&
                    this.TotalDocumentByteCount.Equals(other.TotalDocumentByteCount)
                ) &&
                (
                    this.TotalDocumentCount == other.TotalDocumentCount ||
                    this.TotalDocumentCount != null &&
                    this.TotalDocumentCount.Equals(other.TotalDocumentCount)
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
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.TotalDocumentByteCount != null)
                    hash = hash * 59 + this.TotalDocumentByteCount.GetHashCode();
                
                if (this.TotalDocumentCount != null)
                    hash = hash * 59 + this.TotalDocumentCount.GetHashCode();
                
                return hash;
            }
        }
    }

}

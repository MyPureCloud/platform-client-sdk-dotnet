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
    /// SCIM Error
    /// </summary>
    [DataContract]
    public partial class ScimError :  IEquatable<ScimError>
    {
        
        
        
        
        
        /// <summary>
        /// Optional SCIM Error Type when httpStatus is 400 error
        /// </summary>
        /// <value>Optional SCIM Error Type when httpStatus is 400 error</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ScimTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Invalidfilter for "invalidFilter"
            /// </summary>
            [EnumMember(Value = "invalidFilter")]
            Invalidfilter,
            
            /// <summary>
            /// Enum Toomany for "tooMany"
            /// </summary>
            [EnumMember(Value = "tooMany")]
            Toomany,
            
            /// <summary>
            /// Enum Uniqueness for "uniqueness"
            /// </summary>
            [EnumMember(Value = "uniqueness")]
            Uniqueness,
            
            /// <summary>
            /// Enum Mutability for "mutability"
            /// </summary>
            [EnumMember(Value = "mutability")]
            Mutability,
            
            /// <summary>
            /// Enum Invalidsyntax for "invalidSyntax"
            /// </summary>
            [EnumMember(Value = "invalidSyntax")]
            Invalidsyntax,
            
            /// <summary>
            /// Enum Invalidpath for "invalidPath"
            /// </summary>
            [EnumMember(Value = "invalidPath")]
            Invalidpath,
            
            /// <summary>
            /// Enum Notarget for "noTarget"
            /// </summary>
            [EnumMember(Value = "noTarget")]
            Notarget,
            
            /// <summary>
            /// Enum Invalidvalue for "invalidValue"
            /// </summary>
            [EnumMember(Value = "invalidValue")]
            Invalidvalue,
            
            /// <summary>
            /// Enum Invalidvers for "invalidVers"
            /// </summary>
            [EnumMember(Value = "invalidVers")]
            Invalidvers,
            
            /// <summary>
            /// Enum Sensitive for "sensitive"
            /// </summary>
            [EnumMember(Value = "sensitive")]
            Sensitive
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Optional SCIM Error Type when httpStatus is 400 error
        /// </summary>
        /// <value>Optional SCIM Error Type when httpStatus is 400 error</value>
        [DataMember(Name="scimType", EmitDefaultValue=false)]
        public ScimTypeEnum? ScimType { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimError" /> class.
        /// </summary>
        /// <param name="Schemas">Schemas for the SCIM Error.</param>
        public ScimError(List<string> Schemas = null)
        {
            this.Schemas = Schemas;
            
        }
        
        
        
        /// <summary>
        /// HTTP Status Code
        /// </summary>
        /// <value>HTTP Status Code</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }
        
        
        
        
        
        /// <summary>
        /// Optional detailed error description
        /// </summary>
        /// <value>Optional detailed error description</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; private set; }
        
        
        
        /// <summary>
        /// Schemas for the SCIM Error
        /// </summary>
        /// <value>Schemas for the SCIM Error</value>
        [DataMember(Name="schemas", EmitDefaultValue=false)]
        public List<string> Schemas { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimError {\n");
            
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ScimType: ").Append(ScimType).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Schemas: ").Append(Schemas).Append("\n");
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
            return this.Equals(obj as ScimError);
        }

        /// <summary>
        /// Returns true if ScimError instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.ScimType == other.ScimType ||
                    this.ScimType != null &&
                    this.ScimType.Equals(other.ScimType)
                ) &&
                (
                    this.Detail == other.Detail ||
                    this.Detail != null &&
                    this.Detail.Equals(other.Detail)
                ) &&
                (
                    this.Schemas == other.Schemas ||
                    this.Schemas != null &&
                    this.Schemas.SequenceEqual(other.Schemas)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.ScimType != null)
                    hash = hash * 59 + this.ScimType.GetHashCode();
                
                if (this.Detail != null)
                    hash = hash * 59 + this.Detail.GetHashCode();
                
                if (this.Schemas != null)
                    hash = hash * 59 + this.Schemas.GetHashCode();
                
                return hash;
            }
        }
    }

}

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
    /// Represents an individual patch operation. Path and value have very specific rules based on operation type. See https://tools.ietf.org/html/rfc7644#section-3.5.2 for details.
    /// </summary>
    [DataContract]
    public partial class ScimV2PatchOperation :  IEquatable<ScimV2PatchOperation>
    {
        
        
        /// <summary>
        /// The patch operation to perform.
        /// </summary>
        /// <value>The patch operation to perform.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum OpEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Add for "add"
            /// </summary>
            [EnumMember(Value = "add")]
            Add,
            
            /// <summary>
            /// Enum Replace for "replace"
            /// </summary>
            [EnumMember(Value = "replace")]
            Replace,
            
            /// <summary>
            /// Enum Remove for "remove"
            /// </summary>
            [EnumMember(Value = "remove")]
            Remove
        }
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The patch operation to perform.
        /// </summary>
        /// <value>The patch operation to perform.</value>
        [DataMember(Name="op", EmitDefaultValue=false)]
        public OpEnum? Op { get; set; }
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimV2PatchOperation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScimV2PatchOperation() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimV2PatchOperation" /> class.
        /// </summary>
        /// <param name="Op">The patch operation to perform. (required).</param>
        /// <param name="Path">The attribute path that describes the target of the operation. Required for a &#39;remove&#39; operation..</param>
        /// <param name="Value">The value to set in the path..</param>
        public ScimV2PatchOperation(OpEnum? Op = null, string Path = null, JsonNode Value = null)
        {
            this.Op = Op;
            this.Path = Path;
            this.Value = Value;
            
        }
        
        
        
        
        
        /// <summary>
        /// The attribute path that describes the target of the operation. Required for a &#39;remove&#39; operation.
        /// </summary>
        /// <value>The attribute path that describes the target of the operation. Required for a &#39;remove&#39; operation.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
        
        
        
        /// <summary>
        /// The value to set in the path.
        /// </summary>
        /// <value>The value to set in the path.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public JsonNode Value { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScimV2PatchOperation {\n");
            
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as ScimV2PatchOperation);
        }

        /// <summary>
        /// Returns true if ScimV2PatchOperation instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimV2PatchOperation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimV2PatchOperation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Op == other.Op ||
                    this.Op != null &&
                    this.Op.Equals(other.Op)
                ) &&
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                
                if (this.Op != null)
                    hash = hash * 59 + this.Op.GetHashCode();
                
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                return hash;
            }
        }
    }

}

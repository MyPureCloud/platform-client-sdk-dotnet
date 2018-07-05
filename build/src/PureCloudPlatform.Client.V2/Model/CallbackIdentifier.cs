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
    /// CallbackIdentifier
    /// </summary>
    [DataContract]
    public partial class CallbackIdentifier :  IEquatable<CallbackIdentifier>
    {
        
        
        /// <summary>
        /// The type of the associated callback participant
        /// </summary>
        /// <value>The type of the associated callback participant</value>
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
            /// Enum Acd for "ACD"
            /// </summary>
            [EnumMember(Value = "ACD")]
            Acd,
            
            /// <summary>
            /// Enum External for "EXTERNAL"
            /// </summary>
            [EnumMember(Value = "EXTERNAL")]
            External
        }
        
        
        
        
        
        
        
        
        /// <summary>
        /// The type of the associated callback participant
        /// </summary>
        /// <value>The type of the associated callback participant</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackIdentifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CallbackIdentifier() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackIdentifier" /> class.
        /// </summary>
        /// <param name="Type">The type of the associated callback participant (required).</param>
        /// <param name="Id">The identifier of the callback (required).</param>
        public CallbackIdentifier(TypeEnum? Type = null, string Id = null)
        {
            
        }
        
        
        
        
        
        /// <summary>
        /// The identifier of the callback
        /// </summary>
        /// <value>The identifier of the callback</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallbackIdentifier {\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as CallbackIdentifier);
        }

        /// <summary>
        /// Returns true if CallbackIdentifier instances are equal
        /// </summary>
        /// <param name="other">Instance of CallbackIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallbackIdentifier other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                return hash;
            }
        }
    }

}

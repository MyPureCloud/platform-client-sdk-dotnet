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
    /// KeyRotationSchedule
    /// </summary>
    [DataContract]
    public partial class KeyRotationSchedule :  IEquatable<KeyRotationSchedule>
    {
        
        
        
        
        
        
        
        
        /// <summary>
        /// Value to set schedule to
        /// </summary>
        /// <value>Value to set schedule to</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PeriodEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Disabled for "DISABLED"
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            Disabled,
            
            /// <summary>
            /// Enum Daily for "DAILY"
            /// </summary>
            [EnumMember(Value = "DAILY")]
            Daily,
            
            /// <summary>
            /// Enum Weekly for "WEEKLY"
            /// </summary>
            [EnumMember(Value = "WEEKLY")]
            Weekly,
            
            /// <summary>
            /// Enum Monthly for "MONTHLY"
            /// </summary>
            [EnumMember(Value = "MONTHLY")]
            Monthly,
            
            /// <summary>
            /// Enum Yearly for "YEARLY"
            /// </summary>
            [EnumMember(Value = "YEARLY")]
            Yearly
        }
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Value to set schedule to
        /// </summary>
        /// <value>Value to set schedule to</value>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public PeriodEnum? Period { get; set; }
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyRotationSchedule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KeyRotationSchedule() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyRotationSchedule" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Period">Value to set schedule to (required).</param>
        public KeyRotationSchedule(string Name = null, PeriodEnum? Period = null)
        {
            this.Name = Name;
            this.Period = Period;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyRotationSchedule {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as KeyRotationSchedule);
        }

        /// <summary>
        /// Returns true if KeyRotationSchedule instances are equal
        /// </summary>
        /// <param name="other">Instance of KeyRotationSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyRotationSchedule other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}

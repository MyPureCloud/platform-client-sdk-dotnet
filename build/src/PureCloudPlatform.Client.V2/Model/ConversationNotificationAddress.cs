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
    /// ConversationNotificationAddress
    /// </summary>
    [DataContract]
    public partial class ConversationNotificationAddress :  IEquatable<ConversationNotificationAddress>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNotificationAddress" /> class.
        /// </summary>
        
        
        /// <param name="Name">Name.</param>
        
        
        
        /// <param name="NameRaw">NameRaw.</param>
        
        
        
        /// <param name="AddressNormalized">AddressNormalized.</param>
        
        
        
        /// <param name="AddressRaw">AddressRaw.</param>
        
        
        
        /// <param name="AddressDisplayable">AddressDisplayable.</param>
        
        
        
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        
        
        public ConversationNotificationAddress(string Name = null, string NameRaw = null, string AddressNormalized = null, string AddressRaw = null, string AddressDisplayable = null, Object AdditionalProperties = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Name = Name;
            
            
            
            
            
            
            
            
this.NameRaw = NameRaw;
            
            
            
            
            
            
            
            
this.AddressNormalized = AddressNormalized;
            
            
            
            
            
            
            
            
this.AddressRaw = AddressRaw;
            
            
            
            
            
            
            
            
this.AddressDisplayable = AddressDisplayable;
            
            
            
            
            
            
            
            
this.AdditionalProperties = AdditionalProperties;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets NameRaw
        /// </summary>
        [DataMember(Name="nameRaw", EmitDefaultValue=false)]
        public string NameRaw { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AddressNormalized
        /// </summary>
        [DataMember(Name="addressNormalized", EmitDefaultValue=false)]
        public string AddressNormalized { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AddressRaw
        /// </summary>
        [DataMember(Name="addressRaw", EmitDefaultValue=false)]
        public string AddressRaw { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AddressDisplayable
        /// </summary>
        [DataMember(Name="addressDisplayable", EmitDefaultValue=false)]
        public string AddressDisplayable { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationNotificationAddress {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            
            sb.Append("  NameRaw: ").Append(NameRaw).Append("\n");
            
            sb.Append("  AddressNormalized: ").Append(AddressNormalized).Append("\n");
            
            sb.Append("  AddressRaw: ").Append(AddressRaw).Append("\n");
            
            sb.Append("  AddressDisplayable: ").Append(AddressDisplayable).Append("\n");
            
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            
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
            return this.Equals(obj as ConversationNotificationAddress);
        }

        /// <summary>
        /// Returns true if ConversationNotificationAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationNotificationAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationNotificationAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.NameRaw == other.NameRaw ||
                    this.NameRaw != null &&
                    this.NameRaw.Equals(other.NameRaw)
                ) &&
                (
                    this.AddressNormalized == other.AddressNormalized ||
                    this.AddressNormalized != null &&
                    this.AddressNormalized.Equals(other.AddressNormalized)
                ) &&
                (
                    this.AddressRaw == other.AddressRaw ||
                    this.AddressRaw != null &&
                    this.AddressRaw.Equals(other.AddressRaw)
                ) &&
                (
                    this.AddressDisplayable == other.AddressDisplayable ||
                    this.AddressDisplayable != null &&
                    this.AddressDisplayable.Equals(other.AddressDisplayable)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.NameRaw != null)
                    hash = hash * 59 + this.NameRaw.GetHashCode();
                
                if (this.AddressNormalized != null)
                    hash = hash * 59 + this.AddressNormalized.GetHashCode();
                
                if (this.AddressRaw != null)
                    hash = hash * 59 + this.AddressRaw.GetHashCode();
                
                if (this.AddressDisplayable != null)
                    hash = hash * 59 + this.AddressDisplayable.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}

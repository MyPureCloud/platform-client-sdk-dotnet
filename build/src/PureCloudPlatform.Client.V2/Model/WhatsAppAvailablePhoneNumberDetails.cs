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
    /// WhatsAppAvailablePhoneNumberDetails
    /// </summary>
    [DataContract]
    public partial class WhatsAppAvailablePhoneNumberDetails :  IEquatable<WhatsAppAvailablePhoneNumberDetails>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppAvailablePhoneNumberDetails" /> class.
        /// </summary>
        public WhatsAppAvailablePhoneNumberDetails()
        {
            
        }
        
        
        
        /// <summary>
        /// The verified name associated with this phone number.
        /// </summary>
        /// <value>The verified name associated with this phone number.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }
        
        
        
        /// <summary>
        /// The display name associated with this phone number. It&#39;s typically the E.164 representation of the number.
        /// </summary>
        /// <value>The display name associated with this phone number. It&#39;s typically the E.164 representation of the number.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; private set; }
        
        
        
        /// <summary>
        /// The status of this phone number.
        /// </summary>
        /// <value>The status of this phone number.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhatsAppAvailablePhoneNumberDetails {\n");
            
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as WhatsAppAvailablePhoneNumberDetails);
        }

        /// <summary>
        /// Returns true if WhatsAppAvailablePhoneNumberDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of WhatsAppAvailablePhoneNumberDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WhatsAppAvailablePhoneNumberDetails other)
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
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }
    }

}

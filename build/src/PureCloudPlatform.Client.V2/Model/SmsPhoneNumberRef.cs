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
    /// SmsPhoneNumberRef
    /// </summary>
    [DataContract]
    public partial class SmsPhoneNumberRef :  IEquatable<SmsPhoneNumberRef>
    {
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsPhoneNumberRef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsPhoneNumberRef() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsPhoneNumberRef" /> class.
        /// </summary>
        /// <param name="PhoneNumber">A phone number provisioned for SMS communications in E.164 format. E.g. +13175555555 or +34234234234 (required).</param>
        /// <param name="SelfUri">SelfUri.</param>
        public SmsPhoneNumberRef(string PhoneNumber = null, string SelfUri = null)
        {
            this.PhoneNumber = PhoneNumber;
            this.SelfUri = SelfUri;
            
        }
        
        
        
        /// <summary>
        /// A phone number provisioned for SMS communications in E.164 format. E.g. +13175555555 or +34234234234
        /// </summary>
        /// <value>A phone number provisioned for SMS communications in E.164 format. E.g. +13175555555 or +34234234234</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsPhoneNumberRef {\n");
            
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(obj as SmsPhoneNumberRef);
        }

        /// <summary>
        /// Returns true if SmsPhoneNumberRef instances are equal
        /// </summary>
        /// <param name="other">Instance of SmsPhoneNumberRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsPhoneNumberRef other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}

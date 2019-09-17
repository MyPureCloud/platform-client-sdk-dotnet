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
    /// QueueMessagingAddresses
    /// </summary>
    [DataContract]
    public partial class QueueMessagingAddresses :  IEquatable<QueueMessagingAddresses>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueMessagingAddresses" /> class.
        /// </summary>
        /// <param name="SmsAddress">SmsAddress.</param>
        public QueueMessagingAddresses(DomainEntityRef SmsAddress = null)
        {
            this.SmsAddress = SmsAddress;
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets SmsAddress
        /// </summary>
        [DataMember(Name="smsAddress", EmitDefaultValue=false)]
        public DomainEntityRef SmsAddress { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueMessagingAddresses {\n");
            
            sb.Append("  SmsAddress: ").Append(SmsAddress).Append("\n");
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
            return this.Equals(obj as QueueMessagingAddresses);
        }

        /// <summary>
        /// Returns true if QueueMessagingAddresses instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueMessagingAddresses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueMessagingAddresses other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SmsAddress == other.SmsAddress ||
                    this.SmsAddress != null &&
                    this.SmsAddress.Equals(other.SmsAddress)
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
                
                if (this.SmsAddress != null)
                    hash = hash * 59 + this.SmsAddress.GetHashCode();
                
                return hash;
            }
        }
    }

}

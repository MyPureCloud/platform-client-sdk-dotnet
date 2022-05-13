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
    /// EmailsSettings
    /// </summary>
    [DataContract]
    public partial class EmailsSettings :  IEquatable<EmailsSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailsSettings" /> class.
        /// </summary>
        /// <param name="SendingSizeLimit">SendingSizeLimit.</param>
        public EmailsSettings(int? SendingSizeLimit = null)
        {
            this.SendingSizeLimit = SendingSizeLimit;
            
        }
        


        /// <summary>
        /// Gets or Sets SendingSizeLimit
        /// </summary>
        [DataMember(Name="sendingSizeLimit", EmitDefaultValue=false)]
        public int? SendingSizeLimit { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailsSettings {\n");

            sb.Append("  SendingSizeLimit: ").Append(SendingSizeLimit).Append("\n");
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
            return this.Equals(obj as EmailsSettings);
        }

        /// <summary>
        /// Returns true if EmailsSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailsSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailsSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SendingSizeLimit == other.SendingSizeLimit ||
                    this.SendingSizeLimit != null &&
                    this.SendingSizeLimit.Equals(other.SendingSizeLimit)
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
                if (this.SendingSizeLimit != null)
                    hash = hash * 59 + this.SendingSizeLimit.GetHashCode();

                return hash;
            }
        }
    }

}

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
    /// Notification parameters for Apple Invitation
    /// </summary>
    [DataContract]
    public partial class AppleInvitationNotificationParameters :  IEquatable<AppleInvitationNotificationParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleInvitationNotificationParameters" /> class.
        /// </summary>
        /// <param name="ReferenceId">Provides context for the notification message, such as an order number or case ID..</param>
        public AppleInvitationNotificationParameters(string ReferenceId = null)
        {
            this.ReferenceId = ReferenceId;
            
        }
        


        /// <summary>
        /// Provides context for the notification message, such as an order number or case ID.
        /// </summary>
        /// <value>Provides context for the notification message, such as an order number or case ID.</value>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppleInvitationNotificationParameters {\n");

            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
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
            return this.Equals(obj as AppleInvitationNotificationParameters);
        }

        /// <summary>
        /// Returns true if AppleInvitationNotificationParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of AppleInvitationNotificationParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleInvitationNotificationParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
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
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();

                return hash;
            }
        }
    }

}

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
    /// MessagingConferWithUserRequest
    /// </summary>
    [DataContract]
    public partial class MessagingConferWithUserRequest :  IEquatable<MessagingConferWithUserRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingConferWithUserRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagingConferWithUserRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingConferWithUserRequest" /> class.
        /// </summary>
        /// <param name="TargetUserId">The user ID of the target. (required).</param>
        public MessagingConferWithUserRequest(string TargetUserId = null)
        {
            this.TargetUserId = TargetUserId;
            
        }
        


        /// <summary>
        /// The user ID of the target.
        /// </summary>
        /// <value>The user ID of the target.</value>
        [DataMember(Name="targetUserId", EmitDefaultValue=false)]
        public string TargetUserId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingConferWithUserRequest {\n");

            sb.Append("  TargetUserId: ").Append(TargetUserId).Append("\n");
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
            return this.Equals(obj as MessagingConferWithUserRequest);
        }

        /// <summary>
        /// Returns true if MessagingConferWithUserRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingConferWithUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingConferWithUserRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TargetUserId == other.TargetUserId ||
                    this.TargetUserId != null &&
                    this.TargetUserId.Equals(other.TargetUserId)
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
                if (this.TargetUserId != null)
                    hash = hash * 59 + this.TargetUserId.GetHashCode();

                return hash;
            }
        }
    }

}

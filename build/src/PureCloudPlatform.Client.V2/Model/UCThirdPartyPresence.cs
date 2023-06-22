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
    /// Update a Genesys Cloud user&#39;s presence from a given 3rd-party integration
    /// </summary>
    [DataContract]
    public partial class UCThirdPartyPresence :  IEquatable<UCThirdPartyPresence>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UCThirdPartyPresence" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UCThirdPartyPresence() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UCThirdPartyPresence" /> class.
        /// </summary>
        /// <param name="Email">Primary Email address of the associated Genesys Cloud user. (required).</param>
        /// <param name="Presence">Integration presence value. (required).</param>
        /// <param name="Message">Integration presence message..</param>
        /// <param name="DateModified">ISO 8601 timestamp of presence value change..</param>
        public UCThirdPartyPresence(string Email = null, string Presence = null, string Message = null, DateTime? DateModified = null)
        {
            this.Email = Email;
            this.Presence = Presence;
            this.Message = Message;
            this.DateModified = DateModified;
            
        }
        


        /// <summary>
        /// Primary Email address of the associated Genesys Cloud user.
        /// </summary>
        /// <value>Primary Email address of the associated Genesys Cloud user.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }



        /// <summary>
        /// Integration presence value.
        /// </summary>
        /// <value>Integration presence value.</value>
        [DataMember(Name="presence", EmitDefaultValue=false)]
        public string Presence { get; set; }



        /// <summary>
        /// Integration presence message.
        /// </summary>
        /// <value>Integration presence message.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// ISO 8601 timestamp of presence value change.
        /// </summary>
        /// <value>ISO 8601 timestamp of presence value change.</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UCThirdPartyPresence {\n");

            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as UCThirdPartyPresence);
        }

        /// <summary>
        /// Returns true if UCThirdPartyPresence instances are equal
        /// </summary>
        /// <param name="other">Instance of UCThirdPartyPresence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UCThirdPartyPresence other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) &&
                (
                    this.Presence == other.Presence ||
                    this.Presence != null &&
                    this.Presence.Equals(other.Presence)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();

                if (this.Presence != null)
                    hash = hash * 59 + this.Presence.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                return hash;
            }
        }
    }

}

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
    /// CallForwardingEventCallForwarding
    /// </summary>
    [DataContract]
    public partial class CallForwardingEventCallForwarding :  IEquatable<CallForwardingEventCallForwarding>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallForwardingEventCallForwarding" /> class.
        /// </summary>
        /// <param name="User">User.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="Calls">Calls.</param>
        /// <param name="Voicemail">Voicemail.</param>
        /// <param name="ModifiedDate">ModifiedDate.</param>
        public CallForwardingEventCallForwarding(CallForwardingEventUser User = null, bool? Enabled = null, List<CallForwardingEventCall> Calls = null, string Voicemail = null, DateTime? ModifiedDate = null)
        {
            this.User = User;
            this.Enabled = Enabled;
            this.Calls = Calls;
            this.Voicemail = Voicemail;
            this.ModifiedDate = ModifiedDate;
            
        }
        


        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public CallForwardingEventUser User { get; set; }



        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Gets or Sets Calls
        /// </summary>
        [DataMember(Name="calls", EmitDefaultValue=false)]
        public List<CallForwardingEventCall> Calls { get; set; }



        /// <summary>
        /// Gets or Sets Voicemail
        /// </summary>
        [DataMember(Name="voicemail", EmitDefaultValue=false)]
        public string Voicemail { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedDate
        /// </summary>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallForwardingEventCallForwarding {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Calls: ").Append(Calls).Append("\n");
            sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
            return this.Equals(obj as CallForwardingEventCallForwarding);
        }

        /// <summary>
        /// Returns true if CallForwardingEventCallForwarding instances are equal
        /// </summary>
        /// <param name="other">Instance of CallForwardingEventCallForwarding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallForwardingEventCallForwarding other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.Calls == other.Calls ||
                    this.Calls != null &&
                    this.Calls.SequenceEqual(other.Calls)
                ) &&
                (
                    this.Voicemail == other.Voicemail ||
                    this.Voicemail != null &&
                    this.Voicemail.Equals(other.Voicemail)
                ) &&
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();

                if (this.Calls != null)
                    hash = hash * 59 + this.Calls.GetHashCode();

                if (this.Voicemail != null)
                    hash = hash * 59 + this.Voicemail.GetHashCode();

                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();

                return hash;
            }
        }
    }

}

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
    /// JourneySessionEventsNotificationConversationUserDisposition
    /// </summary>
    [DataContract]
    public partial class JourneySessionEventsNotificationConversationUserDisposition :  IEquatable<JourneySessionEventsNotificationConversationUserDisposition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneySessionEventsNotificationConversationUserDisposition" /> class.
        /// </summary>
        /// <param name="Code">Code.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="User">User.</param>
        public JourneySessionEventsNotificationConversationUserDisposition(string Code = null, string Notes = null, JourneySessionEventsNotificationUser User = null)
        {
            this.Code = Code;
            this.Notes = Notes;
            this.User = User;
            
        }
        


        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }



        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }



        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public JourneySessionEventsNotificationUser User { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JourneySessionEventsNotificationConversationUserDisposition {\n");

            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as JourneySessionEventsNotificationConversationUserDisposition);
        }

        /// <summary>
        /// Returns true if JourneySessionEventsNotificationConversationUserDisposition instances are equal
        /// </summary>
        /// <param name="other">Instance of JourneySessionEventsNotificationConversationUserDisposition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JourneySessionEventsNotificationConversationUserDisposition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) &&
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();

                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();

                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                return hash;
            }
        }
    }

}

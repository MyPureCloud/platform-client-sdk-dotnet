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
    /// AddConversationResponse
    /// </summary>
    [DataContract]
    public partial class AddConversationResponse :  IEquatable<AddConversationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddConversationResponse" /> class.
        /// </summary>
        public AddConversationResponse()
        {
            
        }
        


        /// <summary>
        /// The conversation reference
        /// </summary>
        /// <value>The conversation reference</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public ConversationReference Conversation { get; private set; }



        /// <summary>
        /// The appointment reference
        /// </summary>
        /// <value>The appointment reference</value>
        [DataMember(Name="appointment", EmitDefaultValue=false)]
        public CoachingAppointmentReference Appointment { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddConversationResponse {\n");

            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Appointment: ").Append(Appointment).Append("\n");
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
            return this.Equals(obj as AddConversationResponse);
        }

        /// <summary>
        /// Returns true if AddConversationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AddConversationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddConversationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Conversation == other.Conversation ||
                    this.Conversation != null &&
                    this.Conversation.Equals(other.Conversation)
                ) &&
                (
                    this.Appointment == other.Appointment ||
                    this.Appointment != null &&
                    this.Appointment.Equals(other.Appointment)
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
                if (this.Conversation != null)
                    hash = hash * 59 + this.Conversation.GetHashCode();

                if (this.Appointment != null)
                    hash = hash * 59 + this.Appointment.GetHashCode();

                return hash;
            }
        }
    }

}

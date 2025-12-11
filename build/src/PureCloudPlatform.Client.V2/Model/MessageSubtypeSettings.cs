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
    /// MessageSubtypeSettings
    /// </summary>
    [DataContract]
    public partial class MessageSubtypeSettings :  IEquatable<MessageSubtypeSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSubtypeSettings" /> class.
        /// </summary>
        /// <param name="EnableAutoAnswer">Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings..</param>
        /// <param name="EnableInactivityTimeout">Indicates if inactivity timeout is enabled for the given subtype..</param>
        public MessageSubtypeSettings(bool? EnableAutoAnswer = null, bool? EnableInactivityTimeout = null)
        {
            this.EnableAutoAnswer = EnableAutoAnswer;
            this.EnableInactivityTimeout = EnableInactivityTimeout;
            
        }
        


        /// <summary>
        /// Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.
        /// </summary>
        /// <value>Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.</value>
        [DataMember(Name="enableAutoAnswer", EmitDefaultValue=false)]
        public bool? EnableAutoAnswer { get; set; }



        /// <summary>
        /// Indicates if inactivity timeout is enabled for the given subtype.
        /// </summary>
        /// <value>Indicates if inactivity timeout is enabled for the given subtype.</value>
        [DataMember(Name="enableInactivityTimeout", EmitDefaultValue=false)]
        public bool? EnableInactivityTimeout { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageSubtypeSettings {\n");

            sb.Append("  EnableAutoAnswer: ").Append(EnableAutoAnswer).Append("\n");
            sb.Append("  EnableInactivityTimeout: ").Append(EnableInactivityTimeout).Append("\n");
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
            return this.Equals(obj as MessageSubtypeSettings);
        }

        /// <summary>
        /// Returns true if MessageSubtypeSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageSubtypeSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageSubtypeSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EnableAutoAnswer == other.EnableAutoAnswer ||
                    this.EnableAutoAnswer != null &&
                    this.EnableAutoAnswer.Equals(other.EnableAutoAnswer)
                ) &&
                (
                    this.EnableInactivityTimeout == other.EnableInactivityTimeout ||
                    this.EnableInactivityTimeout != null &&
                    this.EnableInactivityTimeout.Equals(other.EnableInactivityTimeout)
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
                if (this.EnableAutoAnswer != null)
                    hash = hash * 59 + this.EnableAutoAnswer.GetHashCode();

                if (this.EnableInactivityTimeout != null)
                    hash = hash * 59 + this.EnableInactivityTimeout.GetHashCode();

                return hash;
            }
        }
    }

}

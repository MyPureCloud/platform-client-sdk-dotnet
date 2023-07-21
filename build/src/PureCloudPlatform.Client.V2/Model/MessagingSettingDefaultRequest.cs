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
    /// MessagingSettingDefaultRequest
    /// </summary>
    [DataContract]
    public partial class MessagingSettingDefaultRequest :  IEquatable<MessagingSettingDefaultRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingSettingDefaultRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagingSettingDefaultRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagingSettingDefaultRequest" /> class.
        /// </summary>
        /// <param name="SettingId">Messaging Setting ID to be used as the default for this Organization. (required).</param>
        public MessagingSettingDefaultRequest(string SettingId = null)
        {
            this.SettingId = SettingId;
            
        }
        


        /// <summary>
        /// Messaging Setting ID to be used as the default for this Organization.
        /// </summary>
        /// <value>Messaging Setting ID to be used as the default for this Organization.</value>
        [DataMember(Name="settingId", EmitDefaultValue=false)]
        public string SettingId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagingSettingDefaultRequest {\n");

            sb.Append("  SettingId: ").Append(SettingId).Append("\n");
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
            return this.Equals(obj as MessagingSettingDefaultRequest);
        }

        /// <summary>
        /// Returns true if MessagingSettingDefaultRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MessagingSettingDefaultRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagingSettingDefaultRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SettingId == other.SettingId ||
                    this.SettingId != null &&
                    this.SettingId.Equals(other.SettingId)
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
                if (this.SettingId != null)
                    hash = hash * 59 + this.SettingId.GetHashCode();

                return hash;
            }
        }
    }

}

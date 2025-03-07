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
    /// Settings for mobile devices
    /// </summary>
    [DataContract]
    public partial class MobileSettings :  IEquatable<MobileSettings>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MobileSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MobileSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileSettings" /> class.
        /// </summary>
        /// <param name="Notifications">Settings for a user&#39;s mobile notifications (required).</param>
        public MobileSettings(MobileNotificationSettings Notifications = null)
        {
            this.Notifications = Notifications;
            
        }
        


        /// <summary>
        /// Settings for a user&#39;s mobile notifications
        /// </summary>
        /// <value>Settings for a user&#39;s mobile notifications</value>
        [DataMember(Name="notifications", EmitDefaultValue=false)]
        public MobileNotificationSettings Notifications { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MobileSettings {\n");

            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
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
            return this.Equals(obj as MobileSettings);
        }

        /// <summary>
        /// Returns true if MobileSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of MobileSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MobileSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Notifications == other.Notifications ||
                    this.Notifications != null &&
                    this.Notifications.Equals(other.Notifications)
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
                if (this.Notifications != null)
                    hash = hash * 59 + this.Notifications.GetHashCode();

                return hash;
            }
        }
    }

}

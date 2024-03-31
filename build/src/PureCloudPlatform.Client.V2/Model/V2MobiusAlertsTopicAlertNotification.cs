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
    /// V2MobiusAlertsTopicAlertNotification
    /// </summary>
    [DataContract]
    public partial class V2MobiusAlertsTopicAlertNotification :  IEquatable<V2MobiusAlertsTopicAlertNotification>
    {
        /// <summary>
        /// Gets or Sets NotificationTypes
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NotificationTypesEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Device for "Device"
            /// </summary>
            [EnumMember(Value = "Device")]
            Device,
            
            /// <summary>
            /// Enum Email for "Email"
            /// </summary>
            [EnumMember(Value = "Email")]
            Email,
            
            /// <summary>
            /// Enum Sms for "Sms"
            /// </summary>
            [EnumMember(Value = "Sms")]
            Sms,
            
            /// <summary>
            /// Enum Push for "Push"
            /// </summary>
            [EnumMember(Value = "Push")]
            Push,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2MobiusAlertsTopicAlertNotification" /> class.
        /// </summary>
        /// <param name="Recipient">Recipient.</param>
        /// <param name="NotificationTypes">NotificationTypes.</param>
        /// <param name="Locale">Locale.</param>
        public V2MobiusAlertsTopicAlertNotification(string Recipient = null, List<NotificationTypesEnum> NotificationTypes = null, string Locale = null)
        {
            this.Recipient = Recipient;
            this.NotificationTypes = NotificationTypes;
            this.Locale = Locale;
            
        }
        


        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public string Recipient { get; set; }



        /// <summary>
        /// Gets or Sets NotificationTypes
        /// </summary>
        [DataMember(Name="notificationTypes", EmitDefaultValue=false)]
        public List<NotificationTypesEnum> NotificationTypes { get; set; }



        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2MobiusAlertsTopicAlertNotification {\n");

            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  NotificationTypes: ").Append(NotificationTypes).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(obj as V2MobiusAlertsTopicAlertNotification);
        }

        /// <summary>
        /// Returns true if V2MobiusAlertsTopicAlertNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of V2MobiusAlertsTopicAlertNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2MobiusAlertsTopicAlertNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Recipient == other.Recipient ||
                    this.Recipient != null &&
                    this.Recipient.Equals(other.Recipient)
                ) &&
                (
                    this.NotificationTypes == other.NotificationTypes ||
                    this.NotificationTypes != null &&
                    this.NotificationTypes.SequenceEqual(other.NotificationTypes)
                ) &&
                (
                    this.Locale == other.Locale ||
                    this.Locale != null &&
                    this.Locale.Equals(other.Locale)
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
                if (this.Recipient != null)
                    hash = hash * 59 + this.Recipient.GetHashCode();

                if (this.NotificationTypes != null)
                    hash = hash * 59 + this.NotificationTypes.GetHashCode();

                if (this.Locale != null)
                    hash = hash * 59 + this.Locale.GetHashCode();

                return hash;
            }
        }
    }

}

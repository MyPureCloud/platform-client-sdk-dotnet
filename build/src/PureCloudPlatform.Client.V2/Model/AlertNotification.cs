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
    /// AlertNotification
    /// </summary>
    [DataContract]
    public partial class AlertNotification :  IEquatable<AlertNotification>
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
            /// Enum Sms for "Sms"
            /// </summary>
            [EnumMember(Value = "Sms")]
            Sms,
            
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
            /// Enum Push for "Push"
            /// </summary>
            [EnumMember(Value = "Push")]
            Push
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlertNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlertNotification" /> class.
        /// </summary>
        /// <param name="Recipient">The entity to receive the notification. (required).</param>
        /// <param name="NotificationTypes">The notification types the user will receive. (required).</param>
        /// <param name="Locale">The locale whose language will be used when sending alerts.  Locale should be in theformat language_COUNTRY where language is always lower case and country is always upper case..</param>
        public AlertNotification(string Recipient = null, List<NotificationTypesEnum> NotificationTypes = null, string Locale = null)
        {
            this.Recipient = Recipient;
            this.NotificationTypes = NotificationTypes;
            this.Locale = Locale;
            
        }
        


        /// <summary>
        /// The entity to receive the notification.
        /// </summary>
        /// <value>The entity to receive the notification.</value>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public string Recipient { get; set; }



        /// <summary>
        /// The notification types the user will receive.
        /// </summary>
        /// <value>The notification types the user will receive.</value>
        [DataMember(Name="notificationTypes", EmitDefaultValue=false)]
        public List<NotificationTypesEnum> NotificationTypes { get; set; }



        /// <summary>
        /// The locale whose language will be used when sending alerts.  Locale should be in theformat language_COUNTRY where language is always lower case and country is always upper case.
        /// </summary>
        /// <value>The locale whose language will be used when sending alerts.  Locale should be in theformat language_COUNTRY where language is always lower case and country is always upper case.</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertNotification {\n");

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
            return this.Equals(obj as AlertNotification);
        }

        /// <summary>
        /// Returns true if AlertNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of AlertNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlertNotification other)
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

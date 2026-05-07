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
    /// Inbound response to a notification, such as an Apple Invitations acceptance.
    /// </summary>
    [DataContract]
    public partial class ConversationContentNotificationResponse :  IEquatable<ConversationContentNotificationResponse>
    {
        /// <summary>
        /// The status of the notification response.
        /// </summary>
        /// <value>The status of the notification response.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum NotificationStatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Accepted for "Accepted"
            /// </summary>
            [EnumMember(Value = "Accepted")]
            Accepted,
            
            /// <summary>
            /// Enum Declined for "Declined"
            /// </summary>
            [EnumMember(Value = "Declined")]
            Declined
        }
        /// <summary>
        /// The status of the notification response.
        /// </summary>
        /// <value>The status of the notification response.</value>
        [DataMember(Name="notificationStatus", EmitDefaultValue=false)]
        public NotificationStatusEnum? NotificationStatus { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentNotificationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationContentNotificationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentNotificationResponse" /> class.
        /// </summary>
        /// <param name="OriginatingMessageId">Reference to the ID of the original outbound notification message this response is for (e.g. the Apple requestIdentifier). (required).</param>
        /// <param name="ReferenceId">The business context reference associated with the notification (e.g. order ID, case ID). May be empty if the provider does not return it..</param>
        /// <param name="NotificationStatus">The status of the notification response. (required).</param>
        /// <param name="NotificationText">The localized display text of the user&#39;s response (e.g. \&quot;Yes\&quot;)..</param>
        public ConversationContentNotificationResponse(string OriginatingMessageId = null, string ReferenceId = null, NotificationStatusEnum? NotificationStatus = null, string NotificationText = null)
        {
            this.OriginatingMessageId = OriginatingMessageId;
            this.ReferenceId = ReferenceId;
            this.NotificationStatus = NotificationStatus;
            this.NotificationText = NotificationText;
            
        }
        


        /// <summary>
        /// Reference to the ID of the original outbound notification message this response is for (e.g. the Apple requestIdentifier).
        /// </summary>
        /// <value>Reference to the ID of the original outbound notification message this response is for (e.g. the Apple requestIdentifier).</value>
        [DataMember(Name="originatingMessageId", EmitDefaultValue=false)]
        public string OriginatingMessageId { get; set; }



        /// <summary>
        /// The business context reference associated with the notification (e.g. order ID, case ID). May be empty if the provider does not return it.
        /// </summary>
        /// <value>The business context reference associated with the notification (e.g. order ID, case ID). May be empty if the provider does not return it.</value>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }





        /// <summary>
        /// The localized display text of the user&#39;s response (e.g. \&quot;Yes\&quot;).
        /// </summary>
        /// <value>The localized display text of the user&#39;s response (e.g. \&quot;Yes\&quot;).</value>
        [DataMember(Name="notificationText", EmitDefaultValue=false)]
        public string NotificationText { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentNotificationResponse {\n");

            sb.Append("  OriginatingMessageId: ").Append(OriginatingMessageId).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  NotificationStatus: ").Append(NotificationStatus).Append("\n");
            sb.Append("  NotificationText: ").Append(NotificationText).Append("\n");
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
            return this.Equals(obj as ConversationContentNotificationResponse);
        }

        /// <summary>
        /// Returns true if ConversationContentNotificationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentNotificationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentNotificationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OriginatingMessageId == other.OriginatingMessageId ||
                    this.OriginatingMessageId != null &&
                    this.OriginatingMessageId.Equals(other.OriginatingMessageId)
                ) &&
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
                ) &&
                (
                    this.NotificationStatus == other.NotificationStatus ||
                    this.NotificationStatus != null &&
                    this.NotificationStatus.Equals(other.NotificationStatus)
                ) &&
                (
                    this.NotificationText == other.NotificationText ||
                    this.NotificationText != null &&
                    this.NotificationText.Equals(other.NotificationText)
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
                if (this.OriginatingMessageId != null)
                    hash = hash * 59 + this.OriginatingMessageId.GetHashCode();

                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();

                if (this.NotificationStatus != null)
                    hash = hash * 59 + this.NotificationStatus.GetHashCode();

                if (this.NotificationText != null)
                    hash = hash * 59 + this.NotificationText.GetHashCode();

                return hash;
            }
        }
    }

}

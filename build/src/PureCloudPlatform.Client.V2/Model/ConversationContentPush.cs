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
    /// A Push object
    /// </summary>
    [DataContract]
    public partial class ConversationContentPush :  IEquatable<ConversationContentPush>
    {
        /// <summary>
        /// The device type used to send the push notification
        /// </summary>
        /// <value>The device type used to send the push notification</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum DeviceTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Android for "Android"
            /// </summary>
            [EnumMember(Value = "Android")]
            Android,
            
            /// <summary>
            /// Enum Ios for "IOS"
            /// </summary>
            [EnumMember(Value = "IOS")]
            Ios
        }
        /// <summary>
        /// The device type used to send the push notification
        /// </summary>
        /// <value>The device type used to send the push notification</value>
        [DataMember(Name="deviceType", EmitDefaultValue=false)]
        public DeviceTypeEnum? DeviceType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentPush" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationContentPush() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationContentPush" /> class.
        /// </summary>
        /// <param name="DeviceType">The device type used to send the push notification (required).</param>
        /// <param name="DeviceTokenId">Unique Id of the device token (required).</param>
        /// <param name="DeviceToken">device token from the notification provider (required).</param>
        /// <param name="FailedMessages">MessageIds failed to be sent which trigger the push event (required).</param>
        /// <param name="NotificationMessage">Title and body localized according to deployment (required).</param>
        /// <param name="PushProviderIntegration">Push provider integrations details configured on the deployment (required).</param>
        /// <param name="Expiration">The time to live of the pushed message (required).</param>
        public ConversationContentPush(DeviceTypeEnum? DeviceType = null, string DeviceTokenId = null, string DeviceToken = null, List<ConversationPushFailedMessageReferences> FailedMessages = null, ConversationPushNotificationMessageLabel NotificationMessage = null, ConversationPushProviderIntegration PushProviderIntegration = null, long? Expiration = null)
        {
            this.DeviceType = DeviceType;
            this.DeviceTokenId = DeviceTokenId;
            this.DeviceToken = DeviceToken;
            this.FailedMessages = FailedMessages;
            this.NotificationMessage = NotificationMessage;
            this.PushProviderIntegration = PushProviderIntegration;
            this.Expiration = Expiration;
            
        }
        




        /// <summary>
        /// Unique Id of the device token
        /// </summary>
        /// <value>Unique Id of the device token</value>
        [DataMember(Name="deviceTokenId", EmitDefaultValue=false)]
        public string DeviceTokenId { get; set; }



        /// <summary>
        /// device token from the notification provider
        /// </summary>
        /// <value>device token from the notification provider</value>
        [DataMember(Name="deviceToken", EmitDefaultValue=false)]
        public string DeviceToken { get; set; }



        /// <summary>
        /// MessageIds failed to be sent which trigger the push event
        /// </summary>
        /// <value>MessageIds failed to be sent which trigger the push event</value>
        [DataMember(Name="failedMessages", EmitDefaultValue=false)]
        public List<ConversationPushFailedMessageReferences> FailedMessages { get; set; }



        /// <summary>
        /// Title and body localized according to deployment
        /// </summary>
        /// <value>Title and body localized according to deployment</value>
        [DataMember(Name="notificationMessage", EmitDefaultValue=false)]
        public ConversationPushNotificationMessageLabel NotificationMessage { get; set; }



        /// <summary>
        /// Push provider integrations details configured on the deployment
        /// </summary>
        /// <value>Push provider integrations details configured on the deployment</value>
        [DataMember(Name="pushProviderIntegration", EmitDefaultValue=false)]
        public ConversationPushProviderIntegration PushProviderIntegration { get; set; }



        /// <summary>
        /// The time to live of the pushed message
        /// </summary>
        /// <value>The time to live of the pushed message</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public long? Expiration { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationContentPush {\n");

            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  DeviceTokenId: ").Append(DeviceTokenId).Append("\n");
            sb.Append("  DeviceToken: ").Append(DeviceToken).Append("\n");
            sb.Append("  FailedMessages: ").Append(FailedMessages).Append("\n");
            sb.Append("  NotificationMessage: ").Append(NotificationMessage).Append("\n");
            sb.Append("  PushProviderIntegration: ").Append(PushProviderIntegration).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
            return this.Equals(obj as ConversationContentPush);
        }

        /// <summary>
        /// Returns true if ConversationContentPush instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationContentPush to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationContentPush other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.DeviceType == other.DeviceType ||
                    this.DeviceType != null &&
                    this.DeviceType.Equals(other.DeviceType)
                ) &&
                (
                    this.DeviceTokenId == other.DeviceTokenId ||
                    this.DeviceTokenId != null &&
                    this.DeviceTokenId.Equals(other.DeviceTokenId)
                ) &&
                (
                    this.DeviceToken == other.DeviceToken ||
                    this.DeviceToken != null &&
                    this.DeviceToken.Equals(other.DeviceToken)
                ) &&
                (
                    this.FailedMessages == other.FailedMessages ||
                    this.FailedMessages != null &&
                    this.FailedMessages.SequenceEqual(other.FailedMessages)
                ) &&
                (
                    this.NotificationMessage == other.NotificationMessage ||
                    this.NotificationMessage != null &&
                    this.NotificationMessage.Equals(other.NotificationMessage)
                ) &&
                (
                    this.PushProviderIntegration == other.PushProviderIntegration ||
                    this.PushProviderIntegration != null &&
                    this.PushProviderIntegration.Equals(other.PushProviderIntegration)
                ) &&
                (
                    this.Expiration == other.Expiration ||
                    this.Expiration != null &&
                    this.Expiration.Equals(other.Expiration)
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
                if (this.DeviceType != null)
                    hash = hash * 59 + this.DeviceType.GetHashCode();

                if (this.DeviceTokenId != null)
                    hash = hash * 59 + this.DeviceTokenId.GetHashCode();

                if (this.DeviceToken != null)
                    hash = hash * 59 + this.DeviceToken.GetHashCode();

                if (this.FailedMessages != null)
                    hash = hash * 59 + this.FailedMessages.GetHashCode();

                if (this.NotificationMessage != null)
                    hash = hash * 59 + this.NotificationMessage.GetHashCode();

                if (this.PushProviderIntegration != null)
                    hash = hash * 59 + this.PushProviderIntegration.GetHashCode();

                if (this.Expiration != null)
                    hash = hash * 59 + this.Expiration.GetHashCode();

                return hash;
            }
        }
    }

}

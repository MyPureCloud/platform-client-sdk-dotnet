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
    /// UpdatedTopicSystemMessage
    /// </summary>
    [DataContract]
    public partial class UpdatedTopicSystemMessage :  IEquatable<UpdatedTopicSystemMessage>
    {
        /// <summary>
        /// Gets or Sets SystemTopicType
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SystemTopicTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum NoLongerSubscribed for "no_longer_subscribed"
            /// </summary>
            [EnumMember(Value = "no_longer_subscribed")]
            NoLongerSubscribed,
            
            /// <summary>
            /// Enum SubscriptionChanged for "subscription_changed"
            /// </summary>
            [EnumMember(Value = "subscription_changed")]
            SubscriptionChanged,
            
            /// <summary>
            /// Enum TokenRevoked for "token_revoked"
            /// </summary>
            [EnumMember(Value = "token_revoked")]
            TokenRevoked
        }
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum AnotherChannelSubscribed for "another_channel_subscribed"
            /// </summary>
            [EnumMember(Value = "another_channel_subscribed")]
            AnotherChannelSubscribed,
            
            /// <summary>
            /// Enum UserTokensRevoked for "user_tokens_revoked"
            /// </summary>
            [EnumMember(Value = "user_tokens_revoked")]
            UserTokensRevoked
        }
        /// <summary>
        /// Gets or Sets SystemTopicType
        /// </summary>
        [DataMember(Name="systemTopicType", EmitDefaultValue=false)]
        public SystemTopicTypeEnum? SystemTopicType { get; set; }
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatedTopicSystemMessage" /> class.
        /// </summary>
        /// <param name="ChannelId">ChannelId.</param>
        /// <param name="SystemTopicType">SystemTopicType.</param>
        /// <param name="CorrelationId">CorrelationId.</param>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="OauthClientId">OauthClientId.</param>
        /// <param name="OauthClientOrgId">OauthClientOrgId.</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Data">Data.</param>
        public UpdatedTopicSystemMessage(string ChannelId = null, SystemTopicTypeEnum? SystemTopicType = null, string CorrelationId = null, string OrganizationId = null, string UserId = null, string OauthClientId = null, string OauthClientOrgId = null, ReasonEnum? Reason = null, string Message = null, Dictionary<string, Object> Data = null)
        {
            this.ChannelId = ChannelId;
            this.SystemTopicType = SystemTopicType;
            this.CorrelationId = CorrelationId;
            this.OrganizationId = OrganizationId;
            this.UserId = UserId;
            this.OauthClientId = OauthClientId;
            this.OauthClientOrgId = OauthClientOrgId;
            this.Reason = Reason;
            this.Message = Message;
            this.Data = Data;
            
        }
        


        /// <summary>
        /// Gets or Sets ChannelId
        /// </summary>
        [DataMember(Name="channelId", EmitDefaultValue=false)]
        public string ChannelId { get; set; }





        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name="correlationId", EmitDefaultValue=false)]
        public string CorrelationId { get; set; }



        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }



        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }



        /// <summary>
        /// Gets or Sets OauthClientId
        /// </summary>
        [DataMember(Name="oauthClientId", EmitDefaultValue=false)]
        public string OauthClientId { get; set; }



        /// <summary>
        /// Gets or Sets OauthClientOrgId
        /// </summary>
        [DataMember(Name="oauthClientOrgId", EmitDefaultValue=false)]
        public string OauthClientOrgId { get; set; }





        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }



        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Dictionary<string, Object> Data { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatedTopicSystemMessage {\n");

            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  SystemTopicType: ").Append(SystemTopicType).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  OauthClientId: ").Append(OauthClientId).Append("\n");
            sb.Append("  OauthClientOrgId: ").Append(OauthClientOrgId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(obj as UpdatedTopicSystemMessage);
        }

        /// <summary>
        /// Returns true if UpdatedTopicSystemMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdatedTopicSystemMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatedTopicSystemMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ChannelId == other.ChannelId ||
                    this.ChannelId != null &&
                    this.ChannelId.Equals(other.ChannelId)
                ) &&
                (
                    this.SystemTopicType == other.SystemTopicType ||
                    this.SystemTopicType != null &&
                    this.SystemTopicType.Equals(other.SystemTopicType)
                ) &&
                (
                    this.CorrelationId == other.CorrelationId ||
                    this.CorrelationId != null &&
                    this.CorrelationId.Equals(other.CorrelationId)
                ) &&
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.OauthClientId == other.OauthClientId ||
                    this.OauthClientId != null &&
                    this.OauthClientId.Equals(other.OauthClientId)
                ) &&
                (
                    this.OauthClientOrgId == other.OauthClientOrgId ||
                    this.OauthClientOrgId != null &&
                    this.OauthClientOrgId.Equals(other.OauthClientOrgId)
                ) &&
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
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
                if (this.ChannelId != null)
                    hash = hash * 59 + this.ChannelId.GetHashCode();

                if (this.SystemTopicType != null)
                    hash = hash * 59 + this.SystemTopicType.GetHashCode();

                if (this.CorrelationId != null)
                    hash = hash * 59 + this.CorrelationId.GetHashCode();

                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();

                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();

                if (this.OauthClientId != null)
                    hash = hash * 59 + this.OauthClientId.GetHashCode();

                if (this.OauthClientOrgId != null)
                    hash = hash * 59 + this.OauthClientOrgId.GetHashCode();

                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();

                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();

                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();

                return hash;
            }
        }
    }

}

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
    /// CommonAlertBulkUpdateRequest
    /// </summary>
    [DataContract]
    public partial class CommonAlertBulkUpdateRequest :  IEquatable<CommonAlertBulkUpdateRequest>
    {
        /// <summary>
        /// The action to take
        /// </summary>
        /// <value>The action to take</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Mute for "Mute"
            /// </summary>
            [EnumMember(Value = "Mute")]
            Mute,
            
            /// <summary>
            /// Enum Snooze for "Snooze"
            /// </summary>
            [EnumMember(Value = "Snooze")]
            Snooze,
            
            /// <summary>
            /// Enum Unread for "Unread"
            /// </summary>
            [EnumMember(Value = "Unread")]
            Unread
        }
        /// <summary>
        /// The action to take
        /// </summary>
        /// <value>The action to take</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAlertBulkUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonAlertBulkUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonAlertBulkUpdateRequest" /> class.
        /// </summary>
        /// <param name="Type">The action to take (required).</param>
        /// <param name="AlertIds">The user supplied alert ids to be muted (required).</param>
        /// <param name="MuteSnooze">The fields need for a mute or snooze requests.</param>
        /// <param name="Unread">The fields need for an unread update requests.</param>
        public CommonAlertBulkUpdateRequest(TypeEnum? Type = null, List<string> AlertIds = null, MuteSnoozeFields MuteSnooze = null, UnreadFields Unread = null)
        {
            this.Type = Type;
            this.AlertIds = AlertIds;
            this.MuteSnooze = MuteSnooze;
            this.Unread = Unread;
            
        }
        




        /// <summary>
        /// The user supplied alert ids to be muted
        /// </summary>
        /// <value>The user supplied alert ids to be muted</value>
        [DataMember(Name="alertIds", EmitDefaultValue=false)]
        public List<string> AlertIds { get; set; }



        /// <summary>
        /// The fields need for a mute or snooze requests
        /// </summary>
        /// <value>The fields need for a mute or snooze requests</value>
        [DataMember(Name="muteSnooze", EmitDefaultValue=false)]
        public MuteSnoozeFields MuteSnooze { get; set; }



        /// <summary>
        /// The fields need for an unread update requests
        /// </summary>
        /// <value>The fields need for an unread update requests</value>
        [DataMember(Name="unread", EmitDefaultValue=false)]
        public UnreadFields Unread { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonAlertBulkUpdateRequest {\n");

            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AlertIds: ").Append(AlertIds).Append("\n");
            sb.Append("  MuteSnooze: ").Append(MuteSnooze).Append("\n");
            sb.Append("  Unread: ").Append(Unread).Append("\n");
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
            return this.Equals(obj as CommonAlertBulkUpdateRequest);
        }

        /// <summary>
        /// Returns true if CommonAlertBulkUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CommonAlertBulkUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonAlertBulkUpdateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.AlertIds == other.AlertIds ||
                    this.AlertIds != null &&
                    this.AlertIds.SequenceEqual(other.AlertIds)
                ) &&
                (
                    this.MuteSnooze == other.MuteSnooze ||
                    this.MuteSnooze != null &&
                    this.MuteSnooze.Equals(other.MuteSnooze)
                ) &&
                (
                    this.Unread == other.Unread ||
                    this.Unread != null &&
                    this.Unread.Equals(other.Unread)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.AlertIds != null)
                    hash = hash * 59 + this.AlertIds.GetHashCode();

                if (this.MuteSnooze != null)
                    hash = hash * 59 + this.MuteSnooze.GetHashCode();

                if (this.Unread != null)
                    hash = hash * 59 + this.Unread.GetHashCode();

                return hash;
            }
        }
    }

}

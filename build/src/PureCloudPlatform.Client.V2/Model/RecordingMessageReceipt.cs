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
    /// RecordingMessageReceipt
    /// </summary>
    [DataContract]
    public partial class RecordingMessageReceipt :  IEquatable<RecordingMessageReceipt>
    {
        /// <summary>
        /// The message receipt status
        /// </summary>
        /// <value>The message receipt status</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Sent for "Sent"
            /// </summary>
            [EnumMember(Value = "Sent")]
            Sent,
            
            /// <summary>
            /// Enum Delivered for "Delivered"
            /// </summary>
            [EnumMember(Value = "Delivered")]
            Delivered,
            
            /// <summary>
            /// Enum Read for "Read"
            /// </summary>
            [EnumMember(Value = "Read")]
            Read,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Published for "Published"
            /// </summary>
            [EnumMember(Value = "Published")]
            Published,
            
            /// <summary>
            /// Enum Removed for "Removed"
            /// </summary>
            [EnumMember(Value = "Removed")]
            Removed
        }
        /// <summary>
        /// The message receipt status
        /// </summary>
        /// <value>The message receipt status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingMessageReceipt" /> class.
        /// </summary>
        /// <param name="Id">The id of the message receipt. Message receipts will have the same ID as the message they reference..</param>
        /// <param name="Status">The message receipt status.</param>
        /// <param name="Reasons">List of reasons for a message receipt that indicates the message has failed. Only used with Failed status..</param>
        public RecordingMessageReceipt(string Id = null, StatusEnum? Status = null, List<RecordingMessageReceiptReason> Reasons = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.Reasons = Reasons;
            
        }
        


        /// <summary>
        /// The id of the message receipt. Message receipts will have the same ID as the message they reference.
        /// </summary>
        /// <value>The id of the message receipt. Message receipts will have the same ID as the message they reference.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// List of reasons for a message receipt that indicates the message has failed. Only used with Failed status.
        /// </summary>
        /// <value>List of reasons for a message receipt that indicates the message has failed. Only used with Failed status.</value>
        [DataMember(Name="reasons", EmitDefaultValue=false)]
        public List<RecordingMessageReceiptReason> Reasons { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingMessageReceipt {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Reasons: ").Append(Reasons).Append("\n");
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
            return this.Equals(obj as RecordingMessageReceipt);
        }

        /// <summary>
        /// Returns true if RecordingMessageReceipt instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingMessageReceipt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingMessageReceipt other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Reasons == other.Reasons ||
                    this.Reasons != null &&
                    this.Reasons.SequenceEqual(other.Reasons)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();

                if (this.Reasons != null)
                    hash = hash * 59 + this.Reasons.GetHashCode();

                return hash;
            }
        }
    }

}

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
    /// TransferToExternalContactRequest
    /// </summary>
    [DataContract]
    public partial class TransferToExternalContactRequest :  IEquatable<TransferToExternalContactRequest>
    {
        /// <summary>
        /// The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended.
        /// </summary>
        /// <value>The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TransferTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Attended for "Attended"
            /// </summary>
            [EnumMember(Value = "Attended")]
            Attended,
            
            /// <summary>
            /// Enum Unattended for "Unattended"
            /// </summary>
            [EnumMember(Value = "Unattended")]
            Unattended
        }
        /// <summary>
        /// The external contact phone type.
        /// </summary>
        /// <value>The external contact phone type.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum PhoneTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Workphone for "WorkPhone"
            /// </summary>
            [EnumMember(Value = "WorkPhone")]
            Workphone,
            
            /// <summary>
            /// Enum Cellphone for "CellPhone"
            /// </summary>
            [EnumMember(Value = "CellPhone")]
            Cellphone,
            
            /// <summary>
            /// Enum Homephone for "HomePhone"
            /// </summary>
            [EnumMember(Value = "HomePhone")]
            Homephone,
            
            /// <summary>
            /// Enum Otherphone for "OtherPhone"
            /// </summary>
            [EnumMember(Value = "OtherPhone")]
            Otherphone
        }
        /// <summary>
        /// The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended.
        /// </summary>
        /// <value>The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended.</value>
        [DataMember(Name="transferType", EmitDefaultValue=false)]
        public TransferTypeEnum? TransferType { get; set; }
        /// <summary>
        /// The external contact phone type.
        /// </summary>
        /// <value>The external contact phone type.</value>
        [DataMember(Name="phoneType", EmitDefaultValue=false)]
        public PhoneTypeEnum? PhoneType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToExternalContactRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransferToExternalContactRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToExternalContactRequest" /> class.
        /// </summary>
        /// <param name="TransferType">The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended..</param>
        /// <param name="KeepInternalMessageAlive">If true, the digital internal message will NOT be terminated..</param>
        /// <param name="ContactId">The external contact id. (required).</param>
        /// <param name="PhoneType">The external contact phone type. (required).</param>
        public TransferToExternalContactRequest(TransferTypeEnum? TransferType = null, bool? KeepInternalMessageAlive = null, string ContactId = null, PhoneTypeEnum? PhoneType = null)
        {
            this.TransferType = TransferType;
            this.KeepInternalMessageAlive = KeepInternalMessageAlive;
            this.ContactId = ContactId;
            this.PhoneType = PhoneType;
            
        }
        




        /// <summary>
        /// If true, the digital internal message will NOT be terminated.
        /// </summary>
        /// <value>If true, the digital internal message will NOT be terminated.</value>
        [DataMember(Name="keepInternalMessageAlive", EmitDefaultValue=false)]
        public bool? KeepInternalMessageAlive { get; set; }



        /// <summary>
        /// The external contact id.
        /// </summary>
        /// <value>The external contact id.</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public string ContactId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferToExternalContactRequest {\n");

            sb.Append("  TransferType: ").Append(TransferType).Append("\n");
            sb.Append("  KeepInternalMessageAlive: ").Append(KeepInternalMessageAlive).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  PhoneType: ").Append(PhoneType).Append("\n");
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
            return this.Equals(obj as TransferToExternalContactRequest);
        }

        /// <summary>
        /// Returns true if TransferToExternalContactRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferToExternalContactRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferToExternalContactRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TransferType == other.TransferType ||
                    this.TransferType != null &&
                    this.TransferType.Equals(other.TransferType)
                ) &&
                (
                    this.KeepInternalMessageAlive == other.KeepInternalMessageAlive ||
                    this.KeepInternalMessageAlive != null &&
                    this.KeepInternalMessageAlive.Equals(other.KeepInternalMessageAlive)
                ) &&
                (
                    this.ContactId == other.ContactId ||
                    this.ContactId != null &&
                    this.ContactId.Equals(other.ContactId)
                ) &&
                (
                    this.PhoneType == other.PhoneType ||
                    this.PhoneType != null &&
                    this.PhoneType.Equals(other.PhoneType)
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
                if (this.TransferType != null)
                    hash = hash * 59 + this.TransferType.GetHashCode();

                if (this.KeepInternalMessageAlive != null)
                    hash = hash * 59 + this.KeepInternalMessageAlive.GetHashCode();

                if (this.ContactId != null)
                    hash = hash * 59 + this.ContactId.GetHashCode();

                if (this.PhoneType != null)
                    hash = hash * 59 + this.PhoneType.GetHashCode();

                return hash;
            }
        }
    }

}

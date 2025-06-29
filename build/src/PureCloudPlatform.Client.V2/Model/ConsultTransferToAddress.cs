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
    /// ConsultTransferToAddress
    /// </summary>
    [DataContract]
    public partial class ConsultTransferToAddress :  IEquatable<ConsultTransferToAddress>
    {
        /// <summary>
        /// Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION
        /// </summary>
        /// <value>Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum SpeakToEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Destination for "DESTINATION"
            /// </summary>
            [EnumMember(Value = "DESTINATION")]
            Destination,
            
            /// <summary>
            /// Enum Object for "OBJECT"
            /// </summary>
            [EnumMember(Value = "OBJECT")]
            Object,
            
            /// <summary>
            /// Enum Both for "BOTH"
            /// </summary>
            [EnumMember(Value = "BOTH")]
            Both,
            
            /// <summary>
            /// Enum Conference for "CONFERENCE"
            /// </summary>
            [EnumMember(Value = "CONFERENCE")]
            Conference
        }
        /// <summary>
        /// Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION
        /// </summary>
        /// <value>Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION</value>
        [DataMember(Name="speakTo", EmitDefaultValue=false)]
        public SpeakToEnum? SpeakTo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultTransferToAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConsultTransferToAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultTransferToAddress" /> class.
        /// </summary>
        /// <param name="SpeakTo">Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION (required).</param>
        /// <param name="ConsultingUserId">The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID.</param>
        /// <param name="Address">Destination&#39;s address or phone number..</param>
        public ConsultTransferToAddress(SpeakToEnum? SpeakTo = null, string ConsultingUserId = null, string Address = null)
        {
            this.SpeakTo = SpeakTo;
            this.ConsultingUserId = ConsultingUserId;
            this.Address = Address;
            
        }
        




        /// <summary>
        /// The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID
        /// </summary>
        /// <value>The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID</value>
        [DataMember(Name="consultingUserId", EmitDefaultValue=false)]
        public string ConsultingUserId { get; set; }



        /// <summary>
        /// Destination&#39;s address or phone number.
        /// </summary>
        /// <value>Destination&#39;s address or phone number.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsultTransferToAddress {\n");

            sb.Append("  SpeakTo: ").Append(SpeakTo).Append("\n");
            sb.Append("  ConsultingUserId: ").Append(ConsultingUserId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(obj as ConsultTransferToAddress);
        }

        /// <summary>
        /// Returns true if ConsultTransferToAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of ConsultTransferToAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultTransferToAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.SpeakTo == other.SpeakTo ||
                    this.SpeakTo != null &&
                    this.SpeakTo.Equals(other.SpeakTo)
                ) &&
                (
                    this.ConsultingUserId == other.ConsultingUserId ||
                    this.ConsultingUserId != null &&
                    this.ConsultingUserId.Equals(other.ConsultingUserId)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
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
                if (this.SpeakTo != null)
                    hash = hash * 59 + this.SpeakTo.GetHashCode();

                if (this.ConsultingUserId != null)
                    hash = hash * 59 + this.ConsultingUserId.GetHashCode();

                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();

                return hash;
            }
        }
    }

}

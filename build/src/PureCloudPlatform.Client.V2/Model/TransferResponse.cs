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
    /// TransferResponse
    /// </summary>
    [DataContract]
    public partial class TransferResponse :  IEquatable<TransferResponse>
    {
        /// <summary>
        /// The state of the command.
        /// </summary>
        /// <value>The state of the command.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Pending for "Pending"
            /// </summary>
            [EnumMember(Value = "Pending")]
            Pending,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Canceled for "Canceled"
            /// </summary>
            [EnumMember(Value = "Canceled")]
            Canceled,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Timeout for "Timeout"
            /// </summary>
            [EnumMember(Value = "Timeout")]
            Timeout,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown
        }
        /// <summary>
        /// The type of transfer to perform.
        /// </summary>
        /// <value>The type of transfer to perform.</value>
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
        /// The state of the command.
        /// </summary>
        /// <value>The state of the command.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// The type of transfer to perform.
        /// </summary>
        /// <value>The type of transfer to perform.</value>
        [DataMember(Name="transferType", EmitDefaultValue=false)]
        public TransferTypeEnum? TransferType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferResponse" /> class.
        /// </summary>
        /// <param name="Id">The id of the command..</param>
        /// <param name="State">The state of the command..</param>
        /// <param name="DateIssued">The date/time that this command was issued. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        /// <param name="Initiator">The initiator of the command..</param>
        /// <param name="Destination">The destination of the command..</param>
        /// <param name="TransferType">The type of transfer to perform..</param>
        public TransferResponse(string Id = null, StateEnum? State = null, DateTime? DateIssued = null, TransferInitiator Initiator = null, TransferDestination Destination = null, TransferTypeEnum? TransferType = null)
        {
            this.Id = Id;
            this.State = State;
            this.DateIssued = DateIssued;
            this.Initiator = Initiator;
            this.Destination = Destination;
            this.TransferType = TransferType;
            
        }
        


        /// <summary>
        /// The id of the command.
        /// </summary>
        /// <value>The id of the command.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }





        /// <summary>
        /// The date/time that this command was issued. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>The date/time that this command was issued. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateIssued", EmitDefaultValue=false)]
        public DateTime? DateIssued { get; set; }



        /// <summary>
        /// The initiator of the command.
        /// </summary>
        /// <value>The initiator of the command.</value>
        [DataMember(Name="initiator", EmitDefaultValue=false)]
        public TransferInitiator Initiator { get; set; }



        /// <summary>
        /// The destination of the command.
        /// </summary>
        /// <value>The destination of the command.</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public TransferDestination Destination { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DateIssued: ").Append(DateIssued).Append("\n");
            sb.Append("  Initiator: ").Append(Initiator).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  TransferType: ").Append(TransferType).Append("\n");
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
            return this.Equals(obj as TransferResponse);
        }

        /// <summary>
        /// Returns true if TransferResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferResponse other)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.DateIssued == other.DateIssued ||
                    this.DateIssued != null &&
                    this.DateIssued.Equals(other.DateIssued)
                ) &&
                (
                    this.Initiator == other.Initiator ||
                    this.Initiator != null &&
                    this.Initiator.Equals(other.Initiator)
                ) &&
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
                ) &&
                (
                    this.TransferType == other.TransferType ||
                    this.TransferType != null &&
                    this.TransferType.Equals(other.TransferType)
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

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.DateIssued != null)
                    hash = hash * 59 + this.DateIssued.GetHashCode();

                if (this.Initiator != null)
                    hash = hash * 59 + this.Initiator.GetHashCode();

                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();

                if (this.TransferType != null)
                    hash = hash * 59 + this.TransferType.GetHashCode();

                return hash;
            }
        }
    }

}
